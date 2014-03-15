GO
USE master

GO
IF DB_ID('BookStore') IS NOT NULL
	DROP DATABASE BookStore

GO
CREATE DATABASE BookStore

GO
USE BookStore

GO
CREATE TABLE Users
(
	Id						INT PRIMARY KEY,
	Username				NVARCHAR(100) NOT NULL,
	PasswordHash			NVARCHAR(100) NOT NULL
)

GO
CREATE PROCEDURE GetUserByUserAuthenticationQuery
(
	@Username				NVARCHAR(100),
	@PasswordHash			NVARCHAR(100)
)
AS
SELECT
	*
FROM
	Users
WHERE
	Users.Username = @Username AND Users.PasswordHash = @PasswordHash