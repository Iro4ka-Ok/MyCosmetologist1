CREATE TABLE [dbo].[Deposits]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [CustomerId] INT NOT NULL, 
    [ProcedureId] INT NOT NULL, 
    [Deposite] MONEY NULL, 
    [Comment] NVARCHAR(MAX) NOT NULL
)
