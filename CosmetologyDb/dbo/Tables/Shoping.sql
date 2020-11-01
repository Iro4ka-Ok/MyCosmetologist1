CREATE TABLE [dbo].[Shoping]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [CustomerId] INT NULL, 
    [ProcedureId] INT NULL, 
    [CreditId] INT NOT NULL, 
    [DepositId] INT NOT NULL, 
    [PaidId] INT NOT NULL, 
    [Comment] NVARCHAR(MAX) NOT NULL
)
