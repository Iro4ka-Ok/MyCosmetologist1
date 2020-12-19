CREATE TABLE [dbo].[Record]
(
	[Id] INT IDENTITY (1, 1) NOT NULL,
    [DayRecord] DATE NOT NULL, 
    [ClientId] INT NOT NULL, 
    [ProcedureId] INT NOT NULL, 
    [ProductId] INT NOT NULL, 
    [Volume] DECIMAL NOT NULL, 
    [Prise] MONEY NOT NULL, 
    [Comment] NVARCHAR(MAX) NULL, 
    [Result] NVARCHAR(MAX) NULL, 
    CONSTRAINT [PK_Records] PRIMARY KEY NONCLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Records_Clients_ClientId] FOREIGN KEY ([ClientId]) REFERENCES [dbo].[Client] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_Records_Procedures_ProcedureId] FOREIGN KEY ([ProcedureId]) REFERENCES [dbo].[Procedure] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_Records_Products_ProductId] FOREIGN KEY ([ProductId]) REFERENCES [dbo].[Product] ([Id]) ON DELETE CASCADE
);
