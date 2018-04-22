using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLySieuThi.DAL;
using QuanLySieuThi.Entity;
using System.Data;
namespace QuanLySieuThi.BUS
{
    public class HangHoaBUS
    {
        HangHoaDAL dal = new HangHoaDAL();
        public DataTable GetData()
        {
            return dal.GetData();
        }
        public DataTable TimKiemHH(string str)
        {
            return dal.TimKiemHH(str);
        }
        public int ThemHH(HangHoa ncc)
        {
            return dal.ThemHH(ncc);
        }
        public int SuaHH(HangHoa ncc)
        {
            return dal.SuaHH(ncc);
        }
        public int XoaHH(string id)
        {
            return dal.XoaHH(id);
        }
        public string TangMa()
        {
            return dal.TangMa();
        }
    }
}
