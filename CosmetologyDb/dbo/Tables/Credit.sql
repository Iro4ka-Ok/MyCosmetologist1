CREATE TABLE [dbo].[Credit]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [CreditSum] MONEY NOT NULL, 
    [Comment] NVARCHAR(MAX) NULL
)
