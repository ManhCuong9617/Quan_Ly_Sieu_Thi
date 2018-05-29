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