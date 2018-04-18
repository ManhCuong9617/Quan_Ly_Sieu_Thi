USE QuanLySieuThi

--Nhà cung cấp--
GO
CREATE PROC XemNCC
AS
BEGIN
	SELECT * FROM dbo.NhaCungCap
END

GO
CREATE PROC ThemNCC(@mancc VARCHAR(10),@tenncc NVARCHAR(50),@diachi NVARCHAR(20),@sdt VARCHAR(11))
AS
BEGIN
	INSERT dbo.NhaCungCap (MaNCC,TenNCC,DiaChi,SDT)
	VALUES (@mancc,@tenncc,@diachi,@sdt)
END

GO
CREATE PROC SuaNCC(@mancc VARCHAR(10),@tenncc NVARCHAR(50),@diachi NVARCHAR(20),@sdt VARCHAR(11))
AS
BEGIN
	UPDATE dbo.NhaCungCap SET TenNCC=@tenncc,DiaChi=@diachi,SDT=@sdt
	WHERE MaNCC=@mancc
END

GO
CREATE PROC XoaNCC(@mancc VARCHAR(10))
AS
BEGIN 
	DELETE dbo.NhaCungCap
	WHERE MaNCC=@mancc
END

--Người quản lý--

GO
CREATE PROC XemNQL
AS
BEGIN
	SELECT * FROM dbo.NguoiQuanLy
END

GO
CREATE PROC ThemNQL(@manql VARCHAR(10),@tennql NVARCHAR(50),@diachi NVARCHAR(20))
AS
BEGIN
	INSERT dbo.NguoiQuanLy (MaNQL,TenNQL,DiaChi)
	VALUES (@manql,@tennql,@diachi)
END

GO
CREATE PROC SuaNQL(@manql VARCHAR(10),@tennql NVARCHAR(50),@diachi NVARCHAR(20))
AS
BEGIN
	UPDATE dbo.NguoiQuanLy SET TenNQL=@tennql,DiaChi =@diachi
	WHERE MaNQL=@manql
END

GO
CREATE PROC XoaNQL(@manql VARCHAR(10))
AS
BEGIN
	DELETE dbo.NguoiQuanLy
	WHERE MaNQL=@manql
END
