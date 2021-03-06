USE [master]
GO
/****** Object:  Database [QuanLyNhanSu]    Script Date: 03-Jun-17 6:33:15 PM ******/
CREATE DATABASE [QuanLyNhanSu]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLyNhanSu', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MKCUONG\MSSQL\DATA\QuanLyNhanSu.mdf' , SIZE = 3264KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QuanLyNhanSu_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MKCUONG\MSSQL\DATA\QuanLyNhanSu_log.ldf' , SIZE = 832KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QuanLyNhanSu] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLyNhanSu].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLyNhanSu] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLyNhanSu] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLyNhanSu] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLyNhanSu] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLyNhanSu] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLyNhanSu] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [QuanLyNhanSu] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLyNhanSu] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyNhanSu] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLyNhanSu] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLyNhanSu] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLyNhanSu] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLyNhanSu] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLyNhanSu] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLyNhanSu] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QuanLyNhanSu] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLyNhanSu] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLyNhanSu] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLyNhanSu] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLyNhanSu] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLyNhanSu] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLyNhanSu] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLyNhanSu] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QuanLyNhanSu] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLyNhanSu] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLyNhanSu] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLyNhanSu] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLyNhanSu] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [QuanLyNhanSu] SET DELAYED_DURABILITY = DISABLED 
GO
USE [QuanLyNhanSu]
GO
/****** Object:  Table [dbo].[chucvu]    Script Date: 03-Jun-17 6:33:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[chucvu](
	[ma] [varchar](10) NOT NULL,
	[tenchucvu] [nvarchar](15) NULL,
PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[luong]    Script Date: 03-Jun-17 6:33:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[luong](
	[luongcoban] [float] NOT NULL,
	[hesoluong] [float] NULL,
	[hesophucap] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[luongcoban] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[nhanvien]    Script Date: 03-Jun-17 6:33:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[nhanvien](
	[ma] [varchar](10) NOT NULL,
	[hoten] [nvarchar](100) NULL,
	[ngaysinh] [datetime] NULL,
	[quequan] [nchar](200) NULL,
	[gioitinh] [nchar](3) NULL,
	[dantoc] [nvarchar](20) NULL,
	[sodienthoai] [char](11) NULL,
	[taikhoan] [varchar](50) NULL,
	[matkhau] [varchar](50) NULL DEFAULT ('123456'),
	[luongcoban] [float] NULL DEFAULT ((0)),
	[chucvuma] [varchar](10) NULL DEFAULT ('04'),
	[phongbanma] [varchar](10) NULL DEFAULT ('06'),
	[trinhdohocvanma] [varchar](10) NULL DEFAULT ('06'),
PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[phongban]    Script Date: 03-Jun-17 6:33:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[phongban](
	[ma] [varchar](10) NOT NULL,
	[tenphongban] [nvarchar](50) NULL,
	[diachi] [nvarchar](200) NULL,
	[sodienthoai] [char](11) NULL,
PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[trinhdohocvan]    Script Date: 03-Jun-17 6:33:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[trinhdohocvan](
	[ma] [varchar](10) NOT NULL,
	[tentrinhdohocvan] [nvarchar](20) NULL,
	[chuyennganh] [nchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[chucvu] ([ma], [tenchucvu]) VALUES (N'01', N'Giám đốc')
INSERT [dbo].[chucvu] ([ma], [tenchucvu]) VALUES (N'02', N'Phó giám đốc')
INSERT [dbo].[chucvu] ([ma], [tenchucvu]) VALUES (N'03 ', N'Thư ký')
INSERT [dbo].[chucvu] ([ma], [tenchucvu]) VALUES (N'04 ', N'Nhân viên')
INSERT [dbo].[chucvu] ([ma], [tenchucvu]) VALUES (N'05', N'Bảo vệ')
INSERT [dbo].[chucvu] ([ma], [tenchucvu]) VALUES (N'06', N'Thu ngân')
INSERT [dbo].[chucvu] ([ma], [tenchucvu]) VALUES (N'07', N'Thực tập sinh')
INSERT [dbo].[luong] ([luongcoban], [hesoluong], [hesophucap]) VALUES (1000000, 1, 0.5)
INSERT [dbo].[luong] ([luongcoban], [hesoluong], [hesophucap]) VALUES (5000000, 1.3, 0.2)
INSERT [dbo].[luong] ([luongcoban], [hesoluong], [hesophucap]) VALUES (8000000, 1.3, 0.1)
INSERT [dbo].[luong] ([luongcoban], [hesoluong], [hesophucap]) VALUES (10000000, 1.5, 0.1)
INSERT [dbo].[luong] ([luongcoban], [hesoluong], [hesophucap]) VALUES (15000000, 2, 0.2)
INSERT [dbo].[nhanvien] ([ma], [hoten], [ngaysinh], [quequan], [gioitinh], [dantoc], [sodienthoai], [taikhoan], [matkhau], [luongcoban], [chucvuma], [phongbanma], [trinhdohocvanma]) VALUES (N'01', N'Vu Hung Cuong', CAST(N'1995-10-10 00:00:00.000' AS DateTime), N'Ninh Bình                                                                                                                                                                                               ', N'Nam', N'Kinh', N'09883423   ', N'abc', N'123456', 0, N'04', N'06', N'06')
INSERT [dbo].[nhanvien] ([ma], [hoten], [ngaysinh], [quequan], [gioitinh], [dantoc], [sodienthoai], [taikhoan], [matkhau], [luongcoban], [chucvuma], [phongbanma], [trinhdohocvanma]) VALUES (N'02', N'Nguyen Duy Minh', CAST(N'1995-02-11 00:00:00.000' AS DateTime), N'Hà Nội                                                                                                                                                                                                  ', N'Nam', N'Thái', N'09865432   ', N'abc', N'123456', 0, N'04', N'06', N'06')
INSERT [dbo].[nhanvien] ([ma], [hoten], [ngaysinh], [quequan], [gioitinh], [dantoc], [sodienthoai], [taikhoan], [matkhau], [luongcoban], [chucvuma], [phongbanma], [trinhdohocvanma]) VALUES (N'03', N'Le Manh Quyet Thang', CAST(N'1997-10-11 00:00:00.000' AS DateTime), N'Bắc Ninh                                                                                                                                                                                                ', N'Nam', N'Mường', N'09865432   ', N'xyz', N'123456', 0, N'04', N'06', N'06')
INSERT [dbo].[nhanvien] ([ma], [hoten], [ngaysinh], [quequan], [gioitinh], [dantoc], [sodienthoai], [taikhoan], [matkhau], [luongcoban], [chucvuma], [phongbanma], [trinhdohocvanma]) VALUES (N'04', N'Nguyen Minh Anh', CAST(N'1996-12-31 00:00:00.000' AS DateTime), N'Hà Nội                                                                                                                                                                                                  ', N'Nam', N'Kinh', N'09865432   ', N'poi', N'123456', 0, N'04', N'06', N'06')
INSERT [dbo].[nhanvien] ([ma], [hoten], [ngaysinh], [quequan], [gioitinh], [dantoc], [sodienthoai], [taikhoan], [matkhau], [luongcoban], [chucvuma], [phongbanma], [trinhdohocvanma]) VALUES (N'05', N'Tran Thi Quyen', CAST(N'1994-01-01 00:00:00.000' AS DateTime), N'Hà Nội                                                                                                                                                                                                  ', N'Nữ ', N'Kinh', N'09865432   ', N'hjghhy', N'123456', 0, N'04', N'06', N'06')
INSERT [dbo].[nhanvien] ([ma], [hoten], [ngaysinh], [quequan], [gioitinh], [dantoc], [sodienthoai], [taikhoan], [matkhau], [luongcoban], [chucvuma], [phongbanma], [trinhdohocvanma]) VALUES (N'10', N'Le Vu ', CAST(N'1990-01-01 00:00:00.000' AS DateTime), N'Hà Nội                                                                                                                                                                                                  ', N'Nam', N'Kinh', N'09865432   ', N'uiop', N'123456', 0, N'04', N'06', N'06')
INSERT [dbo].[nhanvien] ([ma], [hoten], [ngaysinh], [quequan], [gioitinh], [dantoc], [sodienthoai], [taikhoan], [matkhau], [luongcoban], [chucvuma], [phongbanma], [trinhdohocvanma]) VALUES (N'13', N'Lê Mạnh Dạn', CAST(N'1990-01-01 00:00:00.000' AS DateTime), N'Hà Nội                                                                                                                                                                                                  ', N'Nam', N'Thái', N'0987675231 ', N'abc', N'123456', 0, N'04 ', N'06', N'02')
INSERT [dbo].[nhanvien] ([ma], [hoten], [ngaysinh], [quequan], [gioitinh], [dantoc], [sodienthoai], [taikhoan], [matkhau], [luongcoban], [chucvuma], [phongbanma], [trinhdohocvanma]) VALUES (N'15', N'Lê Quốc Bảo', CAST(N'1990-01-01 00:00:00.000' AS DateTime), N'Hà Nội                                                                                                                                                                                                  ', N'Nam', N'Kinh', N'0123456789 ', N'abre', N'123456', 0, N'05', N'06', N'06')
INSERT [dbo].[nhanvien] ([ma], [hoten], [ngaysinh], [quequan], [gioitinh], [dantoc], [sodienthoai], [taikhoan], [matkhau], [luongcoban], [chucvuma], [phongbanma], [trinhdohocvanma]) VALUES (N'20', N'Vũ Lê Minh', CAST(N'1990-01-01 00:00:00.000' AS DateTime), N'Hải Phòng                                                                                                                                                                                               ', N'Nam', N'Kinh', N'0123456    ', N'abc', N'123456', 10000000, N'01', N'01', N'01')
INSERT [dbo].[nhanvien] ([ma], [hoten], [ngaysinh], [quequan], [gioitinh], [dantoc], [sodienthoai], [taikhoan], [matkhau], [luongcoban], [chucvuma], [phongbanma], [trinhdohocvanma]) VALUES (N'23', N'Trần Văn Khương', CAST(N'1990-01-01 00:00:00.000' AS DateTime), N'Hà Nội                                                                                                                                                                                                  ', N'Nam', N'Kinh', N'0987654    ', N'khuongtran', N'123456', 10000000, N'07', N'05', N'03')
INSERT [dbo].[phongban] ([ma], [tenphongban], [diachi], [sodienthoai]) VALUES (N'01', N'Phòng giám đốc', NULL, NULL)
INSERT [dbo].[phongban] ([ma], [tenphongban], [diachi], [sodienthoai]) VALUES (N'02', N'Phòng quản lý nhân sự', NULL, NULL)
INSERT [dbo].[phongban] ([ma], [tenphongban], [diachi], [sodienthoai]) VALUES (N'03', N'Phòng kế toán', NULL, NULL)
INSERT [dbo].[phongban] ([ma], [tenphongban], [diachi], [sodienthoai]) VALUES (N'04', N'Phòng hành chính', NULL, NULL)
INSERT [dbo].[phongban] ([ma], [tenphongban], [diachi], [sodienthoai]) VALUES (N'05', N'Phòng kinh doanh', NULL, NULL)
INSERT [dbo].[phongban] ([ma], [tenphongban], [diachi], [sodienthoai]) VALUES (N'06', N'Phòng nhân sự', NULL, NULL)
INSERT [dbo].[trinhdohocvan] ([ma], [tentrinhdohocvan], [chuyennganh]) VALUES (N'01', N'Cử nhân', N'Công nghệ                                                                                           ')
INSERT [dbo].[trinhdohocvan] ([ma], [tentrinhdohocvan], [chuyennganh]) VALUES (N'02', N'Kỹ sư', N'Kỹ thuật điện tử                                                                                    ')
INSERT [dbo].[trinhdohocvan] ([ma], [tentrinhdohocvan], [chuyennganh]) VALUES (N'03', N'Thạc sĩ', N'Kế toán                                                                                             ')
INSERT [dbo].[trinhdohocvan] ([ma], [tentrinhdohocvan], [chuyennganh]) VALUES (N'04', N'Tiến sĩ', N'Quản lý tài chính                                                                                   ')
INSERT [dbo].[trinhdohocvan] ([ma], [tentrinhdohocvan], [chuyennganh]) VALUES (N'05', N'Giáo sư', N'Công nghệ thông tin                                                                                 ')
INSERT [dbo].[trinhdohocvan] ([ma], [tentrinhdohocvan], [chuyennganh]) VALUES (N'06', N'Không', N'Không                                                                                               ')
USE [master]
GO
ALTER DATABASE [QuanLyNhanSu] SET  READ_WRITE 
GO
