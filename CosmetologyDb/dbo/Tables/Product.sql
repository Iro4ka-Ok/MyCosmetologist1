CREATE TABLE [dbo].[Product]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] NVARCHAR(MAX) NOT NULL, 
    [Value] DECIMAL NOT NULL, 
    [PriceFirst] MONEY NOT NULL, 
    [PriceLast] MONEY NOT NULL, 
    [Quantity] INT NOT NULL, 
    [ProductCategoryId] INT NOT NULL, 
    [ExpirationDate] DATE NOT NULL
)
