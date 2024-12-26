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
    public partial class FrmFirmalar : Form
    {
        public FrmFirmalar()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl=new SqlBaglantisi();
        void firmaListesi()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_Firmalar", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
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
        void firmaTemizle()
        {
            TxtFirmaID.Text = "";
            TxtFirmaAd.Text = "";
            TxtSektor.Text = "";
            TxtYetkiliAdSoyad.Text = "";
            TxtYetkılıGorev.Text = "";
            MskYetkiliTC.Text = "";
            MskTelefon1F.Text = "";
            MskTelefon2F.Text = "";
            MskTelefon3F.Text = "";
            MskFaxF.Text = "";
            TxtFMail.Text = "";
            CmbIl.Text = "";
            CmbIlce.Text = "";
            TxtVergiDairesiF.Text = "";
            RchAdres.Text = "";
            TxtKod1.Text = "";
            TxtKod2.Text = "";
            TxtKod3.Text = "";
            TxtFirmaAd.Focus();
        }
        void carikodAciklamalar()
        {
            SqlCommand komut = new SqlCommand("Select FIRMAKOD1 from Tbl_Kodlar", bgl.baglanti());
            SqlDataReader dr=komut.ExecuteReader();
            while (dr.Read())
            {
                RchOzelKod1.Text = dr[0].ToString();
            }
            bgl.baglanti().Close();
        }
        private void FrmFirmalar_Load(object sender, EventArgs e)
        {
            firmaListesi();
            sehirListesi();
            firmaTemizle();
            carikodAciklamalar();
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

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            firmaTemizle();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                TxtFirmaID.Text = dr["FIRMAID"].ToString();
                TxtFirmaAd.Text = dr["FIRMA_AD"].ToString();
                TxtYetkılıGorev.Text = dr["YETKILISTATU"].ToString();
                TxtYetkiliAdSoyad.Text = dr["YETKILIADSOYAD"].ToString();
                MskYetkiliTC.Text = dr["YETKILITC"].ToString();
                TxtSektor.Text = dr["SEKTOR"].ToString();
                MskTelefon1F.Text = dr["TELEFON1"].ToString();
                MskTelefon2F.Text = dr["TELEFON2"].ToString();
                MskTelefon3F.Text = dr["TELEFON3"].ToString();
                TxtFMail.Text = dr["MAIL"].ToString();
                MskFaxF.Text = dr["FAX"].ToString();
                CmbIl.Text = dr["IL"].ToString();
                CmbIlce.Text = dr["ILCE"].ToString();
                TxtVergiDairesiF.Text = dr["VERGIDAIRE"].ToString();
                RchAdres.Text = dr["ADRES"].ToString();
                TxtKod1.Text = dr["OZELKOD1"].ToString();
                TxtKod2.Text = dr["OZELKOD2"].ToString();
                TxtKod3.Text = dr["OZELKOD3"].ToString();



            }
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut=new SqlCommand("insert into Tbl_Firmalar (FIRMA_AD,YETKILISTATU,YETKILIADSOYAD,YETKILITC,SEKTOR,TELEFON1,TELEFON2,TELEFON3,MAIL,FAX,IL,ILCE,VERGIDAIRE,ADRES,OZELKOD1,OZELKOD2,OZELKOD3) VALUES (@P1,@P2,@P3,@P4,@P5,@P6,@P7,@P8,@P9,@P10,@P11,@P12,@P13,@P14,@P15,@P16,@P17)",bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", TxtFirmaAd.Text);
            komut.Parameters.AddWithValue("@P2", TxtYetkılıGorev.Text);
            komut.Parameters.AddWithValue("@P3", TxtYetkiliAdSoyad.Text);
            komut.Parameters.AddWithValue("@P4", MskYetkiliTC.Text);
            komut.Parameters.AddWithValue("@P5", TxtSektor.Text);
            komut.Parameters.AddWithValue("@P6", MskTelefon1F.Text);
            komut.Parameters.AddWithValue("@P7", MskTelefon2F.Text);
            komut.Parameters.AddWithValue("@P8", MskTelefon3F.Text);
            komut.Parameters.AddWithValue("@P9", TxtFMail.Text);
            komut.Parameters.AddWithValue("@P10", MskFaxF.Text);
            komut.Parameters.AddWithValue("@P11", CmbIl.Text);
            komut.Parameters.AddWithValue("@P12", CmbIlce.Text);
            komut.Parameters.AddWithValue("@P13", TxtVergiDairesiF.Text);
            komut.Parameters.AddWithValue("@P14", RchAdres.Text);
            komut.Parameters.AddWithValue("@P15", TxtKod1.Text);
            komut.Parameters.AddWithValue("@P16", TxtKod2.Text);
            komut.Parameters.AddWithValue("@P17", TxtKod3.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Firma Bilgisi Sisteme Kaydedildi.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            firmaListesi();
            firmaTemizle();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from Tbl_Firmalar where FIRMAID=@P1",bgl.baglanti());
            komut.Parameters.AddWithValue("@P1",TxtFirmaID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Firma Bilgisi Sistemden Silindi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            firmaListesi();
            firmaTemizle();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Tbl_Firmalar set FIRMA_AD=@P1,YETKILISTATU=@P2,YETKILIADSOYAD=@P3,YETKILITC=@P4,SEKTOR=@P5,TELEFON1=@P6,TELEFON2=@P7,TELEFON3=@P8,MAIL=@P9,FAX=@P10,IL=@P11,ILCE=@P12,VERGIDAIRE=@P13,ADRES=@P14,OZELKOD1=@P15,OZELKOD2=@P16,OZELKOD3=@P17 WHERE FIRMAID=@P18",bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", TxtFirmaAd.Text);
            komut.Parameters.AddWithValue("@P2", TxtYetkılıGorev.Text);
            komut.Parameters.AddWithValue("@P3", TxtYetkiliAdSoyad.Text);
            komut.Parameters.AddWithValue("@P4", MskYetkiliTC.Text);
            komut.Parameters.AddWithValue("@P5", TxtSektor.Text);
            komut.Parameters.AddWithValue("@P6", MskTelefon1F.Text);
            komut.Parameters.AddWithValue("@P7", MskTelefon2F.Text);
            komut.Parameters.AddWithValue("@P8", MskTelefon3F.Text);
            komut.Parameters.AddWithValue("@P9", TxtFMail.Text);
            komut.Parameters.AddWithValue("@P10", MskFaxF.Text);
            komut.Parameters.AddWithValue("@P11", CmbIl.Text);
            komut.Parameters.AddWithValue("@P12", CmbIlce.Text);
            komut.Parameters.AddWithValue("@P13", TxtVergiDairesiF.Text);
            komut.Parameters.AddWithValue("@P14", RchAdres.Text);
            komut.Parameters.AddWithValue("@P15", TxtKod1.Text);
            komut.Parameters.AddWithValue("@P16", TxtKod2.Text);
            komut.Parameters.AddWithValue("@P17", TxtKod3.Text);
            komut.Parameters.AddWithValue("@P18", TxtFirmaID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Firma Bilgisi Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            firmaListesi();
            firmaTemizle();
        }
    }
}
