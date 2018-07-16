
Use Master
go
if Exists(select *From Sys.databases Where name='QLNS')
Drop database QLNS
go
create database QLNS
go
Use QLNS
go
--format thoi gian--
set dateformat dmy
-----------------------------------------nho giao dien
go
if Exists(select *From Sys.tables Where name='nhogiaodien')
Drop table nhogiaodien
go
create table nhogiaodien
(
	skin nvarchar(100)
)
go
insert into nhogiaodien values('Money Twins')
go
-----------------------------------------nho tai khoan
if Exists(select *From Sys.tables Where name='NhoTaikhoan')
Drop table NhoTaikhoan
go
create table NhoTaikhoan
(
	taikhoan nvarchar(36)
)
go
insert into NhoTaikhoan values('')
go
-----------------------------------------user
go
if Exists(select *From Sys.tables Where name='Taikhoan')
Drop table Taikhoan
go
create table Taikhoan
(
	hoten		nvarchar(36),
	ten			nvarchar(26) not null primary key,
	matkhau		nvarchar(26) not null,
	quyen		smallint
)
go
insert into Taikhoan values(N'Nguyễn Tính',N'Nguyễn Tính','nguyentinh',0)
insert into Taikhoan values(N'Hồ hoàng An',N'Hoàng An','hoangan',1)
insert into Taikhoan values(N'Admin',N'Admin','admin',2)
go
-- Tinh
if Exists(select *From Sys.tables Where name='Tinh')
Drop table Tinh
go
create table Tinh
(
	id	nvarchar(5) not null primary key,
	TenTinh	nvarchar(50)
)
go
-- Tien luong
if Exists(select *From Sys.tables Where name='Tienluong')
Drop table Tienluong
go
create table Tienluong
(
	tien	real,
	thangTL	smallint,
	namTL	smallint,
	constraint p_tl primary key(thangTL,namTL)
)
go
insert into Tienluong values (2400000,'2','2011')
insert into Tienluong values (2500000,'5','2013')
go
-- DanToc
if Exists(select *From Sys.tables Where name='DanToc')
Drop table DanToc
go
create table DanToc
(
	id	nvarchar(2) not null primary key,
	TenDanToc	nvarchar(50)
)
go
-- Bo Phan
if Exists(select * From Sys.tables Where name='BoPhan')
Drop table BoPhan
go
create table BoPhan
(
	MaBoPhan	nvarchar(10) not null primary key,
	TenBoPhan	nvarchar(50)
)
go
-- Chi tiet CMNN
if Exists(select * From Sys.tables Where name='CTChungminhnhandan')
Drop table CTChungminhnhandan
go
create table CTChungminhnhandan
(
	Socmnd	nvarchar(10) not null primary key,
	noicap	nvarchar(70),
	ngaycap date
)
go
-- Chuc vu
if Exists(select * From Sys.tables Where name='ChucVu')
Drop table ChucVu
go
create table ChucVu
(
	machucvu	nvarchar(2) not null primary key,
	tenchucvu	nvarchar(50),
	hsl			float,
)
go
-- NhanVien
if Exists(select *From Sys.tables Where name='NhanVien')
Drop table NhanVien
go
create table NhanVien
(
	MaNV		nvarchar(10) not null primary key,-- khoa chinh, ngoai
	HoLot		nvarchar(30) not null,
	Ten			nvarchar(10) not null,
	MaThe		nvarchar(10),
	MaBoPhan	nvarchar(10), --not null foreign key (MaBoPhan) references BoPhan ON DELETE CASCADE ON UPDATE CASCADE , -- QTKD / khoa ngoai
	ATM			nvarchar(20),
	thoiviec	nvarchar(1), -- 1 la da thoi viec,0 la con lam
	machucvu		nvarchar(2),-- not null foreign key (maChucvu) references Chucvu ON DELETE CASCADE ON UPDATE CASCADE, -- 1 là thu viec,0 la lam chinh thuc
	GioiTinh		nvarchar(2),-- not null, -- Nam or Nữ
	NgaySinh	date,-- not null,
	Anh			Image,   -- tam thoi null;
	QueQuan		nvarchar(70),--not null foreign key (QueQuan) references Tinh ON DELETE CASCADE ON UPDATE CASCADE,
	HKTT		nvarchar(70),		   -- Ho khau thuong tru
	CMND		nvarchar(10),-- not null,
	NgayLamViec	date,-- not null,
	BangCap		nvarchar(20),
	TTHonNhan	nvarchar(2),-- not null,  -- 1:Co GD || 0:Doc Than
	DanToc		nvarchar(2),--not null foreign key (DanToc) references DanToc ON DELETE CASCADE ON UPDATE CASCADE,
	QuocTich	nvarchar(30),
	SDT			nvarchar(11),
)
go
-- danh muc bao hiem
if Exists(select * From Sys.tables Where name='NVnghiviec')
Drop table NVnghiviec
go
create table NVnghiviec
(
	manv nvarchar(10) not null,
	ngay date not null,
	CONSTRAINT P_NV PRIMARY KEY (Manv)
)
go
-- danh muc bao hiem
if Exists(select * From Sys.tables Where name='DMBaoHiem')
Drop table DMBaoHiem
go
create table DMBaoHiem
(
	sobaohiem nvarchar(20),
	manv nvarchar(10) not null foreign key (manv) references NhanVien ON DELETE CASCADE ON UPDATE CASCADE ,
	loaibaohiem nvarchar(2),
	ngaycap date,
	noicap nvarchar(70),
	noikhambenh nvarchar(70),
	ngaynghiviec date,
	CONSTRAINT P_BH PRIMARY KEY (sobaohiem)
)
go
alter table DMBaoHiem add constraint F_BH_NV foreign key (Manv) references Nhanvien
go

-------------------
--ngay 1-3-2013
-- bang Hop Dong
if Exists(select *From Sys.tables Where name='LoaiHD')
Drop table LoaiHD
go
create table LoaiHD
(
	loaihd		int primary key not null,
	tenloai		nvarchar(50)	not null,
	thoihan		int				not null,
	hsl			float(5)		not null,
)

if Exists(select *From Sys.tables Where name='HopDong')
Drop table HopDong
go
create table HopDong
(

	sohd		nvarchar(10) not null,
	manv		nvarchar(10) not null,
	loaihd		int not null,
	ngaykihd	date,
	ngayhd		date,
	ngayhh		date,
	kilanthu	int,
	dieukhoan	nvarchar(255),
	constraint P_hd primary key (sohd,manv) ,
	constraint f_fhd foreign key (loaihd) references LoaiHD(loaihd)ON DELETE CASCADE ON UPDATE CASCADE
)
-------------------
go
--tao id nhan vien tu dong
if exists (select * from sys.tables where name='IdNhanvien')
drop table IdNhanvien
go 
create table IdNhanvien
(
	Id	int not null primary key,
)
go
-- tenviet tat cua ma nhan vien
if exists (select * from sys.tables where name='TenVietTatMaNV')
drop table TenVietTatMaNV
go 
create table TenVietTatMaNV
(
	TenVT	nvarchar(10) not null primary key,
)
go
--tao id hop dong
if exists (select * from sys.tables where name='IdHopDong')
drop table IdHopDong
go 
create table IdHopDong
(
	Id	int not null primary key,
)

