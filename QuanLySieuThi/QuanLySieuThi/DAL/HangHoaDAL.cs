using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLySieuThi.Entity;
using System.Data;
using System.Data.SqlClient;
namespace QuanLySieuThi.DAL
{
    public class HangHoaDAL
    {
        KetNoi conn = new KetNoi();
        public DataTable GetData()
        {
            return conn.GetData("XemHH", null);
        }

        public DataTable TimKiemHH(string str)
        {
            return conn.GetData(str);
        }

        public int ThemHH(HangHoa hh)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaHH",hh.MaHH),
                new SqlParameter("TenHH",hh.TenHH),
                new SqlParameter("Gia",hh.Gia),
                new SqlParameter("NSX",hh.NSX),
                new SqlParameter("HSD",hh.HSD),
                new SqlParameter("MaLHH",hh.MaLHH),
                new SqlParameter("GhiChu",hh.GhiChu)
            };
            return conn.ExcuteSQL("ThemHH", para);
        }
        public int SuaHH(HangHoa hh)
        {
            SqlParameter[] para =
            {
               new SqlParameter("MaHH",hh.MaHH),
                new SqlParameter("TenHH",hh.TenHH),
                new SqlParameter("Gia",hh.Gia),
                new SqlParameter("NSX",hh.NSX),
                new SqlParameter("HSD",hh.HSD),
                new SqlParameter("MaLHH",hh.MaLHH),
                new SqlParameter("GhiChu",hh.GhiChu)
            };
            return conn.ExcuteSQL("SuaHH", para);
        }

        public int XoaHH(string ID)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaHH",ID)
            };
            return conn.ExcuteSQL("XoaHH", para);
        }

        public string TangMa()
        {
            return conn.TangMa("select * from HangHoa", "HH");
        }
    }
}
