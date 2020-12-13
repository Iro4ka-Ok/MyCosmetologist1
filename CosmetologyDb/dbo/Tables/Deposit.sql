CREATE TABLE [dbo].[Deposit]
(
	[Id] INT IDENTITY (1, 1) NOT NULL PRIMARY KEY, 
    [DepositSum] MONEY NOT NULL, 
    [Comment] NVARCHAR(MAX) NULL
)
