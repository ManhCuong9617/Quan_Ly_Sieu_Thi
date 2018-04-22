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
    public partial class frmLoaiHangHoa_CTLHH : Form
    {

        private LoaiHangHoa _loaiHangHoa = new LoaiHangHoa();
        private LoaiHangHoaBUS BUS_LoaiHangHoa = new LoaiHangHoaBUS();

        private ChiTietLoaiHang _chiTietLoaiHang = new ChiTietLoaiHang();
        private ChiTietLoaiHangBUS BUS_ChiTietLoaiHang = new ChiTietLoaiHangBUS();
        private bool _clickBtn = false;

        public frmLoaiHangHoa_CTLHH()
        {
            InitializeComponent();
        }

        private void KhoaDieuKhien(bool e)
        {
            btnThem.Enabled = !e;
            btnXoa.Enabled = !e;
            btnSua.Enabled = !e;
            btnLuu.Enabled = e;
            btnHuy.Enabled = e;

            txtMaLoaiHang.Enabled = e;
            txtGhiChu.Enabled = e;
            txtSoLuong.Enabled = e;
            cbMaGianHang.Enabled = e;
            txtTenLoaiHang.Enabled = e;
            cbMaNhaCungCap.Enabled = e;
        }

        private void ClearTxt()
        {
            txtMaLoaiHang.Text = "";
            txtTenLoaiHang.Text = "";
            txtGhiChu.Text = "";
            txtSoLuong.Text = "";
            cbMaGianHang.Text = "";
            cbMaNhaCungCap.Text = "";
        }
        private void LayDanhSach_MaGH_MaNCC()
        {
            cbMaGianHang.DataSource = BUS_ChiTietLoaiHang.ListMaGianHang();
            cbMaGianHang.DisplayMember = "MaGH";

            cbMaNhaCungCap.DataSource = BUS_ChiTietLoaiHang.ListMaNhaCungCap();
            cbMaNhaCungCap.DisplayMember = "MaNCC";
             
        }

        private void HienThiChiTietLoaiHang()
        {
            dgvChiTietLoaiHang.DataSource = BUS_ChiTietLoaiHang.GetDataCTLH();
        }
        private void frmLoaiHangHoa_CTLHH_Load(object sender, EventArgs e)
        {
            HienThiChiTietLoaiHang();
            KhoaDieuKhien(false);
        }

        private void dgvChiTietLoaiHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (_clickBtn == true)
            {
                //txtMaLoaiHang.Text = Convert.ToString(dgvChiTietLoaiHang.CurrentRow.Cells["MaLoaiHang"].Value);
                txtGhiChu.Text = Convert.ToString(dgvChiTietLoaiHang.CurrentRow.Cells["GhiChu"].Value);
                txtSoLuong.Text = Convert.ToString(dgvChiTietLoaiHang.CurrentRow.Cells["SoLuong"].Value);
                cbMaGianHang.Text = Convert.ToString(dgvChiTietLoaiHang.CurrentRow.Cells["MaGH"].Value);
                cbMaNhaCungCap.Text = Convert.ToString(dgvChiTietLoaiHang.CurrentRow.Cells["MaNCC"].Value);
                txtTenLoaiHang.Text = Convert.ToString(dgvChiTietLoaiHang.CurrentRow.Cells["TenLH"].Value);
            }
            else
            {
                txtMaLoaiHang.Text = Convert.ToString(dgvChiTietLoaiHang.CurrentRow.Cells["MaLHH"].Value);
                txtGhiChu.Text = Convert.ToString(dgvChiTietLoaiHang.CurrentRow.Cells["GhiChu"].Value);
                txtSoLuong.Text = Convert.ToString(dgvChiTietLoaiHang.CurrentRow.Cells["SoLuong"].Value);
                cbMaGianHang.Text = Convert.ToString(dgvChiTietLoaiHang.CurrentRow.Cells["MaGH"].Value);
                cbMaNhaCungCap.Text = Convert.ToString(dgvChiTietLoaiHang.CurrentRow.Cells["MaNCC"].Value);
                txtTenLoaiHang.Text = Convert.ToString(dgvChiTietLoaiHang.CurrentRow.Cells["TenLH"].Value);
            }
        }

        private void dgvChiTietLoaiHang_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvChiTietLoaiHang.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            KhoaDieuKhien(true);
            LayDanhSach_MaGH_MaNCC();
            _clickBtn = true;
            txtMaLoaiHang.Text = BUS_LoaiHangHoa.TangMa();
            txtMaLoaiHang.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            KhoaDieuKhien(true);
            LayDanhSach_MaGH_MaNCC();
            _clickBtn = false;
            txtMaLoaiHang.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(txtMaLoaiHang.Text=="")
            {
                MessageBox.Show("Chọn để xóa !", "Chú ý!");

            }
            else if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {                   

                    BUS_ChiTietLoaiHang.DeleteData(txtMaLoaiHang.Text);
                    BUS_LoaiHangHoa.DeleteData(txtMaLoaiHang.Text);
                    MessageBox.Show("Xóa thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearTxt();
                    KhoaDieuKhien(false);
                    HienThiChiTietLoaiHang();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có Lỗi Không thể xóa !\n" + ex.Message,"Error");
                }
            }

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtTenLoaiHang.Text == "")
            {
                MessageBox.Show("Thông tin còn thiếu !", "Chú ý!");
            }
            if (txtSoLuong.Text == "")
            {
                MessageBox.Show("Chưa nhập số lượng!", "Chú ý!");
                txtSoLuong.Text = "0";
            }
            else
            {
                _loaiHangHoa.MaLHH = txtMaLoaiHang.Text;
                _loaiHangHoa.TenLHH = txtTenLoaiHang.Text;
                _loaiHangHoa.GhiChu = txtGhiChu.Text;
                _loaiHangHoa.MaGH = cbMaGianHang.Text;
                _chiTietLoaiHang.MaLoaiHH = txtMaLoaiHang.Text;
                _chiTietLoaiHang.MaNhaCC = cbMaNhaCungCap.Text;
                _chiTietLoaiHang.SoLuong = Convert.ToInt32(txtSoLuong.Text);
                try
                {
                    if (_clickBtn == true)
                    {
                        BUS_LoaiHangHoa.InsertData(_loaiHangHoa);
                        BUS_ChiTietLoaiHang.InsertData(_chiTietLoaiHang);

                        MessageBox.Show("Đã thêm ! ");
                    }
                    else
                    {
                        BUS_LoaiHangHoa.UpdateData(_loaiHangHoa);
                        BUS_ChiTietLoaiHang.UpdateData(_chiTietLoaiHang);
                        MessageBox.Show("Đã sửa! ");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi \n" + ex, "Error");
                }
            }
            ClearTxt();
            KhoaDieuKhien(false);
            HienThiChiTietLoaiHang();
            _clickBtn = true;

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn hủy thao tác đang làm?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                HienThiChiTietLoaiHang();
                KhoaDieuKhien(false);
                ClearTxt();
                _clickBtn = true;

            }
            else
                return;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn thoát?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                // frmMain m = new frmMain();
                // m.Show();
                this.Close();
            }
            else
                HienThiChiTietLoaiHang();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
             string timkiem = "SELECT l.MaLHH, TenLHH, GhiChu, MaGH, MaNCC, SoLuong FROM dbo.LoaiHangHoa l  INNER JOIN dbo.ChiTietLoaiHang ON ChiTietLoaiHang.MaLHH = l.MaLHH Where ";
            if(txtTimKiem.Text==""||cbTimKiem.Text=="")
            {
                MessageBox.Show("Điền thông tin tìm kiếm ");
            }
            else
            {
               // try
                //{
                    if (cbTimKiem.Text == "Theo Mã Loại Hàng Hóa")
                    {
                        dgvChiTietLoaiHang.DataSource = BUS_ChiTietLoaiHang.TimKiemNV(timkiem +  " l.MaLHH LIKE N'%" + txtTimKiem.Text.Trim() + "%'");
                    }
                    if (cbTimKiem.Text == "Theo Mã Nhà Cung Cấp")
                    {
                        dgvChiTietLoaiHang.DataSource = BUS_ChiTietLoaiHang.TimKiemNV(timkiem +  " MaNCC LIKE N'%" + txtTimKiem.Text.Trim() + "%'");
                    }

                    if (cbTimKiem.Text == "Theo Tên Loại Hàng Hóa")
                    {
                        dgvChiTietLoaiHang.DataSource = BUS_ChiTietLoaiHang.TimKiemNV(timkiem + " TenLHH LIKE N'%" + txtTimKiem.Text.Trim() + "%'");
                    }
                    if (cbTimKiem.Text == "Theo Mã Gian Hàng")
                    {
                        dgvChiTietLoaiHang.DataSource = BUS_ChiTietLoaiHang.TimKiemNV(timkiem + " MaGH LIKE  '%" + txtTimKiem.Text.Trim() + "%'");
                    }
                //}
               // catch(Exception ex)
               // {
                   // MessageBox.Show("Không thể tìm !\n" + ex);
               // }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearTxt();
            txtTimKiem.Text = "";
            KhoaDieuKhien(false);
            HienThiChiTietLoaiHang();
        }
    }
}