go
-- du lieu id hop dong tu dong
insert into IdHopDong values (0);
go
-- du lieu id ma nhan vien tu dong
insert into IdNhanvien values (0);
go

-- Ten viet tat cong ty, hop dong
--tao id hop dong
if exists (select * from sys.tables where name='TenCT')
drop table TenCT
go 
create table TenCT
(
	TenCT	nvarchar(10) not null primary key,
)
go
-- luu tru ten tai khoang khi dang nhap
if exists (select * from sys.tables where name='storeTaikhoan')
drop table storeTaikhoan
go 
create table storeTaikhoan
(
	TenTk	nvarchar(30) not null primary key,
)
-- them du lieu cua bang storeTaikhoan
insert into storeTaikhoan values ('');
-- du lieu ten viet tat tu tao ma hop dong
insert into TenCT values ('SF_');
go
-- du lieu ten viet tat tu tao ma nhan vien
insert into TenVietTatMaNV values ('SFNV_');
go
-- du lieu bang Tinh
insert into Tinh values ('01',N'Đồng Tháp')
insert into Tinh values ('02',N'Quảng Ngãi')
insert into Tinh values ('03',N'Long An')
go
-- du lieu bang dan toc
insert into DanToc values ('01',N'Kinh')
insert into DanToc values ('02',N'Khơ Me')
insert into DanToc values ('03',N'Tày')
go
-- du lieu bang BoPhan
insert into BoPhan values ('001',N'Kế Toán')
insert into BoPhan values ('002',N'Kinh Danh')
insert into BoPhan values ('003',N'Xuất Nhập Khẩu')
insert into BoPhan values ('004',N'Tiếp Tân')
insert into BoPhan values ('005',N'Trợ Lý Tổng Giám Đốc')
insert into BoPhan values ('006',N'Láp Ráp')
insert into BoPhan values ('007',N'Thành Hình')
insert into BoPhan values ('008',N'Phun Sơn')
insert into BoPhan values ('009',N'Gia Công')
go
-- them du lieu cho bang chuc vu
insert into ChucVu values ('0',N'Nhân viên',1.0)
insert into ChucVu values ('1',N'Ca trưởng',1.2)
insert into ChucVu values ('2',N'Tổ trưởng',1.4)
insert into ChucVu values ('3',N'Xưởng trưởng',1.6)
-- them du lieu cho bang CMND
insert into CTChungminhnhandan values ('123456789','Công an Đồng Tháp','20/01/2008')
insert into CTChungminhnhandan values ('589632145','Công an Quảng Ngãi','18/09/2010')
insert into CTChungminhnhandan values ('852741963','Công an Hà Tĩnh','05/01/2011')
-- du lieu bang nhan vien
insert into NhanVien values ('00001',N'Võ Nguyễn Lộc',N'Tính','00001','001','210000125511',
							'1','0','1','01-01-1992','',N'Đồng Tháp',N'Ấp 5A trường Xuân, Tháp Mười, Đồng Tháp',
                                '123456789','20-05-2010',N'Cao Đẳng','0','01',N'Việt Nam','01212181202')
insert into NhanVien values ('00002',N'Hồ Hoàng',N'An','00002','002','210000125512',
							'1','1','1','20/2/1992','',N'Quảng Ngãi',N'Ấp soài Châu Thành, Mộ Đức, Quãng Ngãi',
                                '589632145','14/3/2011',N'Cao Đẳng','1','01',N'Việt Nam','01669587451')
insert into NhanVien values ('00003',N'Nguyễn Thị',N'Lài','00003','003','210000125513',
							'1','2','0','3/4/1993','',N'Sóc Trang',N'Ấp soài Châu Thành, Mộ Đức, Quãng Ngãi',
                                '852741963','15/3/2011',N'Đại Học','0','02',N'Việt Nam','01234567889')
insert into NhanVien values ('00004',N'Nguyễn Thị Ngọc',N'Tuyết','00004','003','54546',
							'0','2','0','14/2/1995','',N'Tiền Giang',N'Cái Bè Tiền Giang',
                                '852741963','15/3/2011',N'Đại Học','0','02',N'Việt Nam','01234567889')
go
insert into NVnghiviec values ('00004','20/2/2012')
go
-- du lieu bang bao hiem
insert into DMBaoHiem values
 ('0012365212','00001','yt','20/5/2010',N'Bệnh viện đa khoa huyện Tân Thành, BRVT',N'Bệnh viện đa khoa huyện Tân Thành, BRVT','13/7/2010')
 insert into DMBaoHiem values
 ('8574523621','00002','yt','22/3/2010',N'Bệnh viện Quân 9 miền đông, Quận 9, TP HCM, BRVT',N'Bệnh viện Quân 9 miền đông, Quận 9, TP HCM','3/8/2010')
 insert into DMBaoHiem values
 ('8745874587','00003','yt','1/5/2010',N'Bệnh viện Y Dược, quận 5, TP HCM',N'Bệnh viện Y Dược, quận 5, TP HCM','20/10/2010')
 insert into DMBaoHiem values
 ('8565885541','00001','tn','20/5/2010',N'Bệnh viện đa khoa huyện Tân Thành, BRVT',N'Bệnh viện đa khoa huyện Tân Thành, BRVT','13/7/2010')
 insert into DMBaoHiem values
 ('8855445566','00002','tn','22/3/2010',N'Bệnh viện Quân 9 miền đông, Quận 9, TP HCM, BRVT',N'Bệnh viện Quân 9 miền đông, Quận 9, TP HCM','3/8/2010')
 insert into DMBaoHiem values
 ('9658741254','00003','tn','1/5/2010',N'Bệnh viện Y Dược, quận 5, TP HCM',N'Bệnh viện Y Dược, quận 5, TP HCM','20/10/2010')

--Loai HD
insert into LoaiHD values(1,N'3 tháng',3,1.1)
insert into LoaiHD values(2,N'6 tháng',6,1.1)
insert into LoaiHD values(3,N'1 năm',12,1.1)
insert into LoaiHD values(4,N'2 năm',24,1.1)
insert into LoaiHD values(5,N'Không thời hạn',0,1.1)

go
-- Bang Ung luong
if exists (select * from sys.tables where name='QLUngLuong')
drop table QLUngLuong
go 
create table QLUngLuong
(
	manv		nvarchar(10) not null,
	ngay		nvarchar(2) not null,
	thang		nvarchar(2) not null, 
	nam			nvarchar(4) not null,
	tien		real,
	trangthai	bit,--0 :chua tra, 1:da tra
	constraint p_ul primary key (manv,ngay,thang,nam),
	constraint f_ul_nv foreign key (manv) references NhanVien on delete cascade   on  UPDATE cascade
)
--insert ung luong
go
insert into QLUngLuong values
('00001',1,1,2013,500000,1),
('00001',12,3,2013,500000,0),
('00002',1,1,2013,500000,0),
('00002',1,2,2013,500000,1),
('00003',13,1,2013,500000,1),
('00004',15,12,2013,500000,0)

-- luu hinh anh vao

go
create proc saveImage
(
	@manv nvarchar(10),
	@image image
)
as
begin 
	 update NhanVien set Anh=@image where MaNV=@manv
