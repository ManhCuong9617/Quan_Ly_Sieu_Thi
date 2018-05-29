USE QuanLySieuThi
go



CREATE PROC SP_XemGianHang
AS
BEGIN
	SELECT * FROM dbo.GianHang
END
GO
CREATE PROC SP_ThemGianHang(@MaGH VARCHAR(10),@TenGH NVARCHAR(20),@ViTri NVARCHAR(10),@MaNQL VARCHAR(10))
AS
BEGIN
	INSERT dbo.GianHang
	VALUES  ( @MaGH, @TenGH, @ViTri, @MaNQL )
END
GO
CREATE PROC SP_SuaGianHang(@MaGH VARCHAR(10),@TenGH NVARCHAR(20),@ViTri NVARCHAR(10),@MaNQL VARCHAR(10))
AS
BEGIN
	UPDATE dbo.GianHang
	SET TenGH=@TenGH,ViTri=@ViTri,MaNQL=@MaNQL
	WHERE MaGH=@MaGH
END
GO
CREATE PROC SP_XoaGianHang(@MaGH VARCHAR(10))
AS
BEGIN
	DELETE dbo.GianHang 
	WHERE MaGH=@MaGH
END
