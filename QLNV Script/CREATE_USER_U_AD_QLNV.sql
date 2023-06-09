ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE; 
DROP USER U_AD_QLNV CASCADE;
CREATE USER U_AD_QLNV IDENTIFIED BY 123;

GRANT DBA TO U_AD_QLNV;

GRANT ALL PRIVILEGES TO U_AD_QLNV with ADMIN OPTION;

GRANT SELECT ON dba_sys_privs TO U_AD_QLNV WITH GRANT OPTION;
GRANT SELECT ON role_sys_privs TO U_AD_QLNV WITH GRANT OPTION;
GRANT SELECT ON DBA_COL_PRIVS TO U_AD_QLNV WITH GRANT OPTION;
GRANT SELECT ON DBA_ROLE_PRIVS to U_AD_QLNV WITH GRANT OPTION;

GRANT SELECT ON DBA_TAB_PRIVS TO U_AD_QLNV WITH GRANT OPTION;
GRANT SELECT ON ROLE_TAB_PRIVS TO U_AD_QLNV WITH GRANT OPTION;

GRANT SELECT ON dba_tables TO U_AD_QLNV WITH GRANT OPTION;

GRANT SELECT ON dba_users TO U_AD_QLNV WITH GRANT OPTION;

GRANT SELECT ON USER_ROLE_PRIVS TO U_AD_QLNV WITH GRANT OPTION;
GRANT SELECT ON DBA_ROLES TO U_AD_QLNV WITH GRANT OPTION;

GRANT EXECUTE ON DBMS_RLS TO U_AD_QLNV;
GRANT EXECUTE ON DBMS_CRYPTO TO U_AD_QLNV;

GRANT SELECT ON dba_audit_trail TO U_AD_QLNV;

GRANT SELECT ON dba_audit_trail TO U_AD_QLNV;
GRANT EXECUTE ON DBMS_FGA TO U_AD_QLNV;
GRANT SELECT ON SYS.FGA_LOG$ TO U_AD_QLNV;