using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThi.Entity
{
   public class ChiTietLoaiHang
    {
        private string  _MaLoaiHH;
        private string _MaNhaCC;
        private int _SoLuong;

        public string MaLoaiHH
        {
            get
            {
                return _MaLoaiHH;
            }

            set
            {
                _MaLoaiHH = value;
            }
        }

        public string MaNhaCC
        {
            get
            {
                return _MaNhaCC;
            }

            set
            {
                _MaNhaCC = value;
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
