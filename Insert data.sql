USE QuanLySieuThi
GO
INSERT dbo.KhachHang
VALUES  ( 'KH01',N'Lệnh Hồ Xung',N'Hoa sơn', '0135265688')
INSERT dbo.KhachHang
VALUES  ( 'KH02',N'Trương Vô Kỵ',N'Võ đang', '0169658565')
INSERT dbo.KhachHang
VALUES  ( 'KH03',N'Quách Tĩnh',N'Đảo đào hoa', '0169854585')
INSERT dbo.KhachHang
VALUES  ( 'KH04',N'Ly Ca Tiếu',N'Nhất Chi Mai', '0136254247')
INSERT dbo.KhachHang
VALUES  ( 'KH05',N'Hoàng Dung',N'Đảo đào hoa', '0185452478')
INSERT dbo.KhachHang
VALUES  ( 'KH06',N'Âu Dương Phong',N'Hoa Sơn', '0168524574')
INSERT dbo.KhachHang
VALUES  ( 'KH07',N'Dương Quá',N'Cổ mộ', '0152598785')
INSERT dbo.KhachHang
VALUES  ( 'KH08',N'Trương Tam Phong',N'Võ đang', '0196523564')
INSERT dbo.KhachHang
VALUES  ( 'KH09',N'Bao thanh thiên',N'Hoa Sơn', '098652541')
INSERT dbo.KhachHang
VALUES  ( 'KH10',N'Đông Phương Bất Bại',N'Hoa Sơn', '0985254124')
GO

INSERT INTO dbo.NhanVien
        ( MaNV ,
          TenNV ,
          NgaySinh ,
          QueQuan ,
          SDT ,
          Luong ,
          MaGH ,
          GioiTinh
        )
VALUES  ( 'NV01' , -- MaNV - varchar(10)
          N'Nguyễn Văn Quang' , -- HoTen - nvarchar(50)
		  '1995-04-03' , -- NgaySinh - date
		  N'Hà Nội' , -- QueQuan - nvarchar(50)
		  '0987654567' , -- SDT - char(15)
		  '9000000'  ,
		  'GH01' , 
          N'Nam'  -- GioiTinh - nvarchar(5)
        )
GO
INSERT INTO dbo.NhanVien
        ( MaNV ,
          TenNV ,
          NgaySinh ,
          QueQuan ,
          SDT ,
          Luong ,
          MaGH ,
          GioiTinh
        )
VALUES  ( 'NV02' , -- MaNV - varchar(10)
          N'Nguyễn Văn Minh' , -- TenNV - nvarchar(50)
          '1994-04-03' , -- NgaySinh - date
          N'Hà Nam' , -- QueQuan - nvarchar(20)
          '0987654987' , -- SDT - varchar(11)
          8500000 , -- Luong - int
          'GH02' , -- MaGH - varchar(10)
          N'Nam'  -- GioiTinh - nvarchar(5)
        )
GO
INSERT INTO dbo.NhanVien
        ( MaNV ,
          TenNV ,
          NgaySinh ,
          QueQuan ,
          SDT ,
          Luong ,
          MaGH ,
          GioiTinh
        )
VALUES  ( 'NV03' , -- MaNV - varchar(10)
          N'Thị Lý' , -- TenNV - nvarchar(50)
          '1992-01-03' , -- NgaySinh - date
          N'Quảng Ninh' , -- QueQuan - nvarchar(20)
          '0987906987' , -- SDT - varchar(11)
          8500000 , -- Luong - int
          'GH02' , -- MaGH - varchar(10)
          N'Nữ'  -- GioiTinh - nvarchar(5)
        )
GO
INSERT INTO dbo.NhanVien
        ( MaNV ,
          TenNV ,
          NgaySinh ,
          QueQuan ,
          SDT ,
          Luong ,
          MaGH ,
          GioiTinh
        )
VALUES  ( 'NV04' , -- MaNV - varchar(10)
          N'Đào Thị Hồng' , -- TenNV - nvarchar(50)
          '1991-03-02' , -- NgaySinh - date
          N'Bắc Ninh' , -- QueQuan - nvarchar(20)
          '0987689034' , -- SDT - varchar(11)
          8500000 , -- Luong - int
          'GH01' , -- MaGH - varchar(10)
          N'Nữ'  -- GioiTinh - nvarchar(5)
        )
GO
INSERT INTO dbo.NhanVien
        ( MaNV ,
          TenNV ,
          NgaySinh ,
          QueQuan ,
          SDT ,
          Luong ,
          MaGH ,
          GioiTinh
        )
VALUES  ( 'NV05' , -- MaNV - varchar(10)
          N'Nguyễn Mạnh Cường' , -- TenNV - nvarchar(50)
          '1992-05-03' , -- NgaySinh - date
          N'Hà Nam' , -- QueQuan - nvarchar(20)
          '0987658923' , -- SDT - varchar(11)
          9500000 , -- Luong - int
          'GH03' , -- MaGH - varchar(10)
          N'Nam'  -- GioiTinh - nvarchar(5)
        )
GO
INSERT INTO dbo.NhanVien
        ( MaNV ,
          TenNV ,
          NgaySinh ,
          QueQuan ,
          SDT ,
          Luong ,
          MaGH ,
          GioiTinh
        )
