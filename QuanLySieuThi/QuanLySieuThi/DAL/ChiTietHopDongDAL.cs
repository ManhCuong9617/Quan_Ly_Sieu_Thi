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
    public class ChiTietHopDongDAL
    {
        KetNoi _connect = new KetNoi();

        public DataTable GetData()
        {
            return _connect.GetData("SP_ChiTietHopDongALL");
        }

        public int ThemChiTietHopDong(ChiTietHopDongEntity ct)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaHD",ct.MaHopDong),
                new SqlParameter("MaLH",ct.MaLoaiHang),
                new SqlParameter("SoLuong",ct.SoLuong)
            };
            return _connect.ExcuteSQL("SP_ThemChiTietHopDong", para);
        }

        public int SuaChiTietHopDong(ChiTietHopDongEntity ct)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaHD",ct.MaHopDong),
                new SqlParameter("MaLH",ct.MaLoaiHang),
                new SqlParameter("SoLuong",ct.SoLuong)
            };
            return _connect.ExcuteSQL("SP_SuaChiTietHopDong", para);
        }

        public int XoaChiTietHopDong(string MaHopDong)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaHD",MaHopDong),

            };
            return _connect.ExcuteSQL("SP_XoaChiTietHopDong", para);
        }

    }
}
