using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TİcariOtomsyon
{
    public partial class FrmFaturaUrunDetay : Form
    {
        public FrmFaturaUrunDetay()
        {
            InitializeComponent();
        }
        public string id;
        SqlBaglantisi bgl=new SqlBaglantisi();
        void faturaUrunListele()
        {
            SqlDataAdapter da=new SqlDataAdapter("select * from Tbl_FaturaDetay where FATURAID='"+id+ "'",bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        private void FrmFaturaUrunDetay_Load(object sender, EventArgs e)
        {
            faturaUrunListele();
            
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            FrmFaturaUrunDuzenleme frduzenle=new FrmFaturaUrunDuzenleme();
            DataRow dr=gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null )
            {
                frduzenle.urunid = dr["FATURAURUNID"].ToString();

            }
            frduzenle.Show();
        }
    }
}
