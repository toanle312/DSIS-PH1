-- Create role
create or replace NONEDITIONABLE PROCEDURE CREATE_ROLE_SP(
in_rolename VARCHAR2
)
IS
    statement VARCHAR2(100) :='';
BEGIN
    statement:='alter session set "_ORACLE_SCRIPT"=true';
    execute immediate(statement);

    statement:='CREATE ROLE "'|| in_rolename||'"';
    execute immediate(statement);

END CREATE_ROLE_SP;

-- Create user
create or replace NONEDITIONABLE PROCEDURE CREATE_USER_SP(
in_username VARCHAR2,
in_password VARCHAR2
)
IS
    statement VARCHAR2(100) :='';
BEGIN
    statement:='alter session set "_ORACLE_SCRIPT"=true';
    execute immediate(statement);

    statement:='CREATE USER "'|| in_username ||'" IDENTIFIED BY '||in_password;
    execute immediate(statement);

END CREATE_USER_SP;

-- Delete role
create or replace NONEDITIONABLE PROCEDURE DELETE_ROLE_SP(
in_rolename VARCHAR2
)
IS
    statement VARCHAR2(100) :='';
BEGIN
    statement:='alter session set "_ORACLE_SCRIPT"=true';
    execute immediate(statement);

    statement:='DROP ROLE "'|| in_rolename ||'"';
    execute immediate(statement);

END DELETE_ROLE_SP;

-- Delete user
create or replace NONEDITIONABLE PROCEDURE DELETE_USER_SP(
in_username VARCHAR2
)
IS
    statement VARCHAR2(100) :='';
BEGIN
    statement:='alter session set "_ORACLE_SCRIPT"=true';
    execute immediate(statement);

    statement:='DROP USER '|| in_username;
    execute immediate(statement);

END DELETE_USER_SP;

-- Edit user
create or replace NONEDITIONABLE PROCEDURE EDIT_USER_SP(
in_username VARCHAR2,
in_password VARCHAR2
)
IS
    statement VARCHAR2(100) :='';
BEGIN
    statement:='alter session set "_ORACLE_SCRIPT"=true';
    execute immediate(statement);

    statement:='ALTER USER '|| in_username ||' IDENTIFIED BY '||in_password;
    execute immediate(statement);

END EDIT_USER_SP;

-- Check user role if exist
create or replace NONEDITIONABLE FUNCTION CHECK_USER_ROLE_EXIST(
in_name VARCHAR2
)
RETURN NUMBER
IS
    mark NUMBER :=0;
BEGIN
    select count(*) 
    into mark
    from dba_users
    where username=in_name;
    
    --user ton tai
    if mark=1 then
        return 1;
    else
        select count(*) 
        into mark
        from dba_roles
        where role=in_name;
        if mark=1 then
            return 2; --role ton tai
        else
            return 0; --user va role khong ton tai
        end if;
    end if;
END CHECK_USER_ROLE_EXIST;

-- Phan quyen cho user va role tren obj
CREATE OR REPLACE PROCEDURE usp_GrantObjPrivs(
	privs VARCHAR2, -- seperated by comma
	schema_name VARCHAR2,
	obj VARCHAR2, -- can be table or view
	grantee VARCHAR2, -- can be user or ROLE
	with_grant BOOLEAN -- with grant option
)
AS
	sql_string VARCHAR2(200);
BEGIN
	EXECUTE IMMEDIATE 'ALTER SESSION SET "_ORACLE_SCRIPT"=TRUE';
	
	sql_string := 'GRANT {privileges} ON {schema}.{object} TO {grantee}';
	sql_string := REPLACE (sql_string, '{privileges}', privs);
	sql_string := REPLACE (sql_string, '{schema}', schema_name);
	sql_string := REPLACE (sql_string, '{object}', obj);
	sql_string := REPLACE (sql_string, '{grantee}', grantee);
	IF with_grant THEN
		sql_string := sql_string || ' WITH GRANT OPTION';
	END IF;
	
	DBMS_OUTPUT.PUT_LINE (sql_string);
	EXECUTE IMMEDIATE (sql_string);
END;

SELECT * FROM USER_ERRORS WHERE NAME = UPPER('usp_GrantObjPrivs');

-- Phan role cho user
CREATE OR REPLACE PROCEDURE usp_GrantRole(
	rol VARCHAR2,
	usr VARCHAR2
)
AS
	sql_string VARCHAR2(200);
BEGIN
	EXECUTE IMMEDIATE 'ALTER SESSION SET "_ORACLE_SCRIPT"=TRUE';

	sql_string := 'GRANT {role} TO {user}';
	sql_string := REPLACE (sql_string, '{role}', rol);
	SQL_string := REPLACE (sql_string, '{user}', usr);
	
	DBMS_OUTPUT.PUT_LINE (sql_string);
	EXECUTE IMMEDIATE (sql_string);
END;

SELECT * FROM USER_ERRORS WHERE NAME = UPPER('usp_GrantRole');

-- Phan quyen select cho cot
CREATE OR REPLACE PROCEDURE usp_GrantSelectOnCol(
	schema_name VARCHAR2,
	obj VARCHAR2,
	col VARCHAR2, -- seperated by comma
	grantee VARCHAR2,
	with_grant BOOLEAN
)
AS 
	sql_string VARCHAR2(200);
BEGIN
	EXECUTE IMMEDIATE 'ALTER SESSION SET "_ORACLE_SCRIPT"=TRUE';
	
	-- Create view from base object
	sql_string := '
	CREATE OR REPLACE VIEW {grantee}.{object}
	AS
	SELECT {col} FROM {schema_name}.{object}';
	sql_string := REPLACE (sql_string, '{grantee}', grantee);
	sql_string := REPLACE (sql_string, '{object}', obj);
	sql_string := REPLACE (sql_string, '{col}', col);
	sql_string := REPLACE (sql_string, '{schema_name}', schema_name);
	
	DBMS_OUTPUT.PUT_LINE (sql_string);
	EXECUTE IMMEDIATE (sql_string);

	usp_GrantObjPrivs ('SELECT', grantee, obj, grantee, with_grant);
END;

SELECT * FROM USER_ERRORS WHERE NAME = UPPER('usp_GrantSelectOnCol');

-- Phan quyen update cho cot
CREATE OR REPLACE PROCEDURE usp_GrantUpdateOnCol(
	obj VARCHAR2,
	col VARCHAR2, -- seperated by comma
	grantee VARCHAR2,
	with_grant BOOLEAN
)
AS
	sql_string VARCHAR2(200);
BEGIN
	EXECUTE IMMEDIATE 'ALTER SESSION SET "_ORACLE_SCRIPT"=TRUE';
	
	sql_string := 'GRANT UPDATE ({col}) ON {object} TO {grantee}';
	sql_string := REPLACE (sql_string, '{grantee}', grantee);
	sql_string := REPLACE (sql_string, '{object}', obj);
	sql_string := REPLACE (sql_string, '{col}', col);

	DBMS_OUTPUT.PUT_LINE (sql_string);
	EXECUTE IMMEDIATE (sql_string);
END;

SELECT * FROM USER_ERRORS WHERE NAME = UPPER('usp_GrantUpdateOnCol');

