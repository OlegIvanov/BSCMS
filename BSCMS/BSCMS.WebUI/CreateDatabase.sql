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
INSERT INTO Users VALUES (1, 'oleg', 'ac29937c97d6154f8f31c85f9abf5c790557cf55')

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