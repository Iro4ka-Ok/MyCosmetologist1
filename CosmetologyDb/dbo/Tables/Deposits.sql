CREATE TABLE [dbo].[Deposits]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [CustomerId] INT NULL, 
    [ProcedureId] INT NULL, 
    [Deposite] MONEY NULL, 
    [Comment] NVARCHAR(MAX) NULL
)
