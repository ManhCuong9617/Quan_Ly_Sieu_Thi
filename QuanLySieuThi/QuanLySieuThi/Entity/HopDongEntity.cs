using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThi.Entity
{
    public class HopDongEntity
    {
        private string maHopDong;
        private string ngayKy;
        private string maNhanVien;
        private string maKhachHang;
        private int giaLoaiHang;

        public string MaHopDong
        {
            get
            {
                return maHopDong;
            }

            set
            {
                maHopDong = value;
            }
        }

        public string NgayKy
        {
            get
            {
                return ngayKy;
            }

            set
            {
                ngayKy = value;
            }
        }

        public string MaNhanVien
        {
            get
            {
                return maNhanVien;
            }

            set
            {
                maNhanVien = value;
            }
        }

        public string MaKhachHang
        {
            get
            {
                return maKhachHang;
            }

            set
            {
                maKhachHang = value;
            }
        }

        public int GiaLoaiHang
        {
            get
            {
                return giaLoaiHang;
            }

            set
            {
                giaLoaiHang = value;
            }
        }
    }
}
