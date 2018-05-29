USE QuanLySieuThi
GO
CREATE PROC HD_SelectAll 
AS
BEGIN
	SELECT HoaDon.MaHD, TenKH,TenNV,NgayLap FROM dbo.HoaDon,dbo.KhachHang,dbo.NhanVien
	WHERE HoaDon.MaNV = NhanVien.MaNV AND dbo.KhachHang.MaKH =HoaDon.MaHD
END
GO 
CREATE PROC Them_HD(@MaHD VARCHAR(10),@MaDT VARCHAR(10),@MaNV VARCHAR(10),@NgayLap DATE)
AS
BEGIN
	INSERT INTO dbo.HoaDon ( MaHD ,MaKH ,NgayLap ,MaNV)
	VALUES  (@MaHD,@MaDT,@NgayLap,@MaNV )
END
GO 
CREATE PROC Xoa_HD (@Ma varchar(10) )
AS 
BEGIN
	DELETE dbo.HoaDon WHERE MaHD = @Ma 
END
GO
CREATE PROC Xoa_CTHD (@MaHD varchar(10),@MaHH varchar(10))
AS 
BEGIN
	DELETE dbo.ChiTietHoaDon WHERE MaHD = @MaHD AND MaHH =@MaHH 
END
GO
CREATE PROC Select_HH
AS
BEGIN	
	SELECT*FROM dbo.HangHoa
END
GO
CREATE PROC Select_KH
AS
BEGIN	
	SELECT*FROM dbo.KhachHang
END
GO 
CREATE PROC Select_NV
AS
BEGIN	
	SELECT*FROM dbo.NhanVien
END




----Sửa Thủ Tục
GO 
ALTER PROC CTHD_SelectByID (@Ma VARCHAR(10))
AS
BEGIN
	SELECT MaHD,TenHH,SoLuong,DonGia,ThanhTien = (SoLuong*DonGia) FROM dbo.ChiTietHoaDon, dbo.HangHoa
	WHERE ChiTietHoaDon.MaHH= dbo.HangHoa.MaHH AND  MaHD = @Ma
END
GO 
ALTER PROC Them_CTHD (@MaHD VARCHAR(10), @MaHH VARCHAR(10),@SoLuong INT, @DonGia INT )
AS
BEGIN
	INSERT INTO dbo.ChiTietHoaDon
	        ( MaHH, MaHD, SoLuong, DonGia ,ThanhTien)
	VALUES  ( @MaHH,@MaHD,@SoLuong,@DonGia,@SoLuong*@DonGia)
END
GO
