GO 
USE QuanLySieuThi

--HỢP ĐỒNG
GO 
CREATE PROC SP_HopDongSelectAll
AS
BEGIN
	SELECT * FROM dbo.HopDong
END 

GO 
CREATE PROC SP_ThemHopDong @MaHD VARCHAR(5), @NgayKy DATE, @MaNV VARCHAR(5),@MaKH VARCHAR(5),@GiaLH INT 
AS
 BEGIN 
	INSERT dbo.HopDong( MaHD, NgayKi, GiaLH, MaNV, MaKH )
	VALUES  (@MaHD,@NgayKy,@GiaLH,@MaNV,@MaKH)
 END 

 GO 
 CREATE PROC SP_SuaHopDong @MaHD VARCHAR(5), @NgayKy DATE, @MaNV VARCHAR(5),@MaKH VARCHAR(5),@GiaLH INT 
AS
 BEGIN 
	UPDATE dbo.HopDong SET NgayKi = @NgayKy, MaNV = @MaNV, MaKH = @MaKH, GiaLH = @GiaLH
	WHERE MaHD = @MaHD
 END 

 GO 
CREATE PROC SP_XoaHopDong @MaHD VARCHAR(5)
AS
 BEGIN 
	DELETE dbo.HopDong 
	WHERE MaHD = @MaHD
 END


---CHI TIẾT HỢP ĐỒNG

GO 
CREATE PROC SP_ChiTietHopDongAll
AS
BEGIN
	SELECT *FROM dbo.ChiTietHopDong
END 

GO 
CREATE PROC SP_ThemChiTietHopDong @MaHD VARCHAR(5), @MaLH VARCHAR(5), @SoLuong INT 
AS
BEGIN 
	INSERT dbo.ChiTietHopDong ( MaHD, MaLH, SoLuong )
	VALUES  (@MaHD,@MaLH,@SoLuong)
END 

GO 
CREATE PROC SP_SuaChiTietHopDong @MaHD VARCHAR(5), @MaLH VARCHAR(5), @SoLuong INT 
AS
BEGIN 
	UPDATE dbo.ChiTietHopDong SET MaHD = @MaHD, MaLH = @MaLH ,SoLuong = @SoLuong
	WHERE MaHD = @MaHD
END

GO 
CREATE PROC SP_XoaChiTietHopDong @MaHD VARCHAR(5)
AS
BEGIN 
	DELETE dbo.ChiTietHopDong WHERE MaHD = @MaHD
END