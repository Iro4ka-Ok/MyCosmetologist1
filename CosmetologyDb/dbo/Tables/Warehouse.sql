CREATE TABLE [dbo].[Warehouse]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] NVARCHAR(MAX) NULL, 
    [Value] DECIMAL NULL, 
    [PriceFirst] MONEY NULL, 
    [PriceLast] MONEY NULL, 
    [Quantity] INT NULL, 
    [ProductCategoryId] INT NULL, 
    [ExpirationDate] DATE NULL
)
