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
    class GianHangDAL
    {
        KetNoi conn = new KetNoi();
        public DataTable XemThongTinGianHang()
        {
            return conn.GetData("SP_XemGianHang");
        }
        public DataTable TimKiemGianHang(string str)
        {
            return conn.GetData(str);
        }
        public int ThemGianHang(GianHang gh)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaGH",gh.MaGH),
                new SqlParameter("TenGH",gh.TenGH),
                new SqlParameter("ViTri",gh.Vitri),
                new SqlParameter("MaNQL",gh.MaNQL)
            };
            return conn.ExcuteSQL("SP_ThemGianHang", para);
        }
        public int SuaGianHang(GianHang gh)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaGH",gh.MaGH),
                new SqlParameter("TenGH",gh.TenGH),
                new SqlParameter("ViTri",gh.Vitri),
                new SqlParameter("MaNQL",gh.MaNQL)
            };
            return conn.ExcuteSQL("SP_SuaGianHang", para);
        }
        public int XoaGianHang(string id)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaGH",id)

            };
            return conn.ExcuteSQL("SP_XoaGianHang", para);
        }
        public string TangMa()
        {
            return conn.TangMa("select * from GianHang", "GH");
        }
    }
}
