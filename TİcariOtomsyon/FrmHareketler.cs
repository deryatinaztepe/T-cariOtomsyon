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
    public partial class FrmHareketler : Form
    {
        public FrmHareketler()
        {
            InitializeComponent();
        }
      SqlBaglantisi bgl=new SqlBaglantisi();
        void firmaHareketListele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da=new SqlDataAdapter("exec FirmaHareketler",bgl.baglanti());
            da.Fill(dt);
            gridControl2.DataSource = dt;
        }
        void musteriHareketListele()
        {
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("exec MusteriHareketler", bgl.baglanti());
            da2.Fill(dt2);
            gridControl1.DataSource = dt2;
        }
        private void FrmHareketler_Load(object sender, EventArgs e)
        {
            firmaHareketListele();
            musteriHareketListele();
        }
    }
}
