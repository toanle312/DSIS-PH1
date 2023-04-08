ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE; 
DROP USER U_AD CASCADE;
CREATE USER U_AD IDENTIFIED BY 123;

GRANT DBA TO U_AD;

GRANT ALL PRIVILEGES TO U_AD with ADMIN OPTION;

GRANT SELECT ON DBA_TAB_PRIVS TO U_AD WITH GRANT OPTION;
GRANT SELECT ON ROLE_TAB_PRIVS TO U_AD WITH GRANT OPTION;

GRANT SELECT ON dba_tables TO U_AD WITH GRANT OPTION;

GRANT SELECT ON dba_users TO U_AD WITH GRANT OPTION;

GRANT SELECT ON USER_ROLE_PRIVS TO U_AD WITH GRANT OPTION;
GRANT SELECT ON DBA_ROLES TO U_AD WITH GRANT OPTION;

GRANT EXECUTE ON DBMS_RLS TO U_AD;
GRANT EXECUTE ON DBMS_CRYPTO TO U_AD;

GRANT SELECT ON dba_audit_trail TO U_AD;

GRANT SELECT ON dba_audit_trail TO U_AD;
GRANT EXECUTE ON DBMS_FGA TO U_AD;
GRANT SELECT ON SYS.FGA_LOG$ TO U_AD;