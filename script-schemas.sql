USE [master]
GO
/****** Object:  Database [QuanLyDiem1.0.3]    Script Date: 13-Jul-23 22:05:26 ******/
CREATE DATABASE [QuanLyDiem1.0.3]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLyDiem1.0.3', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSI\MSSQL\DATA\QuanLyDiem1.0.3.mdf' , SIZE = 73728KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QuanLyDiem1.0.3_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSI\MSSQL\DATA\QuanLyDiem1.0.3_log.ldf' , SIZE = 73728KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [QuanLyDiem1.0.3] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLyDiem1.0.3].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLyDiem1.0.3] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLyDiem1.0.3] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLyDiem1.0.3] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLyDiem1.0.3] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLyDiem1.0.3] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLyDiem1.0.3] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [QuanLyDiem1.0.3] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLyDiem1.0.3] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyDiem1.0.3] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLyDiem1.0.3] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLyDiem1.0.3] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLyDiem1.0.3] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLyDiem1.0.3] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLyDiem1.0.3] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLyDiem1.0.3] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QuanLyDiem1.0.3] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLyDiem1.0.3] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLyDiem1.0.3] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLyDiem1.0.3] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLyDiem1.0.3] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLyDiem1.0.3] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLyDiem1.0.3] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLyDiem1.0.3] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QuanLyDiem1.0.3] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLyDiem1.0.3] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLyDiem1.0.3] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLyDiem1.0.3] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLyDiem1.0.3] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QuanLyDiem1.0.3] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QuanLyDiem1.0.3] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [QuanLyDiem1.0.3] SET QUERY_STORE = ON
GO
ALTER DATABASE [QuanLyDiem1.0.3] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [QuanLyDiem1.0.3]
GO
/****** Object:  Table [dbo].[BangDiem]    Script Date: 13-Jul-23 22:05:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BangDiem](
	[maLopHP] [varchar](16) NOT NULL,
	[maSinhVien] [varchar](16) NOT NULL,
	[diemChuyenCan] [float] NULL,
	[diemGiuaKy] [float] NULL,
	[diemThi] [float] NULL,
	[diemTrungBinh] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[maLopHP] ASC,
	[maSinhVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GiangVien]    Script Date: 13-Jul-23 22:05:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GiangVien](
	[maGiangVien] [varchar](16) NOT NULL,
	[tenGiangVien] [nvarchar](32) NOT NULL,
	[hoDem] [nvarchar](32) NOT NULL,
	[gioiTinh] [bit] NOT NULL,
	[ngaySinh] [date] NULL,
	[diaChi] [nvarchar](128) NULL,
	[dienThoai] [varchar](16) NULL,
	[email] [varchar](64) NULL,
	[hocVi] [nvarchar](32) NULL,
	[maKhoa] [varchar](16) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[maGiangVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Huyen]    Script Date: 13-Jul-23 22:05:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Huyen](
	[maHuyen] [varchar](16) NOT NULL,
	[maTinh] [varchar](16) NULL,
	[tenHuyen] [nvarchar](64) NULL,
 CONSTRAINT [PK_Huyen] PRIMARY KEY CLUSTERED 
(
	[maHuyen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Khoa]    Script Date: 13-Jul-23 22:05:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Khoa](
	[maKhoa] [varchar](16) NOT NULL,
	[tenKhoa] [nvarchar](64) NOT NULL,
	[dienThoai] [varchar](16) NULL,
PRIMARY KEY CLUSTERED 
(
	[maKhoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LopHanhChinh]    Script Date: 13-Jul-23 22:05:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LopHanhChinh](
	[maLopHaCh] [varchar](16) NOT NULL,
	[tenLop] [nvarchar](64) NOT NULL,
	[maGiangVien] [varchar](16) NOT NULL,
	[maKhoa] [varchar](16) NOT NULL,
	[namNhapHoc] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[maLopHaCh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[maLopHaCh] ASC,
	[tenLop] ASC,
	[maGiangVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[maGiangVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[maGiangVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[maGiangVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LopHocPhan]    Script Date: 13-Jul-23 22:05:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LopHocPhan](
	[maLopHP] [varchar](16) NOT NULL,
	[maMon] [varchar](16) NOT NULL,
	[maGiangVien] [varchar](16) NOT NULL,
	[hocKy] [tinyint] NOT NULL,
	[namHoc] [varchar](16) NOT NULL,
	[maKhoa] [varchar](16) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[maLopHP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MonHoc]    Script Date: 13-Jul-23 22:05:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MonHoc](
	[maMon] [varchar](16) NOT NULL,
	[tenMon] [nvarchar](64) NOT NULL,
	[soTinChi] [tinyint] NOT NULL,
	[maKhoa] [varchar](16) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[maMon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SinhVien]    Script Date: 13-Jul-23 22:05:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SinhVien](
	[maSinhVien] [varchar](16) NOT NULL,
	[tenSinhVien] [nvarchar](32) NOT NULL,
	[hoDem] [nvarchar](32) NOT NULL,
	[gioiTinh] [bit] NOT NULL,
	[ngaySinh] [date] NULL,
	[diaChi] [nvarchar](128) NULL,
	[dienThoai] [varchar](16) NULL,
	[email] [varchar](64) NULL,
	[maLopHaCh] [varchar](16) NOT NULL,
	[anhDaiDien] [varbinary](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[maSinhVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 13-Jul-23 22:05:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[tenDangNhap] [varchar](16) NOT NULL,
	[matKhau] [int] NULL,
	[quyenHan] [tinyint] NULL,
PRIMARY KEY CLUSTERED 
(
	[tenDangNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tinh]    Script Date: 13-Jul-23 22:05:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tinh](
	[maTinh] [varchar](16) NOT NULL,
	[tenTinh] [nvarchar](64) NULL,
 CONSTRAINT [PK_Tinh] PRIMARY KEY CLUSTERED 
(
	[maTinh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Xa]    Script Date: 13-Jul-23 22:05:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Xa](
	[maXa] [varchar](16) NOT NULL,
	[maHuyen] [varchar](16) NULL,
	[tenXa] [nvarchar](64) NULL,
 CONSTRAINT [PK_Xa] PRIMARY KEY CLUSTERED 
(
	[maXa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[SinhVien] ADD  CONSTRAINT [DF_SinhVien_anhDaiDien]  DEFAULT (NULL) FOR [anhDaiDien]
GO
ALTER TABLE [dbo].[TaiKhoan] ADD  DEFAULT ('-842352753') FOR [matKhau]
GO
ALTER TABLE [dbo].[TaiKhoan] ADD  DEFAULT ('0') FOR [quyenHan]
GO
ALTER TABLE [dbo].[BangDiem]  WITH CHECK ADD  CONSTRAINT [conBDLHP] FOREIGN KEY([maLopHP])
REFERENCES [dbo].[LopHocPhan] ([maLopHP])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[BangDiem] CHECK CONSTRAINT [conBDLHP]
GO
ALTER TABLE [dbo].[BangDiem]  WITH CHECK ADD  CONSTRAINT [conBDSV] FOREIGN KEY([maSinhVien])
REFERENCES [dbo].[SinhVien] ([maSinhVien])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[BangDiem] CHECK CONSTRAINT [conBDSV]
GO
ALTER TABLE [dbo].[GiangVien]  WITH CHECK ADD  CONSTRAINT [conGVK] FOREIGN KEY([maKhoa])
REFERENCES [dbo].[Khoa] ([maKhoa])
GO
ALTER TABLE [dbo].[GiangVien] CHECK CONSTRAINT [conGVK]
GO
ALTER TABLE [dbo].[Huyen]  WITH CHECK ADD  CONSTRAINT [FK_Huyen_Tinh] FOREIGN KEY([maTinh])
REFERENCES [dbo].[Tinh] ([maTinh])
GO
ALTER TABLE [dbo].[Huyen] CHECK CONSTRAINT [FK_Huyen_Tinh]
GO
ALTER TABLE [dbo].[LopHanhChinh]  WITH CHECK ADD  CONSTRAINT [conLHCGV] FOREIGN KEY([maGiangVien])
REFERENCES [dbo].[GiangVien] ([maGiangVien])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[LopHanhChinh] CHECK CONSTRAINT [conLHCGV]
GO
ALTER TABLE [dbo].[LopHanhChinh]  WITH CHECK ADD  CONSTRAINT [conLHCK] FOREIGN KEY([maKhoa])
REFERENCES [dbo].[Khoa] ([maKhoa])
GO
ALTER TABLE [dbo].[LopHanhChinh] CHECK CONSTRAINT [conLHCK]
GO
ALTER TABLE [dbo].[LopHocPhan]  WITH CHECK ADD  CONSTRAINT [conLHPGV] FOREIGN KEY([maGiangVien])
REFERENCES [dbo].[GiangVien] ([maGiangVien])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[LopHocPhan] CHECK CONSTRAINT [conLHPGV]
GO
ALTER TABLE [dbo].[LopHocPhan]  WITH CHECK ADD  CONSTRAINT [conLHPK] FOREIGN KEY([maKhoa])
REFERENCES [dbo].[Khoa] ([maKhoa])
GO
ALTER TABLE [dbo].[LopHocPhan] CHECK CONSTRAINT [conLHPK]
GO
ALTER TABLE [dbo].[LopHocPhan]  WITH CHECK ADD  CONSTRAINT [conLHPMH] FOREIGN KEY([maMon])
REFERENCES [dbo].[MonHoc] ([maMon])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[LopHocPhan] CHECK CONSTRAINT [conLHPMH]
GO
ALTER TABLE [dbo].[MonHoc]  WITH CHECK ADD  CONSTRAINT [conMHK] FOREIGN KEY([maKhoa])
REFERENCES [dbo].[Khoa] ([maKhoa])
GO
ALTER TABLE [dbo].[MonHoc] CHECK CONSTRAINT [conMHK]
GO
ALTER TABLE [dbo].[SinhVien]  WITH CHECK ADD  CONSTRAINT [conSVLHC] FOREIGN KEY([maLopHaCh])
REFERENCES [dbo].[LopHanhChinh] ([maLopHaCh])
GO
ALTER TABLE [dbo].[SinhVien] CHECK CONSTRAINT [conSVLHC]
GO
ALTER TABLE [dbo].[Xa]  WITH CHECK ADD  CONSTRAINT [FK_Xa_Huyen] FOREIGN KEY([maHuyen])
REFERENCES [dbo].[Huyen] ([maHuyen])
GO
ALTER TABLE [dbo].[Xa] CHECK CONSTRAINT [FK_Xa_Huyen]
GO
/****** Object:  StoredProcedure [dbo].[spGetAllDiem]    Script Date: 13-Jul-23 22:05:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[spGetAllDiem]
as
begin
	select BangDiem.maLopHP, MonHoc.tenMon, BangDiem.maSinhVien, SinhVien.hoDem, SinhVien.tenSinhVien, diemChuyenCan, diemGiuaKy, diemThi, diemTrungBinh
	from BangDiem
	join LopHocPhan on BangDiem.maLopHP = LopHocPhan.maLopHP
	join MonHoc on LopHocPhan.maMon = MonHoc.maMon
	join SinhVien on BangDiem.maSinhVien = SinhVien.maSinhVien
end
GO
/****** Object:  StoredProcedure [dbo].[spGetAllGiangVien]    Script Date: 13-Jul-23 22:05:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spGetAllGiangVien]
as
begin
	select maGiangVien, hoDem, tenGiangVien, gioiTinh, ngaySinh, diaChi, GiangVien.dienThoai, email, hocVi, GiangVien.maKhoa, tenKhoa
	from GiangVien join Khoa on GiangVien.maKhoa = Khoa.maKhoa
end
GO
/****** Object:  StoredProcedure [dbo].[spGetAllLopHC]    Script Date: 13-Jul-23 22:05:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spGetAllLopHC]
as
begin
	select LopHanhChinh.maLopHaCh, LopHanhChinh.tenLop, LopHanhChinh.maGiangVien, GiangVien.hoDem, GiangVien.tenGiangVien, LopHanhChinh.maKhoa, Khoa.tenKhoa, LopHanhChinh.namNhapHoc
	from LopHanhChinh
	join GiangVien on LopHanhChinh.maGiangVien = GiangVien.maGiangVien
	join Khoa on LopHanhChinh.maKhoa = Khoa.maKhoa
end
GO
/****** Object:  StoredProcedure [dbo].[spGetAllLopHP]    Script Date: 13-Jul-23 22:05:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[spGetAllLopHP]
as
begin
	select LopHocPhan.maLopHP, LopHocPhan.maMon, MonHoc.tenMon, LopHocPhan.maGiangVien, GiangVien.hoDem, GiangVien.tenGiangVien, hocKy, namhoc, LopHocPhan.maKhoa, Khoa.tenKhoa 
	from LopHocPhan
	join MonHoc on LopHocPhan.maMon = MonHoc.maMon 
	join GiangVien on LopHocPhan.maGiangVien = GiangVien.maGiangVien 
	join Khoa on LopHocPhan.maKhoa = Khoa.maKhoa
end
GO
/****** Object:  StoredProcedure [dbo].[spGetAllSinhVien]    Script Date: 13-Jul-23 22:05:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[spGetAllSinhVien]
as
begin
	select maSinhVien, hoDem, tenSinhVien, gioiTinh, ngaySinh, diaChi, dienThoai, email, SinhVien.maLopHaCh, tenLop, anhDaiDien
	from SinhVien
	join LopHanhChinh on SinhVien.maLopHaCh = LopHanhChinh.maLopHaCh
end
GO
/****** Object:  StoredProcedure [dbo].[spGetDiemByGV]    Script Date: 13-Jul-23 22:05:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[spGetDiemByGV]
@mag varchar(16)
as
begin
	select BangDiem.maLopHP, MonHoc.tenMon, BangDiem.maSinhVien, SinhVien.hoDem, SinhVien.tenSinhVien, diemChuyenCan, diemGiuaKy, diemThi, diemTrungBinh
	from BangDiem
	join LopHocPhan on BangDiem.maLopHP = LopHocPhan.maLopHP
	join MonHoc on LopHocPhan.maMon = MonHoc.maMon
	join SinhVien on BangDiem.maSinhVien = SinhVien.maSinhVien
	where LopHocPhan.maLopHP = @mag
end
GO
/****** Object:  StoredProcedure [dbo].[spGetGiangVienByKHoa]    Script Date: 13-Jul-23 22:05:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spGetGiangVienByKHoa]
@mak varchar(16)
as 
begin
	select maGiangVien, hoDem, tenGiangVien, gioiTinh, ngaySinh, diaChi, GiangVien.dienThoai, email, hocVi, GiangVien.maKhoa, tenKhoa
	from GiangVien join Khoa on GiangVien.maKhoa = Khoa.maKhoa
	where GiangVien.maKhoa = @mak
end
GO
/****** Object:  StoredProcedure [dbo].[spGetGVCN]    Script Date: 13-Jul-23 22:05:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spGetGVCN]
as
begin
	select GiangVien.maGiangVien, hocVi, hoDem, tenGiangVien, GiangVien.maKhoa, Khoa.tenKhoa
	from GiangVien join Khoa on GiangVien.maKhoa = Khoa.maKhoa
	where not exists (
		select 1 from LopHanhChinh
		where GiangVien.maGiangVien = LopHanhChinh.maGiangVien
	);
end
GO
/****** Object:  StoredProcedure [dbo].[spGetSinhVienForGV]    Script Date: 13-Jul-23 22:05:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[spGetSinhVienForGV]
@mgv varchar(16)
as
begin
	select SinhVien.maSinhVien, SinhVien.hoDem, SinhVien.tenSinhVien
	from SinhVien
	cross join LopHocPhan
	left join BangDiem on SinhVien.maSinhVien = BangDiem.maSinhVien and LopHocPhan.maLopHP = BangDiem.maLopHP
	left join GiangVien on LopHocPhan.maGiangVien = GiangVien.maGiangVien
	where BangDiem.maSinhVien is null and GiangVien.maGiangVien = @mgv
end
GO
/****** Object:  StoredProcedure [dbo].[spGetSinhVienLHC]    Script Date: 13-Jul-23 22:05:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[spGetSinhVienLHC]
@mgv varchar(16)
as
begin
	select maSinhVien, SinhVien.hoDem, tenSinhVien, SinhVien.gioiTinh, SinhVien.ngaySinh, SinhVien.diaChi, SinhVien.dienThoai, SinhVien.email, SinhVien.maLopHaCh, LopHanhChinh.tenLop, anhDaiDien
	from SinhVien
	join LopHanhChinh on SinhVien.maLopHaCh = LopHanhChinh.maLopHaCh
	join GiangVien on LopHanhChinh.maGiangVien = GiangVien.maGiangVien
	where LopHanhChinh.maGiangVien = @mgv
end
GO
/****** Object:  StoredProcedure [dbo].[spSearchSinhVien]    Script Date: 13-Jul-23 22:05:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[spSearchSinhVien]
@sea varchar(16)
as
begin
	select maSinhVien, hoDem, tenSinhVien, gioiTinh, ngaySinh, diaChi, dienThoai, email, SinhVien.maLopHaCh, tenLop, anhDaiDien 
	from SinhVien join LopHanhChinh on SinhVien.maLopHaCh = LopHanhChinh.maLopHaCh 
	where maSinhVien collate SQL_Latin1_General_CP1_CI_AI like '%' + @sea + '%' 
	or tenSinhVien collate SQL_Latin1_General_CP1_CI_AI like '%' + @sea + '%' 
	or hoDem collate SQL_Latin1_General_CP1_CI_AI like '%' + @sea + '%'
end
GO
USE [master]
GO
ALTER DATABASE [QuanLyDiem1.0.3] SET  READ_WRITE 
GO
