USE [master]
GO
/****** Object:  Database [NuocNgotStore_3]    Script Date: 21/06/2020 10:58:38 SA ******/
CREATE DATABASE [NuocNgotStore_3]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'NuocNgotStore_3', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\NuocNgotStore_3.mdf' , SIZE = 3136KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'NuocNgotStore_3_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\NuocNgotStore_3_log.ldf' , SIZE = 832KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [NuocNgotStore_3] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [NuocNgotStore_3].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [NuocNgotStore_3] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [NuocNgotStore_3] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [NuocNgotStore_3] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [NuocNgotStore_3] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [NuocNgotStore_3] SET ARITHABORT OFF 
GO
ALTER DATABASE [NuocNgotStore_3] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [NuocNgotStore_3] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [NuocNgotStore_3] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [NuocNgotStore_3] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [NuocNgotStore_3] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [NuocNgotStore_3] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [NuocNgotStore_3] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [NuocNgotStore_3] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [NuocNgotStore_3] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [NuocNgotStore_3] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [NuocNgotStore_3] SET  ENABLE_BROKER 
GO
ALTER DATABASE [NuocNgotStore_3] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [NuocNgotStore_3] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [NuocNgotStore_3] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [NuocNgotStore_3] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [NuocNgotStore_3] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [NuocNgotStore_3] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [NuocNgotStore_3] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [NuocNgotStore_3] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [NuocNgotStore_3] SET  MULTI_USER 
GO
ALTER DATABASE [NuocNgotStore_3] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [NuocNgotStore_3] SET DB_CHAINING OFF 
GO
ALTER DATABASE [NuocNgotStore_3] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [NuocNgotStore_3] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [NuocNgotStore_3]
GO
/****** Object:  Table [dbo].[NCC]    Script Date: 21/06/2020 10:58:38 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NCC](
	[MaNCC] [nvarchar](50) NOT NULL,
	[TenNCC] [nvarchar](100) NULL,
	[SoLuongMua] [float] NULL,
	[Gia] [float] NULL,
	[DiaChi] [nvarchar](100) NULL,
	[GhiChu] [nvarchar](100) NULL,
 CONSTRAINT [PK_NCC] PRIMARY KEY CLUSTERED 
(
	[MaNCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 21/06/2020 10:58:38 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanPham](
	[MaSP] [nvarchar](10) NOT NULL,
	[TenSP] [nvarchar](100) NOT NULL,
	[Gia] [float] NOT NULL,
	[SoLuongTon] [float] NOT NULL,
	[Ngay] [date] NOT NULL,
	[DonVi] [nvarchar](100) NOT NULL,
	[NgayBan] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 21/06/2020 10:58:38 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[TenTK] [varchar](50) NOT NULL,
	[MatKhau] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[TenTK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[NCC] ([MaNCC], [TenNCC], [SoLuongMua], [Gia], [DiaChi], [GhiChu]) VALUES (N'1', N'abc', 200, 5000, N'ấp 4', N'')
INSERT [dbo].[NCC] ([MaNCC], [TenNCC], [SoLuongMua], [Gia], [DiaChi], [GhiChu]) VALUES (N'2', N'cty Trà', 11, 5000, N'ấp 4/3', N'')
INSERT [dbo].[NCC] ([MaNCC], [TenNCC], [SoLuongMua], [Gia], [DiaChi], [GhiChu]) VALUES (N'3', N'bcd', 100, 5000, N'ấp 5', N'')
INSERT [dbo].[NCC] ([MaNCC], [TenNCC], [SoLuongMua], [Gia], [DiaChi], [GhiChu]) VALUES (N'BiaSaiGon', N'Tổng công Ty cổ phần Bia-Rượu-Giải Khát Sài Gòn', 500, 20000, N'187 Nguyễn Chí Thanh, Phường 12, Quận 5, TP HCM', NULL)
INSERT [dbo].[NCC] ([MaNCC], [TenNCC], [SoLuongMua], [Gia], [DiaChi], [GhiChu]) VALUES (N'Lavie', N'Huỳnh Phát Lavie', 400, 4000, N'72/23/11 Đường Số 30, Phường 6, Q. Gò Vấp, HCM', NULL)
INSERT [dbo].[NCC] ([MaNCC], [TenNCC], [SoLuongMua], [Gia], [DiaChi], [GhiChu]) VALUES (N'PepSi', N'PepSi Vietnam', 301, 6000, N'485 Xa lộ Hà Nội, Phường Linh Trung, Quận Thủ Đức, tp. HCM', N'')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Gia], [SoLuongTon], [Ngay], [DonVi], [NgayBan]) VALUES (N'1', N'Trà', 7000, 61, CAST(0x9E3F0B00 AS Date), N'chai', CAST(0x9E3F0B00 AS Date))
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Gia], [SoLuongTon], [Ngay], [DonVi], [NgayBan]) VALUES (N'Aquafina', N'Nước khoáng Aquafina', 5000, 54, CAST(0x5E400B00 AS Date), N'chai', CAST(0x5E400B00 AS Date))
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Gia], [SoLuongTon], [Ngay], [DonVi], [NgayBan]) VALUES (N'CocaCola', N'Coca-Cola', 10000, 59, CAST(0xCE3F0B00 AS Date), N'chai', CAST(0xCE3F0B00 AS Date))
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Gia], [SoLuongTon], [Ngay], [DonVi], [NgayBan]) VALUES (N'Sabeco', N'Bia Sabeco', 30000, 78, CAST(0x7C400B00 AS Date), N'chai', NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Gia], [SoLuongTon], [Ngay], [DonVi], [NgayBan]) VALUES (N'Sprite', N'Nước ngọt Sprite', 10000, 48, CAST(0x3E400B00 AS Date), N'chai', CAST(0x3E400B00 AS Date))
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Gia], [SoLuongTon], [Ngay], [DonVi], [NgayBan]) VALUES (N'YenSao', N'Yến', 30000, 60, CAST(0x7F3F0B00 AS Date), N'chai', NULL)
INSERT [dbo].[TaiKhoan] ([TenTK], [MatKhau]) VALUES (N'admin', N'123')
INSERT [dbo].[TaiKhoan] ([TenTK], [MatKhau]) VALUES (N'user1', N'456')
ALTER TABLE [dbo].[SanPham] ADD  DEFAULT ((0)) FOR [Gia]
GO
ALTER TABLE [dbo].[SanPham] ADD  DEFAULT ((0)) FOR [SoLuongTon]
GO
USE [master]
GO
ALTER DATABASE [NuocNgotStore_3] SET  READ_WRITE 
GO
