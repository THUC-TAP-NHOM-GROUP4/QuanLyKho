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


create table Kho
(
ma varchar(20) primary key,
ten nvarchar(50)
)


create table KhachHang
(
ma varchar(20) primary key,
ten nvarchar(50),
diachi nvarchar(50),
dienthoai varchar(20),
Email varchar(50),
)

create table Nhom
(
ma varchar(20) primary key,
ten nvarchar(50)
)


create table HangHoa
(
ma varchar(20) primary key,
ten nvarchar(50),
nhomma varchar(20),
FOREIGN KEY(nhomma) REFERENCES Nhom(ma)
)

CREATE TABLE PhieuXuat
(
ma varchar(20) primary key,
ngay date,
khoma varchar(20),
manguoinhan varchar(20),
noidung text,
khachhangma varchar(20),
nhanvienma varchar(20)
FOREIGN KEY(khoma) REFERENCES Kho(ma),
FOREIGN KEY(khachhangma) REFERENCES KhachHang(ma),
FOREIGN KEY(nhanvienma) REFERENCES NhanVien(ma)

)

create table ChiTietPhieuXuat
(
ma varchar(20) primary key,
phieuxuatma varchar(20),
hanghoama varchar(20),
khoma varchar(20),
soluong int,
dongia float,
thanhtien money,
FOREIGN KEY(phieuxuatma) REFERENCES PhieuXuat(ma),
FOREIGN KEY(hanghoama) REFERENCES HangHoa(ma),
FOREIGN KEY(khoma) REFERENCES Kho(ma)
)

create table NhaCungCap
(
ma varchar(20) primary key,
ten nvarchar(50),
diachi nvarchar(50),
dienthoai varchar(20),
masothue int,
email varchar(50)
)


create table PhieuNhap
(
ma varchar(20) primary key,
ngay date,
nhacungcapma varchar(20),
manguoigiao varchar(20),
noidung text,
khoma varchar(20),
nhanvienma varchar(20)
FOREIGN KEY(khoma) REFERENCES Kho(ma),
FOREIGN KEY(nhacungcapma) REFERENCES NhaCungCap(ma),
FOREIGN KEY(nhanvienma) REFERENCES NhanVien(ma)

)



create table ChiTietPhieuNhap
(
ma varchar(20) primary key ,
phieunhapma varchar(20),
hanghoama varchar(20),
khoma varchar(20),
soluong int , 
dongia float,
thanhtien money,
FOREIGN KEY(phieunhapma) REFERENCES PhieuNhap(ma),
FOREIGN KEY(hanghoama) REFERENCES HangHoa(ma),
FOREIGN KEY(khoma) REFERENCES Kho(ma)
)



INSERT INTO NhanVien VALUES('NV001' ,N'Nguyễn Văn An', '04/05/1992', '0' , N'Hà Nội','0123432567',N'Quản Lí'),
                            ('NV002' ,N'Lê Văn An', '04/08/1992', '0' , N'Hà Nội','0123432567',N'Dịch Vụ'),
							('NV003' ,N'Hoàng Văn Nam', '04/07/1992', '0' , N'Hà Nội','0123432567',N'Thu Ngân'),
							('NV004' ,N'Nguyễn Văn Bình', '10/05/1992', '0' , N'Hà Nội','0123432567',N'Bán Hàng'),
							('NV005' ,N'Nguyễn Văn Cường', '04/09/1992', '0' , N'Hà Nội','0123432567',N'Quản Lí')

--insert bảng danh mục kho , mã kho , tên kho

INSERT INTO Kho VALUES('MK001',N'Kho chứa hàng thực phẩm'),
                        ('MK002',N'Kho chứa hàng xuất khẩu'),
						('MK003',N'Kho chứa hàng tồn đọng'),
						('MK004',N'Kho chứa hàng gia dụng'),
						('MK005',N'Kho chứa hàng may mặc')
                         
--insert bảng danh mục khách hàng : makh, tenkh , diachi, dien thoai, email


INSERT INTO KhachHang VALUES ('KH001',N'Nguyễn Văn An', N'Hà Nội','0123456789','nguyenan@gmail.com'),
                         ('KH002',N'Nguyễn Văn Hải', N'Hải phòng','0142367589','nguyenhai45@gmail.com'),
						 ('KH003',N'Nguyễn Văn Nam', N'Hà Nội','0126797859','nguyennan@gmail.com'),
						 ('KH004',N'Nguyễn Văn Bình', N'Hà giang','03985789','nguyenbinh@gmail.com'),
						 ('KH005',N'Nguyễn Văn Cường', N'Bắc giang','0987353289','nguyenan@gmail.com')

              


