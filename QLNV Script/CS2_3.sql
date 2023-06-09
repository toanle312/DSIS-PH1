                                                                                                                                                                                                                                                                                                                                                                                                                                                          
--view cho quản lí xem thông tin nhân viên mình quản lí
CREATE OR REPLACE VIEW QUANLI_THONGTIN_VIEW AS 
SELECT NV2.MANV, NV2.TENNV, NV2.PHAI, NV2.NGAYSINH, NV2.DIACHI, NV2.SODT, NV2.VAITRO, NV2.MANQL, NV2.PHG
FROM NHANVIEN$ NV1 JOIN NHANVIEN$ NV2
ON NV2.MANQL=NV1.MANV
WHERE NV1.MANV = SYS_CONTEXT ('userenv', 'session_user');


--view cho quản lí xem thông tin phân công của mình và các nhân viên mình quản lí
CREATE OR REPLACE VIEW QUANLI_PHANCONG_VIEW AS
SELECT PC.MANV,PC.MADA, PC.THOIGIAN
FROM PHANCONG$ PC JOIN NHANVIEN$ NV ON PC.MANV=NV.MANV
WHERE NV.MANV = SYS_CONTEXT ('userenv', 'session_user') or NV.MANV in (SELECT NV2.MANV
                                                                       FROM NHANVIEN$ NV2 JOIN NHANVIEN$ NV1 ON NV2.MANQL=NV1.MANV
                                                                       WHERE NV1.MANV = SYS_CONTEXT ('userenv', 'session_user'));
                                                                       
-- Tạo role quản lí trực tiếp và cấp quyền cho role này
alter session set "_ORACLE_SCRIPT"=TRUE;
/
DROP ROLE R_QLTRUCTIEP;
CREATE ROLE R_QLTRUCTIEP;

GRANT SELECT ON QUANLI_THONGTIN_VIEW TO R_QLTRUCTIEP;
GRANT SELECT ON QUANLI_PHANCONG_VIEW TO R_QLTRUCTIEP;



-- Cấp role ROLE_NHANVIEN và role R_QLTRUCTIEP cho tất cả quản lí trực tiếp
/
CREATE OR REPLACE PROCEDURE GRANT_ROLE_NHANVIEN_QLTRUCTIEP
AS
    CURSOR CUR IS SELECT MANV FROM NHANVIEN$ WHERE UPPER(MANV) IN (SELECT USERNAME FROM ALL_USERS) AND VAITRO = N'QL trực tiếp';
    strSQL varchar(2000);
    usr varchar(60);
BEGIN
    OPEN CUR;
    LOOP
        FETCH CUR INTO usr;
        EXIT WHEN CUR%NOTFOUND;
        
        strSQL := 'GRANT ROLE_NHANVIEN TO ' || usr;
        EXECUTE IMMEDIATE (strSQL);
        
        strSQL := 'GRANT R_QLTRUCTIEP TO ' || usr;
        EXECUTE IMMEDIATE (strSQL);
        
    END LOOP;
END;
/
EXEC GRANT_ROLE_NHANVIEN_QLTRUCTIEP;
/


---------------------------------
/
--VIEW cho trưởng phòng xem thông tin các thành viên trong phòng ban của bản thân
CREATE OR REPLACE VIEW TRUONGPHONG_THONGTIN_VIEW AS
SELECT NV2.MANV, NV2.TENNV, NV2.PHAI, NV2.NGAYSINH, NV2.DIACHI, NV2.SODT, NV2.VAITRO, NV2.MANQL, NV2.PHG
FROM NHANVIEN$ NV1 JOIN NHANVIEN$ NV2
ON NV2.PHG=NV1.PHG
WHERE NV1.MANV = SYS_CONTEXT ('userenv', 'session_user');
/


--VIEW cho trưởng phòng xem bảng phân công
CREATE OR REPLACE VIEW TRUONGPHONG_PHANCONG_VIEW AS
SELECT PC.MANV,PC.MADA, PC.THOIGIAN
FROM PHANCONG$ PC JOIN NHANVIEN$ NV ON PC.MANV=NV.MANV
WHERE NV.MANV = SYS_CONTEXT ('userenv', 'session_user') or NV.MANV in (SELECT NV2.MANV
                                                                        FROM NHANVIEN$ NV1 JOIN NHANVIEN$ NV2
                                                                        ON NV2.PHG=NV1.PHG
                                                                        WHERE NV1.MANV = SYS_CONTEXT ('userenv', 'session_user'));


/
-- Hàm kiểm tra xem nhân viên được thêm vào có thuộc phòng của trưởng phòng đó hay không
create or replace  FUNCTION CHECK_INSERT_PC_VALID(
MANV_IN  VARCHAR2
)
RETURN NUMBER
IS
    PH_TEMP VARCHAR2(100);
    PHG_TEMP VARCHAR2(100);
BEGIN  
    SELECT PHG INTO PH_TEMP 
    FROM NHANVIEN$ WHERE MANV = SYS_CONTEXT('userenv', 'SESSION_USER');
    
    SELECT PHG INTO PHG_TEMP
    FROM NHANVIEN$ WHERE MANV = MANV_IN;
    
    --Nhân viên không thuộc phòng đó
    if (PH_TEMP <> PHG_TEMP) then
        return 0;
    --Nhân viên thuộc phòng của trưởng phòng đó
    else
        return 1;
    end if;
