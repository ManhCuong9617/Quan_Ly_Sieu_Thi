USE QuanLySieuThi
GO
CREATE TABLE NguoiDung
(
	TaiKhoan VARCHAR(50),
	MatKhau VARCHAR(50)
)
GO
INSERT dbo.NguoiDung
VALUES  ( 'admin','admin')
INSERT dbo.NguoiDung
VALUES  ( 'user1','1')
GO
CREATE PROC LayThongTinNguoiDung(@TaiKhoan VARCHAR(50),@MatKhau VARCHAR(50))
AS
BEGIN
	SELECT * FROM dbo.NguoiDung
	WHERE TaiKhoan=@TaiKhoan AND MatKhau=@MatKhau
END
GO

CREATE PROC SP_XemKhachHang
AS
BEGIN
	SELECT * FROM dbo.KhachHang
END
GO
CREATE PROC SP_ThemKhachHang(@MaKH VARCHAR(10),@TenKH NVARCHAR(50),@DiaChi NVARCHAR(50),@SDT int)
AS
BEGIN
	INSERT dbo.KhachHang
	VALUES  ( @MaKH, @TenKH, @DiaChi, @SDT )
END
GO
CREATE PROC SP_SuaKhachHang(@MaKH VARCHAR(10),@TenKH NVARCHAR(50),@DiaChi NVARCHAR(50),@SDT int)
AS
BEGIN
	UPDATE dbo.KhachHang
	SET TenKH=@TenKH,DiaChi=@DiaChi,SDT=@SDT
	WHERE MaKH=@MaKH
END
GO
CREATE PROC SP_XoaKhachhang(@MaKH VARCHAR(10))
AS
BEGIN
	DELETE dbo.KhachHang 
	WHERE MaKH=@MaKH
END