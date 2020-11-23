CREATE TABLE [dbo].[Paid]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [PaidSum] MONEY NOT NULL, 
    [Comment] NVARCHAR(MAX) NULL
)
