using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLySieuThi.Entity;
using QuanLySieuThi.BUS;
namespace QuanLySieuThi.View
{
    public partial class frmDangNhap : Form
    {
        NguoiDung nd = new NguoiDung();
        NguoiDungBUS ndbus = new NguoiDungBUS();
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            nd.TaiKhoan = txtTaiKhoan.Text;
            nd.MatKhau = txtMatKhau.Text;
            DataTable dt = ndbus.LayThongTinNguoiDung(nd);
            if (dt.Rows.Count > 0 )
            {
                frmMain main = new frmMain();
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
