CREATE TABLE [dbo].[Client]
(
	[Id]  INT IDENTITY (1, 1) NOT NULL , 
    [Name] NVARCHAR(100) NOT NULL, 
    [SurName] NVARCHAR(100) NOT NULL, 
    [Email] NVARCHAR(100) NOT NULL, 
    [Phone] NVARCHAR(50) NOT NULL, 
    [BirthDate] DATE NOT NULL, 
    [Gender] NVARCHAR(50) NOT NULL, 
    [PhotoFirst] NVARCHAR(MAX) NULL, 
    [PhotoLast] NVARCHAR(MAX) NULL,
    CONSTRAINT [PK_[Clients] PRIMARY KEY NONCLUSTERED ([Id] ASC)
)
