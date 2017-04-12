USE [TTN_QLKho]
GO

-- TAO BANG BO MON

create table DMKho
(
ma_kho varchar(20) primary key,
ten_kho nvarchar(50)
)


create table DMKhachHang
(
ma_kh varchar(20) primary key,
ten_kh nvarchar(50),
diachi_kh nvarchar(50),
dienthoai_kh varchar(20),
Email varchar(50),
)

create table DMNhom
(
ma_nhom varchar(20) primary key,
ten_nhom nvarchar(50)
)


create table DMHangHoa
(
ma_hh varchar(20) primary key,
ten_hh nvarchar(50),
nhom_ma varchar(20),
FOREIGN KEY(nhom_ma) REFERENCES DMNhom(ma_nhom)

)

CREATE TABLE PhieuXuat
(
maso_px varchar(20) primary key,
ngayCT date,
kho_ma varchar(20),
nguoi_nhan nvarchar(50),
noidung text,
kh_ma varchar(20)
FOREIGN KEY(kho_ma) REFERENCES DMKho(ma_kho),
FOREIGN KEY(kh_ma) REFERENCES DMKhachHang(ma_kh)

)

create table ChiTietPX
(
px_ma varchar(20),
hh_ma varchar(20) primary key,
ma_kho varchar(20),
so_luong int,
don_gia money,
FOREIGN KEY(px_ma) REFERENCES PhieuXuat(maso_px),
FOREIGN KEY(hh_ma) REFERENCES DMHangHoa(ma_hh)

)

create table DMNhaCungCap
(
ma_ncc varchar(20) primary key,
ten_ncc nvarchar(50),
diachi nvarchar(50),
dienthoai varchar(20),
masothue int,
email varchar(50)
)


create table PhieuNhap
(
maso_pn varchar(20) primary key,
ngayCT date,
ncc_ma varchar(20),
nguoi_giao nvarchar(50),
noidung text,
kho_ma varchar(20)
FOREIGN KEY(kho_ma) REFERENCES DMKho(ma_kho),
FOREIGN KEY(ncc_ma) REFERENCES DMNhaCungCap(ma_ncc)

)



create table ChiTietPN
(
pn_soma varchar(20) ,
hh_ma varchar(20),
kho_ma varchar(20),
so_luong int , 
don_gia money,
FOREIGN KEY(pn_soma) REFERENCES PhieuNhap(maso_pn),
FOREIGN KEY(hh_ma) REFERENCES DMHangHoa(ma_hh)

)

