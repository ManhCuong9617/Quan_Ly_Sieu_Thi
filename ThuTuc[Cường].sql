USE QuanLySieuThi

--Nhà cung cấp--


INSERT dbo.NhaCungCap
        ( MaNCC, TenNCC, DiaChi, SDT )
VALUES  ( 'NCC02',N'E Cook',N'Hải Phòng',NULL)
INSERT dbo.NhaCungCap
        ( MaNCC, TenNCC, DiaChi, SDT )
VALUES  ( 'NCC03',N'Nam Ngư',N'Quảng Ninh',NULL)
INSERT dbo.NhaCungCap
        ( MaNCC, TenNCC, DiaChi, SDT )
VALUES  ( 'NCC04',N'Cocacola',N'TP Hồ Chí Minh',NULL)
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
 --Hàng hóa--


 GO
 CREATE PROC XemHH
 AS
 BEGIN
	SELECT * FROM HangHoa
END

GO
CREATE PROC ThemHH(@mahh VARCHAR(10),@tenhh NVARCHAR(50),@gia INT,@nsx DATE,@hsd DATE,@malhh VARCHAR(10),@ghichu NVARCHAR(50))
AS
BEGIN
	INSERT HangHoa(MaHH,TenHH,Gia,NSX,HSD,MaLHH,GhiChu)
	VALUES(@mahh,@tenhh,@gia,@nsx,@hsd,@malhh,@ghichu)
END

GO
CREATE PROC SuaHH(@mahh VARCHAR(10),@tenhh NVARCHAR(50),@gia INT,@nsx DATE,@hsd DATE,@malhh VARCHAR(10),@ghichu NVARCHAR(50))
AS
BEGIN
	UPDATE HangHoa SET TenHH=@tenhh,Gia=@gia,NSX=@nsx,HSD=@hsd,MaLHH=@malhh,GhiChu=@ghichu
	WHERE MaHH=@mahh
END

GO
CREATE PROC XoaHH(@mahh VARCHAR(10))
AS
BEGIN
	DELETE HangHoa
	WHERE MaHH=@mahh
END





