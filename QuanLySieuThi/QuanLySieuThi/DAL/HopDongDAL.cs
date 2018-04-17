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
    public class HopDongDAL
    {
        KetNoi _connect = new KetNoi();

        public DataTable GetData()
        {
            return _connect.GetData("SP_HopDongSelectAll");
        }

        public int ThemHopDong(HopDongEntity hd)
        {
            SqlParameter[] para = {
                    new SqlParameter("MaHD",hd.MaHopDong),
                    new SqlParameter("NgayKy",hd.NgayKy),
                    new SqlParameter("MaNV", hd.MaNhanVien),
                    new SqlParameter("MaKH", hd.MaKhachHang)
            };
            return _connect.ExcuteSQL("SP_ThemHopDong",para);
        }

        public int SuaHopDong(HopDongEntity hd)
        {
            SqlParameter[] para = {
                    new SqlParameter("MaHD",hd.MaHopDong),
                    new SqlParameter("NgayKy",hd.NgayKy),
                    new SqlParameter("MaNV", hd.MaNhanVien),
                    new SqlParameter("MaKH", hd.MaKhachHang)
            };
            return _connect.ExcuteSQL("SP_SuaHopDong", para);
        }
        public int XoaHopDong(string MaHopDong)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaHD",MaHopDong)
            };
            return _connect.ExcuteSQL("SP_XoaHopDong", para);
        }

        public string TangMa()
        {
            return _connect.TangMa("select * from HopDong", "HD");
        }
    }
}
