CREATE TABLE [dbo].[Record]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [ClientId] INT NOT NULL, 
    [ProcedureId] INT NOT NULL, 
    [DayRecord] DATE NOT NULL, 
    [TimeRecord] DATETIME NOT NULL, 
    [Comment] NVARCHAR(MAX) NULL
)
