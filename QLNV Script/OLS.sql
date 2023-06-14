--CONN SYS

ALTER SESSION SET container = CDB$ROOT;

-- XÓA DATABASE
ALTER PLUGGABLE DATABASE QLNV_PDB CLOSE IMMEDIATE;
DROP PLUGGABLE DATABASE QLNV_PDB INCLUDING DATAFILES;

--TẠO DATABASE
CREATE PLUGGABLE DATABASE QLNV_PDB                                                                                    
ADMIN USER AD_QLNV IDENTIFIED BY "123" ROLES = (dba) 
FILE_NAME_CONVERT = ('pdbseed', 'qlnv_pdb');

ALTER SESSION SET container = QLNV_PDB;
ALTER PLUGGABLE DATABASE QLNV_PDB OPEN;
ALTER USER AD_QLNV QUOTA UNLIMITED ON SYSTEM;

--BẬT OLS
EXEC LBACSYS.CONFIGURE_OLS;
/
EXEC LBACSYS.OLS_ENFORCEMENT.ENABLE_OLS;
/
ALTER USER lbacsys IDENTIFIED BY "123" ACCOUNT UNLOCK;
GRANT CONNECT TO lbacsys;

SHUTDOWN IMMEDIATE
STARTUP

select value from V$OPTION where parameter = 'Oracle Label Security';


--CONN lbacsys/123
--TẠO CHÍNH SÁCH
ALTER SESSION SET container = QLNV_PDB;
/
BEGIN
    SA_SYSDBA.DROP_POLICY (
        policy_name => 'TRUY_CAP_THONG_BAO',
        drop_column => true
    );
END;
/
BEGIN
    SA_SYSDBA.CREATE_POLICY (
        policy_name => 'TRUY_CAP_THONG_BAO',
        column_name => 'OLS_COLUMN'
    );
END;
/
--GÁN QUYỀN CHO AD_QLNV
grant TRUY_CAP_THONG_BAO_DBA to AD_QLNV;
grant execute on SA_COMPONENTS to AD_QLNV;
grant execute on SA_LABEL_ADMIN to AD_QLNV;
grant execute on sa_policy_admin to AD_QLNV;
grant execute on SA_USER_ADMIN to AD_QLNV;
grant execute on CHAR_TO_LABEL to AD_QLNV;
GRANT execute ON to_lbac_data_label TO AD_QLNV;


--CONN AD_QLNV/123
GRANT INHERIT PRIVILEGES ON USER AD_QLNV TO LBACSYS;

--TẠO BẢNG THÔNG BÁO
DROP TABLE THONGBAO PURGE;

CREATE TABLE THONGBAO (
    MATB NUMBER GENERATED ALWAYS AS IDENTITY(START WITH 1 INCREMENT by 1),
    NOIDUNG NVARCHAR2(300),
    NGAYGIO DATE,
	CAPBAC NVARCHAR2(100), 
	LINHVUC NVARCHAR2(100),
	CHINHANH NVARCHAR2(100),
    CONSTRAINT PK_THONGBAO PRIMARY KEY (MATB)
);

--TẠO USER 
DROP USER TONGGIAMDOC CASCADE;
DROP USER TRUONGPHONG_SANXUAT_MIENNAM CASCADE;
DROP USER GIAMDOC_MIENBAC CASCADE;

CREATE USER TONGGIAMDOC identified by "1";
CREATE USER TRUONGPHONG_SANXUAT_MIENNAM identified by "1";
CREATE USER GIAMDOC_MIENBAC identified by "1";

grant select on THONGBAO to TONGGIAMDOC;
grant select on THONGBAO to TRUONGPHONG_SANXUAT_MIENNAM;
grant select on THONGBAO to GIAMDOC_MIENBAC;
grant CREATE SESSION to TONGGIAMDOC, TRUONGPHONG_SANXUAT_MIENNAM, GIAMDOC_MIENBAC;

--TẠO THÀNH PHẦN NHÃN
BEGIN
    sa_components.create_level (
        policy_name => 'TRUY_CAP_THONG_BAO',
        long_name   => 'GIAM_DOC',
        short_name  => 'GD',
        level_num   => 9000
    );
END;
/

BEGIN
    sa_components.create_level (
        policy_name => 'TRUY_CAP_THONG_BAO',
        long_name   => 'TRUONG_PHONG',
        short_name  => 'TP',
        level_num   => 7000
    );
END;
/

BEGIN
    sa_components.create_level (
        policy_name => 'TRUY_CAP_THONG_BAO',
        long_name   => 'NHANVIEN',
        short_name  => 'NV',
        level_num   => 4000
    );
END;
/
BEGIN
     sa_components.create_compartment (
        policy_name => 'TRUY_CAP_THONG_BAO',
        long_name =>'MUA_BAN',
        short_name => 'MB',
        comp_num => 1000
    );
END;
/
BEGIN
     sa_components.create_compartment (
        policy_name => 'TRUY_CAP_THONG_BAO',
        long_name =>'SAN_XUAT',
        short_name => 'SX',
        comp_num => 2000
    );
END;
/
BEGIN
     sa_components.create_compartment (
        policy_name => 'TRUY_CAP_THONG_BAO',
        long_name =>'GIA_CONG',
        short_name => 'GC',
        comp_num => 3000
    );
END;
/
BEGIN
     sa_components.create_GROUP (
        policy_name => 'TRUY_CAP_THONG_BAO',
        long_name =>'MIEN_BAC',
        short_name => 'B',
        GROUP_num => 1000
    );
END;
/
BEGIN
     sa_components.create_GROUP (
        policy_name => 'TRUY_CAP_THONG_BAO',
        long_name =>'MIEN_TRUNG',
        short_name => 'T',
        GROUP_num => 2000
    );
