create database QuanLiSinhVienGiaoVien

create table SinhVien
(
	masinhvien nvarchar(20) primary key,
	hoten nvarchar(30),
	ngaysinh datetime,
	quequan nvarchar(20),
	diachithuogtru nvarchar(100),
	lop nvarchar(50),
	malop nvarchar(10),
	sodienthoai nvarchar(11)
)


create table LopMonHoc
(
	malopmonhoc nvarchar(10) primary key,
	tenlop nvarchar(50),
	giavienchunhiem nvarchar(30),
	magiaovien nvarchar(10),
	soluongsinhvien int
)

create table GiaoVien
(
	magiaovien nvarchar(10) primary key,
	tengiaovien nvarchar(30),
	ngaysinh datetime,
	quequan nvarchar(20),
	diachithuogtru nvarchar(100),
	quanham nvarchar(20),
	hocvi nvarchar(20),
	luong nvarchar(20),
	sodienthoai nvarchar(11)

)
