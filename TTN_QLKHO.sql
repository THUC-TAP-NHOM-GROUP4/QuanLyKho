USE [master]
GO
/****** Object:  Database [TTN_QLKho]    Script Date: 27/05/2017 7:24:51 CH ******/
CREATE DATABASE [TTN_QLKho]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TTN_QLKho', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL12.THANHHUONG\MSSQL\DATA\TTN_QLKho.mdf' , SIZE = 4288KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'TTN_QLKho_log', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL12.THANHHUONG\MSSQL\DATA\TTN_QLKho_log.ldf' , SIZE = 1072KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [TTN_QLKho] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TTN_QLKho].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TTN_QLKho] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TTN_QLKho] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TTN_QLKho] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TTN_QLKho] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TTN_QLKho] SET ARITHABORT OFF 
GO
ALTER DATABASE [TTN_QLKho] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [TTN_QLKho] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TTN_QLKho] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TTN_QLKho] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TTN_QLKho] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TTN_QLKho] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TTN_QLKho] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TTN_QLKho] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TTN_QLKho] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TTN_QLKho] SET  ENABLE_BROKER 
GO
ALTER DATABASE [TTN_QLKho] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TTN_QLKho] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TTN_QLKho] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TTN_QLKho] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TTN_QLKho] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TTN_QLKho] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TTN_QLKho] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TTN_QLKho] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [TTN_QLKho] SET  MULTI_USER 
GO
ALTER DATABASE [TTN_QLKho] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TTN_QLKho] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TTN_QLKho] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TTN_QLKho] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [TTN_QLKho] SET DELAYED_DURABILITY = DISABLED 
GO
USE [TTN_QLKho]
GO
/****** Object:  UserDefinedFunction [dbo].[auto_maCTPhieuXuat]    Script Date: 27/05/2017 7:24:51 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE function [dbo].[auto_maCTPhieuXuat]() returns varchar(8)
as
begin
declare @ma varchar(8)
if(select count(ma) from ChiTietPhieuXuat)=0
set @ma='0'
else 
select @ma=max(right(ma,4)) from ChiTietPhieuXuat
set @ma=case
when 
@ma>=0 and @ma<9 then 'CTPX000'+CONVERT(char,convert(int,@ma)+1)
when @ma>=9 and @ma<99 then 'CTPX00'+CONVERT(char,convert(int,@ma)+1)
when @ma>=99 and @ma<999 then 'CTPX0'+CONVERT(char,convert(int,@ma)+1)
end
return 
@ma
end
GO
/****** Object:  UserDefinedFunction [dbo].[auto_maPhieuXuat]    Script Date: 27/05/2017 7:24:51 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[auto_maPhieuXuat]() returns varchar(6)
as
begin
declare @ma varchar(6)
if(select count(ma) from PhieuXuat)=0
set @ma='0'
else 
select @ma=max(right(ma,4)) from PhieuXuat
set @ma=case
when 
@ma>=0 and @ma<9 then 'PX000'+CONVERT(char,convert(int,@ma)+1)
when @ma>=9 and @ma<99 then 'PX00'+CONVERT(char,convert(int,@ma)+1)
when @ma>=99 and @ma<999 then 'PX0'+CONVERT(char,convert(int,@ma)+1)
end
return 
@ma
end

GO
/****** Object:  Table [dbo].[ChiTietPhieuNhap]    Script Date: 27/05/2017 7:24:51 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ChiTietPhieuNhap](
	[ma] [varchar](20) NOT NULL,
	[phieunhapma] [varchar](20) NULL,
	[hanghoama] [varchar](20) NULL,
	[khoma] [varchar](20) NULL,
	[soluong] [int] NULL,
	[dongia] [float] NULL,
	[thanhtien] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ChiTietPhieuXuat]    Script Date: 27/05/2017 7:24:51 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ChiTietPhieuXuat](
	[ma] [varchar](20) NOT NULL,
	[phieuxuatma] [varchar](20) NULL,
	[hanghoama] [varchar](20) NULL,
	[khoma] [varchar](20) NULL,
	[soluong] [int] NULL,
	[dongia] [money] NULL,
	[thanhtien] [money] NULL,
 CONSTRAINT [PK__ChiTietP__3213C8B79E4258C8] PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HangHoa]    Script Date: 27/05/2017 7:24:51 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HangHoa](
	[ma] [varchar](20) NOT NULL,
	[ten] [nvarchar](50) NULL,
	[nhomma] [varchar](20) NULL,
	[dongia] [float] NULL,
	[soluong] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 27/05/2017 7:24:51 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KhachHang](
	[ma] [varchar](20) NOT NULL,
	[ten] [nvarchar](50) NULL,
	[diachi] [nvarchar](50) NULL,
	[dienthoai] [varchar](20) NULL,
	[email] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Kho]    Script Date: 27/05/2017 7:24:51 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Kho](
	[ma] [varchar](20) NOT NULL,
	[ten] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 27/05/2017 7:24:51 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhaCungCap](
	[ma] [varchar](20) NOT NULL,
	[ten] [nvarchar](50) NULL,
	[diachi] [nvarchar](50) NULL,
	[dienthoai] [varchar](20) NULL,
	[masothue] [int] NULL,
	[email] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 27/05/2017 7:24:51 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhanVien](
	[ma] [varchar](20) NOT NULL,
	[ten] [nvarchar](50) NULL,
	[ngaysinh] [date] NULL,
	[gioitinh] [bit] NULL,
	[diachi] [nvarchar](50) NULL,
	[dienthoai] [int] NULL,
	[chucvu] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Nhom]    Script Date: 27/05/2017 7:24:51 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Nhom](
	[ma] [varchar](20) NOT NULL,
	[ten] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PhieuNhap]    Script Date: 27/05/2017 7:24:51 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PhieuNhap](
	[ma] [varchar](20) NOT NULL,
	[ngay] [date] NULL,
	[nhacungcapma] [varchar](20) NULL,
	[manguoigiao] [varchar](20) NULL,
	[noidung] [text] NULL,
	[khoma] [varchar](20) NULL,
	[nhanvienma] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PhieuXuat]    Script Date: 27/05/2017 7:24:51 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PhieuXuat](
	[ma] [varchar](20) NOT NULL,
	[ngay] [date] NULL,
	[khoma] [varchar](20) NULL,
	[noidung] [text] NULL,
	[khachhangma] [varchar](20) NULL,
	[nhanvienma] [varchar](20) NULL,
	[tongtien] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap]  WITH CHECK ADD FOREIGN KEY([hanghoama])
REFERENCES [dbo].[HangHoa] ([ma])
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap]  WITH CHECK ADD FOREIGN KEY([khoma])
REFERENCES [dbo].[Kho] ([ma])
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap]  WITH CHECK ADD FOREIGN KEY([phieunhapma])
REFERENCES [dbo].[PhieuNhap] ([ma])
GO
ALTER TABLE [dbo].[ChiTietPhieuXuat]  WITH CHECK ADD  CONSTRAINT [FK__ChiTietPh__hangh__3C69FB99] FOREIGN KEY([hanghoama])
REFERENCES [dbo].[HangHoa] ([ma])
GO
ALTER TABLE [dbo].[ChiTietPhieuXuat] CHECK CONSTRAINT [FK__ChiTietPh__hangh__3C69FB99]
GO
ALTER TABLE [dbo].[ChiTietPhieuXuat]  WITH CHECK ADD  CONSTRAINT [FK__ChiTietPh__khoma__3D5E1FD2] FOREIGN KEY([khoma])
REFERENCES [dbo].[Kho] ([ma])
GO
ALTER TABLE [dbo].[ChiTietPhieuXuat] CHECK CONSTRAINT [FK__ChiTietPh__khoma__3D5E1FD2]
GO
ALTER TABLE [dbo].[ChiTietPhieuXuat]  WITH CHECK ADD  CONSTRAINT [FK__ChiTietPh__phieu__3B75D760] FOREIGN KEY([phieuxuatma])
REFERENCES [dbo].[PhieuXuat] ([ma])
GO
ALTER TABLE [dbo].[ChiTietPhieuXuat] CHECK CONSTRAINT [FK__ChiTietPh__phieu__3B75D760]
GO
ALTER TABLE [dbo].[HangHoa]  WITH CHECK ADD FOREIGN KEY([nhomma])
REFERENCES [dbo].[Nhom] ([ma])
GO
ALTER TABLE [dbo].[PhieuNhap]  WITH CHECK ADD FOREIGN KEY([nhacungcapma])
REFERENCES [dbo].[NhaCungCap] ([ma])
GO
ALTER TABLE [dbo].[PhieuNhap]  WITH CHECK ADD FOREIGN KEY([khoma])
REFERENCES [dbo].[Kho] ([ma])
GO
ALTER TABLE [dbo].[PhieuNhap]  WITH CHECK ADD FOREIGN KEY([nhanvienma])
REFERENCES [dbo].[NhanVien] ([ma])
GO
ALTER TABLE [dbo].[PhieuXuat]  WITH CHECK ADD FOREIGN KEY([khachhangma])
REFERENCES [dbo].[KhachHang] ([ma])
GO
ALTER TABLE [dbo].[PhieuXuat]  WITH CHECK ADD FOREIGN KEY([khoma])
REFERENCES [dbo].[Kho] ([ma])
GO
ALTER TABLE [dbo].[PhieuXuat]  WITH CHECK ADD FOREIGN KEY([nhanvienma])
REFERENCES [dbo].[NhanVien] ([ma])
GO
/****** Object:  StoredProcedure [dbo].[procedure_insertChiTietPhieuXuat]    Script Date: 27/05/2017 7:24:51 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[procedure_insertChiTietPhieuXuat](@phieuxuatma varchar(20),@hanghoama varchar(20),@soluong int,@dongia float)
as
begin
declare @thanhtien money,@khoma varchar(20)
 set @thanhtien=@soluong*@dongia
begin
set @khoma=(select top(1) khoma from ChiTietPhieuNhap where hanghoama=@hanghoama)
insert into ChiTietPhieuXuat(ma,phieuxuatma,hanghoama,khoma,soluong,dongia,thanhtien)
values(dbo.auto_maCTPhieuXuat(),@phieuxuatma,@hanghoama,@khoma,@soluong,@dongia,@thanhtien)
update HangHoa set soluong=soluong-@soluong where ma=@hanghoama
end
end
GO
/****** Object:  StoredProcedure [dbo].[procedure_insertPhieuXuat]    Script Date: 27/05/2017 7:24:51 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[procedure_insertPhieuXuat](@khoma varchar(20),@noidung text,
@khachhangma varchar(20),@nhanvienma varchar(20),@tongtien money)
as
begin
declare @mapx varchar(20)
set		@mapx=dbo.auto_maPhieuXuat()
begin
insert into PhieuXuat(ma,ngay,khoma,noidung,khachhangma,nhanvienma,tongtien)
values(@mapx,GETDATE(),@khoma,@noidung,@khachhangma,@nhanvienma,@tongtien)
end
end

GO
USE [master]
GO
ALTER DATABASE [TTN_QLKho] SET  READ_WRITE 
GO
