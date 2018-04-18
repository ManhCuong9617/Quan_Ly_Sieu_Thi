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
    public class NhaCungCapDAL
    {
        KetNoi conn = new KetNoi();

        public DataTable GetData()
        {
            return conn.GetData("XemNCC", null);
        }

        public DataTable TimKiemNCC(string str)
        {
            return conn.GetData(str);
        }

        public int ThemNCC(NhaCungCapEntity ncc)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaNCC",ncc.MaNCC),
                new SqlParameter("TenNCC",ncc.TenNCC),
                new SqlParameter("DiaChi",ncc.DiaChi),
                new SqlParameter("SDT",ncc.SDT)
            };
            return conn.ExcuteSQL("ThemNCC", para);
        }
        public int SuaNCC(NhaCungCapEntity ncc)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaNCC",ncc.MaNCC),
                new SqlParameter("TenNCC",ncc.TenNCC),
                new SqlParameter("DiaChi",ncc.DiaChi),
                new SqlParameter("SDT",ncc.SDT)
            };
            return conn.ExcuteSQL("SuaNCC", para);
        }

        public int XoaNCC(string ID)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaNCC",ID)
            };
            return conn.ExcuteSQL("XoaNCC", para);
        }
        public string TangMa()
        {
            return conn.TangMa("select * from dbo.NhaCungCap", "NCC");
        }
    }
}
