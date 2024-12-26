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
    public partial class FrmStokDetay : Form
    {
        public FrmStokDetay()
        {
            InitializeComponent();
        }
        public string ad;
        SqlBaglantisi bgl=new SqlBaglantisi();
        private void FrmStokDetay_Load(object sender, EventArgs e)
        {
            DataTable dt=new DataTable();
            SqlDataAdapter da=new SqlDataAdapter("select * from Tbl_Urunler where URUNAD='"+ad+"'",bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;

        }
    }
}
