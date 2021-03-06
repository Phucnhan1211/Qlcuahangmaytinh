USE [Qlcuahangmaytinh]
GO
ALTER TABLE [dbo].[tblThongtinMT] DROP CONSTRAINT [FK_tblThongtinMT_tblNhaCC]
GO
ALTER TABLE [dbo].[tblHoadonnhap] DROP CONSTRAINT [FK_tblHoadonnhap_tblThongtinMT]
GO
ALTER TABLE [dbo].[tblHoadonnhap] DROP CONSTRAINT [FK_tblHoadonnhap_tblNhanvien]
GO
ALTER TABLE [dbo].[tblHoadonnhap] DROP CONSTRAINT [FK_tblHoadonnhap_tblNhaCC]
GO
ALTER TABLE [dbo].[tblHoadonban] DROP CONSTRAINT [FK_tblHoadonban_tblThongtinMT]
GO
ALTER TABLE [dbo].[tblHoadonban] DROP CONSTRAINT [FK_tblHoadonban_tblNhanvien]
GO
ALTER TABLE [dbo].[tblHoadonban] DROP CONSTRAINT [FK_tblHoadonban_tblKhachhang]
GO
/****** Object:  Table [dbo].[tblThongtinMT]    Script Date: 12/28/2021 8:38:19 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblThongtinMT]') AND type in (N'U'))
DROP TABLE [dbo].[tblThongtinMT]
GO
/****** Object:  Table [dbo].[tblNhanvien]    Script Date: 12/28/2021 8:38:19 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblNhanvien]') AND type in (N'U'))
DROP TABLE [dbo].[tblNhanvien]
GO
/****** Object:  Table [dbo].[tblNhaCC]    Script Date: 12/28/2021 8:38:19 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblNhaCC]') AND type in (N'U'))
DROP TABLE [dbo].[tblNhaCC]
GO
/****** Object:  Table [dbo].[tblKhachhang]    Script Date: 12/28/2021 8:38:19 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblKhachhang]') AND type in (N'U'))
DROP TABLE [dbo].[tblKhachhang]
GO
/****** Object:  Table [dbo].[tblHoadonnhap]    Script Date: 12/28/2021 8:38:19 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblHoadonnhap]') AND type in (N'U'))
DROP TABLE [dbo].[tblHoadonnhap]
GO
/****** Object:  Table [dbo].[tblHoadonban]    Script Date: 12/28/2021 8:38:19 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblHoadonban]') AND type in (N'U'))
DROP TABLE [dbo].[tblHoadonban]
GO
/****** Object:  Table [dbo].[DangNhap]    Script Date: 12/28/2021 8:38:19 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DangNhap]') AND type in (N'U'))
DROP TABLE [dbo].[DangNhap]
GO
/****** Object:  Table [dbo].[DangNhap]    Script Date: 12/28/2021 8:38:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DangNhap](
	[TenDangNhap] [nvarchar](50) NOT NULL,
	[MatKhau] [nvarchar](50) NULL,
	[Quyen] [bit] NOT NULL,
 CONSTRAINT [PK_DangNhap] PRIMARY KEY CLUSTERED 
(
	[TenDangNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblHoadonban]    Script Date: 12/28/2021 8:38:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblHoadonban](
	[MaHDB] [nvarchar](20) NOT NULL,
	[MaNV] [nvarchar](20) NULL,
	[MaKH] [nvarchar](20) NULL,
	[MaMT] [nvarchar](20) NULL,
	[Soluong] [int] NULL,
	[Ngayban] [date] NULL,
	[Diachi] [nvarchar](50) NULL,
	[Sdt] [int] NULL,
	[Dongia] [float] NULL,
	[Tongtien] [float] NULL,
 CONSTRAINT [PK_Hoadonban] PRIMARY KEY CLUSTERED 
(
	[MaHDB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblHoadonnhap]    Script Date: 12/28/2021 8:38:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblHoadonnhap](
	[MaHDN] [nvarchar](20) NOT NULL,
	[MaNV] [nvarchar](20) NOT NULL,
	[MaMT] [nvarchar](20) NOT NULL,
	[MaNCC] [nvarchar](20) NULL,
	[Soluong] [int] NULL,
	[Ngaynhap] [date] NULL,
	[Diachi] [nvarchar](50) NULL,
	[Sdt] [int] NULL,
	[Dongia] [float] NULL,
	[Tongtien] [float] NULL,
 CONSTRAINT [PK_Hoadonnhap] PRIMARY KEY CLUSTERED 
(
	[MaHDN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblKhachhang]    Script Date: 12/28/2021 8:38:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblKhachhang](
	[MaKH] [nvarchar](20) NOT NULL,
	[TenKH] [nvarchar](50) NULL,
	[Gioitinh] [nvarchar](10) NULL,
	[Diachi] [nvarchar](50) NULL,
	[Sdt] [int] NULL,
 CONSTRAINT [PK_Khachhang] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblNhaCC]    Script Date: 12/28/2021 8:38:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblNhaCC](
	[MaNCC] [nvarchar](20) NOT NULL,
	[TenNCC] [nvarchar](50) NULL,
	[Diachi] [nvarchar](50) NULL,
	[Sdt] [int] NULL,
 CONSTRAINT [PK_NhaCC] PRIMARY KEY CLUSTERED 
(
	[MaNCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblNhanvien]    Script Date: 12/28/2021 8:38:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblNhanvien](
	[MaNV] [nvarchar](20) NOT NULL,
	[TenNV] [nvarchar](50) NULL,
	[Gioitinh] [nvarchar](10) NULL,
	[Diachi] [nvarchar](50) NULL,
	[Sdt] [int] NULL,
 CONSTRAINT [PK_Nhanvien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblThongtinMT]    Script Date: 12/28/2021 8:38:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblThongtinMT](
	[MaMT] [nvarchar](20) NOT NULL,
	[TenMT] [nvarchar](50) NULL,
	[MaNCC] [nvarchar](20) NULL,
	[Soluong] [int] NULL,
	[Giaban] [int] NULL,
 CONSTRAINT [PK_ThongtinMT] PRIMARY KEY CLUSTERED 
(
	[MaMT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[DangNhap] ([TenDangNhap], [MatKhau], [Quyen]) VALUES (N'admin', N'123', 1)
INSERT [dbo].[DangNhap] ([TenDangNhap], [MatKhau], [Quyen]) VALUES (N'admin1', N'123', 0)
GO
INSERT [dbo].[tblHoadonban] ([MaHDB], [MaNV], [MaKH], [MaMT], [Soluong], [Ngayban], [Diachi], [Sdt], [Dongia], [Tongtien]) VALUES (N'Hd1', N'Nv1', N'Kh1', N'Mt1', 1, CAST(N'2022-02-02' AS Date), N'Hue', 12345, 10000000, 10000000)
INSERT [dbo].[tblHoadonban] ([MaHDB], [MaNV], [MaKH], [MaMT], [Soluong], [Ngayban], [Diachi], [Sdt], [Dongia], [Tongtien]) VALUES (N'Hd2', N'Nv1', N'Kh2', N'Mt1', 3, CAST(N'2022-02-02' AS Date), N'Da Nang', 123456, 10000000, 30000000)
GO
INSERT [dbo].[tblHoadonnhap] ([MaHDN], [MaNV], [MaMT], [MaNCC], [Soluong], [Ngaynhap], [Diachi], [Sdt], [Dongia], [Tongtien]) VALUES (N'Hdn1', N'Nv1', N'Mt1', N'NCC2', 10, CAST(N'2022-01-01' AS Date), N'Hue', 1234, 1000000, 10000000)
INSERT [dbo].[tblHoadonnhap] ([MaHDN], [MaNV], [MaMT], [MaNCC], [Soluong], [Ngaynhap], [Diachi], [Sdt], [Dongia], [Tongtien]) VALUES (N'Hdn2', N'Nv1', N'Mt2', N'NCC2', 21, CAST(N'2022-01-01' AS Date), N'Hue', 1234, 10000000, 210000000)
INSERT [dbo].[tblHoadonnhap] ([MaHDN], [MaNV], [MaMT], [MaNCC], [Soluong], [Ngaynhap], [Diachi], [Sdt], [Dongia], [Tongtien]) VALUES (N'Hdn3', N'Nv2', N'Mt4', N'NCC1', 2, CAST(N'2022-01-01' AS Date), N'Hue', 4321, 20000000, 40000000)
GO
INSERT [dbo].[tblKhachhang] ([MaKH], [TenKH], [Gioitinh], [Diachi], [Sdt]) VALUES (N'Kh1', N'Thai', N'Nam', N'Hue', 12345)
INSERT [dbo].[tblKhachhang] ([MaKH], [TenKH], [Gioitinh], [Diachi], [Sdt]) VALUES (N'Kh2', N'Thai Phuc', N'Nam', N'Hue', 123456)
GO
INSERT [dbo].[tblNhaCC] ([MaNCC], [TenNCC], [Diachi], [Sdt]) VALUES (N'NCC1', N'Phi Long', N'Hue', 123)
INSERT [dbo].[tblNhaCC] ([MaNCC], [TenNCC], [Diachi], [Sdt]) VALUES (N'NCC2', N'FPT Shop', N'Hue', 234)
GO
INSERT [dbo].[tblNhanvien] ([MaNV], [TenNV], [Gioitinh], [Diachi], [Sdt]) VALUES (N'Nv1', N'Nhan', N'Nam', N'Hue', 1234)
INSERT [dbo].[tblNhanvien] ([MaNV], [TenNV], [Gioitinh], [Diachi], [Sdt]) VALUES (N'Nv2', N'Phuc', N'Nam', N'Hue', 4321)
GO
INSERT [dbo].[tblThongtinMT] ([MaMT], [TenMT], [MaNCC], [Soluong], [Giaban]) VALUES (N'Mt1', N'Dell 2021', N'NCC2', 33, 10000000)
INSERT [dbo].[tblThongtinMT] ([MaMT], [TenMT], [MaNCC], [Soluong], [Giaban]) VALUES (N'Mt2', N'Dell 2022', N'NCC2', 33, 10000000)
INSERT [dbo].[tblThongtinMT] ([MaMT], [TenMT], [MaNCC], [Soluong], [Giaban]) VALUES (N'Mt4', N'Asus', N'NCC1', 12, 20000000)
GO
ALTER TABLE [dbo].[tblHoadonban]  WITH CHECK ADD  CONSTRAINT [FK_tblHoadonban_tblKhachhang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[tblKhachhang] ([MaKH])
GO
ALTER TABLE [dbo].[tblHoadonban] CHECK CONSTRAINT [FK_tblHoadonban_tblKhachhang]
GO
ALTER TABLE [dbo].[tblHoadonban]  WITH CHECK ADD  CONSTRAINT [FK_tblHoadonban_tblNhanvien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[tblNhanvien] ([MaNV])
GO
ALTER TABLE [dbo].[tblHoadonban] CHECK CONSTRAINT [FK_tblHoadonban_tblNhanvien]
GO
ALTER TABLE [dbo].[tblHoadonban]  WITH CHECK ADD  CONSTRAINT [FK_tblHoadonban_tblThongtinMT] FOREIGN KEY([MaMT])
REFERENCES [dbo].[tblThongtinMT] ([MaMT])
GO
ALTER TABLE [dbo].[tblHoadonban] CHECK CONSTRAINT [FK_tblHoadonban_tblThongtinMT]
GO
ALTER TABLE [dbo].[tblHoadonnhap]  WITH CHECK ADD  CONSTRAINT [FK_tblHoadonnhap_tblNhaCC] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[tblNhaCC] ([MaNCC])
GO
ALTER TABLE [dbo].[tblHoadonnhap] CHECK CONSTRAINT [FK_tblHoadonnhap_tblNhaCC]
GO
ALTER TABLE [dbo].[tblHoadonnhap]  WITH CHECK ADD  CONSTRAINT [FK_tblHoadonnhap_tblNhanvien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[tblNhanvien] ([MaNV])
GO
ALTER TABLE [dbo].[tblHoadonnhap] CHECK CONSTRAINT [FK_tblHoadonnhap_tblNhanvien]
GO
ALTER TABLE [dbo].[tblHoadonnhap]  WITH CHECK ADD  CONSTRAINT [FK_tblHoadonnhap_tblThongtinMT] FOREIGN KEY([MaMT])
REFERENCES [dbo].[tblThongtinMT] ([MaMT])
GO
ALTER TABLE [dbo].[tblHoadonnhap] CHECK CONSTRAINT [FK_tblHoadonnhap_tblThongtinMT]
GO
ALTER TABLE [dbo].[tblThongtinMT]  WITH CHECK ADD  CONSTRAINT [FK_tblThongtinMT_tblNhaCC] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[tblNhaCC] ([MaNCC])
GO
ALTER TABLE [dbo].[tblThongtinMT] CHECK CONSTRAINT [FK_tblThongtinMT_tblNhaCC]
GO
