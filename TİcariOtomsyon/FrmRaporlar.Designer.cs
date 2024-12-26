namespace TİcariOtomsyon
{
    partial class FrmRaporlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRaporlar));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.Tbl_MusterilerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Dbo_TicariOtomasyonDataSet = new TİcariOtomsyon.Dbo_TicariOtomasyonDataSet();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage4 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage5 = new DevExpress.XtraTab.XtraTabPage();
            this.Tbl_MusterilerTableAdapter = new TİcariOtomsyon.Dbo_TicariOtomasyonDataSetTableAdapters.Tbl_MusterilerTableAdapter();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Dbo_TicariOtomasyonDataSet1 = new TİcariOtomsyon.Dbo_TicariOtomasyonDataSet1();
            this.Tbl_FirmalarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Tbl_FirmalarTableAdapter = new TİcariOtomsyon.Dbo_TicariOtomasyonDataSet1TableAdapters.Tbl_FirmalarTableAdapter();
            this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer4 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Dbo_TicariOtomasyonDataSet2 = new TİcariOtomsyon.Dbo_TicariOtomasyonDataSet2();
            this.Tbl_GiderlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Tbl_GiderlerTableAdapter = new TİcariOtomsyon.Dbo_TicariOtomasyonDataSet2TableAdapters.Tbl_GiderlerTableAdapter();
            this.reportViewer5 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Dbo_TicariOtomasyonDataSet4 = new TİcariOtomsyon.Dbo_TicariOtomasyonDataSet4();
            this.Tbl_PersonellerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Tbl_PersonellerTableAdapter = new TİcariOtomsyon.Dbo_TicariOtomasyonDataSet4TableAdapters.Tbl_PersonellerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Tbl_MusterilerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dbo_TicariOtomasyonDataSet)).BeginInit();
            this.xtraTabPage1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage3.SuspendLayout();
            this.xtraTabPage4.SuspendLayout();
            this.xtraTabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dbo_TicariOtomasyonDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tbl_FirmalarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dbo_TicariOtomasyonDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tbl_GiderlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dbo_TicariOtomasyonDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tbl_PersonellerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Tbl_MusterilerBindingSource
            // 
            this.Tbl_MusterilerBindingSource.DataMember = "Tbl_Musteriler";
            this.Tbl_MusterilerBindingSource.DataSource = this.Dbo_TicariOtomasyonDataSet;
            // 
            // Dbo_TicariOtomasyonDataSet
            // 
            this.Dbo_TicariOtomasyonDataSet.DataSetName = "Dbo_TicariOtomasyonDataSet";
            this.Dbo_TicariOtomasyonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.reportViewer1);
            this.xtraTabPage1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage1.ImageOptions.Image")));
            this.xtraTabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1922, 1003);
            this.xtraTabPage1.Text = "Müşteri Raporları";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Tbl_MusterilerBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TİcariOtomsyon.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1922, 1003);
            this.reportViewer1.TabIndex = 0;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.reportViewer2);
            this.xtraTabPage2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage2.ImageOptions.Image")));
            this.xtraTabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(1922, 1003);
            this.xtraTabPage2.Text = "Firma Raporları";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(1924, 1033);
            this.xtraTabControl1.TabIndex = 1;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2,
            this.xtraTabPage3,
            this.xtraTabPage4,
            this.xtraTabPage5});
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.reportViewer3);
            this.xtraTabPage3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage3.ImageOptions.Image")));
            this.xtraTabPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(1922, 1003);
            this.xtraTabPage3.Text = "Kasa Raporları";
            // 
            // xtraTabPage4
            // 
            this.xtraTabPage4.Controls.Add(this.reportViewer4);
            this.xtraTabPage4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage4.ImageOptions.Image")));
            this.xtraTabPage4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.xtraTabPage4.Name = "xtraTabPage4";
            this.xtraTabPage4.Size = new System.Drawing.Size(1922, 1003);
            this.xtraTabPage4.Text = "Gider Raporları";
            // 
            // xtraTabPage5
            // 
            this.xtraTabPage5.Controls.Add(this.reportViewer5);
            this.xtraTabPage5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage5.ImageOptions.Image")));
            this.xtraTabPage5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.xtraTabPage5.Name = "xtraTabPage5";
            this.xtraTabPage5.Size = new System.Drawing.Size(1922, 1003);
            this.xtraTabPage5.Text = "Personel Raporları";
            // 
            // Tbl_MusterilerTableAdapter
            // 
            this.Tbl_MusterilerTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer2
            // 
            this.reportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.Tbl_FirmalarBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "TİcariOtomsyon.FirmaRaporları.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(0, 0);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(1922, 1003);
            this.reportViewer2.TabIndex = 0;
            // 
            // Dbo_TicariOtomasyonDataSet1
            // 
            this.Dbo_TicariOtomasyonDataSet1.DataSetName = "Dbo_TicariOtomasyonDataSet1";
            this.Dbo_TicariOtomasyonDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Tbl_FirmalarBindingSource
            // 
            this.Tbl_FirmalarBindingSource.DataMember = "Tbl_Firmalar";
            this.Tbl_FirmalarBindingSource.DataSource = this.Dbo_TicariOtomasyonDataSet1;
            // 
            // Tbl_FirmalarTableAdapter
            // 
            this.Tbl_FirmalarTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer3
            // 
            this.reportViewer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer3.Location = new System.Drawing.Point(0, 0);
            this.reportViewer3.Name = "reportViewer3";
            this.reportViewer3.ServerReport.BearerToken = null;
            this.reportViewer3.Size = new System.Drawing.Size(1922, 1003);
            this.reportViewer3.TabIndex = 0;
            // 
            // reportViewer4
            // 
            this.reportViewer4.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.Tbl_GiderlerBindingSource;
            this.reportViewer4.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer4.LocalReport.ReportEmbeddedResource = "TİcariOtomsyon.Report2.rdlc";
            this.reportViewer4.Location = new System.Drawing.Point(0, 0);
            this.reportViewer4.Name = "reportViewer4";
            this.reportViewer4.ServerReport.BearerToken = null;
            this.reportViewer4.Size = new System.Drawing.Size(1922, 1003);
            this.reportViewer4.TabIndex = 0;
            // 
            // Dbo_TicariOtomasyonDataSet2
            // 
            this.Dbo_TicariOtomasyonDataSet2.DataSetName = "Dbo_TicariOtomasyonDataSet2";
            this.Dbo_TicariOtomasyonDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Tbl_GiderlerBindingSource
            // 
            this.Tbl_GiderlerBindingSource.DataMember = "Tbl_Giderler";
            this.Tbl_GiderlerBindingSource.DataSource = this.Dbo_TicariOtomasyonDataSet2;
            // 
            // Tbl_GiderlerTableAdapter
            // 
            this.Tbl_GiderlerTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer5
            // 
            this.reportViewer5.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource4.Name = "DataSet1";
            reportDataSource4.Value = this.Tbl_PersonellerBindingSource;
            this.reportViewer5.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer5.LocalReport.ReportEmbeddedResource = "TİcariOtomsyon.PersonelRaporları.rdlc";
            this.reportViewer5.Location = new System.Drawing.Point(0, 0);
            this.reportViewer5.Name = "reportViewer5";
            this.reportViewer5.ServerReport.BearerToken = null;
            this.reportViewer5.Size = new System.Drawing.Size(1922, 1003);
            this.reportViewer5.TabIndex = 0;
            // 
            // Dbo_TicariOtomasyonDataSet4
            // 
            this.Dbo_TicariOtomasyonDataSet4.DataSetName = "Dbo_TicariOtomasyonDataSet4";
            this.Dbo_TicariOtomasyonDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Tbl_PersonellerBindingSource
            // 
            this.Tbl_PersonellerBindingSource.DataMember = "Tbl_Personeller";
            this.Tbl_PersonellerBindingSource.DataSource = this.Dbo_TicariOtomasyonDataSet4;
            // 
            // Tbl_PersonellerTableAdapter
            // 
            this.Tbl_PersonellerTableAdapter.ClearBeforeFill = true;
            // 
            // FrmRaporlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1033);
            this.Controls.Add(this.xtraTabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmRaporlar";
            this.Text = "RAPORLAR";
            this.Load += new System.EventHandler(this.FrmRaporlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Tbl_MusterilerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dbo_TicariOtomasyonDataSet)).EndInit();
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage3.ResumeLayout(false);
            this.xtraTabPage4.ResumeLayout(false);
            this.xtraTabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dbo_TicariOtomasyonDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tbl_FirmalarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dbo_TicariOtomasyonDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tbl_GiderlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dbo_TicariOtomasyonDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tbl_PersonellerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage4;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage5;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Tbl_MusterilerBindingSource;
        private Dbo_TicariOtomasyonDataSet Dbo_TicariOtomasyonDataSet;
        private Dbo_TicariOtomasyonDataSetTableAdapters.Tbl_MusterilerTableAdapter Tbl_MusterilerTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource Tbl_FirmalarBindingSource;
        private Dbo_TicariOtomasyonDataSet1 Dbo_TicariOtomasyonDataSet1;
        private Dbo_TicariOtomasyonDataSet1TableAdapters.Tbl_FirmalarTableAdapter Tbl_FirmalarTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer4;
        private System.Windows.Forms.BindingSource Tbl_GiderlerBindingSource;
        private Dbo_TicariOtomasyonDataSet2 Dbo_TicariOtomasyonDataSet2;
        private Dbo_TicariOtomasyonDataSet2TableAdapters.Tbl_GiderlerTableAdapter Tbl_GiderlerTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer5;
        private System.Windows.Forms.BindingSource Tbl_PersonellerBindingSource;
        private Dbo_TicariOtomasyonDataSet4 Dbo_TicariOtomasyonDataSet4;
        private Dbo_TicariOtomasyonDataSet4TableAdapters.Tbl_PersonellerTableAdapter Tbl_PersonellerTableAdapter;
    }
}