CREATE TABLE [dbo].[Deposit]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [DepositSum] MONEY NOT NULL, 
    [Comment] NVARCHAR(MAX) NULL
)
