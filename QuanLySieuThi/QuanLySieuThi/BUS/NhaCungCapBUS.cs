﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLySieuThi.DAL;
using QuanLySieuThi.Entity;
using System.Data;
namespace QuanLySieuThi.BUS
{
    public class NhaCungCapBUS
    {
        NhaCungCapDAL dal = new NhaCungCapDAL();
        public DataTable GetData()
        {
            return dal.GetData();
        }
        public DataTable TimKiemNCC(string str)
        {
            return dal.TimKiemNCC(str);
        }
        public int ThemNCC(NhaCungCapEntity ncc)
        {
            return dal.ThemNCC(ncc);
        }
        public int SuaNCC(NhaCungCapEntity ncc)
        {
            return dal.SuaNCC(ncc);
        }
        public int XoaNCC(string id)
        {
            return dal.XoaNCC(id);
        }
        public string TangMa()
        {
            return dal.TangMa();
        }
    }
}
