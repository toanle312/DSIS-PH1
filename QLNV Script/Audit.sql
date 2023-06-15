--a/ Audit những người đã cập nhật trường THOIGIAN trong quan hệ PHANCONG.
BEGIN
DBMS_FGA.DROP_POLICY(
object_schema => 'U_AD_QLNV',
object_name => 'PHANCONG$',
policy_name => 'THOIGIAN_PHANCONG');
END;
/
BEGIN
DBMS_FGA.ADD_POLICY(
object_schema => 'U_AD_QLNV',
object_name => 'PHANCONG$',
policy_name => 'THOIGIAN_PHANCONG',
audit_column => 'THOIGIAN',
statement_types => 'UPDATE',
audit_trail => DBMS_FGA.DB + DBMS_FGA.EXTENDED);
END;
/

--b/ Audit những người đã đọc trên trường LUONG và PHUCAP của người khác.
BEGIN
DBMS_FGA.DROP_POLICY(
object_schema => 'U_AD_QLNV',
object_name => 'NHANVIEN$',
policy_name => 'LUONG_PHUCAP_NHANVIEN');
END;
/
BEGIN
DBMS_FGA.ADD_POLICY(
object_schema => 'U_AD_QLNV',
object_name => 'NHANVIEN$',
policy_name => 'LUONG_PHUCAP_NHANVIEN',
audit_column => 'LUONG,PHUCAP',
audit_condition => q'[SYS_CONTEXT('USERENV', 'SESSION_USER') != MANV]',
statement_types => 'SELECT',
audit_trail => DBMS_FGA.DB + DBMS_FGA.EXTENDED);
END;
/


--c/Một người không thuộc vai trò “Tài chính” nhưng đã cập nhật thành công trên trường LUONG và PHUCAP

-- tạo context tên TESTS ĐỂ lưu vai trò của user đang đăng nhập
create context TESTS using U_AD_QLNV.CONTEXT_PACKAGE;
/
-- tạo package có tên CONTEXT_PACKAGE, chứa thủ tục SET_CONTEXT để lấy vaitro
create or replace package CONTEXT_PACKAGE AS
procedure SET_CONTEXT;
end;
/
-- thủ tục SET_CONTEXT lấy vaitro
create or replace package body CONTEXT_PACKAGE is
procedure SET_CONTEXT IS
v_manv VARCHAR2(30);
v_vaitro VARCHAR2(30);

begin

    DBMS_SESSION.SET_CONTEXT('TESTS','SETUP','TRUE');
    v_manv := SYS_CONTEXT('USERENV','SESSION_USER');
    begin
        select vaitro into v_vaitro from nhanvien$
        where manv = v_manv;
        DBMS_SESSION.SET_CONTEXT('TESTS','VAITRO',v_vaitro);
    -- nếu username không có trong bảng thì gán rỗng
    exception
        WHEN NO_DATA_FOUND then
        DBMS_SESSION.SET_CONTEXT('TESTS','VAITRO','');
    end;
    DBMS_SESSION.SET_CONTEXT('TESTS','SETUP','FALSE');
end SET_CONTEXT;
end CONTEXT_PACKAGE;

/
-- cấp quyền thực thi package với các user khác và tạo 1 public synonym( để khi gọi package chỉ gần ghi CONTEXT_PACKAGE)
grant execute on U_AD_QLNV.CONTEXT_PACKAGE TO PUBLIC;
create or replace public synonym CONTEXT_PACKAGE for U_AD_QLNV.CONTEXT_PACKAGE;

/
--tạo trigger thực hiện context sau khi đăng nhập
create or replace trigger U_AD_QLNV.SET_SECURITY_CONTEXT
after logon on database
begin
U_AD_QLNV.CONTEXT_PACKAGE.SET_CONTEXT;
end;

/

BEGIN
  DBMS_FGA.DROP_POLICY(
    object_schema => 'U_AD_QLNV',
    object_name => 'NHANVIEN$',
    policy_name => 'UPDATE_LUONG_PHUCAP_NHANVIEN'
  );
END;
/
BEGIN
  DBMS_FGA.ADD_POLICY(
    object_schema => 'U_AD_QLNV',
    object_name => 'NHANVIEN$',
    policy_name => 'UPDATE_LUONG_PHUCAP_NHANVIEN',
    audit_column => 'LUONG,PHUCAP',
    statement_types => 'UPDATE',
    audit_trail => DBMS_FGA.DB + DBMS_FGA.EXTENDED,
    audit_condition => q'[SYS_CONTEXT('TESTS','VAITRO') != N'Tài chính']'
    );
END;
/


alter session set "_ORACLE_SCRIPT"=true;
DROP USER TESTaudit;
CREATE USER TESTaudit IDENTIFIED BY 1;
/
GRANT CREATE SESSION TO TESTaudit;
GRANT SELECT ON NHANVIEN$ TO TESTaudit;
GRANT UPDATE ON NHANVIEN$ to TESTaudit;
/
CONNECT TESTaudit/1
UPDATE U_AD_QLNV.NHANVIEN$
SET LUONG=2000
WHERE MANV='NV001';
/

-- Xem bảng audit
SELECT * FROM DBA_FGA_AUDIT_TRAIL;
