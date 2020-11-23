CREATE TABLE [dbo].[Client]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] NVARCHAR(100) NOT NULL, 
    [SurName] NVARCHAR(100) NOT NULL, 
    [Email] NVARCHAR(100) NOT NULL, 
    [Phone] NVARCHAR(50) NOT NULL, 
    [BirthDate] DATE NOT NULL, 
    [Gender] NVARCHAR(50) NOT NULL
)
