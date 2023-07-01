-------------thực hiện bằng U_AD_QLNV

--TEST Ý A( AUDIT NHỮNG NGƯỜI ĐÃ CẬP NHẬT TRƯỜNG THOIGIAN TRONG QUAN HỆ PHANCONG.)
--bị audit
UPDATE U_AD_QLNV.PHANCONG$
SET THOIGIAN = 0
WHERE MANV='NV001';

-- TEST Ý B( AUDIT NHỮNG NGƯỜI ĐÃ ĐỌC TRÊN TRƯỜNG LUONG VÀ PHUCAP CỦA NGƯỜI KHÁC.)
--không bị audit
SELECT MANV, TENNV, PHAI, NGAYSINH, DIACHI, SODT, VAITRO, MANQL,PHG
FROM  U_AD_QLNV.NHANVIEN$;

--bị audit
SELECT *
FROM U_AD_QLNV.NHANVIEN$;
/

-- TEST Ý C( MỘT NGƯỜI KHÔNG THUỘC VAI TRÒ “TÀI CHÍNH” NHƯNG ĐÃ CẬP NHẬT THÀNH CÔNG TRÊN TRƯỜNG LUONG VÀ PHUCAP)
--không bị audit
CONNECT NV329/123;
UPDATE U_AD_QLNV.NHANVIEN
SET LUONG=2000
WHERE MANV='NV001';

--bị audit
alter session set "_ORACLE_SCRIPT"=true;
DROP USER TESTaudit;
CREATE USER TESTaudit IDENTIFIED BY 1;
/
GRANT CREATE SESSION TO TESTaudit;
GRANT SELECT ON U_AD_QLNV.NHANVIEN$ TO TESTaudit;
grant update on U_AD_QLNV.NHANVIEN$ to TESTaudit;
/
CONNECT TESTaudit/1;
UPDATE U_AD_QLNV.NHANVIEN$
SET LUONG=2000
WHERE MANV='NV001';
/
SELECT * 
FROM DBA_FGA_AUDIT_TRAIL
order by timestamp;