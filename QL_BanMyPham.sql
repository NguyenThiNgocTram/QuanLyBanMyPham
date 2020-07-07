USE [QL_BanMyPham]
GO
/****** Object:  Table [dbo].[tbChamCong]    Script Date: 7/7/2020 11:01:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbChamCong](
	[MaNV] [nchar](10) NOT NULL,
	[MaLoaiNV] [nchar](10) NOT NULL,
	[SoNgayNghiKP] [date] NULL,
	[SoNgayNghiCP] [date] NULL,
	[Luong] [int] NULL,
	[HoaHong] [float] NULL,
	[DoanhSo] [int] NULL,
 CONSTRAINT [PK_tbChamCong] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC,
	[MaLoaiNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbChiTietHoaDon]    Script Date: 7/7/2020 11:01:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbChiTietHoaDon](
	[MaCTHD] [nchar](10) NOT NULL,
	[MaHD] [nchar](10) NOT NULL,
	[MaSP] [nchar](10) NULL,
	[MaKH] [nchar](10) NULL,
	[SoLuong] [int] NULL,
	[GiaSP] [int] NULL,
	[ThanhTien] [int] NULL,
	[VAT] [float] NULL,
	[GiamGia] [int] NULL,
	[ThanhToan] [int] NULL,
 CONSTRAINT [PK_tbChiTietHoaDon] PRIMARY KEY CLUSTERED 
(
	[MaCTHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbCuaHang]    Script Date: 7/7/2020 11:01:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbCuaHang](
	[MaCuaHang] [nchar](10) NOT NULL,
	[TenCuaHang] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SoDienThoaiTuVan] [int] NULL,
 CONSTRAINT [PK_tbCuaHang] PRIMARY KEY CLUSTERED 
(
	[MaCuaHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbHangSP]    Script Date: 7/7/2020 11:01:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbHangSP](
	[MaHangSP] [nchar](10) NOT NULL,
	[TenHangSP] [nvarchar](50) NULL,
	[MaNCC] [nchar](10) NOT NULL,
	[Ghichu] [nvarchar](max) NULL,
 CONSTRAINT [PK_tbHangSP] PRIMARY KEY CLUSTERED 
(
	[MaHangSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbHoaDon]    Script Date: 7/7/2020 11:01:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbHoaDon](
	[MaHD] [nchar](10) NOT NULL,
	[MaCuaHang] [nchar](10) NOT NULL,
	[MaNhanVien] [nchar](10) NOT NULL,
	[NgayLap] [date] NULL,
 CONSTRAINT [PK_tbHoaDon] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbKhachHang]    Script Date: 7/7/2020 11:01:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbKhachHang](
	[MaKH] [nchar](10) NOT NULL,
	[TenKH] [nvarchar](50) NULL,
	[Diachi] [nvarchar](50) NULL,
	[SDT] [int] NULL,
	[TichDiem] [int] NULL,
 CONSTRAINT [PK_tbKhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbLoaiNV]    Script Date: 7/7/2020 11:01:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbLoaiNV](
	[MaLoaiNV] [nchar](10) NOT NULL,
	[TenLoai] [nvarchar](50) NULL,
	[Luong] [int] NULL,
 CONSTRAINT [PK_tbLoaiNV] PRIMARY KEY CLUSTERED 
(
	[MaLoaiNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbLoaiSP]    Script Date: 7/7/2020 11:01:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbLoaiSP](
	[MaLoaiSP] [nchar](10) NOT NULL,
	[TenLoaiSP] [nvarchar](50) NULL,
	[GhiChu] [nvarchar](max) NULL,
 CONSTRAINT [PK_tbLoaiSP] PRIMARY KEY CLUSTERED 
(
	[MaLoaiSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbNCC]    Script Date: 7/7/2020 11:01:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbNCC](
	[MaNCC] [nchar](10) NOT NULL,
	[TenNCC] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
 CONSTRAINT [PK_tbNCC] PRIMARY KEY CLUSTERED 
(
	[MaNCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbNhanVien]    Script Date: 7/7/2020 11:01:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbNhanVien](
	[MaNV] [nchar](10) NOT NULL,
	[TenNV] [nvarchar](50) NULL,
	[MaLoaiNV] [nchar](10) NULL,
	[NgaySinh] [date] NULL,
	[SoCMND] [int] NULL,
	[SDT] [int] NULL,
	[DiaChi] [nvarchar](50) NULL,
	[ChucVu] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tbNhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbSanPham]    Script Date: 7/7/2020 11:01:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbSanPham](
	[MaSP] [nchar](10) NOT NULL,
	[TenSP] [nvarchar](50) NULL,
	[MaLoaiSP] [nchar](10) NOT NULL,
	[MaHang] [nchar](10) NOT NULL,
	[GiaNhap] [int] NULL,
	[GiaBanLe] [int] NULL,
	[XuatSu] [nvarchar](50) NULL,
	[NgayNhap] [date] NULL,
	[SoLuongDaBan] [int] NULL,
	[SoLuongCon] [int] NULL,
 CONSTRAINT [PK_tbSanPham] PRIMARY KEY CLUSTERED 
(
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
