namespace TİcariOtomsyon
{
    partial class FrmGiderler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGiderler));
            this.CmbAy = new DevExpress.XtraEditors.ComboBoxEdit();
            this.CmbYıl = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.BtnSil = new DevExpress.XtraEditors.SimpleButton();
            this.BtnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.BtnTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.BtnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.RchNotlar = new System.Windows.Forms.RichTextBox();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.TxtEkstra = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.TxtDogalgaz = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.TxtSu = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.TxtElektrik = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.TxtGiderID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.TxtMaaslar = new DevExpress.XtraEditors.TextEdit();
            this.TxtInternet = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbAy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbYıl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEkstra.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDogalgaz.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtElektrik.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtGiderID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMaaslar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtInternet.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // CmbAy
            // 
            this.CmbAy.Location = new System.Drawing.Point(127, 75);
            this.CmbAy.Margin = new System.Windows.Forms.Padding(4);
            this.CmbAy.Name = "CmbAy";
            this.CmbAy.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbAy.Properties.Appearance.Options.UseFont = true;
            this.CmbAy.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CmbAy.Properties.Items.AddRange(new object[] {
            "OCAK",
            "ŞUBAT",
            "MART",
            "NİSAN",
            "MAYIS",
            "HAZİRAN",
            "TEMMUZ",
            "AĞUSTOS",
            "EYLÜL ",
            "EKİM",
            "KASIM",
            "ARALIK"});
            this.CmbAy.Size = new System.Drawing.Size(214, 30);
            this.CmbAy.TabIndex = 1;
            // 
            // CmbYıl
            // 
            this.CmbYıl.Location = new System.Drawing.Point(126, 111);
            this.CmbYıl.Margin = new System.Windows.Forms.Padding(4);
            this.CmbYıl.Name = "CmbYıl";
            this.CmbYıl.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbYıl.Properties.Appearance.Options.UseFont = true;
            this.CmbYıl.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CmbYıl.Properties.Items.AddRange(new object[] {
            "2023",
            "2024",
            "2025",
            "2026"});
            this.CmbYıl.Size = new System.Drawing.Size(214, 30);
            this.CmbYıl.TabIndex = 2;
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(40, 300);
            this.labelControl11.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(77, 23);
            this.labelControl11.TabIndex = 27;
            this.labelControl11.Text = "Maaşlar :";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(53, 341);
            this.labelControl10.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(64, 23);
            this.labelControl10.TabIndex = 26;
            this.labelControl10.Text = "Ekstra :";
            // 
            // BtnSil
            // 
            this.BtnSil.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSil.Appearance.Options.UseFont = true;
            this.BtnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSil.ImageOptions.Image")));
            this.BtnSil.Location = new System.Drawing.Point(123, 544);
            this.BtnSil.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(214, 39);
            this.BtnSil.TabIndex = 23;
            this.BtnSil.Text = "Sil";
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGuncelle.Appearance.Options.UseFont = true;
            this.BtnGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuncelle.ImageOptions.Image")));
            this.BtnGuncelle.Location = new System.Drawing.Point(123, 591);
            this.BtnGuncelle.Margin = new System.Windows.Forms.Padding(4);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(214, 39);
            this.BtnGuncelle.TabIndex = 22;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnTemizle
            // 
            this.BtnTemizle.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnTemizle.Appearance.Options.UseFont = true;
            this.BtnTemizle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnTemizle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnTemizle.ImageOptions.Image")));
            this.BtnTemizle.Location = new System.Drawing.Point(123, 637);
            this.BtnTemizle.Margin = new System.Windows.Forms.Padding(4);
            this.BtnTemizle.Name = "BtnTemizle";
            this.BtnTemizle.Size = new System.Drawing.Size(214, 39);
            this.BtnTemizle.TabIndex = 21;
            this.BtnTemizle.Text = "Temizle";
            this.BtnTemizle.Click += new System.EventHandler(this.BtnTemizle_Click);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKaydet.Appearance.Options.UseFont = true;
            this.BtnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnKaydet.ImageOptions.Image")));
            this.BtnKaydet.Location = new System.Drawing.Point(123, 498);
            this.BtnKaydet.Margin = new System.Windows.Forms.Padding(4);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(214, 39);
            this.BtnKaydet.TabIndex = 20;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // RchNotlar
            // 
            this.RchNotlar.Location = new System.Drawing.Point(123, 380);
            this.RchNotlar.Margin = new System.Windows.Forms.Padding(5);
            this.RchNotlar.Name = "RchNotlar";
            this.RchNotlar.Size = new System.Drawing.Size(213, 106);
            this.RchNotlar.TabIndex = 9;
            this.RchNotlar.Text = "";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(54, 377);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(63, 23);
            this.labelControl9.TabIndex = 16;
            this.labelControl9.Text = "Notlar :";
            // 
            // TxtEkstra
            // 
            this.TxtEkstra.Location = new System.Drawing.Point(124, 338);
            this.TxtEkstra.Margin = new System.Windows.Forms.Padding(4);
            this.TxtEkstra.Name = "TxtEkstra";
            this.TxtEkstra.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtEkstra.Properties.Appearance.Options.UseFont = true;
            this.TxtEkstra.Size = new System.Drawing.Size(214, 30);
            this.TxtEkstra.TabIndex = 8;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(36, 265);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(81, 23);
            this.labelControl8.TabIndex = 14;
            this.labelControl8.Text = "İnternet :";
            // 
            // TxtDogalgaz
            // 
            this.TxtDogalgaz.Location = new System.Drawing.Point(124, 224);
            this.TxtDogalgaz.Margin = new System.Windows.Forms.Padding(4);
            this.TxtDogalgaz.Name = "TxtDogalgaz";
            this.TxtDogalgaz.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtDogalgaz.Properties.Appearance.Options.UseFont = true;
            this.TxtDogalgaz.Size = new System.Drawing.Size(214, 30);
            this.TxtDogalgaz.TabIndex = 5;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(27, 227);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(90, 23);
            this.labelControl7.TabIndex = 12;
            this.labelControl7.Text = "Doğalgaz :";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(82, 187);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(35, 23);
            this.labelControl6.TabIndex = 10;
            this.labelControl6.Text = "Su :";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(44, 152);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(73, 23);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Elektrik :";
            // 
            // TxtSu
            // 
            this.TxtSu.Location = new System.Drawing.Point(125, 186);
            this.TxtSu.Margin = new System.Windows.Forms.Padding(4);
            this.TxtSu.Name = "TxtSu";
            this.TxtSu.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSu.Properties.Appearance.Options.UseFont = true;
            this.TxtSu.Size = new System.Drawing.Size(214, 30);
            this.TxtSu.TabIndex = 4;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(85, 114);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(32, 23);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Yıl :";
            // 
            // TxtElektrik
            // 
            this.TxtElektrik.Location = new System.Drawing.Point(125, 149);
            this.TxtElektrik.Margin = new System.Windows.Forms.Padding(4);
            this.TxtElektrik.Name = "TxtElektrik";
            this.TxtElektrik.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtElektrik.Properties.Appearance.Options.UseFont = true;
            this.TxtElektrik.Size = new System.Drawing.Size(214, 30);
            this.TxtElektrik.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(84, 78);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(33, 23);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Ay :";
            // 
            // TxtGiderID
            // 
            this.TxtGiderID.Location = new System.Drawing.Point(124, 37);
            this.TxtGiderID.Margin = new System.Windows.Forms.Padding(4);
            this.TxtGiderID.Name = "TxtGiderID";
            this.TxtGiderID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtGiderID.Properties.Appearance.Options.UseFont = true;
            this.TxtGiderID.Size = new System.Drawing.Size(214, 30);
            this.TxtGiderID.TabIndex = 100;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(84, 40);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(33, 23);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ID :";
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.Moccasin;
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.DetailHeight = 437;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsEditForm.PopupEditFormWidth = 1000;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // gridControl1
            // 
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gridControl1.Location = new System.Drawing.Point(-1, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(4);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1529, 722);
            this.gridControl1.TabIndex = 6;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.TxtMaaslar);
            this.groupControl1.Controls.Add(this.TxtInternet);
            this.groupControl1.Controls.Add(this.CmbAy);
            this.groupControl1.Controls.Add(this.CmbYıl);
            this.groupControl1.Controls.Add(this.labelControl11);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.BtnSil);
            this.groupControl1.Controls.Add(this.BtnGuncelle);
            this.groupControl1.Controls.Add(this.BtnTemizle);
            this.groupControl1.Controls.Add(this.BtnKaydet);
            this.groupControl1.Controls.Add(this.RchNotlar);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.TxtEkstra);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.TxtDogalgaz);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.TxtSu);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.TxtElektrik);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.TxtGiderID);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(1529, 0);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(394, 722);
            this.groupControl1.TabIndex = 7;
            // 
            // TxtMaaslar
            // 
            this.TxtMaaslar.Location = new System.Drawing.Point(123, 300);
            this.TxtMaaslar.Margin = new System.Windows.Forms.Padding(4);
            this.TxtMaaslar.Name = "TxtMaaslar";
            this.TxtMaaslar.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtMaaslar.Properties.Appearance.Options.UseFont = true;
            this.TxtMaaslar.Size = new System.Drawing.Size(214, 30);
            this.TxtMaaslar.TabIndex = 7;
            // 
            // TxtInternet
            // 
            this.TxtInternet.Location = new System.Drawing.Point(123, 262);
            this.TxtInternet.Margin = new System.Windows.Forms.Padding(4);
            this.TxtInternet.Name = "TxtInternet";
            this.TxtInternet.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtInternet.Properties.Appearance.Options.UseFont = true;
            this.TxtInternet.Size = new System.Drawing.Size(214, 30);
            this.TxtInternet.TabIndex = 6;
            // 
            // FrmGiderler
            // 
            this.AcceptButton = this.BtnKaydet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnTemizle;
            this.ClientSize = new System.Drawing.Size(1924, 1033);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "FrmGiderler";
            this.Text = "GİDERLER";
            this.Load += new System.EventHandler(this.FrmGiderler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CmbAy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbYıl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEkstra.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDogalgaz.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtElektrik.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtGiderID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMaaslar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtInternet.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.ComboBoxEdit CmbAy;
        private DevExpress.XtraEditors.ComboBoxEdit CmbYıl;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.SimpleButton BtnSil;
        private DevExpress.XtraEditors.SimpleButton BtnGuncelle;
        private DevExpress.XtraEditors.SimpleButton BtnTemizle;
        private DevExpress.XtraEditors.SimpleButton BtnKaydet;
        private System.Windows.Forms.RichTextBox RchNotlar;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit TxtEkstra;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit TxtDogalgaz;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit TxtSu;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit TxtElektrik;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit TxtGiderID;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit TxtMaaslar;
        private DevExpress.XtraEditors.TextEdit TxtInternet;
    }
}