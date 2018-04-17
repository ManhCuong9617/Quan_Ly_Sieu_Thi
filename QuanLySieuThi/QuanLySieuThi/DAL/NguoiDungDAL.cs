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
    public class NguoiDungDAL
    {
        KetNoi conn = new KetNoi();
        public DataTable LayThongTinNguoiDung(NguoiDung nd)
        {
            SqlParameter[] para =
            {
                new SqlParameter("TaiKhoan",nd.TaiKhoan),
                new SqlParameter("MatKhau",nd.MatKhau)
            };
            return conn.GetData("LayThongTinNguoiDung", para);
        }
    }
}
