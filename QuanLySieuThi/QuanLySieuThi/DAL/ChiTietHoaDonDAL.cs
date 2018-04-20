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
    public class ChiTietHoaDonDAL
    {
        KetNoi conn = new KetNoi();
        public DataTable GetDataByID(String ID)
        {
            SqlParameter[] para = { new SqlParameter("Ma", ID) };
            return conn.GetData("CTHD_SelectByID", para);
        }
        public DataTable GetDataHH(String ID)
        {
            SqlParameter[] para = { new SqlParameter("Ma", ID) };
            return conn.GetData("CTHD_SelectHangHoa", para);
        }
        public int InsertData(ChiTietHoaDonEntity CT)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaHD",CT.MaHD),
                new SqlParameter("MaHH",CT.MaHH),
                new SqlParameter("SoLuong",CT.SoLuong),
                new SqlParameter("DonGia",CT.DonGia)
            };
            return conn.ExcuteSQL("Them_CTHD ", para);
        }
        public int DeleteData(string MaHD,string MaHH)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaHD",MaHD),
                new SqlParameter("MaHH",MaHH)
        };
            return conn.ExcuteSQL("Xoa_CTHD", para);
        }
        public DataTable GetListHangHoa()
        {
            return conn.GetData("Select_HH", null);
        }
    }
}
