IF DB_ID('NuocNgotStore_3') IS NULL 
	CREATE DATABASE NuocNgotStore_3
GO

USE NuocNgotStore_3
GO


CREATE TABLE [dbo].[TaiKhoan](
	[TenTK] [varchar](50) NOT NULL,
	[MatKhau] [varchar](50) NOT NULL, 
	PRIMARY KEY (TenTK)	
	)
GO


INSERT INTO [dbo].[TaiKhoan] ([TenTK], [MatKhau]) VALUES 
	('admin', '123'),
	('user1', '456')
GO


CREATE TABLE [dbo].[SanPham](
	[MaSP] [nvarchar](10) NOT NULL,
	[TenSP] [nvarchar](100) NOT NULL, 
	[Gia] [float]  NOT NULL DEFAULT 0,
	[SoLuongTon] [float]  NOT NULL DEFAULT 0, 
	[SoLuongBan] [float]  NOT NULL DEFAULT 0,
	[Ngay][datetime]NOT NULL,
	[DonVi] [nvarchar](100) NOT NULL,	
	PRIMARY KEY (MaSP)	
	)
GO

INSERT INTO [dbo].[SanPham] ([MaSP], [TenSP], [Gia], [SoLuongTon], [SoLuongBan], [Ngay], [DonVi]) VALUES 
	('CocaCola', N'Coca-Cola', 10000, 50, 40, '10/10/2019', N'thùng'),
	('Sprite', N'N??c ng?t Sprite', 10000, 60, 45, '11/11/2019', N'thùng'),
	('Sabeco', N'Bia Sabeco',  30000, 72, 70, '12/12/2019', N'thùng'),
	('Aquafina', N'N??c khoáng Aquafina', 5000, 55, 40, '09/09/2019', N'thùng')
GO