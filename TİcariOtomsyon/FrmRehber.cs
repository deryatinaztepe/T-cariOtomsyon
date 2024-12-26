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
    public partial class FrmRehber : Form
    {
        public FrmRehber()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();

        private void FrmRehber_Load(object sender, EventArgs e)
        {
            //müşteri bilgileri

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select MUS_AD,MUS_SOYAD,TELEFON,TELEFON2,MAIL FROM Tbl_Musteriler", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;

            //firma bilgileri
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("select FIRMA_AD,YETKILIADSOYAD,TELEFON1,TELEFON2,TELEFON3,MAIL,FAX FROM Tbl_Firmalar", bgl.baglanti());
            da2.Fill(dt2);
            gridControl2.DataSource = dt2;
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmMail frmMail=new FrmMail();
            DataRow dr=gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null )
            {
                frmMail.mail = dr["MAIL"].ToString();
            }
            frmMail.Show();
        }

        private void gridView2_DoubleClick(object sender, EventArgs e)
        {
            FrmMail frmMail = new FrmMail();
            DataRow dr = gridView2.GetDataRow(gridView2.FocusedRowHandle);
            if (dr != null)
            {
                frmMail.mail = dr["MAIL"].ToString();
            }
            frmMail.Show();
        }
    }
}
