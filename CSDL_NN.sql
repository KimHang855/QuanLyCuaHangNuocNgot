IF DB_ID('NuocNgotStore_3') IS NULL 
	CREATE DATABASE NuocNgotStore_3
GO

USE NuocNgotStore_3
GO


CREATE TABLE [dbo].[[TaiKhoan](
	[TenTK] [varchar](50) NOT NULL,
	[MatKhau] [varchar](50) NOT NULL,
	PRIMARY KEY (TenTK)	
	)
GO


INSERT INTO [dbo].[Users] ([UserName], [Password], [Type]) VALUES 
	('admin', '123'),
	('user1', '456')
GO


CREATE TABLE [dbo].[NCC](
	[MaNCC] [nvarchar](50) NOT NULL,
	[TenNCC] [nvarchar](100) NULL,
	[SoLuongMua] [float] NULL,
	[Gia] [float] NULL,
	[DiaChi] [nvarchar](100) NULL,
	[GhiChu] [nvarchar](100) NULL,
	PRIMARY KEY (MaNCC)	
	)
GO


CREATE TABLE [dbo].[SanPham](
	[MaSP] [nvarchar](10) NOT NULL,
	[TenSP] [nvarchar](100) NOT NULL,
	[Gia] [float] NOT NULL,
	[SoLuongTon] [float] NOT NULL,
	[SoLuongBan] [float] NOT NULL,
	[Ngay] [date] NOT NULL,
	[DonVi] [nvarchar](100) NOT NULL,
	PRIMARY KEY (MaSP)	
	)
GO



INSERT INTO [dbo].[NCC] ([MaNCC],[TenNCC],[SoLuongMua],[Gia],[DiaChi],[GhiChu]) VALUES 
	('CocaCola', N'CocaCola Vietnam',600,7000 N'485 Xa lộ Hà Nội, Phường Linh Trung, Quận Thủ Đức, tp. HCM '),
	('Lavie', N'Huỳnh Phát Lavie',400,4000, N'72/23/11 Đường Số 30, Phường 6, Q. Gò Vấp, HCM '),
	('BiaSaiGon', N'Tổng công Ty cổ phần Bia-Rượu-Giải Khát Sài Gòn',500,20000, N'187 Nguyễn Chí Thanh, Phường 12, Quận 5, TP HCM ')
GO

INSERT INTO [dbo].[Product] ([MaSP], [TenSP], [Gia], [SoLuongTon], [SoLuongBan], [Ngay], [DonVi]) VALUES 
	('CocaCola', N'Coca-Cola', 10000, 59, 40, '10/10/2019', 'chai'),
	('Sprite', N'Nước ngọt Sprite', 10000, 49, 45, '11/11/2019', 'chai'),
	('Sabeco', N'Bia Sabeco', 30000, 78, 70, '12/12/2019', 'chai'),
	('Aquafina', N'Nước khoáng Aquafina', 5000, 55, 45, '09/09/2019', 'chai')
GO