end
go

-- lay tat ca hinh anh trong bang nhan vien
go
create proc getAllImage
as
begin
	select manv, anh from nhanvien
end
go
-- lay ra hinh anh theo ma nhan vien
create proc getImg
(
	@manv nvarchar(10)
)
as
begin 
	select anh from NhanVien where MaNV = @manv
end
go

create view Report_NhanVien
as
SELECT distinct nv.MaNV, nv.HoLot, nv.Ten,nv.GioiTinh, nv.NgaySinh,bp.TenBoPhan,cv.tenchucvu,hd.sohd, nv.QueQuan,nv.SDT,nv.thoiviec
FROM (((NhanVien nv left outer join DMBaoHiem bh on nv.MaNV=bh.manv)
left outer join HopDong hd on hd.manv=nv.MaNV)
left outer join ChucVu cv on cv.machucvu=nv.machucvu)
left outer join BoPhan bp on bp.MaBoPhan=nv.MaBoPhan

-- ngay 20/03/2013
-- DMCOng
go
if Exists(select *From Sys.tables Where name='DMLoaiCong')
Drop table DMLoaiCong
go
create table DMLoaiCong
(
	maloai		nvarchar(10) not null,
	tenloai		nvarchar(100),
	heso		float,
	constraint p_lc	primary key (maloai)
)

if Exists(select *From Sys.tables Where name='LoaiCa')
Drop table LoaiCa
go
create table LoaiCa
(
	maloai		nvarchar(10) primary key,
	tenca		nvarchar(100),
	heso		float
)
go
insert into LoaiCa values ('tct',N'Tăng ca thường',2),
('tcd',N'Tăng ca đêm',2.5),
('tccn',N'Tăng ca chủ nhật',3),
('tcl',N'Tăng ca lễ',3)
if Exists(select *From Sys.tables Where name='QLTangCa')
Drop table QLTangCa
go
create table QLTangCa
(
	manv		nvarchar(10) not null,
	maloaica	nvarchar(10) not null,
	ngay		smallint not null,
	thang		smallint not null,
	nam			smallint not null,
	sogio		int
	
	constraint p_qltc primary key(manv,ngay,thang,nam)
	constraint f_qltc_lc foreign key (maloaica) references Loaica on delete cascade on update cascade
)
go
insert into QLTangCa values ('00001','tct',1,1,2012,4),
('00001','tct',10,1,2012,4),
('00001','tct',2,1,2012,4),
('00001','tct',3,1,2012,4),
('00001','tcd',4,1,2012,4),
('00001','tct',5,1,2012,4),
('00001','tct',6,1,2012,4),
('00001','tct',7,1,2012,4),
('00001','tccn',8,1,2012,4),
('00001','tct',9,1,2012,4),
('00002','tct',1,1,2012,4),
('00002','tct',2,1,2012,4),
('00002','tct',3,1,2012,4),
('00002','tcd',4,1,2012,4),
('00002','tct',5,1,2012,4),
('00002','tct',6,1,2012,4),
('00002','tct',7,1,2012,4),
('00002','tccn',8,1,2012,4),
('00002','tct',9,1,2012,4)
go
if Exists(select *From Sys.tables Where name='DMPhuCap')
Drop table DMPhuCap
go
create table DMPhuCap
(
	maloaipc		nvarchar(10) not null primary key,
	tenloai		nvarchar(100),
	tien		real,
)

if Exists(select *From Sys.tables Where name='ChiTietPhuCap')
Drop table ChiTietPhuCap
go
create table ChiTietPhuCap
(
	maloaipc	nvarchar(10) not null,
	manv		nvarchar(10),
	constraint p_ctpc primary key (maloaipc,manv),
	constraint f_pc_nv foreign key (manv) references nhanvien on delete cascade on update cascade,
	constraint f_ctpc_pc foreign key (maloaipc) references DMPhucap on delete cascade on update cascade,
)
go
-- bảng công nhân viên
if Exists(select *From Sys.tables Where name='BangCong')
Drop table BangCong
go
create table BangCong
(
	manv			nvarchar(10) not null,
	maloaicong		nvarchar(10),
	ngay			smallint not null,
	thang			smallint not null,
	nam				int not null,
	giovao			smallint,
	giora			smallint,
	phutvao			smallint,
	phutra			smallint,
	constraint P_PC primary key (manv,ngay,thang,nam),
	constraint f_bc_lc foreign key (maloaicong) references DMLoaiCong on delete cascade on update cascade,
	constraint f_bc_nv foreign key (manv) references NhanVien on delete cascade on update cascade
)
go
-- insert du lieu
insert into DMLoaiCong values ('1',N'Cả ngày',1)
insert into DMLoaiCong values ('1/2',N'Nửa ngày',0.5)
insert into DMLoaiCong values ('K',N'Nghỉ không phép',0)
insert into DMLoaiCong values ('P',N'Nghỉ có phép',1)
insert into DMLoaiCong values ('PN',N'Phép năm',1)
insert into DMLoaiCong values ('PR',N'Phép riêng',1)
insert into DMLoaiCong values ('R1',N'Nghỉ hưởng nửa ngày',1)
insert into DMLoaiCong values ('R0',N'Nghỉ việc không lương',0)
insert into DMLoaiCong values ('8/Ca',N'8 Giờ 1 ca',1)
go
-- du lieu bang cong
insert into Bangcong values ('00001','P',1,1,2012,7,20,4,35)
insert into Bangcong values ('00001','1',2,1,2012,7,20,4,35)
insert into Bangcong values ('00001','1',3,1,2012,7,20,4,35)
insert into Bangcong values ('00001','1',4,1,2012,7,20,4,35)
insert into Bangcong values ('00001','1',5,1,2012,7,20,4,35)
insert into Bangcong values ('00001','1',6,1,2012,7,20,4,35)
insert into Bangcong values ('00001','1',7,1,2012,7,20,4,35)
insert into Bangcong values ('00001','1',9,1,2012,7,20,4,35)
insert into Bangcong values ('00001','K',10,1,2012,7,20,4,35)
insert into Bangcong values ('00001','1',11,1,2012,7,20,4,35)
insert into Bangcong values ('00001','1',12,1,2012,7,20,4,35)
insert into Bangcong values ('00001','1',13,1,2012,7,20,4,35)
insert into Bangcong values ('00001','1',14,1,2012,7,20,4,35)
insert into Bangcong values ('00001','1',16,1,2012,7,20,4,35)
insert into Bangcong values ('00001','1',17,1,2012,7,20,4,35)
insert into Bangcong values ('00001','1',18,1,2012,7,20,4,35)
insert into Bangcong values ('00001','1',19,1,2012,7,20,4,35)
insert into Bangcong values ('00001','1',20,1,2012,7,20,4,35)
insert into Bangcong values ('00001','1',21,1,2012,7,20,4,35)
insert into Bangcong values ('00001','1',23,1,2012,7,20,4,35)
insert into Bangcong values ('00001','1',24,1,2012,7,20,4,35)
insert into Bangcong values ('00001','1',25,1,2012,7,20,4,35)
insert into Bangcong values ('00001','1',26,1,2012,7,20,4,35)
insert into Bangcong values ('00001','1',27,1,2012,7,20,4,35)
insert into Bangcong values ('00001','1',28,1,2012,7,20,4,35)
insert into Bangcong values ('00001','1',30,1,2012,7,20,4,35)
insert into Bangcong values ('00001','1',31,1,2012,7,20,4,35)

