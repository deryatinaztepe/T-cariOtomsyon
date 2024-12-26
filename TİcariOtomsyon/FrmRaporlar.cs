using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TİcariOtomsyon
{
    public partial class FrmRaporlar : Form
    {
        public FrmRaporlar()
        {
            InitializeComponent();
        }

        private void FrmRaporlar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Dbo_TicariOtomasyonDataSet4.Tbl_Personeller' table. You can move, or remove it, as needed.
            this.Tbl_PersonellerTableAdapter.Fill(this.Dbo_TicariOtomasyonDataSet4.Tbl_Personeller);
            // TODO: This line of code loads data into the 'Dbo_TicariOtomasyonDataSet2.Tbl_Giderler' table. You can move, or remove it, as needed.
            this.Tbl_GiderlerTableAdapter.Fill(this.Dbo_TicariOtomasyonDataSet2.Tbl_Giderler);
            // TODO: This line of code loads data into the 'Dbo_TicariOtomasyonDataSet1.Tbl_Firmalar' table. You can move, or remove it, as needed.
            this.Tbl_FirmalarTableAdapter.Fill(this.Dbo_TicariOtomasyonDataSet1.Tbl_Firmalar);
            // TODO: This line of code loads data into the 'Dbo_TicariOtomasyonDataSet.Tbl_Musteriler' table. You can move, or remove it, as needed.
            this.Tbl_MusterilerTableAdapter.Fill(this.Dbo_TicariOtomasyonDataSet.Tbl_Musteriler);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
            this.reportViewer3.RefreshReport();
            this.reportViewer4.RefreshReport();
            this.reportViewer5.RefreshReport();
        }
    }
}
