using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLySieuThi.DAL;
using System.Data;
using System.Data.SqlClient;
using QuanLySieuThi.Entity;

namespace QuanLySieuThi.BUS
{
    public class ChiTietLoaiHangBUS
    {
        ChiTietLoaiHangDAL dal = new ChiTietLoaiHangDAL();

        public DataTable GetDataCTLH()
        {
            return dal.GetDataCTLH();
        }
        public int InsertData(ChiTietLoaiHang CT)
        {
            return dal.InsertData(CT);
        }
        public int DeleteData(string MaLHH, string MaNCC)
        {
            return dal.DeleteData(MaLHH, MaNCC);
        }
    }
}
