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
-- test câu a
update phancong$ set thoigian=40 where manv='NV001';

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

----test cau b
alter session set "_ORACLE_SCRIPT"=true;
CREATE USER TESTaudit IDENTIFIED BY 1;
/
GRANT CREATE SESSION TO TESTaudit;
GRANT SELECT ON NHANVIEN$ TO TESTaudit;
/
CONNECT TESTaudit/1
select * from NHANVIEN$ WHERE MANV='NV002';


--c/ Một người không thuộc vai trò “Tài chính” nhưng đã cập nhật thành công trên trường LUONG và PHUCAP.
BEGIN
DBMS_FGA.DROP_POLICY(
object_schema => 'U_AD_QLNV',
object_name => 'NHANVIEN$',
policy_name => 'CAPNHAT_LUONG_PHUCAP_NHANVIEN');
END;
/
BEGIN
  DBMS_FGA.ADD_POLICY(
    object_schema => 'U_AD_QLNV',
    object_name => 'NHANVIEN$',
    policy_name => 'CAPNHAT_LUONG_PHUCAP_NHANVIEN',
    audit_column => 'LUONG,PHUCAP',
    audit_condition => q'[SYS_CONTEXT('USERENV', 'SESSION_USER') NOT IN (SELECT MANV FROM NHANVIEN$ WHERE VAITRO = N'Tài chính')]',
    statement_types => 'UPDATE',
    audit_trail => DBMS_FGA.DB + DBMS_FGA.EXTENDED
  );
END;
/

---- test câu c
alter session set "_ORACLE_SCRIPT"=true;
/
GRANT UPDATE ON NHANVIEN$ TO TESTaudit;
/
CONNECT TESTaudit/1;
UPDATE U_AD_QLNV.NHANVIEN$ 
SET LUONG = 2000 
WHERE MANV='NV123';
/

--d/ Kiểm tra nhật ký hệ thống.



DROP USER TESTaudit;

-- Xem bảng audit
SELECT * FROM DBA_FGA_AUDIT_TRAIL;
