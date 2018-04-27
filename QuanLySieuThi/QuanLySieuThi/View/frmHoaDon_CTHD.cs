using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLySieuThi.BUS;
using QuanLySieuThi.Entity;
namespace QuanLySieuThi.View
{
    public partial class frmHoaDon_CTHD : Form
    {
        HoaDonBUS HDbus = new HoaDonBUS();
        HoaDonEntity HD = new HoaDonEntity();
        ChiTietHoaDonBUS CTHDbus = new ChiTietHoaDonBUS();
        ChiTietHoaDonEntity CTHD = new ChiTietHoaDonEntity();
        public static string Ma;
        private int fluu = 1;
        public frmHoaDon_CTHD()
        {
            InitializeComponent();
        }

        private void txtMaHD_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new System.Data.DataTable();
                dt = CTHDbus.GetDataByID(txtMaHD.Text);
                dgvCTHD.DataSource = dt;
            }
            catch
            {
                dgvCTHD.DataSource = null;
            }
        }
        private void DisEnl(bool e)
        {
            btnThem.Enabled = !e;
            btnXoa.Enabled = !e;
            btnInHD.Enabled = !e;
            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
            txtMaHD.Enabled = e;
            //txtDonGia.Enabled = e;
           // txtSoLuong.Enabled = e;
            cmbKH.Enabled = e;
            cmbNV.Enabled = e;
            //cmbSP.Enabled = e;
            dpNgayLap.Enabled = e;
        }
        private void KhoaPhim(bool e)
        {
            btnThemCTHD.Enabled = !e;
            btnXoaCTHD.Enabled = !e;
            btnLuuCTHD.Enabled = e;
            btnHuyCTHD.Enabled = e;
            txtMaHD.Enabled = e;
            txtSoLuong.Enabled = e;
            //txtDonGia.Enabled = e;
            cmbHH.Enabled = e;
        }
        private void clearData()
        {
            txtMaHD.Text = "";
            cmbKH.Text = "";
            cmbNV.Text = "";
            dpNgayLap.Text = "";
        }
        private void clearDataCTHD()
        {
           // txtMaHD.Text = "";
            cmbHH.Text = "";
            txtDonGia.Text = "";
            txtSoLuong.Text = "0";
            lbThanhTien.Text =  "0";
        }
        public void ShowHangHoa()
        {
            DataTable dt = new DataTable();
            dt = CTHDbus.GetListHangHoa();
            cmbHH.DataSource = dt;
            cmbHH.DisplayMember = "TenHH";
            cmbHH.ValueMember = "MaHH";
        }
        public void ShowNhanVien()
        {
            DataTable dt = new DataTable();
            dt = HDbus.GetListNhanVien();
            cmbNV.DataSource = dt;
            cmbNV.DisplayMember = "TenNV";
            cmbNV.ValueMember = "MaNV";
        }
        public void ShowKhachHang()
        {
            DataTable dt = new DataTable();
            dt = HDbus.GetListKhachHang();
            cmbKH.DataSource = dt;
            cmbKH.DisplayMember = "TenKH";
            cmbKH.ValueMember = "MaKH";
        }
        private void HienThi()
        {
            dgvHoaDon.DataSource = HDbus.GetData();
        }
        private void frmHoaDon_CTHD_Load(object sender, EventArgs e)
        {
            HienThi();
            DisEnl(false);
            ShowNhanVien();
            ShowHangHoa();
            ShowKhachHang();
        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (fluu == 0)
            {
                cmbKH.Text = Convert.ToString(dgvHoaDon.CurrentRow.Cells["TenKH"].Value);
                cmbNV.Text = Convert.ToString(dgvHoaDon.CurrentRow.Cells["TenNV"].Value);
                dpNgayLap.Text = Convert.ToString(dgvHoaDon.CurrentRow.Cells["NgayLap"].Value);
            }
            else
            {
                txtMaHD.Text = Convert.ToString(dgvHoaDon.CurrentRow.Cells["MaHD"].Value);
                cmbKH.Text = Convert.ToString(dgvHoaDon.CurrentRow.Cells["TenKH"].Value);
                cmbNV.Text = Convert.ToString(dgvHoaDon.CurrentRow.Cells["TenNV"].Value);
                dpNgayLap.Text = Convert.ToString(dgvHoaDon.CurrentRow.Cells["NgayLap"].Value);
            }
        }

        private void dgvHoaDon_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvHoaDon.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }

        private void dgvCTHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaHD.Text = Convert.ToString(dgvCTHD.CurrentRow.Cells["MaHD1"].Value);
            cmbHH.Text = Convert.ToString(dgvCTHD.CurrentRow.Cells["TenHH"].Value);
            txtDonGia.Text = Convert.ToString(dgvCTHD.CurrentRow.Cells["DonGia"].Value);
            txtSoLuong.Text = Convert.ToString(dgvCTHD.CurrentRow.Cells["SoLuong"].Value);
            lbThanhTien.Text = Convert.ToString(dgvCTHD.CurrentRow.Cells["ThanhTien"].Value);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            fluu = 0;
            txtMaHD.Text = HDbus.TangMa();
            DisEnl(true);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaHD.Text == "")
            {
                MessageBox.Show("Yêu Cầu nhập thông tin đầy đủ!");

            }
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    HDbus.DeleteData(txtMaHD.Text);
                    MessageBox.Show("Xóa thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearData();
                    DisEnl(false);
                    HienThi();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có Lỗi Không thể xóa !" + ex.Message);
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaHD.Text == "" || cmbKH.Text == "" || cmbNV.Text == "" || dpNgayLap.Text == "")
            {
                MessageBox.Show("Yêu Cầu nhập thông tin đầy đủ!");

            }
            else
            {
                txtMaHD.Enabled = false;
                HD.MaHD = txtMaHD.Text;
                HD.MaKH = cmbKH.SelectedValue.ToString();
                HD.MaNV = cmbNV.SelectedValue.ToString();
                HD.NgayLap = dpNgayLap.Text;
                try
                {
                    HDbus.InsertData(HD);
                    MessageBox.Show("Thêm thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThi();
                    clearData();
                    DisEnl(false);
                    fluu = 1;
                }
                catch
                {
                   // MessageBox.Show("Thêm Không thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void btnThemCTHD_Click(object sender, EventArgs e)
        {
            KhoaPhim(true);
        }

        private void btnXoaCTHD_Click(object sender, EventArgs e)
        {
            if (txtMaHD.Text == "" || cmbHH.Text == "")
            {
                MessageBox.Show("Yêu Cầu nhập thông tin đầy đủ!");

            }
            else
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        CTHDbus.DeleteData(txtMaHD.Text,cmbHH.SelectedValue.ToString());
                        MessageBox.Show("Xóa thành công!");
                        clearDataCTHD();
                        HienThi();
                        KhoaPhim(false);
                        
                    }
                    catch
                    {
                    }
                }
            }
        }
        private void cmbSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView d = (DataRowView)cmbHH.SelectedItem;

            txtDonGia.Text = d.Row["Gia"].ToString();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn hủy thao tác đang làm?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                HienThi();
                DisEnl(false);
                clearData();
                fluu = 1;

            }
            else
                return;
        }

        private void btnHuyCTHD_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn hủy thao tác đang làm?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                HienThi();
                KhoaPhim(false);
                clearDataCTHD();
            }
            else
                return;
        }

        private void btnLuuCTHD_Click(object sender, EventArgs e)
        {
            if (txtMaHD.Text == "" || cmbHH.Text == "")
            {
                MessageBox.Show("Yêu Cầu nhập thông tin đầy đủ!");

            }
            else
            {
                CTHD.MaHD = txtMaHD.Text;
                CTHD.MaHH = cmbHH.SelectedValue.ToString();
                CTHD.SoLuong = int.Parse(txtSoLuong.Text.ToString());
                CTHD.DonGia = int.Parse(txtDonGia.Text.ToString());
                try
                {
                    CTHDbus.InsertData(CTHD);
                    MessageBox.Show("Thêm thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThi();
                    KhoaPhim(false);
                    clearDataCTHD();
                    
                }
                catch
                {
                    //MessageBox.Show("Thêm Không thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            lbThanhTien.Text = (int.Parse(txtDonGia.Text) * int.Parse(txtSoLuong.Text)).ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn hủy thao tác đang làm?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
               // frmMain m = new frmMain();
               // m.Show();
                this.Close();
            }
            else
                HienThi();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        { 
            if (cmbTimKiem.Text == "Theo Mã Hóa Đơn")
            {
                dgvHoaDon.DataSource = HDbus.TimKiemHD("SELECT HoaDon.MaHD,TenKH,TenNV,NgayLap FROM dbo.HoaDon,dbo.KhachHang,dbo.NhanVien WHERE HoaDon.MaNV = NhanVien.MaNV AND KhachHang.MaKH = HoaDon.MaKH and MaHD  Like '%" + txtTimKiem.Text.Trim() + "%'");
            }
            if (cmbTimKiem.Text == "Theo Khách Hàng")
            {
                dgvHoaDon.DataSource = HDbus.TimKiemHD("SELECT HoaDon.MaHD,TenKH,TenNV,NgayLap FROM dbo.HoaDon,dbo.KhachHang,dbo.NhanVien WHERE HoaDon.MaNV = NhanVien.MaNV AND KhachHang.MaKH = HoaDon.MaKH and TenKH LIKE N'%" + txtTimKiem.Text.Trim() + "%'");
            }
            if (cmbTimKiem.Text == "Theo Nhân Viên")
            {
                dgvHoaDon.DataSource = HDbus.TimKiemHD("SELECT HoaDon.MaHD,TenKH,TenNV,NgayLap FROM dbo.HoaDon,dbo.KhachHang,dbo.NhanVien WHERE HoaDon.MaNV = NhanVien.MaNV AND KhachHang.MaKH = HoaDon.MaKH  and TenNV  LIKE N'%" + txtTimKiem.Text.Trim() + "%'");
            }
            if (cmbTimKiem.Text == "Theo Ngày Lập")
            {
                dgvHoaDon.DataSource = HDbus.TimKiemHD("SELECT HoaDon.MaHD,TenKH,TenNV,NgayLap FROM dbo.HoaDon,dbo.KhachHang,dbo.NhanVien WHERE HoaDon.MaNV = NhanVien.MaNV AND KhachHang.MaKH = HoaDon.MaKH   and NgayLap LIKE '%" + txtTimKiem.Text.Trim() + "%'");
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTimKiem.Text = "";
            cmbTimKiem.Text = "";
            HienThi();
        }

        private void btnInHD_Click(object sender, EventArgs e)
        {
            if(txtMaHD.Text != null)
            {
                Ma = txtMaHD.Text;
                frmInHoaDon frmIn = new frmInHoaDon();
                frmIn.Show();
            }
            else
            {
                MessageBox.Show("Yêu Cầu Nhập Đầy Đủ Thông Tin!!");
            }
        }
    }
}
