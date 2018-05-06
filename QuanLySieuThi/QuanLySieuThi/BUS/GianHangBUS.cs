using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLySieuThi.DAL;
using QuanLySieuThi.Entity;
using System.Data;
namespace QuanLySieuThi.BUS
{
    class GianHangBUS
    {
       GianHangDAL ghdal = new GianHangDAL();
        public DataTable XemGianHang()
        {
            return ghdal.XemThongTinGianHang();
        }
        public DataTable TimKiemGianHang(string str)
        {
            return ghdal.TimKiemGianHang(str);
        }
        public int ThemKhachHang(GianHang gh)
        {
            return ghdal.ThemGianHang(gh);
        }
        public int SuaKhachHang(GianHang gh)
        {
            return ghdal.SuaGianHang(gh);
        }
        public int XoaGianHang(string id)
        {
            return ghdal.XoaGianHang(id);
        }
        public string TangMa()
        {
            return ghdal.TangMa();
        }

    }
}
