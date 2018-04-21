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
    public class LoaiHangHoaBUS
    {
        LoaiHangHoaDAL dal = new LoaiHangHoaDAL();

        public DataTable GetData()
        {
            return dal.GetData();
        }
        public int InsertData(LoaiHangHoa HH)
        {
            return dal.InsertData(HH);
        }
        public int UpdateData(LoaiHangHoa HH)
        {
            return dal.UpdateData(HH);
        }

        public int DeleteData(string MaLoaiHangHoa)
        {
            return dal.DeleteData(MaLoaiHangHoa);
        }
        public string TangMa()
        {
            return dal.TangMa();
        }
    }
}
