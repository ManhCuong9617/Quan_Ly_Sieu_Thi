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
   public class HopDongBUS
    {
        HopDongDAL dal = new HopDongDAL();

        public DataTable GetData()
        {
            return dal.GetData();
        }

        public int ThemHopDong(HopDongEntity hd)
        {
            return dal.ThemHopDong(hd);
        }

        public int SuaHopDong(HopDongEntity hd)
        {
            return dal.SuaHopDong(hd);
        }
        public int XoaHopDong(string MaHopDong)
        {
            return dal.XoaHopDong(MaHopDong);
        }

        public string TangMa()
        {
            return dal.TangMa();
        }
    }
}
