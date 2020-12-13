CREATE TABLE [dbo].[Record]
(
	[Id] INT IDENTITY (1, 1) NOT NULL PRIMARY KEY,
    [ClientId] INT NOT NULL, 
    [ProcedureId] INT NOT NULL,
    [DayRecord] DATE NOT NULL, 
    [TimeRecord] DATE NOT NULL, 
    [Comment] NVARCHAR(MAX) NULL,
    CONSTRAINT [FK_Records_Clients_ClientId] FOREIGN KEY ([ClientId]) REFERENCES [dbo].[Client] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_Records_Procedures_ProcedureId] FOREIGN KEY ([ProcedureId]) REFERENCES [dbo].[Procedure] ([Id]) ON DELETE CASCADE
);
