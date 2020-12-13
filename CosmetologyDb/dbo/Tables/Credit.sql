CREATE TABLE [dbo].[Credit]
(
	[Id] INT IDENTITY (1, 1) NOT NULL PRIMARY KEY, 
    [CreditSum] MONEY NOT NULL, 
    [Comment] NVARCHAR(MAX) NULL
)
