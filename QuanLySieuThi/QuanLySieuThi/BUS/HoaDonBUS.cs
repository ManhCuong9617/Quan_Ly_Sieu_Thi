using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLySieuThi.Entity;
using System.Data;
using System.Data.SqlClient;
using QuanLySieuThi.DAL;

namespace QuanLySieuThi.BUS
{
    public class HoaDonBUS
    {
        HoaDonDAL da = new HoaDonDAL();
        public DataTable GetData()
        {
            return da.GetData();
        }
        public int InsertData(HoaDonEntity HD)
        {
            return da.InsertData(HD);
        }
        public int DeleteData(String ID)
        {
            return da.DeleteData(ID);
        }
        public string TangMa()
        {
            return da.TangMa();
        }
        public DataTable TimKiemHD(string strTimKiem)
        {
            return da.TimKiemHD(strTimKiem);
        }
        public DataTable GetListKhachHang()
        {
            return da.GetListKhachHang();
        }
        public DataTable GetListNhanVien()
        {
            return da.GetListNhanVien();
        }
    }
}
