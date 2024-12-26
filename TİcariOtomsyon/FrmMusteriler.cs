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
    public partial class FrmMusteriler : Form
    {
        public FrmMusteriler()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl=new SqlBaglantisi();
        void musteriListele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da=new SqlDataAdapter("select * from Tbl_Musteriler",bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        void sehirListesi()
        {
            SqlCommand komut = new SqlCommand("select SEHIR FROM Tbl_Iller", bgl.baglanti());
            SqlDataReader dr=komut.ExecuteReader();
            while (dr.Read())
            {
                CmbIl.Properties.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();
        }
        void musteriTemizle()
        {
            TxtMusteriID.Text = "";
            TxtMusteriAd.Text = "";
            TxtMusteriSoyad.Text = "";
            MskTelefon1M.Text = "";
            MskTelefon2M.Text = "";
            MskMusteriTC.Text = "";
            TxtMMail.Text = "";
            CmbIl.Text = "";
            CmbIlce.Text = "";
            TxtVergiDairesi.Text = "";
            RchAdres.Text = "";
        }
        private void FrmMusteriler_Load(object sender, EventArgs e)
        {
            musteriListele();
            sehirListesi();
            musteriTemizle();
        }

        private void CmbIl_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbIlce.Properties.Items.Clear();
            SqlCommand komut = new SqlCommand("select ILCE from Tbl_Ilceler where SEHIR=@P1", bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", CmbIl.SelectedIndex+1);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                CmbIlce.Properties.Items.Add(dr[0]);

            }
            bgl.baglanti().Close();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Musteriler(MUS_AD,MUS_SOYAD,TELEFON,TELEFON2,MUS_TC,MAIL,IL,ILCE,ADRES,VERGIDAIRESI) VALUES(@P1,@P2,@P3,@P4,@P5,@P6,@P7,@P8,@P9,@P10)", bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", TxtMusteriAd.Text);
            komut.Parameters.AddWithValue("@P2",TxtMusteriSoyad.Text);
            komut.Parameters.AddWithValue("@P3", MskTelefon1M.Text);
            komut.Parameters.AddWithValue("@P4", MskTelefon2M.Text);
            komut.Parameters.AddWithValue("@P5",MskMusteriTC.Text);
            komut.Parameters.AddWithValue("@P6",TxtMMail.Text);
            komut.Parameters.AddWithValue("@P7",CmbIl.Text);
            komut.Parameters.AddWithValue("@P8",CmbIlce.Text);
            komut.Parameters.AddWithValue("@P9",RchAdres.Text);
            komut.Parameters.AddWithValue("@P10", TxtVergiDairesi.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Müşteri Bilgisi Sisteme Kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            musteriListele();
            musteriTemizle();
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            musteriTemizle();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr=gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                TxtMusteriID.Text = dr["MUSTERIID"].ToString();
                TxtMusteriAd.Text = dr["MUS_AD"].ToString();
                TxtMusteriSoyad.Text = dr["MUS_SOYAD"].ToString();
                MskTelefon1M.Text = dr["TELEFON"].ToString();
                MskTelefon2M.Text = dr["TELEFON2"].ToString();
                MskMusteriTC.Text = dr["MUS_TC"].ToString();
                TxtMMail.Text = dr["MAIL"].ToString();
                CmbIl.Text = dr["IL"].ToString();
                CmbIlce.Text = dr["ILCE"].ToString();
                TxtVergiDairesi.Text = dr["VERGIDAIRESI"].ToString();
                RchAdres.Text = dr["ADRES"].ToString();
            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from Tbl_Musteriler where MUSTERIID=@P1",bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", TxtMusteriID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Müşteri Bilgisi Sistemden Silindi.","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Error);
            musteriListele();
            musteriTemizle();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Tbl_Musteriler set MUS_AD=@P1,MUS_SOYAD=@P2,TELEFON=@P3,TELEFON2=@P4,MUS_TC=@P5,MAIL=@P6,IL=@P7,ILCE=@P8,VERGIDAIRESI=@P9,ADRES=@P10 WHERE MUSTERIID=@P11",bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", TxtMusteriAd.Text);
            komut.Parameters.AddWithValue("@P2", TxtMusteriSoyad.Text);
            komut.Parameters.AddWithValue("@P3", MskTelefon1M.Text);
            komut.Parameters.AddWithValue("@P4", MskTelefon2M.Text);
            komut.Parameters.AddWithValue("@P5", MskMusteriTC.Text);
            komut.Parameters.AddWithValue("@P6",TxtMMail.Text);
            komut.Parameters.AddWithValue("@P7",CmbIl.Text);
            komut.Parameters.AddWithValue("@P8",CmbIlce.Text);
            komut.Parameters.AddWithValue("@P9",TxtVergiDairesi.Text);
            komut.Parameters.AddWithValue("@P10", RchAdres.Text);
            komut.Parameters.AddWithValue("@P11", TxtMusteriID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Müşteri Bilgisi Sistemde Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            musteriListele();
            musteriTemizle();
        }
    }
}
