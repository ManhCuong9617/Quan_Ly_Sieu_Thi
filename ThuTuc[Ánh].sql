-- Xem NV
GO
CREATE PROC XemNV
AS
BEGIN
	SELECT MaNV,TenNV,NgaySinh,QueQuan,SDT,Luong,TenGH FROM dbo.NhanVien INNER JOIN dbo.GianHang ON GianHang.MaGH = NhanVien.MaGH
END
-- Thêm NV
GO
CREATE PROC ThemNV(@MaNV VARCHAR(10), @TenNV NVARCHAR(50), @NgaySinh DATE, @QueQuan NVARCHAR(20), @SDT VARCHAR(11),@Luong INT,@MaGH VARCHAR(10))
AS
BEGIN
	INSERT INTO dbo.NhanVien
	        ( MaNV ,
	          TenNV ,
	          NgaySinh ,
	          QueQuan ,
	          SDT ,
	          Luong ,
	          MaGH
	        )
	VALUES  ( @MaNV,@TenNV,@NgaySinh,@QueQuan,@SDT,@Luong,@MaGH)
END
-- Sửa NV
GO
CREATE PROC SuaNV(@MaNV VARCHAR(10), @TenNV NVARCHAR(50), @NgaySinh DATE, @QueQuan NVARCHAR(20), @SDT VARCHAR(11),@Luong INT,@MaGH VARCHAR(10))
AS
BEGIN
	UPDATE dbo.NhanVien
	SET MaNV=@MaNV,TenNV=@TenNV,NgaySinh=@NgaySinh,QueQuan=@QueQuan,SDT=@SDT,Luong=@Luong,MaGH=@MaGH
END
--Xóa NV
GO
CREATE PROC XoaNV(@MaNV VARCHAR(10))
AS
BEGIN
	UPDATE dbo.HoaDon
	SET MaNV =NULL
	WHERE MaNV=@MaNV
	DELETE dbo.NhanVien
	WHERE MaNV=@MaNV
END
-- Xem GH
GO
CREATE PROC XemGH
AS
BEGIN
	SELECT * FROM dbo.GianHang
END