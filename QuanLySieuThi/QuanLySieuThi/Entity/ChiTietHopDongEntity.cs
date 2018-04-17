using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThi.Entity
{
    public class ChiTietHopDongEntity
    {
        private string _MaHopDong;
        private string _MaLoaiHang;
        private int _SoLuong;

        public string MaHopDong
        {
            get
            {
                return _MaHopDong;
            }

            set
            {
                _MaHopDong = value;
            }
        }

        public string MaLoaiHang
        {
            get
            {
                return _MaLoaiHang;
            }

            set
            {
                _MaLoaiHang = value;
            }
        }

        public int SoLuong
        {
            get
            {
                return _SoLuong;
            }

            set
            {
                _SoLuong = value;
            }
        }
    }
}
