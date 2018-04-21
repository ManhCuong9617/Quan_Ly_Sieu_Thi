ALTER TABLE dbo.NhanVien
ADD GioiTinh NVARCHAR(5)
-- Xem NV
GO
CREATE PROC XemNV
AS
BEGIN
	SELECT MaNV,TenNV,NgaySinh,QueQuan,SDT,Luong,TenGH,GioiTinh FROM dbo.NhanVien INNER JOIN dbo.GianHang ON GianHang.MaGH = NhanVien.MaGH
END
-- Thêm NV
GO
CREATE PROC ThemNV(@MaNV VARCHAR(10), @TenNV NVARCHAR(50), @NgaySinh DATE, @QueQuan NVARCHAR(20), @SDT VARCHAR(11),@Luong INT,@MaGH VARCHAR(10), @GioiTinh NVARCHAR(5))
AS
BEGIN
	INSERT INTO dbo.NhanVien
	        ( MaNV ,
	          TenNV ,
	          NgaySinh ,
	          QueQuan ,
	          SDT ,
	          Luong ,
	          MaGH,
			  GioiTinh
	        )
	VALUES  ( @MaNV,@TenNV,@NgaySinh,@QueQuan,@SDT,@Luong,@MaGH,@GioiTinh)
END
-- Sửa NV
GO
CREATE PROC SuaNV(@MaNV VARCHAR(10), @TenNV NVARCHAR(50), @NgaySinh DATE, @QueQuan NVARCHAR(20), @SDT VARCHAR(11),@Luong INT,@MaGH VARCHAR(10),@GioiTinh NVARCHAR(5))
AS
BEGIN
	UPDATE dbo.NhanVien
	SET TenNV=@TenNV,NgaySinh=@NgaySinh,QueQuan=@QueQuan,SDT=@SDT,Luong=@Luong,MaGH=@MaGH,GioiTinh = @GioiTinh
	WHERE MaNV=@MaNV
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

EXEC dbo.SuaNV @MaNV = 'NV01', -- varchar(10)
    @TenNV = N'Nguyễn Văn Tuấn', -- nvarchar(50)
    @NgaySinh = '1992-01-12 ', -- date
    @QueQuan = N'Hà Nội', -- nvarchar(20)
    @SDT = '0987654321', -- varchar(11)
    @Luong = 6000000, -- int
    @MaGH = 'GH001', -- varchar(10)
    @GioiTinh = N'Nam' -- nvarchar(5)
