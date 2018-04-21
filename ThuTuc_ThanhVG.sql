GO 
USE QuanLySieuThi

-- insert
GO 
INSERT dbo.GianHang( MaGH, TenGH, ViTri, MaNQL )
VALUES  ('GH001',N'Gian Hàng 1',N'Tầng 1',null)

INSERT dbo.NhanVien( MaNV ,TenNV ,NgaySinh ,QueQuan ,SDT ,Luong ,MaGH)
VALUES  ( 'NV01',N'Nguyễn Văn Tuấn','12-01-1992',N'Hà Nội','0987654321',6000000,'GH001')

INSERT dbo.NhaCungCap( MaNCC, TenNCC, DiaChi, SDT )
VALUES  ('NCC01',N'Công Tý TNHH VTV',N'Hà Nội','09866655441')

INSERT dbo.LoaiHangHoa( MaLHH, TenLHH, GhiChu, MaGH )
VALUES  ('LHH01',N'Nươc',N'không','GH001')

INSERT dbo.ChiTietLoaiHang ( MaNCC, MaLHH, SoLuong )
VALUES  ('NCC01','LHH01',100)

--Chi Tiết loại hàng
GO 
CREATE PROC SP_XemChiTietLoaiHang
AS
BEGIN
	SELECT l.MaLHH,TenLHH,GhiChu,MaGH,MaNCC,SoLuong 
	FROM dbo.LoaiHangHoa l  INNER JOIN dbo.ChiTietLoaiHang ON ChiTietLoaiHang.MaLHH = l.MaLHH
END 

GO 
CREATE PROC SP_ThemCTLH @MaLHH VARCHAR(10),@MaNCC VARCHAR(10),@SoLuong INT 
AS
 BEGIN 
	INSERT dbo.ChiTietLoaiHang( MaNCC, MaLHH, SoLuong )
	VALUES  (@MaNCC,@MaLHH,@SoLuong )
 END 

 GO 
CREATE PROC SP_SuaCTLH @MaLHH VARCHAR(10), @MaNCC VARCHAR(10),@SoLuong INT 
AS
 BEGIN  
	UPDATE dbo.ChiTietLoaiHang SET MaLHH = @MaLHH, MaNCC = @MaNCC , SoLuong = @SoLuong
	WHERE MaLHH = @MaLHH
 END

 GO 
CREATE PROC SP_XoaCTLH @MaLHH VARCHAR(10) , @MaNCC VARCHAR(10)
AS
 BEGIN 
	DELETE dbo.ChiTietLoaiHang
	WHERE MaLHH = @MaLHH AND MaNCC = @MaNCC
 END


---Loại Hàng Hóa

GO 
CREATE PROC SP_ThemLoaiHangHoa @MaLHH VARCHAR(10), @TenLHH NVARCHAR(50), @GhiChu NVARCHAR(50),@MaGH VARCHAR(10)
AS
BEGIN 
	INSERT dbo.LoaiHangHoa( MaLHH, TenLHH, GhiChu, MaGH )
	VALUES  (@MaLHH,@TenLHH,@GhiChu,@MaGH)
END 

GO 
CREATE PROC SP_SuaLoaiHangHoa @MaLHH VARCHAR(10), @TenLHH NVARCHAR(50), @GhiChu NVARCHAR(50),@MaGH VARCHAR(10) 
AS
BEGIN 
	UPDATE dbo.LoaiHangHoa SET TenLHH = @TenLHH,GhiChu = @GhiChu,MaGH = @MaGH
	WHERE MaLHH = @MaLHH
END

GO 
CREATE PROC SP_XoaLoaiHangHoa @MaLoaiHangHoa VARCHAR(10)
AS
BEGIN 
	DELETE dbo.LoaiHangHoa WHERE MaLHH = @MaLoaiHangHoa
END