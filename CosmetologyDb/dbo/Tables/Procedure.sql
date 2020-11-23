CREATE TABLE [dbo].[Procedure] (
    [Id]                INT            IDENTITY (1, 1) NOT NULL,
    [Name]     NVARCHAR (MAX) NOT NULL,
    [Preparat] NVARCHAR (MAX) NOT NULL,
    [Price]             MONEY            NOT NULL,
    [ProcedureCategoryId] INT NOT NULL, 
    CONSTRAINT [PK_Procedures] PRIMARY KEY NONCLUSTERED ([Id] ASC)
);