insert into Bangcong values ('00002','P',1,1,2012,7,20,4,35)
insert into Bangcong values ('00002','1',2,1,2012,7,20,4,35)
insert into Bangcong values ('00002','1',3,1,2012,7,20,4,35)
insert into Bangcong values ('00002','1',4,1,2012,7,20,4,35)
insert into Bangcong values ('00002','1',5,1,2012,7,20,4,35)
insert into Bangcong values ('00002','1',6,1,2012,7,20,4,35)
insert into Bangcong values ('00002','1',7,1,2012,7,20,4,35)
insert into Bangcong values ('00002','P',8,1,2012,7,20,4,35)
insert into Bangcong values ('00002','1',9,1,2012,7,20,4,35)
insert into Bangcong values ('00002','1',10,1,2012,7,20,4,35)
insert into Bangcong values ('00002','1',11,1,2012,7,20,4,35)
insert into Bangcong values ('00002','1',12,1,2012,7,20,4,35)
insert into Bangcong values ('00002','1',13,1,2012,7,20,4,35)
insert into Bangcong values ('00002','1',14,1,2012,7,20,4,35)
insert into Bangcong values ('00002','1',16,1,2012,7,20,4,35)
insert into Bangcong values ('00002','1',17,1,2012,7,20,4,35)
insert into Bangcong values ('00002','1',18,1,2012,7,20,4,35)
insert into Bangcong values ('00002','1',19,1,2012,7,20,4,35)
insert into Bangcong values ('00002','1',20,1,2012,7,20,4,35)
insert into Bangcong values ('00002','1',21,1,2012,7,20,4,35)
insert into Bangcong values ('00002','1',23,1,2012,7,20,4,35)
insert into Bangcong values ('00002','1',24,1,2012,7,20,4,35)
insert into Bangcong values ('00002','1',25,1,2012,7,20,4,35)
insert into Bangcong values ('00002','1',26,1,2012,7,20,4,35)
insert into Bangcong values ('00002','1',27,1,2012,7,20,4,35)
insert into Bangcong values ('00002','1',28,1,2012,7,20,4,35)
insert into Bangcong values ('00002','1',30,1,2012,7,20,4,35)
insert into Bangcong values ('00002','1',31,1,2012,7,20,4,35)
insert into Bangcong values ('00002','1',31,2,2012,7,20,4,35)


insert into DMPhuCap values ('1',N'Cơm',20000)
insert into DMPhuCap values ('2',N'Đêm',10000)
insert into DMPhuCap values ('3',N'Độc hại',5000)
insert into DMPhuCap values ('4',N'Phòng trọ',10000)
insert into DMPhuCap values ('5',N'Đi lại',2000)

insert into ChiTietPhuCap values('1','00001')
insert into ChiTietPhuCap values('2','00001')
insert into ChiTietPhuCap values('1','00002')
insert into ChiTietPhuCap values('3','00003')
go
create view Report_NhanVien_ngaylamviec
as
SELECT distinct nv.MaNV,''as ten, nv.HoLot +' '+ nv.Ten as hoten,nv.GioiTinh, nv.NgaySinh,bp.TenBoPhan,cv.tenchucvu,nv.NgayLamViec, nv.HKTT,Month(ngaylamviec) as thang,year(ngaylamviec)as nam
FROM (((NhanVien nv left outer join DMBaoHiem bh on nv.MaNV=bh.manv)
left outer join HopDong hd on hd.manv=nv.MaNV)
left outer join ChucVu cv on cv.machucvu=nv.machucvu)
left outer join BoPhan bp on bp.MaBoPhan=nv.MaBoPhan

go
create view Report_NhanVien_nghiviec
as
SELECT distinct nv.MaNV,''as ten,nvnv.ngay, nv.HoLot +' '+ nv.Ten as hoten,nv.GioiTinh, nv.NgaySinh,bp.TenBoPhan,cv.tenchucvu,nv.NgayLamViec, nv.HKTT,Month(nvnv.ngay) as thang,year(nvnv.ngay)as nam
FROM ((((NhanVien nv left outer join DMBaoHiem bh on nv.MaNV=bh.manv)
left outer join HopDong hd on hd.manv=nv.MaNV)
left outer join ChucVu cv on cv.machucvu=nv.machucvu)
left outer join BoPhan bp on bp.MaBoPhan=nv.MaBoPhan)
left outer join NVnghiviec nvnv on nvnv.manv=nv.MaNV
go

create view Report_Nhanvien_saphetHD
as
SELECT distinct nv.MaNV, nv.HoLot+' '+ nv.Ten as ten,bp.TenBoPhan,cv.tenchucvu,hd.sohd,hd.ngayhd,hd.ngayhh
FROM (((NhanVien nv left outer join DMBaoHiem bh on nv.MaNV=bh.manv)
left outer join HopDong hd on hd.manv=nv.MaNV)
left outer join ChucVu cv on cv.machucvu=nv.machucvu)
left outer join BoPhan bp on bp.MaBoPhan=nv.MaBoPhan
where year(getdate())=(select year(MAX(ngayhh)) from HopDong  where manv=nv.manv) and MONTH(getdate())+1 = (select MONTH(MAX(ngayhh)) from HopDong  where manv=nv.manv)

------------------------------------------------------------------bang cong thang
go

