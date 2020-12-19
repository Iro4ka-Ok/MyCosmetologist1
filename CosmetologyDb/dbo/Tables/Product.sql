CREATE TABLE [dbo].[Product]
(
	[Id] INT IDENTITY (1, 1) NOT NULL, 
    [Name] NVARCHAR(MAX) NOT NULL, 
    [Volume] DECIMAL NOT NULL, 
    [PriceFirst] DECIMAL NOT NULL, 
    [PriceLast] DECIMAL NOT NULL, 
    [Quantity] INT NOT NULL, 
    [ProductCategoryId] INT NOT NULL, 
    [ExpirationDate] DATE NOT NULL,
    CONSTRAINT [PK_Products] PRIMARY KEY NONCLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Products_ProductCategory_ProductCategoryId] FOREIGN KEY (ProductCategoryId) REFERENCES [dbo].ProductCategory ([Id]) ON DELETE CASCADE
);
