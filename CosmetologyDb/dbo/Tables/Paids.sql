CREATE TABLE [dbo].[Paids]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [CustomerId] INT NULL, 
    [ProcedureId] INT NULL, 
    [Paid] MONEY NULL, 
    [Comment] NVARCHAR(MAX) NULL
)
