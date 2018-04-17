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
    public class NguoiDungBUS
    {
        NguoiDung nd = new NguoiDung();
        NguoiDungDAL nddal = new NguoiDungDAL();
        public DataTable LayThongTinNguoiDung(NguoiDung nd)
        {
            return nddal.LayThongTinNguoiDung(nd);
        }


    }
}
