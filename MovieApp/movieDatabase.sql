CREATE DATABASE [Movies];
GO

USE [Movies];
GO

CREATE TABLE [user] (
	[userId] INT NOT NULL IDENTITY,
	[username] NVARCHAR(16) NOT NULL,
	[password] NVARCHAR(12) NOT NULL
);
GO

CREATE TABLE [movie] (
	[movieId] INT NOT NULL IDENTITY,
	[title] NVARCHAR(32) NOT NULL,
	[releaseYear] INT NOT NULL,
	[dirName] NVARCHAR(32) NOT NULL
);
GO

CREATE TABLE [genre] (
	[genreId] INT NOT NULL IDENTITY,
	[genreName] NVARCHAR(32) NOT null
);
GO

CREATE TABLE [director] (
	[dirId] INT NOT NULL IDENTITY,
	[dirFName] NVARCHAR(32) NOT NULL,
	[dirLName] NVARCHAR(32) NOT NULL
);
GO

CREATE TABLE [mainActor] (
	[actorId] INT NOT NULL IDENTITY,
	[actorFName] NVARCHAR(32) NOT NULL,
	[actorLName] NVARCHAR(32) NOT NULL,
	[actorRole] NVARCHAR(max) NOT NULL
);
GO

INSERT INTO [Movie] (Url) VALUES
('http://movies.msdn.com/dotnet'),
('http://movies.msdn.com/webdev'),
('http://movies.msdn.com/visualstudio')
GO