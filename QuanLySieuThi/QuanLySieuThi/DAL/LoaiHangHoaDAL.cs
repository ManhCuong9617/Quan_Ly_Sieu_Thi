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
    public class LoaiHangHoaDAL
    {
        KetNoi _connect = new KetNoi();
        public DataTable GetData()
        {
            return _connect.GetData("SP_XemLoaiHangHoa", null);
        }
        public int InsertData(LoaiHangHoa HH)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaLHH",HH.MaLHH),
                new SqlParameter("TenLHH",HH.TenLHH),
                new SqlParameter("MaGH",HH.MaGH),
                new SqlParameter("GhiChu",HH.GhiChu)
            };
            return _connect.ExcuteSQL("SP_ThemLoaiHangHoa ", para);
        }
        public int UpdateData(LoaiHangHoa HH)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaLHH",HH.MaLHH),
                new SqlParameter("TenLHH",HH.TenLHH),
                new SqlParameter("MaGH",HH.MaGH),
                new SqlParameter("GhiChu",HH.GhiChu)
            };
            return _connect.ExcuteSQL("SP_SuaLoaiHangHoa ", para);
        }

        public int DeleteData(string MaLoaiHangHoa)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaLHH",MaLoaiHangHoa)
        };
            return _connect.ExcuteSQL("SP_XoaLoaiHangHoa", para);
        }
        public string TangMa()
        {
            return _connect.TangMa("Select * From LoaiHangHoa", "LHH");
        }

    }
}
