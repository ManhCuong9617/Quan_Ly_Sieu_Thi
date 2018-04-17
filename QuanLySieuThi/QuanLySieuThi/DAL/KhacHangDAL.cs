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
    public class KhacHangDAL
    {
        KetNoi conn = new KetNoi();
        public DataTable XemThongTinKhachHang()
        {
            return conn.GetData("SP_XemKhachHang");
        }
        public DataTable TimKiemKhachHang(string str)
        {
            return conn.GetData(str);
        }
        public int ThemKhachHang(KhachHang kh)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaKH",kh.MaKH),
                new SqlParameter("TenKH",kh.TenKH),
                new SqlParameter("DiaChi",kh.DiaChi),
                new SqlParameter("SDT",kh.SDT)
            };
            return conn.ExcuteSQL("SP_ThemKhachHang", para);
        }
        public int SuaKhachHang(KhachHang kh)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaKH",kh.MaKH),
                new SqlParameter("TenKH",kh.TenKH),
                new SqlParameter("DiaChi",kh.DiaChi),
                new SqlParameter("SDT",kh.SDT)
            };
            return conn.ExcuteSQL("SP_SuaKhachHang", para);
        }
        public int XoaKhachHang(string id)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaKH",id)
                
            };
            return conn.ExcuteSQL("SP_XoaKhachHang", para);
        }
        public string TangMa()
        {
            return conn.TangMa("select * from KhachHang","KH");
        }

    }
}