create proc proc_bangcong
(
	 @thang smallint,  @nam int
)
as
begin
select  distinct bc.manv,holot+' '+ten as hoten,TenBoPhan,(select maloaicong from BangCong bc1 where bc1.manv=bc.manv and bc1.thang=@thang and bc1.nam = @nam  and ngay=1) as ngay1,
(select maloaicong from BangCong bc1 where bc1.manv=bc.manv and bc1.thang=@thang and bc1.nam = @nam  and ngay=2) as ngay2,
(select maloaicong from BangCong bc1 where bc1.manv=bc.manv and bc1.thang=@thang and bc1.nam = @nam  and ngay=3) as ngay3,
(select maloaicong from BangCong bc1 where bc1.manv=bc.manv and bc1.thang=@thang and bc1.nam = @nam  and ngay=4) as ngay4,
(select maloaicong from BangCong bc1 where bc1.manv=bc.manv and bc1.thang=@thang and bc1.nam = @nam  and ngay=5) as ngay5,
(select maloaicong from BangCong bc1 where bc1.manv=bc.manv and bc1.thang=@thang and bc1.nam = @nam  and ngay=6) as ngay6,
(select maloaicong from BangCong bc1 where bc1.manv=bc.manv and bc1.thang=@thang and bc1.nam = @nam  and ngay=7) as ngay7,
(select maloaicong from BangCong bc1 where bc1.manv=bc.manv and bc1.thang=@thang and bc1.nam = @nam  and ngay=8) as ngay8,
(select maloaicong from BangCong bc1 where bc1.manv=bc.manv and bc1.thang=@thang and bc1.nam = @nam  and ngay=9) as ngay9,
(select maloaicong from BangCong bc1 where bc1.manv=bc.manv and bc1.thang=@thang and bc1.nam = @nam  and ngay=10) as ngay10,
(select maloaicong from BangCong bc1 where bc1.manv=bc.manv and bc1.thang=@thang and bc1.nam = @nam  and ngay=11) as ngay11,
(select maloaicong from BangCong bc1 where bc1.manv=bc.manv and bc1.thang=@thang and bc1.nam = @nam  and ngay=12) as ngay12,
(select maloaicong from BangCong bc1 where bc1.manv=bc.manv and bc1.thang=@thang and bc1.nam = @nam  and ngay=13) as ngay13,
(select maloaicong from BangCong bc1 where bc1.manv=bc.manv and bc1.thang=@thang and bc1.nam = @nam  and ngay=14) as ngay14,
(select maloaicong from BangCong bc1 where bc1.manv=bc.manv and bc1.thang=@thang and bc1.nam = @nam  and ngay=15) as ngay15,
(select maloaicong from BangCong bc1 where bc1.manv=bc.manv and bc1.thang=@thang and bc1.nam = @nam  and ngay=16) as ngay16,
(select maloaicong from BangCong bc1 where bc1.manv=bc.manv and bc1.thang=@thang and bc1.nam = @nam  and ngay=17) as ngay17,
(select maloaicong from BangCong bc1 where bc1.manv=bc.manv and bc1.thang=@thang and bc1.nam = @nam  and ngay=18) as ngay18,
(select maloaicong from BangCong bc1 where bc1.manv=bc.manv and bc1.thang=@thang and bc1.nam = @nam  and ngay=19) as ngay19,
(select maloaicong from BangCong bc1 where bc1.manv=bc.manv and bc1.thang=@thang and bc1.nam = @nam  and ngay=20) as ngay20,
(select maloaicong from BangCong bc1 where bc1.manv=bc.manv and bc1.thang=@thang and bc1.nam = @nam  and ngay=21) as ngay21,
(select maloaicong from BangCong bc1 where bc1.manv=bc.manv and bc1.thang=@thang and bc1.nam = @nam  and ngay=22) as ngay22,
(select maloaicong from BangCong bc1 where bc1.manv=bc.manv and bc1.thang=@thang and bc1.nam = @nam  and ngay=23) as ngay23,
(select maloaicong from BangCong bc1 where bc1.manv=bc.manv and bc1.thang=@thang and bc1.nam = @nam  and ngay=24) as ngay24,
(select maloaicong from BangCong bc1 where bc1.manv=bc.manv and bc1.thang=@thang and bc1.nam = @nam  and ngay=25) as ngay25,
(select maloaicong from BangCong bc1 where bc1.manv=bc.manv and bc1.thang=@thang and bc1.nam = @nam  and ngay=26) as ngay26,
(select maloaicong from BangCong bc1 where bc1.manv=bc.manv and bc1.thang=@thang and bc1.nam = @nam  and ngay=27) as ngay27,
(select maloaicong from BangCong bc1 where bc1.manv=bc.manv and bc1.thang=@thang and bc1.nam = @nam  and ngay=28) as ngay28,
(select maloaicong from BangCong bc1 where bc1.manv=bc.manv and bc1.thang=@thang and bc1.nam = @nam  and ngay=29) as ngay29,
(select maloaicong from BangCong bc1 where bc1.manv=bc.manv and bc1.thang=@thang and bc1.nam = @nam  and ngay=30) as ngay30,
(select maloaicong from BangCong bc1 where bc1.manv=bc.manv and bc1.thang=@thang and bc1.nam = @nam  and ngay=31) as ngay31,
thang,nam,

(select COUNT(*)
from BangCong bc1
where bc1.thang=@thang and bc1.nam=@nam
group by manv,maloaicong,giovao,giora,phutvao,phutra
having bc1.manv=bc.manv and bc1.maloaicong='1'
) as sl_ngaythuong,

(select		COUNT(*)
from		BangCong bc1, DMLoaiCong lc
where		bc1.thang=1 and bc1.nam=2012 and lc.maloai=bc1.maloaicong and lc.heso=1
group by	manv,giovao,giora,phutvao,phutra
having		bc1.manv=bc.manv 
)as sl_ngaycong
from		BangCong bc,NhanVien nv,BoPhan bp 
where		nv.MaNV=bc.manv and bp.MaBoPhan=nv.MaBoPhan and thang=@thang and nam=@nam
end
go

----------------------------------------------------------------------------------------
create proc [dbo].[proc_chiTietTangCaNhanVienTheoThang]
(
	@manv nvarchar(10),@thang smallint,@nam smallint
)
as
begin
select ngay,lc.tenca,lc.maloai,sogio
from	QLTangCa qltc, Loaica lc
where	lc.maloai=qltc.maloaica and thang=@thang and nam=@nam and manv=@manv
end

go
------------------------------------------------------------------------------
create  proc [dbo].[proc_tangca]
(
	@thang smallint, @nam smallint
)
as
begin
	select  nv.manv,HoLot+' '+Ten as hoten,TenBoPhan,
	(select SUM(sogio) from QLTangCa tc1 where thang=@thang and nam=@nam and nv.MaNV=tc1.manv and maloaica='tct') as tongthuong,
	(select SUM(sogio) from QLTangCa tc1 where thang=@thang and nam=@nam and nv.MaNV=tc1.manv and maloaica='tcd') as tongdem,
	(select SUM(sogio) from QLTangCa tc1 where thang=@thang and nam=@nam and nv.MaNV=tc1.manv and maloaica='tcl') as tongle,
	(select SUM(sogio) from QLTangCa tc1 where thang=@thang and nam=@nam and nv.MaNV=tc1.manv and maloaica='tccn') as tongchunhat
	from	QLTangCa tc, NhanVien nv, BoPhan bp
	where	tc.manv=nv.MaNV and bp.MaBoPhan=nv.MaBoPhan
	group by nv.manv,HoLot,Ten,TenBoPhan,thang,nam
	having thang=@thang and nam=@nam

end

-- rpt nhan vien nghi viec theo thang
go
create view view_Nhanviennghiviectheothang
as
select distinct nv.MaNV, HoLot+' '+Ten as hoten, NgaySinh,nv.GioiTinh, TenBoPhan,
day(nvnv.ngay) as ngay,MONTH(nvnv.ngay) as thang, YEAR(nvnv.ngay) as nam
from	NhanVien nv, BoPhan bp, NVnghiviec nvnv
where	nv.MaNV=nvnv.manv and bp.MaBoPhan=nv.MaBoPhan

go
-------------------------------------------- Khau tru
if Exists(select * From Sys.tables Where name='Khautru')
Drop table Khautru
go
create table Khautru
(
	makt		nvarchar(10) primary key not null,
	tenkt		nvarchar(100),
	tien		real
)
go
-------------------------------------------insert khautu
insert into Khautru values
('001',N'Thuế (%)',10),
('002',N'Phí công đoàn',100000),
('003',N'Bảo hiểm trừ 9% lương cơ bản',9),
('004',N'Khoảng khác',10000)

