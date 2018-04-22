using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using QuanLySieuThi.Entity;
using QuanLySieuThi.BUS;
using QuanLySieuThi.Views;

namespace QuanLySieuThi.View
{
    public partial class frmNhaCungCap : Form
    {
        NhaCungCapEntity ncc = new NhaCungCapEntity();
        NhaCungCapBUS bus = new NhaCungCapBUS();
        int fluu = 1;
   
        public frmNhaCungCap()
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
            txtMaNCC.Enabled = e;
            txtTenNCC.Enabled = e;
            txtDiaChi.Enabled = e;
            txtSDT.Enabled = e;
        }
        private void clearData()
        {
            txtMaNCC.Text = "";
            txtTenNCC.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
        }
        private void HienThi()
        {
            dgvNCC.DataSource = bus.GetData();
        }
        private void frmNhaCungCap_Load(object sender, EventArgs e)
        {
            HienThi();
            DisEnl(false);
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
            txtMaNCC.Text = bus.TangMa();
            DisEnl(true);
            txtMaNCC.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            fluu = 1;
            DisEnl(true);
            txtMaNCC.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    bus.XoaNCC(txtMaNCC.Text);
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
            ncc.MaNCC = txtMaNCC.Text;
            ncc.TenNCC = txtTenNCC.Text;
            ncc.DiaChi = txtDiaChi.Text;
            ncc.SDT = txtSDT.Text;
            if (fluu == 0)
            {
                bus.ThemNCC(ncc);
                MessageBox.Show("Thêm thành công!");
                HienThi();
                clearData();
                DisEnl(false);
            }
            else
            {
                bus.SuaNCC(ncc);
                MessageBox.Show("Sửa Thành Công ! ");
                HienThi();
                clearData();
                DisEnl(false);
            }
        }

        private void dgvNCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (fluu == 0)
            {
                txtTenNCC.Text = Convert.ToString(dgvNCC.CurrentRow.Cells["TenNCC"].Value);
                txtDiaChi.Text = Convert.ToString(dgvNCC.CurrentRow.Cells["DiaChi"].Value);
                txtSDT.Text = Convert.ToString(dgvNCC.CurrentRow.Cells["SDT"].Value);
            }
            else
            {
                txtMaNCC.Text = Convert.ToString(dgvNCC.CurrentRow.Cells["MaNCC"].Value);
                txtTenNCC.Text = Convert.ToString(dgvNCC.CurrentRow.Cells["TenNCC"].Value);
                txtDiaChi.Text = Convert.ToString(dgvNCC.CurrentRow.Cells["DiaChi"].Value);
                txtSDT.Text = Convert.ToString(dgvNCC.CurrentRow.Cells["SDT"].Value);
            }
        }

        private void dgvNCC_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvNCC.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (cmbTimKiem.Text == "Theo Mã Nhà Cung Cấp")
            {
                dgvNCC.DataSource = bus.TimKiemNCC("select * from NhaCungCap where MaNCC like '%" + txtTimKiem.Text + "%'");
            }
            if (cmbTimKiem.Text == "Theo Tên Nhà Cung Cấp")
            {
                dgvNCC.DataSource = bus.TimKiemNCC("select * from NhaCungCap where TenNCC like '%" + txtTimKiem.Text + "%'");
            }
            if (cmbTimKiem.Text == "Theo Địa Chỉ")
            {
                dgvNCC.DataSource = bus.TimKiemNCC("select * from NhaCungCap where DiaChi like '%" + txtTimKiem.Text + "%'");
            }
            if (cmbTimKiem.Text == "Theo Số Điện Thoại")
            {
                dgvNCC.DataSource = bus.TimKiemNCC("select * from NhaCungCap where SDT like '%" + txtTimKiem.Text + "%'");
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            HienThi();
        }
    }
}
