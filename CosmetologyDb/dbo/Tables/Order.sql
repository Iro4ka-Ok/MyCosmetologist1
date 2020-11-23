CREATE TABLE [dbo].[Order] (
    [Id]     INT IDENTITY (1, 1) NOT NULL,
    [ProcedureId] INT NOT NULL,
    [ClientId]  INT NOT NULL,
    [CreditId] MONEY NOT NULL, 
    [DebitId] MONEY NOT NULL, 
    [PaidId] MONEY NOT NULL, 
    [Comment] NVARCHAR(MAX) NULL, 
    CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Orders_Procedures_ProcedureId] FOREIGN KEY ([ProcedureId]) REFERENCES [dbo].[Procedure] ([Id]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_Orders_ClientId]
    ON [dbo].[Order]([ClientId] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_Orders_ProcedureId]
    ON [dbo].[Order]([ProcedureId] ASC);

