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
    public partial class frmGianHang : Form
    {
        public frmGianHang()
        {
            InitializeComponent();
        }

        GianHang gh = new GianHang();
        GianHangBUS ghbus = new GianHangBUS();
        private int fluu = 1;
      
        private void DisEnl(bool e)
        {
            btnThem.Enabled = !e;
            btnXoa.Enabled = !e;
            btnSua.Enabled = !e;
            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
            txtMaGian.Enabled = e;
            txtTenGian.Enabled = e;
            txtViTri.Enabled = e;
            txtMaNQL.Enabled = e;
        }
        private void clearData()
        {
            txtMaGian.Text = "";
            txtTenGian.Text = "";
            txtViTri.Text = "";
            txtMaNQL.Text = "";
        }
        private void HienThi()
        {
            dgvGianHang.DataSource = ghbus.XemGianHang();
        }
        private void frmGianHang_Load(object sender, EventArgs e)
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
            txtMaGian.Text = ghbus.TangMa();
            DisEnl(true);
            txtMaGian.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            fluu = 1;
            DisEnl(true);
            txtMaGian.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    ghbus.XoaGianHang(txtMaGian.Text);
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
            gh.MaGH = txtMaGian.Text;
            gh.TenGH = txtTenGian.Text;
            gh.Vitri = txtViTri.Text;
            gh.MaNQL = txtMaNQL.Text;
            if (fluu == 0)
            {
                ghbus.ThemKhachHang(gh);
                MessageBox.Show("Thêm thành công!");
                HienThi();
                clearData();
                DisEnl(false);
            }
            else
            {
                ghbus.SuaKhachHang(gh);
                MessageBox.Show("Sửa Thành Công ! ");
                HienThi();
                clearData();
                DisEnl(false);
            }
        }

        private void dgvGianHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (fluu == 0)
            {
                txtTenGian.Text = Convert.ToString(dgvGianHang.CurrentRow.Cells["TenGH"].Value);
                txtViTri.Text = Convert.ToString(dgvGianHang.CurrentRow.Cells["ViTri"].Value);
                txtMaNQL.Text = Convert.ToString(dgvGianHang.CurrentRow.Cells["MaNQL"].Value);
            }

            else
            {
                txtMaGian.Text = Convert.ToString(dgvGianHang.CurrentRow.Cells["MaGH"].Value);
                txtTenGian.Text = Convert.ToString(dgvGianHang.CurrentRow.Cells["TenGH"].Value);
                txtViTri.Text = Convert.ToString(dgvGianHang.CurrentRow.Cells["ViTri"].Value);
                txtMaNQL.Text = Convert.ToString(dgvGianHang.CurrentRow.Cells["MaNQL"].Value);
            }
        }

        private void dgvGianHang_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvGianHang.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (cmbTimKiem.Text == "Theo Mã Gian Hàng")
            {
                dgvGianHang.DataSource = ghbus.TimKiemGianHang("select * from GianHang where MaGH like '%" + txtTimKiem.Text + "%'");
            }
            if (cmbTimKiem.Text == "Theo Tên Gian Hàng")
            {
                dgvGianHang.DataSource = ghbus.TimKiemGianHang("select * from GianHang where TenGH like N'%" + txtTimKiem.Text + "%'");
            }
            if (cmbTimKiem.Text == "Theo Vị Trí")
            {
                dgvGianHang.DataSource = ghbus.TimKiemGianHang("select * from GianHang where ViTri like N'%" + txtTimKiem.Text + "%'");
            }
            if (cmbTimKiem.Text == "Theo Mã NQL")
            {
                dgvGianHang.DataSource = ghbus.TimKiemGianHang("select * from GianHang where MaNQL like '%" + txtTimKiem.Text + "%'");
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            HienThi();
        }
    }
}
