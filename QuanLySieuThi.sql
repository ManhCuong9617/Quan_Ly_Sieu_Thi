
CREATE DATABASE QuanLySieuThi
GO 
USE QuanLySieuThi

go
CREATE TABLE NhaCungCap(
	MaNCC VARCHAR(10) PRIMARY KEY,
	TenNCC NVARCHAR(50),
	DiaChi NVARCHAR(20),
	SDT VARCHAR(11)
)
GO
CREATE TABLE GianHang(
	MaGH VARCHAR(10) PRIMARY KEY,
	TenGH NVARCHAR(20),
	ViTri NVARCHAR(10),
	MaNQL VARCHAR(10)
)

GO
CREATE TABLE LoaiHangHoa (
	MaLHH VARCHAR(10) PRIMARY KEY,
	TenLHH NVARCHAR(20),
	GhiChu NVARCHAR(50),
	MaGH VARCHAR(10),
	FOREIGN KEY (MaGH) REFERENCES dbo.GianHang(MaGH)
)

GO
CREATE TABLE HangHoa(
	MaHH VARCHAR(10) PRIMARY KEY,
	TenHH NVARCHAR(50),
	Gia INT,
	NSX date,
	HSD DATE,
	MaLHH VARCHAR(10) REFERENCES LoaiHangHoa(MaLHH),
	GhiChu NVARCHAR(50)
)


GO
CREATE TABLE KhachHang (
	MaKH VARCHAR(10) PRIMARY KEY,
	TenKH NVARCHAR(50),
	DiaChi NVARCHAR(20),
	SDT VARCHAR(11)
)


GO
CREATE TABLE NhanVien(
	MaNV VARCHAR(10) PRIMARY KEY,
	TenNV NVARCHAR(50),
	NgaySinh DATE,
	QueQuan NVARCHAR(20),
	SDT VARCHAR(11),
	Luong INT,
	MaGH VARCHAR(10)
	FOREIGN KEY (MaGH) REFERENCES dbo.GianHang(MaGH)
)

GO
CREATE TABLE HoaDon(
	MaHD VARCHAR(10) PRIMARY KEY,
	NgayLap DATE,
	MaNV VARCHAR(10),
	MaKH VARCHAR(10),
	FOREIGN KEY (MaNV) REFERENCES dbo.NhanVien(MaNV),
	FOREIGN KEY (MaKH) REFERENCES dbo.KhachHang(MaKH)
)

GO
CREATE TABLE ChiTietHoaDon(
	MaHD VARCHAR(10),
	MaHH VARCHAR(10),
	SoLuong INT,
	DonGia INT,
	ThanhTien INT,
	CONSTRAINT PC_MAHD_MALH_PK PRIMARY KEY(MaHD,MaHH),
	CONSTRAINT PC_MAHD_FK FOREIGN KEY (MaHD) REFERENCES dbo.HoaDon(MaHD),
	CONSTRAINT PC_MALH_FK FOREIGN KEY (MaHH) REFERENCES dbo.HangHoa (MaHH)
)

GO
CREATE TABLE ChiTietLoaiHang
(
	MaNCC VARCHAR(10),
	MaLHH VARCHAR(10),
	SoLuong INT,
	CONSTRAINT PC_MANCC_MALH_PK PRIMARY KEY(MaNCC,MaLHH),
	CONSTRAINT PC_MANCC_FK FOREIGN KEY(MaNCC) REFERENCES dbo.NhaCungCap(MaNCC),
	CONSTRAINT PC_MA_LH_FK FOREIGN KEY(MaLHH) REFERENCES dbo.LoaiHangHoa(MaLHH)
)