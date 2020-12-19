CREATE TABLE [dbo].[ProductCategory]
(
	[Id] INT IDENTITY (1, 1) NOT NULL, 
    [Name] NVARCHAR(MAX) NOT NULL, 
    [Description] NVARCHAR(MAX) NULL,
    CONSTRAINT [PK_ProductCategory] PRIMARY KEY NONCLUSTERED ([Id] ASC) 
)