go
-------------------------------------------- CongDoan
if Exists(select * From Sys.tables Where name='CongDoan')
Drop table CongDoan
go
create table CongDoan
(
	manv	nvarchar(10) not null primary key,
	constraint f_cd_nv foreign key (manv) references Nhanvien on delete cascade on update cascade
)
go
-------------------------------------------insertCongDoan
insert into CongDoan values
('00001'),
('00002')

go
-------------------------------------------proc Nhan vien di tre
--drop proc proc_Nhanvienditre
create proc proc_Nhanvienditre
(
	@gio smallint,@phut smallint,@thang smallint,@nam smallint
)
as
begin
select nv.MaNV, HoLot+' '+Ten as hoten,convert(nvarchar,NgaySinh) as NgaySinh,
		GioiTinh = case GioiTinh when 1 then 'Nam'
							 when 0 then N'Nữ' 
				end
		, TenBoPhan,tenchucvu,CONVERT(nvarchar,giovao)+':'+ convert(nvarchar,phutvao) as gio
		,convert(nvarchar,ngay)+'/'+convert(nvarchar,thang)+'/'+convert(nvarchar,nam) as ngay
from	BangCong bc, NhanVien nv, BoPhan bp,ChucVu cv 
where	bc.manv=nv.MaNV and bp.MaBoPhan=nv.MaBoPhan and nv.machucvu=cv.machucvu and
thang=@thang and nam=@nam and (giovao>@gio or(giovao=@gio and phutvao>@phut)) and bc.maloaicong='1'
end

go
------------------------------------------------data set report bao cao nhan vien
--12/04/2012
--(s4 == "1")  //nhan vien chua co HD, BH=tat ca
create proc proc_nhanviendahethd
(
	@tenbophan	nvarchar(50),@tenchucvu	nvarchar(50) 
)
as
begin
SELECT        Report_NhanVien.*
FROM            Report_NhanVien 
where            tenbophan like @tenbophan and tenchucvu like @tenchucvu and thoiviec=1  
and GETDATE()>= all (select MAX(ngayhh) from HopDong  where manv=Report_NhanVien.manv) 
or Report_NhanVien.manv not in (select manv from HopDong)
end

--12/04/2012
--else if (s4 == "0") // co HD , BH = tat ca
go
create proc proc_conhieuluchd
(
	@tenbophan	nvarchar(50),@tenchucvu	nvarchar(50) 
)
as
begin
SELECT        Report_NhanVien.*
FROM            Report_NhanVien, HopDong hd
where            tenbophan like @tenbophan and tenchucvu like @tenchucvu and thoiviec=1
and ( GETDATE()>ngayhd and GETDATE()<ngayhh and Report_NhanVien.sohd=hd.sohd)
end

--else if (s4 == "3")//con hd da dong bh
go
create proc proc_conhieulucHD_dadongBH
(
	@tenbophan	nvarchar(50),@tenchucvu	nvarchar(50) 
)
as
begin
SELECT        nv.*
FROM            Report_NhanVien nv,HopDong hd
where        tenbophan like @tenbophan and tenchucvu like @tenchucvu and thoiviec=1  and
  (( (year(getdate()) <(select year(MAX(ngaycap))+1 from DMBaoHiem where manv=nv.manv)) or 
(year(getdate()) =(select year(MAX(ngaycap))+1 from DMBaoHiem where manv=nv.manv) 
 and (month(getdate()) <(select month(MAX(ngaycap)) from DMBaoHiem where manv=nv.manv))) 
 or(year(getdate()) =(select year(MAX(ngaycap))+1 from DMBaoHiem where manv=nv.manv) 
 and (month(getdate()) =(select month(MAX(ngaycap)) from DMBaoHiem where manv=nv.manv)) 
and (day(getdate()) <(select day(MAX(ngaycap)) from DMBaoHiem where manv=nv.manv))) ))

and( nv.manv not in (select manv from HopDong) or ( GETDATE()>ngayhd and GETDATE()<ngayhh and nv.sohd=hd.sohd))
end

----------------------------------------------COn hieu luc HD - chua dong BH
go
 --else if (s4 =="4")//con hd chua dong bh
create proc proc_conhieulucHD_chuadongBH
(
	@tenbophan	nvarchar(50),@tenchucvu	nvarchar(50) 
)
as
begin
SELECT        nv.*
FROM            Report_NhanVien nv, HopDong hd
where    tenbophan like @tenbophan and tenchucvu like @tenchucvu and thoiviec=1
and ( GETDATE()>ngayhd and GETDATE()<ngayhh and nv.sohd=hd.sohd)
and(
 nv.manv not in (select manv from DMBaoHiem) or 
( (year(getdate()) >(select year(MAX(ngaycap))+1 from DMBaoHiem where manv=nv.manv)) or 
  (year(getdate()) =(select year(MAX(ngaycap))+1 from DMBaoHiem where manv=nv.manv) 
and (month(getdate()) >(select month(MAX(ngaycap)) from DMBaoHiem where manv=nv.manv))) 
or(year(getdate()) =(select year(MAX(ngaycap))+1 from DMBaoHiem where manv=nv.manv) 
and (month(getdate()) =(select month(MAX(ngaycap)) from DMBaoHiem where manv=nv.manv)) 
and (day(getdate()) >(select day(MAX(ngaycap)) from DMBaoHiem where manv=nv.manv))) )
)
end

----------------------------------------------het HD - da dong BH
go
--else if (s4 =="5")//het HD da dong BH
create proc proc_hetHD_dadongBH
(
	@tenbophan	nvarchar(50),@tenchucvu	nvarchar(50) 
)
as
begin
SELECT        nv.*
FROM            Report_NhanVien nv
where            tenbophan like @tenbophan and tenchucvu like @tenchucvu and thoiviec=1  
and GETDATE()>= all (select MAX(ngayhh) from HopDong  where manv=nv.manv) or nv.manv not in (select manv from HopDong)

and
  (( (year(getdate()) <(select year(MAX(ngaycap))+1 from DMBaoHiem where manv=nv.manv)) or 
(year(getdate()) =(select year(MAX(ngaycap))+1 from DMBaoHiem where manv=nv.manv) 
 and (month(getdate()) <(select month(MAX(ngaycap)) from DMBaoHiem where manv=nv.manv))) 
 or(year(getdate()) =(select year(MAX(ngaycap))+1 from DMBaoHiem where manv=nv.manv) 
 and (month(getdate()) =(select month(MAX(ngaycap)) from DMBaoHiem where manv=nv.manv)) 
and (day(getdate()) <(select day(MAX(ngaycap)) from DMBaoHiem where manv=nv.manv))) ))
end

----------------------------------------------het HD - chua dong BH
go
--else if (s4 =="6")//het HD chua dong BH
create proc proc_hetHD_chuadongBH
(
	@tenbophan	nvarchar(50),@tenchucvu	nvarchar(50) 
)
as
begin
SELECT        nv.*
FROM            Report_NhanVien nv
where            tenbophan like @tenbophan and tenchucvu like @tenchucvu and thoiviec=1  
and GETDATE()>= all (select MAX(ngayhh) from HopDong  where manv=nv.manv) or nv.manv not in (select manv from HopDong)

