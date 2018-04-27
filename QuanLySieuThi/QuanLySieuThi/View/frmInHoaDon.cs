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
    public partial class frmInHoaDon : Form
    {
        public frmInHoaDon()
        {
            InitializeComponent();
        }

        private void frmInHoaDon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLySieuThiDataSet.InHoaDon' table. You can move, or remove it, as needed.
            this.inHoaDonTableAdapter.Fill(this.quanLySieuThiDataSet.InHoaDon,frmHoaDon_CTHD.Ma);

            this.reportViewer1.RefreshReport();
        }
    }
}
