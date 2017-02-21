create database QuanLiNhanSu

create table NhanVien
(
manv varchar(10) primary key,
hoten nvarchar(30),
ngaysinh datetime,
quequan text,
gioitinh nchar(3),
dantoc nvarchar(20),
sodienthoai char(11),
maphongban nvarchar(15),
machucvu nvarchar(15),
bangluong char(10)
)

create table phongban
(
maphongban nvarchar(15) primary key,
tenphongban nvarchar(30),
diachi text,
sodienthoai char(11)
)

create table chucvu
(
machucvu varchar(10) primary key,
tenchucvu nvarchar(15)
)

create table trinhdohocvan
(
matrinhdohocvan char(10) primary key,
tentrinhdohocvan nvarchar(20),
chuyennganh text
)

create table luong
(
bacluong char(10) primary key,
hesoluongcoban char(10),
hesoluong char(10),
hesophucap char(10)
)


