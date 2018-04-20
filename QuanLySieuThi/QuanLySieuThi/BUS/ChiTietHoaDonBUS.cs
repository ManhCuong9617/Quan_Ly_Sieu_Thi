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
    public class ChiTietHoaDonBUS
    {
        ChiTietHoaDonDAL da = new ChiTietHoaDonDAL();
        public DataTable GetDataByID(string ID)
        {
            return da.GetDataByID(ID);
        }
        public DataTable GetDataHH(string ID)
        {
            return da.GetDataHH(ID);
        }
        public int InsertData(ChiTietHoaDonEntity CT)
        {
            return da.InsertData(CT);
        }
        public int DeleteData(string MaHD,string MaSP)
        {
            return da.DeleteData(MaHD,MaSP);
        }
        public DataTable GetListHangHoa()
        {
            return da.GetListHangHoa();
        }
    }
}
