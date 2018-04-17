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
    public class ChiTietHopDongBUS
    {
        ChiTietHopDongDAL dal = new ChiTietHopDongDAL();

        public DataTable GetData()
        {
            return dal.GetData();
        }

        public int ThemChiTietHopDong(ChiTietHopDongEntity ct)
        {
            return dal.ThemChiTietHopDong(ct);
        }

        public int SuaChiTietHopDong(ChiTietHopDongEntity ct)
        {
            return dal.SuaChiTietHopDong(ct);
        }

        public int XoaChiTietHopDong(string MaHopDong)
        {
            return dal.XoaChiTietHopDong(MaHopDong);
        }
    }
}
