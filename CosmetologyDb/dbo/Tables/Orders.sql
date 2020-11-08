CREATE TABLE [dbo].[Orders] (
    [Id]     INT IDENTITY (1, 1) NOT NULL,
    [ProcedureId] INT NULL,
    [CustomerId]  INT NULL,
    [Credit] MONEY NULL, 
    [Debit] MONEY NULL, 
    [Paid] MONEY NULL, 
    [Comment] NVARCHAR(MAX) NULL, 
    CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Orders_Procedures_ProcedureId] FOREIGN KEY ([ProcedureId]) REFERENCES [dbo].[Procedures] ([Id]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_Orders_CustomerId]
    ON [dbo].[Orders]([CustomerId] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_Orders_ProcedureId]
    ON [dbo].[Orders]([ProcedureId] ASC);

