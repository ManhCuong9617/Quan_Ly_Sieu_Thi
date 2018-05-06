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
    public partial class frmKhachHang : Form
    {
        KhachHang kh = new KhachHang();
        KhachHangBUS khbus = new KhachHangBUS();
        private int fluu = 1;
        public frmKhachHang()
        {
            InitializeComponent();
        }
        private void DisEnl(bool e)
        {
            btnThem.Enabled = !e;
            btnXoa.Enabled = !e;
            btnSua.Enabled = !e;
            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
            txtMaKhach.Enabled = e;
            txtTenKhach.Enabled = e;
            txtDiaChi.Enabled = e;
            txtSDT.Enabled = e;
        }
        private void clearData()
        {
            txtMaKhach.Text = "";
            txtTenKhach.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
        }
        private void HienThi()
        {
            dgvKhachHang.DataSource = khbus.XemKhachHang();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác Nhận ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                frmMain main = new frmMain();
                main.Show();
                this.Close();
            }
            else
            {
                HienThi();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn hủy thao tác đang làm?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                HienThi();
                DisEnl(false);
            }
            else
                return;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            fluu = 0;
            clearData();
            txtMaKhach.Text = khbus.TangMa();
            DisEnl(true);
            txtMaKhach.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            fluu = 1;
            DisEnl(true);
            txtMaKhach.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    khbus.XoaKhachHang(txtMaKhach.Text);
                    MessageBox.Show("Xóa thành công!");
                    clearData();
                    DisEnl(false);
                    HienThi();
                }
                catch
                {
                    MessageBox.Show("Xóa không thành công");
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            kh.MaKH = txtMaKhach.Text;
            kh.TenKH = txtTenKhach.Text;
            kh.DiaChi = txtDiaChi.Text;
            kh.SDT = Convert.ToInt32(txtSDT.Text);
            if (fluu == 0)
            {
                khbus.ThemKhachHang(kh);
                MessageBox.Show("Thêm thành công!");
                HienThi();
                clearData();
                DisEnl(false);
            }
            else
            {
                khbus.SuaKhachHang(kh);
                MessageBox.Show("Sửa Thành Công ! ");
                HienThi();
                clearData();
                DisEnl(false);
            }
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (fluu == 0)
            {
                txtTenKhach.Text = Convert.ToString(dgvKhachHang.CurrentRow.Cells["TenKH"].Value);
                txtDiaChi.Text = Convert.ToString(dgvKhachHang.CurrentRow.Cells["DiaChi"].Value);
                txtSDT.Text = Convert.ToString(dgvKhachHang.CurrentRow.Cells["SDT"].Value);
            }
            else
            {
                txtMaKhach.Text = Convert.ToString(dgvKhachHang.CurrentRow.Cells["MaKH"].Value);
                txtTenKhach.Text = Convert.ToString(dgvKhachHang.CurrentRow.Cells["TenKH"].Value);
                txtDiaChi.Text = Convert.ToString(dgvKhachHang.CurrentRow.Cells["DiaChi"].Value);
                txtSDT.Text = Convert.ToString(dgvKhachHang.CurrentRow.Cells["SDT"].Value);
            }
        }

        private void dgvKhachHang_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvKhachHang.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (cmbTimKiem.Text == "Theo Mã Khách Hàng")
            {
                dgvKhachHang.DataSource = khbus.TimKiemKhachHang("select * from KhachHang where MaKH like '%" + txtTimKiem.Text + "%'");
            }
            if (cmbTimKiem.Text == "Theo Tên Khách Hàng")
            {
                dgvKhachHang.DataSource = khbus.TimKiemKhachHang("select * from KhachHang where MaKH like '%" + txtTimKiem.Text + "%'");
            }
            if (cmbTimKiem.Text == "Theo Địa Chỉ")
            {
                dgvKhachHang.DataSource = khbus.TimKiemKhachHang("select * from KhachHang where MaKH like '%" + txtTimKiem.Text + "%'");
            }
            if (cmbTimKiem.Text == "Theo Điện Thoại")
            {
                dgvKhachHang.DataSource = khbus.TimKiemKhachHang("select * from KhachHang where MaKH like '%" + txtTimKiem.Text + "%'");
            }
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            HienThi();
            DisEnl(false);
        }
    }
}
