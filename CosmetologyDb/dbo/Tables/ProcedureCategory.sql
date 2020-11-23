CREATE TABLE [dbo].[ProcedureCategory](
	[Id] INT IDENTITY (1, 1) NOT NULL,
    [Name] NVARCHAR(MAX) NOT NULL, 
    [Description] NVARCHAR(MAX) NOT NULL, 
    CONSTRAINT [PK_ProcedureCategory] PRIMARY KEY NONCLUSTERED ([Id] ASC) 
);
