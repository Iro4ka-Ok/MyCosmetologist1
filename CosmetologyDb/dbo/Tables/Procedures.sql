CREATE TABLE [dbo].[Procedures] (
    [Id]                INT            IDENTITY (1, 1) NOT NULL,
    [NameProcedure]     NVARCHAR (MAX) NULL,
    [Preparation] NVARCHAR (MAX) NULL,
    [Price]             INT            NULL,
    [CategoryProcedyreId] INT NULL, 
    CONSTRAINT [PK_Procedures] PRIMARY KEY CLUSTERED ([Id] ASC)
);

