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
    public partial class FrmAyarlar : Form
    {
        public FrmAyarlar()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl=new SqlBaglantisi();
        void kullaniciListele()
        {
            DataTable dt=new DataTable();
            SqlDataAdapter da=new SqlDataAdapter("select * from Tbl_Admin",bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        private void FrmAyarlar_Load(object sender, EventArgs e)
        {
            kullaniciListele();
            TxtKullanici.Text = "";
            TxtSifre.Text = "";
        }

        private void BtnIslem_Click(object sender, EventArgs e)
        {
            if (BtnIslem.Text == "KAYDET")
            {
                SqlCommand komut = new SqlCommand("insert into Tbl_Admin values(@P1,@P2)", bgl.baglanti());
                komut.Parameters.AddWithValue("@P1", TxtKullanici.Text);
                komut.Parameters.AddWithValue("@P2", TxtSifre.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Yeni Admin Sisteme Kaydedildi.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                kullaniciListele();
            }
            if(BtnIslem.Text=="GÜNCELLE")
            {
                SqlCommand komutguncelle = new SqlCommand("update Tbl_Admin set SIFRE=@P2 WHERE KULLANICIADI=@P1", bgl.baglanti());
                komutguncelle.Parameters.AddWithValue("@P1", TxtKullanici.Text);
                komutguncelle.Parameters.AddWithValue("@P2",TxtSifre.Text);
                komutguncelle.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Şifre Güncellendi.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                kullaniciListele();
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr=gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                TxtKullanici.Text = dr["KULLANICIADI"].ToString();
                TxtSifre.Text = dr["SIFRE"].ToString();
            }
        }

        private void TxtKullanici_EditValueChanged(object sender, EventArgs e)
        {
            if(TxtKullanici.Text!="")
            {
                BtnIslem.Text = "GÜNCELLE";
                BtnIslem.BackColor = Color.GreenYellow;
            }
            else
            {
                BtnIslem.Text = "KAYDET";
                BtnIslem.BackColor = Color.Orange;
            }
        }
    }
}
