create database QuanLyNhanSu
go
create table phongban
(
	ma varchar(10) primary key,
	tenphongban nvarchar(50),
	diachi nvarchar(200),
	sodienthoai char(11)
)

create table chucvu
(
	ma varchar(10) primary key,
	tenchucvu nvarchar(15)
)

create table trinhdohocvan
(
	ma varchar(10) primary key,
	tentrinhdohocvan nvarchar(20),
	chuyennganh nchar(100)
)

create table luong
(
	luongcoban float primary key,
	hesoluong float,
	hesophucap float
)


create table nhanvien
(
	ma varchar(10) primary key,
	hoten nvarchar(100),
	ngaysinh datetime,
	quequan nchar(200),
	gioitinh nchar(3),
	dantoc nvarchar(20),
	sodienthoai char(11),
	taikhoan varchar(50),
	matkhau varchar(20),
	chucvuma varchar(10) references chucvu(ma),
	luongcoban float references luong(luongcoban),
	phongbanma varchar(10) references phongban(ma),
	trinhdohocvanma varchar(10) references trinhdohocvan(ma)
)



