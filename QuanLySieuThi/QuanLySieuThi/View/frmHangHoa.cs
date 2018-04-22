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
using QuanLySieuThi.Views;
namespace QuanLySieuThi.View
{
    public partial class frmHangHoa : Form
    {
        HangHoa hh = new HangHoa();
        HangHoaBUS bus = new HangHoaBUS();
        int fluu = 1;
        public frmHangHoa()
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
            txtMaHH.Enabled = e;
            txtTenHH.Enabled = e;
            txtGia1.Enabled = e;
            dtpNSX.Enabled = e;
            dtpHSD.Enabled = e;
            txtMaLHH.Enabled = e;
            txtGhiChu.Enabled = e;
        }
        private void clearData()
        {
            txtMaHH.Text = "";
            txtTenHH.Text = "";
            txtGia1.Text = "";
            txtMaLHH.Text = "";
            txtGhiChu.Text = "";
            dtpNSX.Value = DateTime.Parse("1/1/1997");
            dtpHSD.Value = DateTime.Parse("1/1/1997");
        }
        private void HienThi()
        {
            dgvHH.DataSource = bus.GetData();
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void frmHangHoa_Load(object sender, EventArgs e)
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
            txtMaHH.Text = bus.TangMa();
            DisEnl(true);
            txtMaHH.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            fluu = 1;
            DisEnl(true);
            txtMaHH.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    bus.XoaHH(txtMaHH.Text);
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
            hh.MaHH = txtMaHH.Text;
            hh.TenHH = txtTenHH.Text;
            hh.Gia = Convert.ToInt32(txtGia1.Text);
            hh.NSX = dtpNSX.Value;
            hh.HSD = dtpHSD.Value;
            hh.MaLHH = txtMaLHH.Text;
            hh.GhiChu = txtGhiChu.Text;
            if (fluu == 0)
            {
                bus.ThemHH(hh);
                MessageBox.Show("Thêm thành công!");
                HienThi();
                clearData();
                DisEnl(false);
            }
            else
            {
                bus.SuaHH(hh);
                MessageBox.Show("Sửa Thành Công ! ");
                HienThi();
                clearData();
                DisEnl(false);
            }
        }

        private void dgvHH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (fluu == 0)
            {
                txtTenHH.Text = Convert.ToString(dgvHH.CurrentRow.Cells["TenHH"].Value);
                txtGia1.Text = Convert.ToString(dgvHH.CurrentRow.Cells["Gia"].Value);
                dtpNSX.Text = Convert.ToString(dgvHH.CurrentRow.Cells["NSX"].Value);
                dtpHSD.Text = Convert.ToString(dgvHH.CurrentRow.Cells["HSD"].Value);
                txtMaLHH.Text = Convert.ToString(dgvHH.CurrentRow.Cells["MaLHH"].Value);
                txtGhiChu.Text = Convert.ToString(dgvHH.CurrentRow.Cells["GhiChu"].Value);
            }
            else
            {
                txtMaHH.Text = Convert.ToString(dgvHH.CurrentRow.Cells["MaHH"].Value);
                txtTenHH.Text = Convert.ToString(dgvHH.CurrentRow.Cells["TenHH"].Value);
                txtGia1.Text = Convert.ToString(dgvHH.CurrentRow.Cells["Gia"].Value);
                dtpNSX.Text = Convert.ToString(dgvHH.CurrentRow.Cells["NSX"].Value);
                dtpHSD.Text = Convert.ToString(dgvHH.CurrentRow.Cells["HSD"].Value);
                txtMaLHH.Text = Convert.ToString(dgvHH.CurrentRow.Cells["MaLHH"].Value);
                txtGhiChu.Text = Convert.ToString(dgvHH.CurrentRow.Cells["GhiChu"].Value);
            }
        }

        private void dgvHH_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvHH.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (cmbTimKiem.Text == "Theo Mã Hàng Hóa")
            {
                dgvHH.DataSource = bus.TimKiemHH("select * from HangHoa where MaHH like '%" + txtTimKiem.Text + "%'");
            }
            if (cmbTimKiem.Text == "Theo Tên Hàng Hóa")
            {
                dgvHH.DataSource = bus.TimKiemHH("select * from HangHoa where TenHH like '%" + txtTimKiem.Text + "%'");
            }
            if (cmbTimKiem.Text == "Theo Giá")
            {
                dgvHH.DataSource = bus.TimKiemHH("select * from HangHoa where Gia like '%" + txtTimKiem.Text + "%'");
            }
            if (cmbTimKiem.Text == "Theo Mã Loại Hàng Hóa")
            {
                dgvHH.DataSource = bus.TimKiemHH("select * from HangHoa where MaLHH like '%" + txtTimKiem.Text + "%'");
            }
            if (cmbTimKiem.Text == "Theo Ghi Chú")
            {
                dgvHH.DataSource = bus.TimKiemHH("select * from HangHoa where GhiChu like '%" + txtTimKiem.Text + "%'");
            }
            if (cmbTimKiem.Text == "Theo Ngày Sản Xuất")
            {
                dgvHH.DataSource = bus.TimKiemHH("select * from HangHoa where NSX like '%" + txtTimKiem.Text + "%'");
            }
            if (cmbTimKiem.Text == "Theo Hạn Sử Dụng")
            {
                dgvHH.DataSource = bus.TimKiemHH("select * from HangHoa where HSD like '%" + txtTimKiem.Text + "%'");
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            HienThi();
        }
    }
}
