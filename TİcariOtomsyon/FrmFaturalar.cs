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
    public partial class FrmFaturalar : Form
    {
        public FrmFaturalar()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl=new SqlBaglantisi();
        void faturaListele()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_FaturaBilgi", bgl.baglanti());
            DataTable dt=new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        void faturaTemizle()
        {
            TxtFaturaID.Text = "";
            TxtSeriNo.Text = "";
            TxtSiraNo.Text = "";
            MskTarihFatura.Text = "";
            MskSaatFatura.Text = "";
            TxtVergiDairesi.Text = "";
            TxtAlici.Text = "";
            TxtTeslimAlan.Text = "";
            TxtTeslimEden.Text = "";
        }
        private void FrmFaturalar_Load(object sender, EventArgs e)
        {
            faturaListele();
            faturaTemizle();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            
            if (TxtFaturaID2.Text == "" )
            {
                SqlCommand komut = new SqlCommand("insert into Tbl_FaturaBilgi (SERI,SIRANO,TARIH,SAAT,VERGIDAIRE,ALICI,TESLIMEDEN,TESLIMALAN) VALUES(@P1,@P2,@P3,@P4,@P5,@P6,@P7,@P8)", bgl.baglanti());
                komut.Parameters.AddWithValue("@P1", TxtSeriNo.Text);
                komut.Parameters.AddWithValue("@P2", TxtSiraNo.Text);
                komut.Parameters.AddWithValue("@P3", MskTarihFatura.Text);
                komut.Parameters.AddWithValue("@P4", MskSaatFatura.Text);
                komut.Parameters.AddWithValue("@P5", TxtVergiDairesi.Text);
                komut.Parameters.AddWithValue("@P6", TxtAlici.Text);
                komut.Parameters.AddWithValue("@P7", TxtTeslimEden.Text);
                komut.Parameters.AddWithValue("@P8", TxtTeslimAlan.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Fatura Bilgisi Sisteme Eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                faturaListele();
                faturaTemizle();

            }
            if (TxtFaturaID2.Text != "")
            {
                double miktar, tutar, fiyat;
                fiyat = Convert.ToDouble(TxtFiyat.Text);
                miktar = Convert.ToDouble(TxtMiktar.Text);
                tutar = miktar * fiyat;
                TxtTutar.Text = tutar.ToString();
                SqlCommand komut2 = new SqlCommand("insert into Tbl_FaturaDetay (URUNAD,MIKTAR,FIYAT,TUTAR,FATURAID) VALUES(@P1,@P2,@P3,@P4,@P5)", bgl.baglanti());
                komut2.Parameters.AddWithValue("@P1", TxtUrunAdi.Text);
                komut2.Parameters.AddWithValue("@P2", TxtMiktar.Text);
                komut2.Parameters.AddWithValue("@P3", decimal.Parse(TxtFiyat.Text));
                komut2.Parameters.AddWithValue("@P4", decimal.Parse(TxtTutar.Text));
                komut2.Parameters.AddWithValue("@P5", TxtFaturaID2.Text);
                komut2.ExecuteNonQuery();
                bgl.baglanti().Close();

                //hareket tablosuna veri girişi

                SqlCommand komut3 = new SqlCommand("insert into Tbl_FirmaHareketler(URUNID,ADET,PERSONEL,FIRMA,FIYAT,TOPLAM,FATURAID,TARIH)VALUES(@H1,@H2,@H3,@H4,@H5,@H6,@H7,@H8)", bgl.baglanti());
                komut3.Parameters.AddWithValue("@H1", TxtUrunID.Text);
                komut3.Parameters.AddWithValue("@H2", TxtMiktar.Text);
                komut3.Parameters.AddWithValue("@H3", TxtPersonelID.Text);
                komut3.Parameters.AddWithValue("@H4", TxtFirma.Text);
                komut3.Parameters.AddWithValue("@H5", decimal.Parse(TxtFiyat.Text));
                komut3.Parameters.AddWithValue("@H6", decimal.Parse(TxtTutar.Text));
                komut3.Parameters.AddWithValue("@H7", TxtFaturaID2.Text);
                komut3.Parameters.AddWithValue("@H8", MskTarihFatura.Text);
                komut3.ExecuteNonQuery();
                bgl.baglanti().Close();

                //STOK SAYISINI AZALTMA
                SqlCommand komut4 = new SqlCommand("update Tbl_Urunler set ADET=ADET-@S1 WHERE URUNID=@S2", bgl.baglanti());
                komut4.Parameters.AddWithValue("@S1", TxtMiktar.Text);
                komut4.Parameters.AddWithValue("@S2", TxtUrunID.Text);
                komut4.ExecuteNonQuery();
                bgl.baglanti().Close();

                MessageBox.Show("Faturaya Ait Ürün Bilgisi Sisteme Kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            
               
        }
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr=gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null )
            {
                TxtFaturaID.Text = dr["FATURABILGIID"].ToString();
                TxtSeriNo.Text = dr["SERI"].ToString();
                TxtSiraNo.Text = dr["SIRANO"].ToString();
                MskTarihFatura.Text = dr["TARIH"].ToString();
                MskSaatFatura.Text = dr["SAAT"].ToString();
                TxtVergiDairesi.Text = dr["VERGIDAIRE"].ToString();
                TxtAlici.Text = dr["ALICI"].ToString();
                TxtTeslimEden.Text = dr["TESLIMEDEN"].ToString();
                TxtTeslimAlan.Text = dr["TESLIMALAN"].ToString();
            }
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            faturaTemizle();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from Tbl_FaturaBilgi where FATURABILGIID=@P1", bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", TxtFaturaID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Fatura Bilgisi Sistemden Silindi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            faturaListele();
            faturaTemizle();
        }

        private void BtnTemizle_Click_1(object sender, EventArgs e)
        {
            faturaTemizle();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Tbl_FaturaBilgi set SERI=@P1,SIRANO=@P2,TARIH=@P3,SAAT=@P4,VERGIDAIRE=@P5,ALICI=@P6,TESLIMEDEN=@P7,TESLIMALAN=@P8 WHERE FATURABILGIID=@P9", bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", TxtSeriNo.Text);
            komut.Parameters.AddWithValue("@P2", TxtSiraNo.Text);
            komut.Parameters.AddWithValue("@P3", MskTarihFatura.Text);
            komut.Parameters.AddWithValue("@P4", MskSaatFatura.Text);
            komut.Parameters.AddWithValue("@P5", TxtVergiDairesi.Text);
            komut.Parameters.AddWithValue("@P6", TxtAlici.Text);
            komut.Parameters.AddWithValue("@P7", TxtTeslimEden.Text);
            komut.Parameters.AddWithValue("@P8", TxtTeslimAlan.Text);
            komut.Parameters.AddWithValue("@P9", TxtFaturaID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Fatura Bilgisi Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            faturaListele();
            faturaTemizle();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmFaturaUrunDetay fr=new FrmFaturaUrunDetay();
            DataRow dr=gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if (dr != null)
            {
                fr.id = dr["FATURABILGIID"].ToString();
            }
            fr.Show();
        }

        private void BtnBul_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select URUNAD,SATISFIYAT FROM Tbl_Urunler where URUNID=@P1", bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", TxtUrunID.Text);
            SqlDataReader dr=komut.ExecuteReader();
            while (dr.Read())
            {
                TxtUrunAdi.Text = dr[0].ToString();
                TxtFiyat.Text = dr[1].ToString();
            }
            bgl.baglanti().Close();
        }
    }
}
