-- CS#1
ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE;
/
-- Tạo tài khoản cho tất cả các user
CREATE OR REPLACE PROCEDURE USP_CREATEUSER
AS
    CURSOR CUR IS SELECT MANV FROM NHANVIEN$ WHERE UPPER(MANV) NOT IN (SELECT USERNAME FROM ALL_USERS);
    strSQL varchar(2000);
    usr varchar(60);
BEGIN
    OPEN CUR;
    strSQL := 'ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE';
    EXECUTE IMMEDIATE (strSQL);
    LOOP
        FETCH CUR INTO usr;
        EXIT WHEN CUR%NOTFOUND;
        
        strSQL := 'DROP USER ' || usr || ' CASCADE';
        EXECUTE IMMEDIATE (strSQL);
        strSQL := 'CREATE USER ' || usr || ' IDENTIFIED BY ' || 123;
        EXECUTE IMMEDIATE (strSQL);
        strSQL := 'GRANT CONNECT TO ' || usr;
        EXECUTE IMMEDIATE (strSQL);
        strSQL := 'GRANT CREATE SESSION TO ' || usr;
        EXECUTE IMMEDIATE (strSQL);
    END LOOP;
    strSQL := 'ALTER SESSION SET "_ORACLE_SCRIPT" = FALSE';
    EXECUTE IMMEDIATE (strSQL);
END;
/
EXEC USP_CREATEUSER;
/
-- Xóa và tạo role ROLE_NHANVIEN
DROP ROLE ROLE_NHANVIEN;
CREATE ROLE ROLE_NHANVIEN;
DROP ROLE ROLE_NHANSU;
CREATE ROLE ROLE_NHANSU;
/
-- Tạo view xem thuộc tính trên bảng nhân viên
CREATE OR REPLACE VIEW NHANVIEN AS
SELECT *
FROM NHANVIEN$;
/
CREATE OR REPLACE VIEW NHANVIEN_NHANSU AS
SELECT *
FROM NHANVIEN$;
/
CREATE OR REPLACE VIEW NHANVIEN_SESSION AS
SELECT *
FROM NHANVIEN$
WHERE MANV = SYS_CONTEXT('USERENV', 'SESSION_USER');
/
-- Tạo view xem thuộc tính trên bảng phân công
CREATE OR REPLACE VIEW PHANCONG_SESSION AS
SELECT *
FROM PHANCONG$
WHERE MANV = SYS_CONTEXT('USERENV', 'SESSION_USER');
/
-- Gán quyền cho role
GRANT SELECT ON NHANVIEN TO ROLE_NHANVIEN;
GRANT SELECT ON NHANVIEN_SESSION TO ROLE_NHANVIEN;
GRANT SELECT ON PHANCONG_SESSION TO ROLE_NHANVIEN;
GRANT SELECT ON PHONGBAN TO ROLE_NHANVIEN;
GRANT SELECT ON DEAN TO ROLE_NHANVIEN;
GRANT SELECT ON NHANVIEN_NHANSU TO ROLE_NHANSU;

/ 
-- Cấp quyền ROLE_NHANVIEN cho tất cả nhân viên
CREATE OR REPLACE PROCEDURE USP_GRANT_ROLE_NHANVIEN
AS
    CURSOR CUR IS SELECT MANV FROM NHANVIEN$ WHERE UPPER(MANV) IN (SELECT USERNAME FROM ALL_USERS);
    strSQL varchar(2000);
    usr varchar(60);
BEGIN
    OPEN CUR;
    LOOP
        FETCH CUR INTO usr;
        EXIT WHEN CUR%NOTFOUND;
        
        strSQL := 'GRANT ROLE_NHANVIEN TO ' || usr;
        EXECUTE IMMEDIATE (strSQL);
        
    END LOOP;
END;
/
EXEC USP_GRANT_ROLE_NHANVIEN;
/
-- Cấp quyền thao tác trên bảng nhân viên cho tất cả các nhân viên có vai trò Nhân viên
CREATE OR REPLACE PROCEDURE USP_GRANT_PRIVS_NHANVIEN
AS
    CURSOR CUR IS SELECT MANV FROM NHANVIEN$ WHERE UPPER(MANV) IN (SELECT USERNAME FROM ALL_USERS);
    strSQL varchar(2000);
    usr varchar(60);