END CHECK_INSERT_PC_VALID;
/

-- Procedure insert PHANCONG
CREATE OR REPLACE PROCEDURE INSERT_PHANCONG
(
    MANV_IN  VARCHAR2,
    MADA_IN VARCHAR2 ,
    THOIGIAN_IN NUMBER
)
AS
BEGIN
    INSERT INTO PHANCONG$ VALUES(MANV_IN, MADA_IN, THOIGIAN_IN);
    COMMIT;
END;
/

-- Procedure DELETE PHANCON
/
CREATE OR REPLACE PROCEDURE DELETE_PHANCONG
(
    MANV_IN  VARCHAR2,
    MADA_IN VARCHAR2
)
AS
BEGIN
    DELETE FROM PHANCONG$ WHERE MANV = MANV_IN AND MADA = MADA_IN;
    COMMIT;
END;
/

/
create or replace  FUNCTION CHECK_PHANCONG_EXIST(
MANV_IN  VARCHAR2,
MADA_IN VARCHAR2
)
RETURN NUMBER
IS
    mark NUMBER :=0;
BEGIN
    select count(*) 
    into mark
    from U_AD_QLNV.PHANCONG$
    where MANV=MANV_IN AND MADA = MADA_IN;
    
    --phan cong ton tai
    if mark = 1 then
        return 1;
    else
        return 0;
    end if;
END CHECK_PHANCONG_EXIST;


-- Procedure UPDATE PHANCONG
/
CREATE OR REPLACE PROCEDURE UPDATE_PHANCONG
(
    MANV_IN  VARCHAR2,
    MADA_IN VARCHAR2,
    THOIGIAN_IN VARCHAR2
)
AS
    USER VARCHAR2(255);
BEGIN
    UPDATE PHANCONG$
    SET THOIGIAN = THOIGIAN_IN
    WHERE MANV = MANV_IN AND MADA = MADA_IN;
    COMMIT;
END;
/


-- Tạo role trưởng phòng và cấp quyền
alter session set "_ORACLE_SCRIPT"=TRUE;
/
DROP ROLE R_TRUONGPHONG;
CREATE ROLE R_TRUONGPHONG;
GRANT SELECT ON TRUONGPHONG_THONGTIN_VIEW TO R_TRUONGPHONG;
GRANT SELECT ON TRUONGPHONG_PHANCONG_VIEW TO R_TRUONGPHONG;


-- Cấp role ROLE_NHANVIEN và role R_TRUONGPHONG cho tất cả trưởng phòng
/
CREATE OR REPLACE PROCEDURE GRANT_ROLE_NHANVIEN_TRUONGPHONG
AS
    CURSOR CUR IS SELECT MANV FROM NHANVIEN WHERE UPPER(MANV) IN (SELECT USERNAME FROM ALL_USERS) AND VAITRO = N'Trưởng phòng';
    strSQL varchar(2000);
    usr varchar(60);
BEGIN
    OPEN CUR;
    LOOP
        FETCH CUR INTO usr;
        EXIT WHEN CUR%NOTFOUND;
        
        strSQL := 'GRANT ROLE_NHANVIEN TO ' || usr;
        EXECUTE IMMEDIATE (strSQL);
        
        strSQL := 'GRANT R_TRUONGPHONG TO ' || usr;
        EXECUTE IMMEDIATE (strSQL);
        
    END LOOP;
END;
/
EXEC GRANT_ROLE_NHANVIEN_TRUONGPHONG;
/

-- Cấp quyền thao tác trên bảng nhân viên cho tất cả các nhân viên có vai trò Nhân viên( tại vì có thêm Trưởng phòng với Quản lí trực tiếp cũng có vai trò nhân viên)
/
EXEC USP_GRANT_PRIVS_NHANVIEN;
/

-- Gán quyền thực thi các hàm và thủ tục cho các trưởng phòng
CREATE OR REPLACE PROCEDURE GRANT_EXECUTE_FUNC_TRUONGPHONG
AS
    CURSOR CUR IS SELECT MANV FROM NHANVIEN WHERE UPPER(MANV) IN (SELECT USERNAME FROM ALL_USERS) AND VAITRO = N'Trưởng phòng';
    strSQL varchar(2000);
    usr varchar(60);
BEGIN
    OPEN CUR;
    LOOP
        FETCH CUR INTO usr;
        EXIT WHEN CUR%NOTFOUND;
        
        strSQL := 'GRANT EXECUTE ON CHECK_PHANCONG_EXIST TO ' || usr;
        EXECUTE IMMEDIATE (strSQL);
        strSQL := 'GRANT EXECUTE ON UPDATE_PHANCONG TO ' || usr;
        EXECUTE IMMEDIATE (strSQL);
        strSQL := 'GRANT EXECUTE ON CHECK_INSERT_PC_VALID TO ' || usr;
        EXECUTE IMMEDIATE (strSQL);
        strSQL := 'GRANT EXECUTE ON INSERT_PHANCONG TO ' || usr;
        EXECUTE IMMEDIATE (strSQL);
        strSQL := 'GRANT EXECUTE ON DELETE_PHANCONG TO ' || usr;
        EXECUTE IMMEDIATE (strSQL);
    END LOOP;
END;
/
EXEC GRANT_EXECUTE_FUNC_TRUONGPHONG;