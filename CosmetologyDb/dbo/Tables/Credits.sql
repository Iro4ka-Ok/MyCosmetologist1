CREATE TABLE [dbo].[Credits]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [CustomerId] INT NOT NULL, 
    [ProcedureId] INT NOT NULL, 
    [Credit] MONEY NULL, 
    [Comment] NVARCHAR(MAX) NOT NULL
)
