namespace QuanLySieuThi.View
{
    partial class frmInHoaDon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.inHoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLySieuThiDataSet = new QuanLySieuThi.QuanLySieuThiDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.inHoaDonTableAdapter = new QuanLySieuThi.QuanLySieuThiDataSetTableAdapters.InHoaDonTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.inHoaDonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLySieuThiDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // inHoaDonBindingSource
            // 
            this.inHoaDonBindingSource.DataMember = "InHoaDon";
            this.inHoaDonBindingSource.DataSource = this.quanLySieuThiDataSet;
            // 
            // quanLySieuThiDataSet
            // 
            this.quanLySieuThiDataSet.DataSetName = "QuanLySieuThiDataSet";
            this.quanLySieuThiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.inHoaDonBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLySieuThi.View.HoaDon.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(686, 416);
            this.reportViewer1.TabIndex = 0;
            // 
            // inHoaDonTableAdapter
            // 
            this.inHoaDonTableAdapter.ClearBeforeFill = true;
            // 
            // frmInHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 416);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmInHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmInHoaDon";
            this.Load += new System.EventHandler(this.frmInHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inHoaDonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLySieuThiDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private QuanLySieuThiDataSet quanLySieuThiDataSet;
        private System.Windows.Forms.BindingSource inHoaDonBindingSource;
        private QuanLySieuThiDataSetTableAdapters.InHoaDonTableAdapter inHoaDonTableAdapter;
    }
}