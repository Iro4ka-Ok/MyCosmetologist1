CREATE TABLE [dbo].[Warehouse]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] NVARCHAR(MAX) NULL, 
    [Value] INT NULL, 
    [PriceFirst] MONEY NULL, 
    [PriceLast] MONEY NULL, 
    [Quantity] DECIMAL NULL, 
    [ProductCategoryId] INT NULL, 
    [ExpirationDate] DATE NULL
)