END;
/
BEGIN
     sa_components.create_GROUP (
        policy_name => 'TRUY_CAP_THONG_BAO',
        long_name =>'MIEN_NAM',
        short_name => 'N',
        GROUP_num => 3000
    );
END;
/

--TẠO HÀM GÁN NHÃN
CREATE OR REPLACE FUNCTION AD_QLNV.GEN_THONGBAO_LABEL
 (CAPBAC NVARCHAR2, LINHVUC NVARCHAR2, CHINHANH NVARCHAR2)
RETURN LBACSYS.LBAC_LABEL
AS
 i_label varchar2(80);
BEGIN
/************* Xác định level *************/
IF CAPBAC = N'Giám đốc' THEN
    i_label := 'GD:';
ELSIF CAPBAC = N'Trưởng phòng' THEN
    i_label := 'TP:';
ELSE
    i_label := 'NV:';
END IF;

/************* Xác định compartment *************/
IF LINHVUC LIKE N'%Mua bán%' THEN
    i_label := i_label||'MB,';
END IF;
IF LINHVUC LIKE N'%Sản xuất%' THEN
    i_label := i_label||'SX,';
END IF;
IF LINHVUC LIKE N'%Gia công%' THEN
    i_label := i_label||'GC,';
END IF;
i_label := i_label||':';

/************* Xác định groups *************/
IF CHINHANH LIKE N'%Miền Bắc%' THEN
    i_label := i_label||'B,';
END IF;
IF CHINHANH LIKE N'%Miền Trung%' THEN
    i_label := i_label||'T,';
END IF;
IF CHINHANH LIKE N'%Miền Nam%' THEN
    i_label := i_label||'N,';
END IF;

RETURN TO_LBAC_DATA_LABEL('TRUY_CAP_THONG_BAO',i_label);
END;
/

GRANT execute ON AD_QLNV.GEN_THONGBAO_LABEL TO lbacsys;

--GÁN NHÃN LÊN DỮ LIỆU
BEGIN
    sa_policy_admin.remove_table_policy (
        policy_name     => 'TRUY_CAP_THONG_BAO',
        schema_name     => 'AD_QLNV',
        table_name      => 'THONGBAO'
    );
END;
/
BEGIN
    sa_policy_admin.apply_table_policy (
        policy_name     => 'TRUY_CAP_THONG_BAO',
        schema_name     => 'AD_QLNV',
        table_name      => 'THONGBAO',
        table_options   => 'HIDE,READ_CONTROL',
        label_function => 'AD_QLNV.GEN_THONGBAO_LABEL(:new.capbac, :new.linhvuc, :new.chinhanh)',
        PREDICATE => NULL);
END;
/


insert into THONGBAO (NOIDUNG, NGAYGIO, CAPBAC, LINHVUC, CHINHANH) values (N'Thông báo t1 đến tất cả trưởng phòng phụ trách tất cả các lĩnh vực không phân biệt chi nhánh.', '01-JAN-2023', N'Trưởng phòng', N'Mua bán, Sản xuất, Gia công', NULL);
insert into THONGBAO (NOIDUNG, NGAYGIO, CAPBAC, LINHVUC, CHINHANH) values (N'Thông báo t2 đến trưởng phòng phụ trách lĩnh vực sản xuất ở miền Trung.', '02-JAN-2023', N'Trưởng phòng', N'Sản xuất', N'Miền Trung');
insert into THONGBAO (NOIDUNG, NGAYGIO, CAPBAC, LINHVUC, CHINHANH) values (N'Thông báo t3 đến nhân viên phụ trách lĩnh vực sản xuất ở miền Nam.', '03-JAN-2023', N'Nhân viên', N'Sản xuất', N'Miền Nam');
insert into THONGBAO (NOIDUNG, NGAYGIO, CAPBAC, LINHVUC, CHINHANH) values (N'Thông báo t4 đến tất cả nhân viên phụ trách lĩnh vực mua bán và gia công ở miền Bắc và miền Trung.', '04-JAN-2023', N'Nhân viên', N'Mua bán, Gia công', N'Miền Bắc, Miền Trung');
insert into THONGBAO (NOIDUNG, NGAYGIO, CAPBAC, LINHVUC, CHINHANH) values (N'Thông báo t5 đến tất cả trưởng phòng phụ trách lĩnh vực sản xuất ở miền Bắc và miền Nam.', '05-JAN-2023', N'Trưởng phòng', N'Sản xuất', N'Miền Bắc, Miền Nam');

--GÁN NHÃN LÊN USER
BEGIN
    sa_user_admin.set_user_labels (
        policy_name     => 'TRUY_CAP_THONG_BAO',
        user_name       => 'TONGGIAMDOC',
        max_read_label  => 'GD:MB,SX,GC:B,T,N'
        --min_write_label => 'NV',
        --def_label => 'GD:MB,SX,GC:B,T,N'
    );
END;
/

BEGIN
    sa_user_admin.set_user_labels (
        policy_name     => 'TRUY_CAP_THONG_BAO',
        user_name       => 'TRUONGPHONG_SANXUAT_MIENNAM',
        max_read_label  => 'TP:SX:N'
        --min_write_label => 'NV',
        --def_label => 'TP:SX:N'
    );
END;
/

BEGIN
    sa_user_admin.set_user_labels (
        policy_name     => 'TRUY_CAP_THONG_BAO',
        user_name       => 'GIAMDOC_MIENBAC',
        max_read_label  => 'GD:MB,SX,GC:B'
        --min_write_label => 'NV',
        --def_label => 'GD:MB,SX,GC:B'
    );
END;
/



