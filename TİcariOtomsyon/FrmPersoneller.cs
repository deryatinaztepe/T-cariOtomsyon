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
    public partial class FrmPersoneller : Form
    {
        public FrmPersoneller()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl=new SqlBaglantisi();
        void personelListele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da=new SqlDataAdapter("select * from Tbl_Personeller",bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource=dt;
        }
        void sehirListesi()
        {
            SqlCommand komut = new SqlCommand("select SEHIR FROM Tbl_Iller", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                CmbIl.Properties.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();
        }
        void personelTemizle()
        {
            TxtPersonelID.Text = "";
            TxtPersonelAd.Text = "";
            TxtPersonelSoyad.Text = "";
            MskTelefon1P.Text = "";
            MskPersonelTC.Text = "";
            TxtPMail.Text = "";
            CmbIl.Text = "";
            CmbIlce.Text = "";
            RchAdres.Text = "";
            TxtPGorev.Text = "";
        }
        private void FrmPersoneller_Load(object sender, EventArgs e)
        {
            personelListele();
            sehirListesi();
            personelTemizle();
        }

        private void CmbIl_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbIlce.Properties.Items.Clear();
            SqlCommand komut = new SqlCommand("select ILCE from Tbl_Ilceler where SEHIR=@P1", bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", CmbIl.SelectedIndex + 1);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                CmbIlce.Properties.Items.Add(dr[0]);

            }
            bgl.baglanti().Close();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Personeller (PER_AD,PER_SOYAD,TELEFON,PER_TC,MAIL,IL,ILCE,ADRES,GOREV) VALUES(@P1,@P2,@P3,@P4,@P5,@P6,@P7,@P8,@P9)",bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", TxtPersonelAd.Text);
            komut.Parameters.AddWithValue("@P2", TxtPersonelSoyad.Text);
            komut.Parameters.AddWithValue("@P3", MskTelefon1P.Text);
            komut.Parameters.AddWithValue("@P4",MskPersonelTC.Text);
            komut.Parameters.AddWithValue("@P5",TxtPMail.Text);
            komut.Parameters.AddWithValue("@P6", CmbIl.Text);
            komut.Parameters.AddWithValue("@P7",CmbIlce.Text);
            komut.Parameters.AddWithValue("@P8",RchAdres.Text);
            komut.Parameters.AddWithValue("@P9",TxtPGorev.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Personel Bilgisi Sisteme Kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            personelListele();
            personelTemizle();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if (dr != null)
            {
                TxtPersonelID.Text = dr["PERSONELID"].ToString();
                TxtPersonelAd.Text = dr["PER_AD"].ToString();
                TxtPersonelSoyad.Text = dr["PER_SOYAD"].ToString();
                MskTelefon1P.Text = dr["TELEFON"].ToString();
                MskPersonelTC.Text = dr["PER_TC"].ToString();
                TxtPMail.Text = dr["MAIL"].ToString();
                CmbIl.Text = dr["IL"].ToString();
                CmbIlce.Text = dr["ILCE"].ToString();
                RchAdres.Text = dr["ADRES"].ToString();
                TxtPGorev.Text = dr["GOREV"].ToString();
            }
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            personelTemizle();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Tbl_Personeller set PER_AD=@P1,PER_SOYAD=@P2,TELEFON=@P3,PER_TC=@P4,MAIL=@P5,IL=@P6,ILCE=@P7,ADRES=@P8,GOREV=@P9 WHERE PERSONELID=@P10",bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", TxtPersonelAd.Text);
            komut.Parameters.AddWithValue("@P2", TxtPersonelSoyad.Text);
            komut.Parameters.AddWithValue("@P3", MskTelefon1P.Text);
            komut.Parameters.AddWithValue("@P4", MskPersonelTC.Text);
            komut.Parameters.AddWithValue("@P5", TxtPMail.Text);
            komut.Parameters.AddWithValue("@P6", CmbIl.Text);
            komut.Parameters.AddWithValue("@P7", CmbIlce.Text);
            komut.Parameters.AddWithValue("@P8", RchAdres.Text);
            komut.Parameters.AddWithValue("@P9", TxtPGorev.Text);
            komut.Parameters.AddWithValue("@P10", TxtPersonelID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Personel Bilgisi Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            personelListele();
            personelTemizle();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from Tbl_Personeller where PERSONELID=@P1",bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", TxtPersonelID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Personel Sistemden Silindi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            personelListele();
            personelTemizle();
        }
    }
}
