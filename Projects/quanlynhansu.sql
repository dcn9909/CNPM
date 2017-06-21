USE master
GO


IF EXISTS(select * from sys.databases where name='quanlynhansu')
DROP DATABASE quanlynhansu
GO

CREATE DATABASE quanlynhansu
GO

USE quanlynhansu
GO


CREATE TABLE Account(
	id INT PRIMARY KEY IDENTITY,
	userName NVARCHAR(100),
	passWord NVARCHAR(100),
	displayName NVARCHAR(100),
	permission TINYINT DEFAULT 1--1 là user bình thường, 0 là admin 
)
GO

--store insert vào bảng account
CREATE PROC USP_InsertAccount
@userName NVARCHAR(100),
@passWord NVARCHAR(100),
@displayName NVARCHAR(100),
@permission TINYINT
AS
BEGIN
	INSERT INTO dbo.Account (  userName, passWord,displayName, permission )VALUES  ( @username,@passWord, @displayName, @permission)
END
GO

EXEC dbo.USP_InsertAccount @userName = N'daty', -- nvarchar(100)
    @passWord = N'1', -- nvarchar(100)
    @displayName = N'Đặng Huỳnh Đạt Ý', -- nvarchar(100)
    @permission = 0 -- tinyint
GO

--store procedure login
CREATE PROC USP_Login
@userName NVARCHAR(100),
@passWord NVARCHAR(100)
AS
BEGIN
	SELECT COUNT(*) FROM dbo.Account WHERE userName = @userName AND passWord = @passWord
END
GO


EXEC dbo.USP_Login @userName = N'daty', -- nvarchar(100)
    @passWord = N'1' -- nvarchar(100)
GO
