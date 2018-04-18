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
    public class NguoiQuanLyDAL
    {
        KetNoi conn = new KetNoi();
        public DataTable GetData()
        {
            return conn.GetData("XemNQL", null);
        }

        public DataTable TimKiemNQL(string str)
        {
            return conn.GetData(str);
        }

        public int ThemNQL(NguoiQuanLyEntity nql)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaNQL",nql.MaNQL),
                new SqlParameter("TenNQL",nql.TenNQL),
                new SqlParameter("DiaChi",nql.DiaChi)
            };
            return conn.ExcuteSQL("ThemNQL", para);
        }
        public int SuaNQL(NguoiQuanLyEntity nql)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaNQL",nql.MaNQL),
                new SqlParameter("TenNQL",nql.TenNQL),
                new SqlParameter("DiaChi",nql.DiaChi)
            };
            return conn.ExcuteSQL("SuaNQL", para);
        }

        public int XoaNQL(string ID)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaNQL",ID)
            };
            return conn.ExcuteSQL("XoaNQL", para);
        }

        public string TangMa()
        {
            return conn.TangMa("select * from NguoiQuanLy", "NQL");
        }
    }
}
