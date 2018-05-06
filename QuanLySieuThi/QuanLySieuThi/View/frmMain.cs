using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySieuThi.View
{
    public partial class frmMain : Form
    {
        
        public frmMain()
        {
            InitializeComponent();
        }
        private int i = 10;
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbchuchay.Location = new Point(lbchuchay.Location.X - i, lbchuchay.Location.Y);

            if (lbchuchay.Location.X <= -510 || lbchuchay.Location.Y <= 0)
            {
                lbchuchay.Location = new Point(lbchuchay.Location.X + 1300, lbchuchay.Location.Y);
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDangNhap dt = new frmDangNhap();
            dt.Show();
            this.Hide();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhanVien dt = new frmNhanVien();
            dt.Show();
            this.Hide();
        }



        private void trợGiúpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmhuongdan h = new frmhuongdan();
            h.Show();
        }

        private void QLKH_Click(object sender, EventArgs e)
        {
            frmKhachHang dt = new frmKhachHang();
            dt.Show();
            this.Hide();
        }

        private void QLHD_Click(object sender, EventArgs e)
        {
            frmHoaDon_CTHD k = new frmHoaDon_CTHD();
            k.Show();
            this.Hide();
        }

        private void QLHH_Click(object sender, EventArgs e)
        {
            frmHangHoa k = new frmHangHoa();
            k.Show();
            this.Hide();
        }

        private void QLLHH_Click(object sender, EventArgs e)
        {
            frmLoaiHangHoa_CTLHH k = new frmLoaiHangHoa_CTLHH();
            k.Show();
            this.Hide();
        }

        private void QLDT_Click(object sender, EventArgs e)
        {
            frmNhaCungCap k = new frmNhaCungCap();
            k.Show();
            this.Hide();
        }

        private void QLGH_Click(object sender, EventArgs e)
        {
            frmGianHang k = new frmGianHang();
            k.Show();
            this.Hide();
        }
    }
}
