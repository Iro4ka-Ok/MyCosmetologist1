CREATE TABLE [dbo].[Procedure] (
    [Id]                INT            IDENTITY (1, 1) NOT NULL,
    [Name]     NVARCHAR (MAX) NOT NULL,
    [Price]             DECIMAL            NOT NULL,
    [ProcedureCategoryId] INT NOT NULL, 
    CONSTRAINT [PK_Procedures] PRIMARY KEY NONCLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Procedures_ProcedureCategory_ProcedureCategoryId] FOREIGN KEY ([ProcedureCategoryId]) REFERENCES [dbo].[ProcedureCategory] ([Id]) ON DELETE CASCADE
);

