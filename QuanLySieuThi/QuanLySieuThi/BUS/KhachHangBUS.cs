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
    public class KhachHangBUS
    {
        KhacHangDAL khdal = new KhacHangDAL();
        public DataTable XemKhachHang()
        {
            return khdal.XemThongTinKhachHang();
        }
        public DataTable TimKiemKhachHang(string str)
        {
            return khdal.TimKiemKhachHang(str);
        }
        public int ThemKhachHang(KhachHang kh)
        {
            return khdal.ThemKhachHang(kh);
        }
        public int SuaKhachHang(KhachHang kh)
        {
            return khdal.SuaKhachHang(kh);
        }
        public int XoaKhachHang(string id)
        {
            return khdal.XoaKhachHang(id);
        }
        public string TangMa()
        {
            return khdal.TangMa();
        }

    }
}
