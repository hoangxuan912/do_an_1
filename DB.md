# do_an_1
đồ án 1 của nhóm 8
create table NhaCungCap (
	NhaCungCap_id nvarchar(100) primary key,
	NhaCungCap_ten nvarchar(max),
	NhaCungCap_diachi nvarchar(max),
	NhaCungCap_sdt nvarchar(20)
)
create table KhachHang (
	KhachHang_id int identity(1,1) primary key,
	KhachHang_ten nvarchar(max),
	KhachHang_diachi nvarchar(max),
	KhachHang_sdt nvarchar(20)
)
create table SanPham (
	SanPham_id nvarchar(100) primary key,
	SanPham_ten nvarchar(max),
	SanPham_sl int,
	SanPham_GiaBan float,
	NhaCungCap_id nvarchar(100) not null foreign key references NhaCungCap(NhaCungCap_id)
)
create table TaiKhoan (
	TaiKhoan_id int identity(1,1) primary key,
	TaiKhoan_TK nvarchar(20),
	TaiKhoan_MK nvarchar(20),
	TaiKhoan_QuyenTruyCap nvarchar(10)
)
create table CTPhieuNhapHang (
	CTPhieuNhapHang_id int identity(1,1) primary key,
	SanPham_id nvarchar(100) not null foreign key references SanPham(SanPham_id),
	CTPhieuNhapHang_sl int,
	CTPhieuNhapHang_Ngay datetime
)
create table CTPhieuXuatHang (
	CTPhieuXuatHang_id int identity(1,1) primary key,
	KhachHang_id int  not null  foreign key references KhachHang(KhachHang_id),
	SanPham_id nvarchar(100) not null foreign key references SanPham(SanPham_id),
	CTPhieuXuatHang_sl int,
	CTHoaDon_tongTien float,
	CTPhieuXuatHang_Ngay datetime
)
