USE [TTN_QLKho]
GO

-- TAO BANG BO MON

create table NhanVien
(
ma varchar(20) primary key,
ten nvarchar(50),
ngaysinh date,
gioitinh bit,
diachi nvarchar(50),
dienthoai int,
chucvu nvarchar(50)
)
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
kh_ma varchar(20),
nv_ma varchar(20)
FOREIGN KEY(kho_ma) REFERENCES DMKho(ma_kho),
FOREIGN KEY(kh_ma) REFERENCES DMKhachHang(ma_kh),
FOREIGN KEY(nv_ma) REFERENCES NhanVien(ma)

)

create table ChiTietPX
(
px_ma varchar(20),
hh_ma varchar(20) primary key,
ma_kho varchar(20),
so_luong int,
don_gia float,
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
kho_ma varchar(20),
nv_ma varchar(20)
FOREIGN KEY(kho_ma) REFERENCES DMKho(ma_kho),
FOREIGN KEY(ncc_ma) REFERENCES DMNhaCungCap(ma_ncc),
FOREIGN KEY(nv_ma) REFERENCES NhanVien(ma)

)



create table ChiTietPN
(
pn_soma varchar(20) ,
hh_ma varchar(20),
kho_ma varchar(20),
so_luong int , 
don_gia float,
FOREIGN KEY(pn_soma) REFERENCES PhieuNhap(maso_pn),
FOREIGN KEY(hh_ma) REFERENCES DMHangHoa(ma_hh)

)




INSERT INTO NhanVien VALUES('NV001' ,N'Nguyễn Văn An', '04/05/1992', '0' , N'Hà Nội','0123432567',N'Quản Lí'),
                            ('NV002' ,N'Lê Văn An', '04/08/1992', '0' , N'Hà Nội','0123432567',N'Dịch Vụ'),
							('NV003' ,N'Hoàng Văn Nam', '04/07/1992', '0' , N'Hà Nội','0123432567',N'Thu Ngân'),
							('NV004' ,N'Nguyễn Văn Bình', '10/05/1992', '0' , N'Hà Nội','0123432567',N'Bán Hàng'),
							('NV005' ,N'Nguyễn Văn Cường', '04/09/1992', '0' , N'Hà Nội','0123432567',N'Quản Lí')

--insert bảng danh mục kho , mã kho , tên kho

INSERT INTO DMKho VALUES('MK001',N'Kho chứa hàng thực phẩm'),
                        ('MK002',N'Kho chứa hàng xuất khẩu'),
						('MK003',N'Kho chứa hàng tồn đọng'),
						('MK004',N'Kho chứa hàng gia dụng'),
						('MK005',N'Kho chứa hàng may mặc')
                         
--insert bảng danh mục khách hàng : makh, tenkh , diachi, dien thoai, email


INSERT INTO DMKhachHang VALUES ('KH001',N'Nguyễn Văn An', N'Hà Nội','0123456789','nguyenan@gmail.com'),
                         ('KH002',N'Nguyễn Văn Hải', N'Hải phòng','0142367589','nguyenhai45@gmail.com'),
						 ('KH003',N'Nguyễn Văn Nam', N'Hà Nội','0126797859','nguyennan@gmail.com'),
						 ('KH004',N'Nguyễn Văn Bình', N'Hà giang','03985789','nguyenbinh@gmail.com'),
						 ('KH005',N'Nguyễn Văn Cường', N'Bắc giang','0987353289','nguyenan@gmail.com')

              


INSERT INTO DMNhom VALUES ('N001',N'nhóm hàng gia dụng '), 
						  ('N002',N'nhóm hàng thực phẩm '),   
						  ('N003',N'nhóm hàng tồn kho '),  
						  ('N004',N'nhóm hàng xuất khẩu'), 
						  ('N005',N'nhóm hàng may mặc')


					

INSERT INTO DMHangHoa VALUES ('HH001','gạo','N002'),
                              ('HH002','quần áo','N005'),
							   ('HH003','Mì tôm','N002'),
							    ('HH004','Bánh','N002'),
								 ('HH005','đồ gia công','N001')

	

INSERT INTO PhieuXuat VALUES ('PX001', '02/03/2015','MK001',N'Lê văn Nam' ,'nội dung nhận hàng' , 'KH001' ,'NV001'),
                             ('PX002', '02/03/2015','MK002',N'Lê văn Nam' ,'nội dung nhận hàng' , 'KH002','NV002'),
							 ('PX003', '02/03/2015','MK003',N'Lê văn Nam' ,'nội dung nhận hàng' , 'KH003','NV003'),
							 ('PX004', '02/03/2015','MK004',N'Lê văn Nam' ,'nội dung nhận hàng' , 'KH004','NV004'),
							 ('PX005', '02/03/2015','MK005',N'Lê văn Nam' ,'nội dung nhận hàng' , 'KH005','NV005')



INSERT INTO ChiTietPX VALUES ('PX001', 'HH001' , 'MK001' , '200' , '20.000'),
                             ('PX002', 'HH002' , 'MK002' , '200' , '20.000'),
							 ('PX003', 'HH003 ' , 'MK003' , '200' , '20.000'),
							 ('PX004', 'HH004' , 'MK004' , '200' , '20.000'),
							 ('PX005', 'HH005' , 'MK005' , '200' , '20.000')


INSERT INTO DMNhaCungCap VALUES ('NCC01' , N'Thực phẩm sạch HN' , N'Hà Nội' ,'0123546987', '0001' , 'thucphamHN@gmail.com'),
                                ('NCC02' , N'Hàng Gia Dụng HP' , N'Hải Phòng' ,'0123546987', '0001' , 'hanggiadungHP@gmail.com'),
								('NCC03' , N'Nhà May Việt Tín HN' , N'Hà Nội' ,'0123546987', '0001' , 'viettinHN@gmail.com'),
								('NCC04' , N'Tường AN' , N'Hà Nam' ,'0123546987', '0001' , 'tuonganHN@gmail.com'),
								('NCC05' , N'Hàng Xuất Khẩu Hà Nam HN' , N'Bắc Ninh' ,'0123546987', '0001' , 'xuatkhauhanam@gmail.com')




INSERT INTO PhieuNhap VALUES ('PN001', '04/05/2015', 'NCC01' , N'Nguyễn Văn Nam','nội dung nhập hàng bao nhiêu, số lượng hàng','MK001','NV001'),
                                ('PN002', '04/05/2015', 'NCC02' , N'Nguyễn Văn Bình','nội dung nhập hàng bao nhiêu, số lượng hàng','MK002','NV001'),
								('PN003', '04/05/2015', 'NCC03' , N'Nguyễn Văn An','nội dung nhập hàng bao nhiêu, số lượng hàng','MK003','NV001'),
								('PN004', '04/05/2015', 'NCC04' , N'Nguyễn Văn Bảo','nội dung nhập hàng bao nhiêu, số lượng hàng','MK004','NV001'),
								('PN005', '04/05/2015', 'NCC05' , N'Nguyễn Văn Hải','nội dung nhập hàng bao nhiêu, số lượng hàng','MK005','NV001')




INSERT INTO ChiTietPN VALUES ('PN001' , 'HH001' , 'MK001' , '400' ,'25.000000'),
                             ('PN002' , 'HH002' , 'MK002' , '400' ,'25.000000'),
							 ('PN003' , 'HH003' , 'MK003' , '400' ,'25.000000'),
							 ('PN004' , 'HH004' , 'MK004' , '400' ,'25.000000'),
							 ('PN005' , 'HH005' , 'MK005' , '400' ,'25.000000')