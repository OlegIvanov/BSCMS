﻿GO
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
CREATE TABLE Books
(
	Id						INT PRIMARY KEY IDENTITY(1,1),
	Title					NVARCHAR(200) NOT NULL,
	Price					MONEY NOT NULL,
	FileName				NVARCHAR(100) NOT NULL
)

GO
INSERT INTO Users VALUES (1, 'Oleg', 'ac29937c97d6154f8f31c85f9abf5c790557cf55')

GO
CREATE PROCEDURE GetUserByUsernameAndPasswordHash
(
	@Username				NVARCHAR(100),
	@PasswordHash			NVARCHAR(100)
)
AS
SELECT
	Users.Id,
	Users.Username,
	Users.PasswordHash
FROM
	Users
WHERE
	Users.Username = @Username AND Users.PasswordHash = @PasswordHash

GO
CREATE PROCEDURE SaveBook
(
	@Title					NVARCHAR(200),
	@Price					MONEY,
	@FileName				NVARCHAR(100)
)
AS
INSERT INTO 
	Books
(
	Books.Title,
	Books.Price,
	Books.FileName
)
VALUES
(
	@Title, 
	@Price, 
	@FileName
)

GO
CREATE PROCEDURE GetAllBooks
AS
SELECT 
	* 
FROM 
	Books

GO
CREATE PROCEDURE DeleteBook
(
	@BookId					INT
)
AS
DELETE
	Books
WHERE
	Books.Id = @BookId

GO
CREATE PROCEDURE GetBookById
(
	@BookId					INT
)
AS
SELECT
	*
FROM
	Books
WHERE
	Books.Id = @BookId

GO
CREATE PROCEDURE UpdateBook
(
	@BookId					INT,
	@Title					NVARCHAR(200),
	@Price					MONEY,
	@FileName				NVARCHAR(100)
)
AS
UPDATE
	Books
SET
	Books.Title = @Title,
	Books.Price = @Price,
	Books.FileName = @FileName
WHERE
	Books.Id = @BookId