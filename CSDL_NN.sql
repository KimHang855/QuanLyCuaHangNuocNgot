IF DB_ID('NuocNgotStore') IS NULL 
	CREATE DATABASE NuocNgotStore
GO

USE NuocNgotStore
GO


CREATE TABLE [dbo].[Users](
	[UserName] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL, 
	[Type] [int] NOT NULL,
	PRIMARY KEY (UserName)	
	)
GO


INSERT INTO [dbo].[Users] ([UserName], [Password], [Type]) VALUES 
	('admin', '135', 1),
	('user1', '246', 2)
GO


CREATE TABLE [dbo].[Supplier](
	[id] [varchar](20) NOT NULL,
	[name] [nvarchar](100) NOT NULL, 
	[address] [nvarchar](200)  NOT NULL,
	PRIMARY KEY (id)	
	)
GO


CREATE TABLE [dbo].[ProductCategory](
	[id] [int] IDENTITY(1,1),
	[name] [nvarchar](100) NOT NULL, 	
	PRIMARY KEY (id)	
	)
GO


CREATE TABLE [dbo].[Product](
	[id] [varchar](10) NOT NULL,
	[name] [nvarchar](100) NOT NULL, 
	[purchasePrice] [float]  NOT NULL DEFAULT 0, 
	[sellingPrice] [float]  NOT NULL DEFAULT 0, 
	[categoryId][int]NOT NULL,	
	[supplierId][varchar](20) NOT NULL,
	PRIMARY KEY (id)	
	)
GO


ALTER TABLE Product ADD CONSTRAINT FK_SUPPLIER_PRODUCT FOREIGN KEY (supplierId) REFERENCES Supplier(id)
ALTER TABLE Product ADD CONSTRAINT FK_PRODUCTCATEGORY_PRODUCT FOREIGN KEY (categoryId) REFERENCES ProductCategory(id)



INSERT INTO [dbo].[ProductCategory] ([name]) VALUES 
	(N'Nước ngọt'),
	(N'Nước khoáng, nước tinh khiết'),
	(N'Thức uống bổ dưỡng'),
	(N'Cà phê'),
	(N'Trà'),
	(N'Nước trái cây'),
	(N'Bia')
GO


INSERT INTO [dbo].[Supplier] ([id], [name], [address]) VALUES 
	('CocaCola', N'CocaCola Vietnam', N'485 Xa lộ Hà Nội, Phường Linh Trung, Quận Thủ Đức, tp. HCM '),
	('Lavie', N'Huỳnh Phát Lavie', N'72/23/11 Đường Số 30, Phường 6, Q. Gò Vấp, HCM '),
	('BiaSaiGon', N'Tổng công Ty cổ phần Bia-Rượu-Giải Khát Sài Gòn', N'187 Nguyễn Chí Thanh, Phường 12, Quận 5, TP HCM ')
GO

INSERT INTO [dbo].[Product] ([id], [name], [sellingPrice], [purchasePrice], [categoryId], [supplierId]) VALUES 
	('CocaCola', N'Coca-Cola', 8000, 10000, 1, 'CocaCola'),
	('Sprite', N'Nước ngọt Sprite', 8000, 10000, 1, 'CocaCola'),
	('Sabeco', N'Bia Sabeco', 15000 , 30000, 3, 'BiaSaiGon'),
	('Aquafina', N'Nước khoáng Aquafina', 3000, 5000, 2, 'Lavie')
GO

