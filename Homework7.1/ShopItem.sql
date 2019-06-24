use ShopItems


CREATE TABLE Shop_Item
(Item_ID INT IDENTITY(1,1) NOT NULL,
Name VARCHAR(50) NULL,
Description VARCHAR(50) NULL,
Price FLOAT NULL,
QuantityAvailable INT )
GO