BEGIN
    OPEN CUR;
    LOOP
        FETCH CUR INTO usr;
        EXIT WHEN CUR%NOTFOUND;
        
        strSQL := 'REVOKE ALL ON NHANVIEN FROM ' || usr;
        EXECUTE IMMEDIATE (strSQL);
        
        strSQL := 'GRANT SELECT ON NHANVIEN TO ' || usr;
        EXECUTE IMMEDIATE (strSQL);
        
        strSQL := 'GRANT UPDATE(NGAYSINH, DIACHI, SODT) ON NHANVIEN TO ' || usr;
        EXECUTE IMMEDIATE (strSQL);
        
    END LOOP;
END;
/
EXEC USP_GRANT_PRIVS_NHANVIEN;
/
-- Nhân viên có thể sửa trên các thuộc tính NGAYSINH, DIACHI, SODT liên quan đến chính nhân viên đó.

-- Xóa và cài đặt Policy function
DROP FUNCTION UPDATE_NV_FUNCTION;
CREATE OR REPLACE FUNCTION UPDATE_NV_FUNCTION (
	P_SCHEMA IN VARCHAR2,
	P_OBJECT IN VARCHAR2) RETURN VARCHAR2
AS
	PREDICATE VARCHAR2(1000);
    MANV VARCHAR(200);
    ROLE_NAME NVARCHAR2(200);
BEGIN

    IF SYS_CONTEXT('USERENV', 'SESSION_USER') = 'U_AD_QLNV' THEN
        RETURN '1=1';
    END IF;
    
    -- Mỗi user đều có mức quyền thấp nhất là nhân viên nên được quyền select trên view NHANVIEN
    SELECT VAITRO INTO ROLE_NAME FROM U_AD_QLNV.NHANVIEN_SESSION;
    MANV := SYS_CONTEXT('USERENV', 'SESSION_USER');
    
	IF ROLE_NAME = N'Tài chính' THEN
        PREDICATE := '1=1';
	ELSE
        PREDICATE := 'MANV = '''||MANV||'''';
    END IF;
	RETURN PREDICATE;
END;
/
DROP FUNCTION SELECT_NV_FUNCTION;
CREATE OR REPLACE FUNCTION SELECT_NV_FUNCTION (
	P_SCHEMA IN VARCHAR2,
	P_OBJECT IN VARCHAR2) RETURN VARCHAR2
AS
	PREDICATE VARCHAR2(1000);
    MANV VARCHAR(200);
    ROLE_NAME NVARCHAR2(200);
BEGIN

    IF SYS_CONTEXT('USERENV', 'SESSION_USER') = 'U_AD_QLNV' THEN
        RETURN '1=1';
    END IF;
    
    -- Mỗi user đều có mức quyền thấp nhất là nhân viên nên được quyền select trên view NHANVIEN
    SELECT VAITRO INTO ROLE_NAME FROM U_AD_QLNV.NHANVIEN_SESSION;
    MANV := SYS_CONTEXT('USERENV', 'SESSION_USER');
    
	IF ROLE_NAME = N'Tài chính' THEN
        PREDICATE := '1=1';
	ELSE
        PREDICATE := 'MANV = '''||MANV||'''';
    END IF;
	RETURN PREDICATE;
END;
/
-- Xóa và cài đặt chính sách
BEGIN
	DBMS_RLS.DROP_POLICY(
        OBJECT_SCHEMA => 'U_AD_QLNV',
        OBJECT_NAME => 'NHANVIEN',
        POLICY_NAME => 'UPDATE_NV_POLICY');
END;
/
BEGIN
	DBMS_RLS.ADD_POLICY(
        OBJECT_SCHEMA => 'U_AD_QLNV',
        OBJECT_NAME => 'NHANVIEN',
        POLICY_NAME => 'UPDATE_NV_POLICY',
        POLICY_FUNCTION => 'UPDATE_NV_FUNCTION',
        STATEMENT_TYPES => 'SELECT, UPDATE',
        UPDATE_CHECK => TRUE
	);
END;
/
BEGIN
	DBMS_RLS.DROP_POLICY(
        OBJECT_SCHEMA => 'U_AD_QLNV',
        OBJECT_NAME => 'NHANVIEN_NHANSU',
        POLICY_NAME => 'SELECT_NV_POLICY');
END;
/
BEGIN
	DBMS_RLS.ADD_POLICY(
        OBJECT_SCHEMA => 'U_AD_QLNV',
        OBJECT_NAME => 'NHANVIEN_NHANSU',
        POLICY_NAME => 'SELECT_NV_POLICY',
        POLICY_FUNCTION => 'SELECT_NV_FUNCTION',
        STATEMENT_TYPES => 'SELECT',
        SEC_RELEVANT_COLS => 'LUONG, PHUCAP',
        SEC_RELEVANT_COLS_OPT => DBMS_RLS.ALL_ROWS
	);
END;
/