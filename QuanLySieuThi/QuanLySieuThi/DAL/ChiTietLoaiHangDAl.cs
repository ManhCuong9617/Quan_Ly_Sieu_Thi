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
    public class ChiTietLoaiHangDAL
    {
        KetNoi _connect = new KetNoi();

        public DataTable GetDataCTLH()
        {
            return _connect.GetData("SP_XemChiTietLoaiHang",null);
        }
        public int InsertData(ChiTietLoaiHang  CT)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaLHH",CT.MaLoaiHH),
                new SqlParameter("MaNCC",CT.MaNhaCC),
                new SqlParameter("SoLuong",CT.SoLuong)          
            };
            return _connect.ExcuteSQL("SP_ThemCTLH ", para);
        }

        public int UpdateData(ChiTietLoaiHang CT)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaLHH",CT.MaLoaiHH),
                new SqlParameter("MaNCC",CT.MaNhaCC),
                new SqlParameter("SoLuong",CT.SoLuong)
            };
            return _connect.ExcuteSQL("SP_SuaCTLH ", para);
        }
        public int DeleteData(string MaLHH)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaLHH",MaLHH),
            };
            return _connect.ExcuteSQL("SP_XoaCTLH", para);
        }
        public DataTable TimKiemNV(string strTimKiem)
        {
            return _connect.GetData(strTimKiem);
        }

        public DataTable ListMaGianHang()
        {
            return _connect.GetData("SP_ListMaGianHang", null);
        }

        public DataTable ListMaNhaCungCap()
        {
            return _connect.GetData("SP_ListMaNhaCungCap", null);
        }
    }
}
