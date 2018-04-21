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
    public class ChiTietLoaiHangDAL
    {
        KetNoi _connect = new KetNoi();

        public DataTable GetDataCTLH()
        {
            return _connect.GetData("SP_XemChiTietLoaiHang",null);
        }
        public int InsertData(ChiTietLoaiHang  CT)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaLHH",CT.MaLoaiHH),
                new SqlParameter("MaNCC",CT.MaNhaCC),
                new SqlParameter("SoLuong",CT.SoLuong)          
            };
            return _connect.ExcuteSQL("SP_ThemCTLH ", para);
        }
        public int DeleteData(string MaLHH, string MaNCC)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaHD",MaLHH),
                new SqlParameter("MaHH",MaNCC)
        };
            return _connect.ExcuteSQL("SP_XoaCTLH", para);
        }
    }
}
