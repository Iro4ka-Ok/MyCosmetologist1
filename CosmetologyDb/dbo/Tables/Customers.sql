CREATE TABLE [dbo].[Customers]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] NVARCHAR(100) NULL, 
    [SurName] NVARCHAR(100) NULL, 
    [Email] NVARCHAR(100) NULL, 
    [Phone] NVARCHAR(50) NULL, 
    [BirthDate] DATE NULL, 
    [Gender] NVARCHAR(50) NULL
)
