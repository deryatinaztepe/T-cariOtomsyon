﻿namespace TİcariOtomsyon
{
    partial class FrmAnaSayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnaSayfa));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.GrdStoklar = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GrdAjanda = new DevExpress.XtraGrid.GridControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GrdSon10Hareket = new DevExpress.XtraGrid.GridControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GrdFihrist = new DevExpress.XtraGrid.GridControl();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.WebDoviz = new System.Windows.Forms.WebBrowser();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdStoklar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdAjanda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdSon10Hareket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdFihrist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.GrdStoklar);
            this.groupControl1.Location = new System.Drawing.Point(2, 1);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(591, 358);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "AZALAN STOKLAR";
            // 
            // GrdStoklar
            // 
            this.GrdStoklar.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(12);
            this.GrdStoklar.Location = new System.Drawing.Point(0, 28);
            this.GrdStoklar.MainView = this.gridView1;
            this.GrdStoklar.Margin = new System.Windows.Forms.Padding(12);
            this.GrdStoklar.Name = "GrdStoklar";
            this.GrdStoklar.Size = new System.Drawing.Size(591, 330);
            this.GrdStoklar.TabIndex = 17;
            this.GrdStoklar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.Moccasin;
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.DetailHeight = 1331;
            this.gridView1.GridControl = this.GrdStoklar;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsEditForm.PopupEditFormWidth = 3050;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridView2
            // 
            this.gridView2.Appearance.Row.BackColor = System.Drawing.Color.Moccasin;
            this.gridView2.Appearance.Row.Options.UseBackColor = true;
            this.gridView2.DetailHeight = 1331;
            this.gridView2.GridControl = this.GrdAjanda;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsEditForm.PopupEditFormWidth = 3050;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // GrdAjanda
            // 
            this.GrdAjanda.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(12);
            this.GrdAjanda.Location = new System.Drawing.Point(0, 28);
            this.GrdAjanda.MainView = this.gridView2;
            this.GrdAjanda.Margin = new System.Windows.Forms.Padding(12);
            this.GrdAjanda.Name = "GrdAjanda";
            this.GrdAjanda.Size = new System.Drawing.Size(591, 330);
            this.GrdAjanda.TabIndex = 17;
            this.GrdAjanda.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.GrdAjanda);
            this.groupControl2.Location = new System.Drawing.Point(599, 1);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(591, 358);
            this.groupControl2.TabIndex = 18;
            this.groupControl2.Text = "AJANDA";
            // 
            // gridView3
            // 
            this.gridView3.Appearance.Row.BackColor = System.Drawing.Color.Moccasin;
            this.gridView3.Appearance.Row.Options.UseBackColor = true;
            this.gridView3.DetailHeight = 1331;
            this.gridView3.GridControl = this.GrdSon10Hareket;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsEditForm.PopupEditFormWidth = 3050;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // GrdSon10Hareket
            // 
            this.GrdSon10Hareket.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(12);
            this.GrdSon10Hareket.Location = new System.Drawing.Point(0, 28);
            this.GrdSon10Hareket.MainView = this.gridView3;
            this.GrdSon10Hareket.Margin = new System.Windows.Forms.Padding(12);
            this.GrdSon10Hareket.Name = "GrdSon10Hareket";
            this.GrdSon10Hareket.Size = new System.Drawing.Size(591, 330);
            this.GrdSon10Hareket.TabIndex = 17;
            this.GrdSon10Hareket.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.GrdSon10Hareket);
            this.groupControl3.Location = new System.Drawing.Point(2, 365);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(591, 358);
            this.groupControl3.TabIndex = 19;
            this.groupControl3.Text = "SON 10 HAREKET";
            // 
            // gridView4
            // 
            this.gridView4.Appearance.Row.BackColor = System.Drawing.Color.Moccasin;
            this.gridView4.Appearance.Row.Options.UseBackColor = true;
            this.gridView4.DetailHeight = 1331;
            this.gridView4.GridControl = this.GrdFihrist;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsEditForm.PopupEditFormWidth = 3050;
            this.gridView4.OptionsView.ShowGroupPanel = false;
            // 
            // GrdFihrist
            // 
            this.GrdFihrist.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(12);
            this.GrdFihrist.Location = new System.Drawing.Point(0, 28);
            this.GrdFihrist.MainView = this.gridView4;
            this.GrdFihrist.Margin = new System.Windows.Forms.Padding(12);
            this.GrdFihrist.Name = "GrdFihrist";
            this.GrdFihrist.Size = new System.Drawing.Size(591, 330);
            this.GrdFihrist.TabIndex = 17;
            this.GrdFihrist.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView4});
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.GrdFihrist);
            this.groupControl4.Location = new System.Drawing.Point(599, 365);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(591, 358);
            this.groupControl4.TabIndex = 18;
            this.groupControl4.Text = "FİHRİST";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(1196, 1);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(716, 722);
            this.xtraTabControl1.TabIndex = 20;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.WebDoviz);
            this.xtraTabPage1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage1.ImageOptions.Image")));
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(714, 692);
            this.xtraTabPage1.Text = "DÖVİZ KURLARI";
            // 
            // WebDoviz
            // 
            this.WebDoviz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WebDoviz.Location = new System.Drawing.Point(0, 0);
            this.WebDoviz.MinimumSize = new System.Drawing.Size(20, 20);
            this.WebDoviz.Name = "WebDoviz";
            this.WebDoviz.Size = new System.Drawing.Size(714, 692);
            this.WebDoviz.TabIndex = 0;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.pictureBox1);
            this.xtraTabPage2.Controls.Add(this.listBox1);
            this.xtraTabPage2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage2.ImageOptions.Image")));
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(714, 692);
            this.xtraTabPage2.Text = "HABERLER";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(328, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.White;
            this.listBox1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 22;
            this.listBox1.Location = new System.Drawing.Point(-5, 85);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(716, 598);
            this.listBox1.TabIndex = 0;
            // 
            // FrmAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1033);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.groupControl4);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "FrmAnaSayfa";
            this.Text = "ANASAYFA";
            this.Load += new System.EventHandler(this.FrmAnaSayfa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrdStoklar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdAjanda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdSon10Hareket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdFihrist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl GrdStoklar;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.GridControl GrdAjanda;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.GridControl GrdSon10Hareket;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraGrid.GridControl GrdFihrist;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private System.Windows.Forms.WebBrowser WebDoviz;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}