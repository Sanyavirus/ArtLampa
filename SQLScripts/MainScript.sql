USE [1gb_x_art_l259]
GO


IF OBJECT_ID(N'[Products]','U') IS  NULL 
BEGIN
	create table Products(
		Id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
		Name nvarchar(100) NULL,
		Description nvarchar(MAX) NULL,
		Article nvarchar(50) NULL,
		Price money NULL,
		Quantity Int NULL,
		Image Int NULL,
		Category Int NULL,
		Color nvarchar(20) NULL, 	
		[Views] Int NULL 
)
END


IF OBJECT_ID(N'[Category]','U') IS  NULL 
BEGIN
	create table Category(
		Id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
		Name nvarchar(100) NULL,
		Description nvarchar(MAX) NULL,
		Image Int NULL,
		Category Int NULL,
)
END



create table Images(
	Id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	Path nvarchar(150) NULL,
	Width Int NULL,
	Height Int NULL
)

IF OBJECT_ID(N'FK_Product_Categories','F') IS NOT NULL 
BEGIN
	ALTER TABLE Category DROP CONSTRAINT [FK_Product_Categories]
END
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Product_Categories] 
FOREIGN KEY(Category)
REFERENCES [dbo].Category (ID)
GO

IF OBJECT_ID(N'FK_Product_Images','F') IS NOT NULL 
BEGIN
	ALTER TABLE Images DROP CONSTRAINT [FK_Product_Images]
END
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT FK_Product_Images 
FOREIGN KEY(Image)
REFERENCES [dbo].[Images] (ID)
GO

IF OBJECT_ID(N'FK_Category_Images','F') IS NOT NULL 
BEGIN
	ALTER TABLE Images DROP CONSTRAINT [FK_Category_Images]
END
GO
ALTER TABLE [dbo].[Category]  WITH CHECK ADD  CONSTRAINT [FK_Category_Images] 
FOREIGN KEY(Image)
REFERENCES [dbo].[Images] (ID)
GO


INSERT INTO Images (Path, Width, Height)
VALUES ('Content\images\lamps\lampa1.jpg', 48, 48)

INSERT INTO Images (Path, Width, Height)
VALUES ('Content\images\lamps\lampa_OHUET.jpg', 48, 48)

INSERT INTO [Products](Name, Description, Article, Price,
					   Quantity, Image, Category, Color, [Views])
VALUES ('Обыкновенная лампа', 'Хорошая лампа, порадует вас домашним уютом',
'LB_121323',1300.0, 10,  1, 1, 'Белый', 0)

INSERT INTO [Products](Name, Description, Article, Price,
					   Quantity, Image, Category, Color, [Views])
VALUES ('ОХУЕТЬ ЛАМПА', 'Охуенная лампа просто красавица',
'LB_1299999',1300.0, 10, 2, 1, 'Черный', 0)


select * from Products

select * from Category 

select * from Images

select p.Name, i.Path FROM Products p
INNER JOIN Images i ON (p.Image = i.Id)
 

INSERT INTO [dbo].[Category]
           ([Name]
           ,[Description]
           ,[Image]
           ,[Category])
     VALUES
           ('Лампочки',
           'Обычные лампочки',
           1,
           NULL)
GO


IF OBJECT_ID(N'[sp_GetProductById]','P') IS NOT NULL
    DROP PROCEDURE sp_GetProductById
GO
CREATE PROCEDURE dbo.sp_GetProductById
@ID Int
AS
BEGIN
	SELECT * FROM Products 
	WHERE Id = @Id
END


IF OBJECT_ID(N'[sp_CreateProduct]','P') IS NOT NULL
    DROP PROCEDURE sp_CreateProduct
GO
CREATE PROCEDURE dbo.sp_CreateProduct
		@Name nvarchar(100),
		@Description nvarchar(MAX) ,
		@Article nvarchar(50),
		@Price money,
		@Quantity Int ,
		@Image Int ,
		@Category Int  ,
		@Color nvarchar(20) = NULL, 	
		@Views Int = NULL 
AS
BEGIN
	INSERT INTO [Products](Name, Description, Article, Price,
						   Quantity, Image, Category, Color, [Views])
	VALUES (@Name, @Description,@Article, @Price, @Quantity, @Image,	
			@Category, @Color, @Views)
END


EXEC dbo.sp_CreateProduct 2