and(
 nv.manv not in (select manv from DMBaoHiem) or 
( (year(getdate()) >(select year(MAX(ngaycap))+1 from DMBaoHiem where manv=nv.manv)) or 
  (year(getdate()) =(select year(MAX(ngaycap))+1 from DMBaoHiem where manv=nv.manv) 
and (month(getdate()) >(select month(MAX(ngaycap)) from DMBaoHiem where manv=nv.manv))) 
or(year(getdate()) =(select year(MAX(ngaycap))+1 from DMBaoHiem where manv=nv.manv) 
and (month(getdate()) =(select month(MAX(ngaycap)) from DMBaoHiem where manv=nv.manv)) 
and (day(getdate()) >(select day(MAX(ngaycap)) from DMBaoHiem where manv=nv.manv))) )
)
end

----------------------------------------------da dong BH - HD = tat ca
go
--else if (s4 =="7")//da dong BH - HD = tat ca
create proc proc_coBH
(
	@tenbophan	nvarchar(50),@tenchucvu	nvarchar(50) 
)
as
begin
SELECT        nv.*
FROM            Report_NhanVien nv
where            tenbophan like @tenbophan and tenchucvu like @tenchucvu and thoiviec=1  
and
  (( (year(getdate()) <(select year(MAX(ngaycap))+1 from DMBaoHiem where manv=nv.manv)) or 
(year(getdate()) =(select year(MAX(ngaycap))+1 from DMBaoHiem where manv=nv.manv) 
 and (month(getdate()) <(select month(MAX(ngaycap)) from DMBaoHiem where manv=nv.manv))) 
 or(year(getdate()) =(select year(MAX(ngaycap))+1 from DMBaoHiem where manv=nv.manv) 
 and (month(getdate()) =(select month(MAX(ngaycap)) from DMBaoHiem where manv=nv.manv)) 
and (day(getdate()) <(select day(MAX(ngaycap)) from DMBaoHiem where manv=nv.manv))) ))
end

----------------------------------------------chua dong BH, HD=tatca
go
--else if (s4 =="8")//chua dong BH, HD=tatca
create proc proc_hetBH
(
	@tenbophan	nvarchar(50),@tenchucvu	nvarchar(50) 
)
as
begin
SELECT        nv.*
FROM            Report_NhanVien nv
where            tenbophan like @tenbophan and tenchucvu like @tenchucvu and thoiviec=1 
and(
 nv.manv not in (select manv from DMBaoHiem) or 
( (year(getdate()) >(select year(MAX(ngaycap))+1 from DMBaoHiem where manv=nv.manv)) or 
  (year(getdate()) =(select year(MAX(ngaycap))+1 from DMBaoHiem where manv=nv.manv) 
and (month(getdate()) >(select month(MAX(ngaycap)) from DMBaoHiem where manv=nv.manv))) 
or(year(getdate()) =(select year(MAX(ngaycap))+1 from DMBaoHiem where manv=nv.manv) 
and (month(getdate()) =(select month(MAX(ngaycap)) from DMBaoHiem where manv=nv.manv)) 
and (day(getdate()) >(select day(MAX(ngaycap)) from DMBaoHiem where manv=nv.manv))) )
)
end

----------------------------------------------rpt nhan vien tat ca
go
create proc proc_tatca
(
	@tenbophan	nvarchar(50),@tenchucvu	nvarchar(50) 
)
as
begin
SELECT        distinct Report_NhanVien.*
FROM            Report_NhanVien, HopDong hd
where  tenbophan like @tenbophan and tenchucvu like @tenchucvu
 and( Report_NhanVien.manv not in (select manv from HopDong) or ( GETDATE()>ngayhd and GETDATE()<ngayhh and Report_NhanVien.sohd=hd.sohd))
 end


------------------------------------------------------Bang luong nhan vien
---------------------------------------------------------------------- tien luong theo thang nam
go
CREATE FUNCTION tien_theo_thang_nam
(
	@thang smallint,@nam int
)
RETURNS TABLE
AS
RETURN
(
	select tien from Tienluong where (thangTL =(select max(thangTL) from Tienluong where thangTL<=@thang) and namTL=@nam)
or (thangTL =(select max(thangTL) from Tienluong where namTL<@nam))
)
-----------------------------------------------------------tien luong tang ca
GO
CREATE FUNCTION tienluong_tangca 
(
	@thang smallint,@nam smallint
)
RETURNS TABLE
AS
RETURN (
		select		distinct nv.manv,isnull(((select SUM(hesogio) as heso
									from	(select		manv,maloaica, sum(sogio)*heso as hesogio
											from		QLTangCa tc, LoaiCa lc
											where		tc.maloaica=lc.maloai and thang=@thang and nam=@nam
											group by	manv,maloaica,heso)as a
									where	nv.manv=a.manv
									group by manv)
									)*((select * from tien_theo_thang_nam(@thang,@nam))/26/8),0) as tientangca
		from		nhanvien nv
		)
---------------------------------------------------------------------- tien luong theo thang
GO
--drop FUNCTION tienluong_
CREATE FUNCTION tienluong_
(
	@thang smallint,@nam int
)
RETURNS TABLE
AS
RETURN
(
	select		manv,isnull(heso*((select * from tien_theo_thang_nam(@thang,@nam))/26),0) as tienluong
	from		(select		a.manv,SUM(hesongay) as heso
						from		(select		manv,maloaicong, COUNT(maloai)* heso as hesongay
									from		BangCong bc, DMLoaiCong lc
									where		bc.maloaicong=lc.maloai and thang=@thang and nam=@nam
									group by	manv,maloaicong,heso) as a
						group by	a.manv) as b	
)
				
------------------------------------------------------------------ tien phu cap  // chua xong
go
create view view_tienphuccap
as
select	nv.manv,isnull((select sum(tien)
				from	ChiTietPhuCap ct, DMPhuCap pc
				where	ct.maloaipc=pc.maloaipc and nv.MaNV=ct.manv),0) as tienphucap
from	Nhanvien nv

-------------------------------------------------------------- tien ung
GO
CREATE FUNCTION tienung
(
	@thang smallint,@nam int
)
RETURNS TABLE
AS
RETURN(
		select	distinct nv.manv,isnull((  select  tien
									FROM	QLUngLuong ul 
									where	nv.MaNV=ul.manv and thang=@thang and nam=@nam and trangthai=0
									),0) as tienung
		from nhanvien nv
		)

-------------------------------------------------------------tien bao hiem
GO
CREATE FUNCTION tien_BH 
(
	@thang smallint,@nam int
)
RETURNS TABLE
AS
RETURN (select	nv.manv,isnull((
				select		heso*((select * from tien_theo_thang_nam(@thang,@nam))/26) as tien
				from		(select		a.manv,SUM(hesongay) as heso
										from		(select		manv,maloaicong, COUNT(maloai)* heso as hesongay
													from		BangCong bc, DMLoaiCong lc
													where		bc.maloaicong=lc.maloai and thang=1 and nam=2012
													group by	manv,maloaicong,heso) as a
										group by	a.manv) as b
				where		b.manv=nv.MaNV
				)*kt.tien/100,0) as tienBH
		from	Khautru kt,NhanVien nv		
		where	kt.makt='003'
		)

