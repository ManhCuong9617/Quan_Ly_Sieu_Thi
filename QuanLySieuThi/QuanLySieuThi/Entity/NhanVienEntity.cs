using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThi.Entity
{
    public class NhanVienEntity
    {
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public DateTime NgaySinh { get; set; }
        public string QueQuan { get; set; }
        public string SDT { get; set; }
        public int Luong { get; set; }
        public string MaGH { get; set; }

        public NhanVienEntity()
        {
            MaNV = "";
            TenNV = "";
            NgaySinh = DateTime.Parse("01/01/1997");
            QueQuan = "";
            SDT = "";
            Luong = 0;
            MaGH = "";
        }
        public NhanVienEntity(string _MaNV, string _TenNV, DateTime _NgaySinh, string _QueQuan, string _SDT, int _Luong, string _MaGH)
        {
            MaNV = _MaNV;
            TenNV = _TenNV;
            NgaySinh = _NgaySinh;
            QueQuan = _QueQuan;
            SDT = _SDT;
            Luong = _Luong;
            MaGH = _MaGH;
        }

    }
}
