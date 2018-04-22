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
        public int UpdateData(ChiTietLoaiHang CT)
        {
            return dal.UpdateData(CT);
        }

        public int DeleteData(string MaLHH)
        {
            return dal.DeleteData(MaLHH);
        }

        public DataTable TimKiemNV(string strTimKiem)
        {
            return dal.TimKiemNV(strTimKiem);
        }

        public DataTable ListMaGianHang()
        {
            return dal.ListMaGianHang();
        }

        public DataTable ListMaNhaCungCap()
        {
            return dal.ListMaNhaCungCap();
        }
    }
}