INSERT INTO Nhom VALUES ('N001',N'nhóm hàng gia dụng '), 
						  ('N002',N'nhóm hàng thực phẩm '),   
						  ('N003',N'nhóm hàng tồn kho '),  
						  ('N004',N'nhóm hàng xuất khẩu'), 
						  ('N005',N'nhóm hàng may mặc')


					

INSERT INTO HangHoa VALUES ('HH001','gạo','N002'),
                              ('HH002','quần áo','N005'),
							   ('HH003','Mì tôm','N002'),
							    ('HH004','Bánh','N002'),
								 ('HH005','đồ gia công','N001')

	

INSERT INTO PhieuXuat VALUES ('PX001', '02/03/2015','MK001','NN001' ,'nội dung nhận hàng' , 'KH001' ,'NV001'),
                             ('PX002', '02/03/2015','MK002','NN002' ,'nội dung nhận hàng' , 'KH002','NV002'),
							 ('PX003', '02/03/2015','MK003','NN003' ,'nội dung nhận hàng' , 'KH003','NV003'),
							 ('PX004', '02/03/2015','MK004','NN004' ,'nội dung nhận hàng' , 'KH004','NV004'),
							 ('PX005', '02/03/2015','MK005','NN005' ,'nội dung nhận hàng' , 'KH005','NV005')



INSERT INTO ChiTietPhieuXuat VALUES ('CTPX001','PX001', 'HH001' , 'MK001' , '200' , '20.000'),
                             ('CTPX002','PX002', 'HH002' , 'MK002' , '200' , '20.000'),
							 ('CTPX003','PX003', 'HH003 ' , 'MK003' , '200' , '20.000'),
							 ('CTPX004','PX004', 'HH004' , 'MK004' , '200' , '20.000'),
							 ('CTPX005','PX005', 'HH005' , 'MK005' , '200' , '20.000')


INSERT INTO NhaCungCap VALUES ('NCC01' , N'Thực phẩm sạch HN' , N'Hà Nội' ,'0123546987', '0001' , 'thucphamHN@gmail.com'),
                                ('NCC02' , N'Hàng Gia Dụng HP' , N'Hải Phòng' ,'0123546987', '0001' , 'hanggiadungHP@gmail.com'),
								('NCC03' , N'Nhà May Việt Tín HN' , N'Hà Nội' ,'0123546987', '0001' , 'viettinHN@gmail.com'),
								('NCC04' , N'Tường AN' , N'Hà Nam' ,'0123546987', '0001' , 'tuonganHN@gmail.com'),
								('NCC05' , N'Hàng Xuất Khẩu Hà Nam HN' , N'Bắc Ninh' ,'0123546987', '0001' , 'xuatkhauhanam@gmail.com')




INSERT INTO PhieuNhap VALUES ('PN001', '04/05/2015', 'NCC01' , N'Nguyễn Văn Nam','nội dung nhập hàng bao nhiêu, số lượng hàng','MK001','NV001'),
                                ('PN002', '04/05/2015', 'NCC02' , N'Nguyễn Văn Bình','nội dung nhập hàng bao nhiêu, số lượng hàng','MK002','NV001'),
								('PN003', '04/05/2015', 'NCC03' , N'Nguyễn Văn An','nội dung nhập hàng bao nhiêu, số lượng hàng','MK003','NV001'),
								('PN004', '04/05/2015', 'NCC04' , N'Nguyễn Văn Bảo','nội dung nhập hàng bao nhiêu, số lượng hàng','MK004','NV001'),
								('PN005', '04/05/2015', 'NCC05' , N'Nguyễn Văn Hải','nội dung nhập hàng bao nhiêu, số lượng hàng','MK005','NV001')




INSERT INTO ChiTietPhieuNhan VALUES ('CTPN001','PN001' , 'HH001' , 'MK001' , '400' ,'25.000000'),
                             ('CTPN002','PN002' , 'HH002' , 'MK002' , '400' ,'25.000000'),
							 ('CTPN003','PN003' , 'HH003' , 'MK003' , '400' ,'25.000000'),
							 ('CTPN004','PN004' , 'HH004' , 'MK004' , '400' ,'25.000000'),
							 ('CTPN005','PN005' , 'HH005' , 'MK005' , '400' ,'25.000000')