USE [master]
GO

USE [TTN_QLKho]
GO
/****** Object:  UserDefinedFunction [dbo].[auto_maCTPhieuXuat]    Script Date: 29/05/2017 9:01:45 CH ******/
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
/****** Object:  UserDefinedFunction [dbo].[auto_maKho]    Script Date: 29/05/2017 9:01:45 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[auto_maKho]() returns varchar(6)
as
begin
declare @ma varchar(6)
if(select count(ma) from Kho)=0
set @ma='0'
else 
select @ma=max(right(ma,4)) from Kho
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
/****** Object:  UserDefinedFunction [dbo].[auto_maPhieuNhap]    Script Date: 29/05/2017 9:01:45 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE function [dbo].[auto_maPhieuNhap]() returns varchar(5)
as
begin
declare @ma varchar(5)
if(select count(ma) from PhieuNhap)=0
set @ma='0'
else 
select @ma=max(right(ma,2)) from PhieuNhap
set @ma=case
when 
@ma>=0 and @ma<9 then 'PN00'+CONVERT(char,convert(int,@ma)+1)
when @ma>=9 and @ma<99 then 'PN0'+CONVERT(char,convert(int,@ma)+1)
when @ma>=99 and @ma<999 then 'PN'+CONVERT(char,convert(int,@ma)+1)
end
return 
@ma
end


GO
/****** Object:  UserDefinedFunction [dbo].[auto_maPhieuXuat]    Script Date: 29/05/2017 9:01:45 CH ******/
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
/****** Object:  Table [dbo].[ChiTietPhieuNhap]    Script Date: 29/05/2017 9:01:45 CH ******/
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
/****** Object:  Table [dbo].[ChiTietPhieuXuat]    Script Date: 29/05/2017 9:01:45 CH ******/
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
/****** Object:  Table [dbo].[HangHoa]    Script Date: 29/05/2017 9:01:45 CH ******/
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
/****** Object:  Table [dbo].[KhachHang]    Script Date: 29/05/2017 9:01:45 CH ******/
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
/****** Object:  Table [dbo].[Kho]    Script Date: 29/05/2017 9:01:45 CH ******/
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
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 29/05/2017 9:01:45 CH ******/
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
/****** Object:  Table [dbo].[NhanVien]    Script Date: 29/05/2017 9:01:45 CH ******/
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
/****** Object:  Table [dbo].[Nhom]    Script Date: 29/05/2017 9:01:45 CH ******/
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
/****** Object:  Table [dbo].[PhieuNhap]    Script Date: 29/05/2017 9:01:45 CH ******/
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
	[nhanvienma] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PhieuXuat]    Script Date: 29/05/2017 9:01:45 CH ******/
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
/****** Object:  StoredProcedure [dbo].[procedure_insertChiTietPhieuXuat]    Script Date: 29/05/2017 9:01:46 CH ******/
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
/****** Object:  StoredProcedure [dbo].[procedure_insertPhieuXuat]    Script Date: 29/05/2017 9:01:46 CH ******/
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
/****** Object:  StoredProcedure [dbo].[ProcGetList]    Script Date: 29/05/2017 9:01:46 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ProcGetList]
as
begin
	select pn.manguoigiao,pn.nhanvienma,ct_hh.ma as mahanghoa,ct_hh.soluong,ct_hh.nhomma,ct_hh.khoma,pn.noidung,ct_hh.dongia
	from   dbo.phieunhap pn
		   inner join(select  ct.phieunhapma,hh.ten,ct.soluong,ct.khoma,hh.ma,hh.nhomma,hh.dongia
					  from    dbo.ChiTietPhieuNhap ct
							   inner join dbo.HangHoa hh on ct.hanghoama = hh.ma
					  group by ct.phieunhapma,hh.ten,ct.soluong,ct.khoma,hh.ma,hh.nhomma,hh.dongia)
			as ct_hh
		on pn.ma = ct_hh.phieunhapma
  end

GO
/****** Object:  StoredProcedure [dbo].[ProcInsert]    Script Date: 29/05/2017 9:01:46 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ProcInsert]
	  @manguoigiaohang varchar(20),
	  @manguoinhaphang varchar(20),
	  @mahanghoa varchar(20),
	  @tenhanghoa nvarchar(50),
	  @soluong int,
	  @manhom varchar(20),
	  @dongia float,
	  @manhacungcap varchar(20),
	  @makho varchar(20),
	  @ngaynhap date,
	  @noidungnhap text 
	as
	  begin
	      if exists(select @mahanghoa from HangHoa where ma=@mahanghoa)
						   begin
						     insert into PhieuNhap(ma,ngay,nhacungcapma,manguoigiao,noidung,khoma,nhanvienma) values(dbo.auto_maPhieuNhap(),@ngaynhap,@manhacungcap,@manguoigiaohang,@noidungnhap,@makho,@manguoinhaphang)
							 declare @maphieunhap varchar(6)
							   select @maphieunhap =(select ma from PhieuNhap pn where pn.ngay=@ngaynhap and pn.nhacungcapma=@manhacungcap and pn.manguoigiao=@manguoigiaohang and pn.nhanvienma = @manguoinhaphang )
							   insert into ChiTietPhieuNhan(ma,phieunhanma,hanghoama,khoma,soluong,dongia) values(dbo.auto_maChiTietPhieuNhan(),@maphieunhap,@mahanghoa,@makho,@soluong,@dongia)
						   end
				   	   else
					      begin
						    insert into HangHoa(ma,ten,nhomma,dongia) values(dbo.auto_maHangHoa(),@tenhanghoa,@manhom,@dongia)
							declare @mahanghoamoi varchar(20)
							select @mahanghoamoi = (select ma from HangHoa where ten =@tenhanghoa)
							 insert into PhieuNhap(ma,ngay,nhacungcapma,manguoigiao,noidung,khoma,nhanvienma) values(dbo.auto_maPhieuNhap(),@ngaynhap,@manhacungcap,@manguoigiaohang,@noidungnhap,@makho,@manguoinhaphang)
							   select @maphieunhap =(select ma from PhieuNhap pn where pn.ngay=@ngaynhap and pn.nhacungcapma=@manhacungcap and pn.manguoigiao=@manguoigiaohang and pn.nhanvienma = @manguoinhaphang)
							   insert into ChiTietPhieuNhan(ma,phieunhanma,hanghoama,khoma,soluong,dongia) values(dbo.auto_maChiTietPhieuNhan(),@maphieunhap,@mahanghoamoi,@makho,@soluong,@dongia)
						  end
					 end



GO
/****** Object:  StoredProcedure [dbo].[ThemPhieuNhap]    Script Date: 29/05/2017 9:01:46 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ThemPhieuNhap]
 @nhanvienma varchar(20),
 @ngay date,
 @nhacungcapma varchar(20),
 @nguoigiaoma nvarchar(50),
 @noidung text,
 @khoma varchar(20)
 as
 begin 
   insert into PhieuNhap(ma,nhanvienma,ngay,nhacungcapma,manguoigiao,noidung,khoma) 
   values (dbo.auto_maPhieuNhap(),@nhanvienma,@ngay,@nhacungcapma,@nguoigiaoma,@noidung,@khoma)
 end

GO
/****** Object:  StoredProcedure [dbo].[ThemVaoChiTietPhieuNhap]    Script Date: 29/05/2017 9:01:46 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ThemVaoChiTietPhieuNhap]
@hanghoama varchar(20),
@soluong int,
@dongia float
as 
 begin 
	declare @phieunhapma varchar(20)
	select @phieunhapma = (select Max(ma) from PhieuNhap)
   insert into ChiTietPhieuNhap(ma,phieunhapma,hanghoama,soluong,dongia,thanhtien) values(dbo.auto_maChiTietPhieuNhap(),@phieunhapma,@hanghoama,@soluong,@dongia,@soluong*@dongia)
 end


GO
USE [master]
GO
ALTER DATABASE [TTN_QLKho] SET  READ_WRITE 
GO






-------------------------------------------------------30/5---------------------------------------------
   

   --1.



create proc [dbo].[DanhSachChiTietPhieuNhap]
as
begin
  declare @phieunhapma varchar(20)
  select @phieunhapma =(select max(ma) from PhieuNhap)
  select ct.ma as [Mã], ct.soluong as [Số lượng], ct.dongia as [Đơn giá], ct.thanhtien as [Thành tiền],
  ct.hanghoama as [Mã hàng hóa], ct.khoma as [Mã kho] from ChiTietPhieuNhap ct
  where ct.phieunhapma = @phieunhapma
end


--2.

create proc [dbo].[DanhSachPhieuNhap]
as
 begin
  select pn.ma as [Mã Phiếu], pn.manguoigiao as [Người giao hàng],pn.ngay as [Ngày],
 pn.nhacungcapma as [Mã nhà cung cấp], pn.nhanvienma as [Mã nhân viên], pn.noidung as [Nội dung] from PhieuNhap pn
 end



 --3.

 ALTER proc [dbo].[ThemPhieuNhap]
 @nhanvienma varchar(20),
 @ngay date,
 @nhacungcapma varchar(20),
 @nguoigiaoma nvarchar(50),
 @noidung text
 as
 begin 
   insert into PhieuNhap(ma,nhanvienma,ngay,nhacungcapma,manguoigiao,noidung) 
   values (dbo.auto_maPhieuNhap(),@nhanvienma,@ngay,@nhacungcapma,@nguoigiaoma,@noidung)
 end


 --4.

 ALTER proc [dbo].[ThemVaoChiTietPhieuNhap]
@hanghoama varchar(20),
@khoma varchar(20),
@soluong int,
@dongia money
as
 begin
  declare @phieunhapma varchar(20)
   select @phieunhapma = (select max(ma) from PhieuNhap)
  insert into ChiTietPhieuNhap(ma,phieunhapma,hanghoama,khoma,soluong,dongia,thanhtien)
  values(dbo.auto_maChiTietPhieuNhap(),@phieunhapma,@hanghoama,@khoma,@soluong,@dongia,@soluong*@dongia)
  end
  ---5/6 chinh sua cho nga---------
  CREATE function [dbo].[auto_maChiTietPhieuNhap]() returns varchar(8)
as
begin
declare @ma varchar(8)
if(select count(ma) from ChiTietPhieuNhap)=0
set @ma='0'
else 
select @ma=max(right(ma,4)) from ChiTietPhieuNhap
set @ma=case
when 
@ma>=0 and @ma<9 then 'CTPN000'+CONVERT(char,convert(int,@ma)+1)
when @ma>=9 and @ma<99 then 'CTPN00'+CONVERT(char,convert(int,@ma)+1)
when @ma>=99 and @ma<999 then 'CTPN0'+CONVERT(char,convert(int,@ma)+1)
end
return 
@ma
end
GO