VALUES  ( 'NV06' , -- MaNV - varchar(10)
          N'Hà Văn Mạnh' , -- TenNV - nvarchar(50)
          '1991-04-03' , -- NgaySinh - date
          N'Hà Nam' , -- QueQuan - nvarchar(20)
          '0987658234' , -- SDT - varchar(11)
          8500000 , -- Luong - int
          'GH03' , -- MaGH - varchar(10)
          N'Nam'  -- GioiTinh - nvarchar(5)
        )
GO
INSERT INTO dbo.NhanVien
        ( MaNV ,
          TenNV ,
          NgaySinh ,
          QueQuan ,
          SDT ,
          Luong ,
          MaGH ,
          GioiTinh
        )
VALUES  ( 'NV07' , -- MaNV - varchar(10)
          N'Nguyễn Bá Huy' , -- TenNV - nvarchar(50)
          '1993-10-03' , -- NgaySinh - date
          N'Hà Nội' , -- QueQuan - nvarchar(20)
          '0989074987' , -- SDT - varchar(11)
          8500000 , -- Luong - int
          'GH04' , -- MaGH - varchar(10)
          N'Nam'  -- GioiTinh - nvarchar(5)
        )
GO
INSERT INTO dbo.NhanVien
        ( MaNV ,
          TenNV ,
          NgaySinh ,
          QueQuan ,
          SDT ,
          Luong ,
          MaGH ,
          GioiTinh
        )
VALUES  ( 'NV08' , -- MaNV - varchar(10)
          N'Trần Văn Linh' , -- TenNV - nvarchar(50)
          '1993-02-13' , -- NgaySinh - date
          N'Bắc Giang' , -- QueQuan - nvarchar(20)
          '0987657896' , -- SDT - varchar(11)
          8500000 , -- Luong - int
          'GH04' , -- MaGH - varchar(10)
          N'Nam'  -- GioiTinh - nvarchar(5)
        )
GO
INSERT INTO dbo.NhanVien
        ( MaNV ,
          TenNV ,
          NgaySinh ,
          QueQuan ,
          SDT ,
          Luong ,
          MaGH ,
          GioiTinh
        )
VALUES  ( 'NV09' , -- MaNV - varchar(10)
          N'Lê Mạnh Hà' , -- TenNV - nvarchar(50)
          '1994-04-23' , -- NgaySinh - date
          N'Hà Nam' , -- QueQuan - nvarchar(20)
          '0987659237' , -- SDT - varchar(11)
          8500000 , -- Luong - int
          'GH05' , -- MaGH - varchar(10)
          N'Nam'  -- GioiTinh - nvarchar(5)
        )
GO
INSERT INTO dbo.NhanVien
        ( MaNV ,
          TenNV ,
          NgaySinh ,
          QueQuan ,
          SDT ,
          Luong ,
          MaGH ,
          GioiTinh
        )
VALUES  ( 'NV10' , -- MaNV - varchar(10)
          N'Ngô Mạnh Hiếu' , -- TenNV - nvarchar(50)
          '1994-10-05' , -- NgaySinh - date
          N'Hà Nam' , -- QueQuan - nvarchar(20)
          '0987013687' , -- SDT - varchar(11)
          9500000 , -- Luong - int
          'GH05' , -- MaGH - varchar(10)
          N'Nam'  -- GioiTinh - nvarchar(5)
        )

--GO
--INSERT dbo.HangHoa
--        ( MaHH, TenHH, Gia, NSX, HSD, MaLHH, GhiChu )
--VALUES  ('HH01','Dầu Gội','50000','2018/01/01','2019/01/01','LHH01','')
--INSERT dbo.HangHoa
--        ( MaHH, TenHH, Gia, NSX, HSD, MaLHH, GhiChu )
--VALUES  ('HH02','Bột Giặt','60000','2018/01/01','2019/01/01','LHH02','')
--INSERT dbo.HangHoa
--        ( MaHH, TenHH, Gia, NSX, HSD, MaLHH, GhiChu )
--VALUES  ('HH03','Nước Rửa Bát','70000','2018/01/01','2019/01/01','LHH03','')
--INSERT dbo.HangHoa
--        ( MaHH, TenHH, Gia, NSX, HSD, MaLHH, GhiChu )
--VALUES  ('HH04','Cocacola','15000','2018/01/01','2019/01/01','LHH04','')

--INSERT dbo.HangHoa
--        ( MaHH, TenHH, Gia, NSX, HSD, MaLHH, GhiChu )
--VALUES  ('HH05','Mì Tôm','5000','2018/01/01','2019/01/01','LHH05','')
--INSERT dbo.HangHoa
--        ( MaHH, TenHH, Gia, NSX, HSD, MaLHH, GhiChu )
--VALUES  ('HH06','Kem','25000','2018/01/01','2019/01/01','LHH06','')
--INSERT dbo.HangHoa
--        ( MaHH, TenHH, Gia, NSX, HSD, MaLHH, GhiChu )
--VALUES  ('HH07','Sữa','15000','2018/01/01','2019/01/01','LHH07','')
--INSERT dbo.HangHoa
--        ( MaHH, TenHH, Gia, NSX, HSD, MaLHH, GhiChu )
--VALUES  ('HH08','Monter Energy','35000','2018/01/01','2019/01/01','LHH08','')