-----------------------------------tien cong doan
go
create view view_tienCD
as
select  distinct manv,isnull((select tien from CongDoan cd where nv.MaNV=cd.manv),0) as tienCD
from	nhanvien nv,Khautru kt
where	kt.makt='002'
	
-------------------------------------------------------------------------------------------
------------------------------------Tổng Tiền Khấu Trừ-------------------------------------
-------------------------------------------------------------------------------------------
GO
CREATE FUNCTION tienkhautru 
(
	@thang smallint,@nam int
)
RETURNS TABLE
AS
RETURN(
select	nv.manv, isnull((select	a.tienBH+b.tienCD 
					from	tien_BH(@thang,@nam) as a, view_tienCD as b
					where	a.manv=b.manv and nv.manv=a.manv),0)as tienKT
from	Nhanvien nv
)

---------------------------------------------------------------------tien thue
GO
CREATE FUNCTION thue 
(
	@thang smallint,@nam smallint
)
RETURNS TABLE
AS
RETURN (
		select	a.manv,b.tienluong,a.tientangca,c.tienphucap,d.tienung,e.tienKT,
				case 
					 when (tientangca+Tienluong+tienphucap-tienung-tienKT)>=5000000 
					 then (tientangca+Tienluong+tienphucap-tienung-tienKT)*(select tien from Khautru where makt='001')/100
					 when tientangca+Tienluong+tienphucap-tienung-tienKT<5000000 then 0 
				end as thue
		from	tienluong_tangca(@thang,@nam) as a, tienluong_(@thang,@nam) as b,view_tienphuccap as c,tienung(@thang,@nam)as d,tienkhautru(@thang,@nam)as e
		where	a.manv=b.manv and a.manv=c.manv and a.manv=d.manv and a.manv=e.manv
		)

------------------------------------------------------Bang luong nhan vien
go
--drop proc proc_bangluong
create proc proc_bangluong
(
	@thang smallint, @nam int
)
as
begin
select	nv.MaNV as N'Mã nhân viên',HoLot+' '+Ten as N'Họ tên',TenBoPhan as N'Tên bộ phận',
		round(tienluong,0) as N'Tiền lương',round(tientangca,0) as N'Tăng ca',round(tienphucap,0) as N'Phụ cấp',round(tienung,0) as N'Tạm ứng',round(tienKT,0) as N'Khấu trừ',
		round(thue,0) as N'Thuế',ROUND(tienluong+tientangca+tienphucap-tienung-tienKT-thue,0) as N'Thực lãnh'
from	NhanVien nv, BoPhan bp,thue(@thang,@nam) t
where	nv.MaBoPhan=bp.MaBoPhan and nv.MaNV=t.manv and thoiviec=1
end
-----------------------------------------------------------------------------------------------------
--------------------------------26/04/2013 == rpt luong nhan vien------------------------------------
-----------------------------------------------------------------------------------------------------
----------------------------------------------------------------------f bang luong

GO
CREATE FUNCTION f_bangluong 
(
	@thang smallint,@nam int
)
RETURNS TABLE
AS
RETURN(
select	nv.MaNV,
		round(tienluong,0) as N'Tiền lương',round(tientangca,0) as N'Tăng ca',round(tienphucap,0) as N'Phụ cấp',round(tienung,0) as N'Tạm ứng',round(tienKT,0) as N'Khấu trừ',
		round(thue,0) as N'Thuế',ROUND(tienluong+tientangca+tienphucap-tienung-tienKT-thue,0) as thuclanh
from	NhanVien nv, BoPhan bp,thue(@thang,@nam) t
where	nv.MaBoPhan=bp.MaBoPhan and nv.MaNV=t.manv and thoiviec=1
)
-------------------------------------------------------------------so ngay cong, vaf cong thuc te
GO
CREATE FUNCTION f_bangcong 
(
	@thang smallint,@nam int
)
RETURNS TABLE
AS
RETURN(
select  distinct bc.manv,

(select COUNT(*)
from BangCong bc1
where bc1.thang=@thang and bc1.nam=@nam
group by manv,maloaicong,giovao,giora,phutvao,phutra
having bc1.manv=bc.manv and bc1.maloaicong='1'
) as sl_ngaythuong,

(select		COUNT(*)
from		BangCong bc1, DMLoaiCong lc
where		bc1.thang=1 and bc1.nam=2012 and lc.maloai=bc1.maloaicong and lc.heso=1
group by	manv,giovao,giora,phutvao,phutra
having		bc1.manv=bc.manv 
)as sl_ngaycong
from		BangCong bc,NhanVien nv,BoPhan bp 
where		nv.MaNV=bc.manv and bp.MaBoPhan=nv.MaBoPhan and thang=@thang and nam=@nam
)
----------------------------------------------------------------------------tien chi tiet tang ca
go
CREATE FUNCTION f_tienluong_tangca 
(
	@thang smallint,@nam int
)
RETURNS TABLE
AS
RETURN
(
	select nv.manv,tenca,isnull(a.hesogio,0) as hesogio,isnull(a.tientangca,0) as tientangca
	from NhanVien nv left outer join(
	select		manv,tenca, sum(sogio)*heso as hesogio,round(isnull((sum(sogio)*heso)*((select * from tien_theo_thang_nam(@thang,@nam))/26/8),0),0)as tientangca
	from		QLTangCa tc, LoaiCa lc,Tienluong
	where		tc.maloaica=lc.maloai and thang=@thang and nam=@nam
	group by	manv,tenca,heso,tien
	)as a on nv.MaNV=a.MaNV
	
)
go
-----------------------------------------------------------------------------phu cap
create view view_phucap_
as
select  nv.manv,pc.tenloai,tien
from	ChiTietPhuCap ct, DMPhuCap pc, NhanVien nv
where	ct.maloaipc=pc.maloaipc and nv.MaNV=ct.manv
-----------------------------------------------------------------------------rpt luong tung nhan vien
go
--drop proc proc_luongtungnhanvien
create proc proc_luongtungnhanvien
(
	@thang smallint,@nam int
)
as
begin
select	distinct nv.manv, HoLot+' '+Ten as hoten,ATM,TenBoPhan,sl_ngaythuong as ngaythucte,sl_ngaycong as ngaycong,round(b.tienluong,0)as tienluong,tenca,d.tientangca,
		c.tenloai,c.tien,round(e.tienBH,0)as tienBH,f.tienCD,g.tienung,h.thue,i.thuclanh
from	NhanVien nv, BangCong bc, BoPhan bp, f_bangcong(@thang,@nam) as a, tienluong_(@thang,@nam) as b, f_tienluong_tangca(@thang,@nam) as d,view_phucap_ as c,
		tien_BH(@thang,@nam) as e,view_tienCD f,tienung(@thang,@nam) g,thue(@thang,@nam) as h,f_bangluong(@thang,@nam)as i
where	nv.MaNV=bc.manv and nv.MaBoPhan=bp.MaBoPhan and nv.MaNV=a.manv and nv.MaNV=b.manv and nv.MaNV=d.manv and nv.MaNV=c.manv
		and e.manv=nv.MaNV and nv.MaNV=f.manv and nv.MaNV=g.manv and nv.MaNV=h.manv and nv.MaNV=i.manv
end

--exec proc_luongtungnhanvien 1,2012