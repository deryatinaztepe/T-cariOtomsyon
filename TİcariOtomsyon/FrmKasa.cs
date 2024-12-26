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
using DevExpress.Charts;

namespace TİcariOtomsyon
{
    public partial class FrmKasa : Form
    {
        public FrmKasa()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        void MusteriHareket()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("execute MusteriHareketler", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        void FirmaHareket()
        {
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("execute FirmaHareketler", bgl.baglanti());
            da2.Fill(dt2);
            gridControl3.DataSource = dt2;
        }
        void GiderHareket()
        {
            DataTable dt3 = new DataTable();
            SqlDataAdapter da3 = new SqlDataAdapter("select * from Tbl_Giderler", bgl.baglanti());
            da3.Fill(dt3);
            gridControl2.DataSource = dt3;
        }
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void gridView2_DoubleClick(object sender, EventArgs e)
        {

        }
        public string ad;
        private void FrmKasa_Load(object sender, EventArgs e)
        {
            LblAktifKullanici.Text = ad;
            MusteriHareket();
            FirmaHareket();
            GiderHareket();

            //toplam tutarı hesaplama
            SqlCommand komut1 = new SqlCommand("select Sum(TUTAR) FROM Tbl_FaturaDetay", bgl.baglanti());
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                LblKasaToplam.Text = dr1[0].ToString() + " TL";
            }
            bgl.baglanti().Close();

            //SON AYIN FATURALARI
            SqlCommand komut2 = new SqlCommand("select (ELEKTRIK+SU+DOGALGAZ+INTERNET+EKSTRA) FROM Tbl_Giderler order by GIDERID ASC", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                LblOdemeler.Text = dr2[0].ToString() + " TL";
            }
            bgl.baglanti().Close();

            //SON AYIN PERSONEL MAAŞLARI
            SqlCommand komut3 = new SqlCommand("select MAASLAR FROM Tbl_Giderler order by GIDERID ASC", bgl.baglanti());
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                LblPersonelMaaslari.Text = dr3[0].ToString() + " TL";
            }
            bgl.baglanti().Close();

            //TOPLAM MÜŞTERİ SAYISI
            SqlCommand komut4 = new SqlCommand("select count(*) From Tbl_Musteriler", bgl.baglanti());
            SqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                LblMusteriSayisi.Text = dr4[0].ToString();
            }
            bgl.baglanti().Close();

            //Toplam Firma Sayısı
            SqlCommand komut5 = new SqlCommand("select Count(*) from Tbl_Firmalar", bgl.baglanti());
            SqlDataReader dr5 = komut5.ExecuteReader();
            while (dr5.Read())
            {
                LblFirmaSayisi.Text = dr5[0].ToString();
            }
            bgl.baglanti().Close();


            //Toplam Firma Şehir Sayısı
            SqlCommand komut6 = new SqlCommand("select Count(distinct (IL)) from Tbl_Firmalar", bgl.baglanti());
            SqlDataReader dr6 = komut6.ExecuteReader();
            while (dr6.Read())
            {
                LblFirmaSehirSayisi.Text = dr6[0].ToString();
            }
            bgl.baglanti().Close();

            //Toplam Müşteri Şehir Sayısı
            SqlCommand komut7 = new SqlCommand("select Count(distinct (IL)) from Tbl_Musteriler", bgl.baglanti());
            SqlDataReader dr7 = komut7.ExecuteReader();
            while (dr7.Read())
            {
                LblMusteriSehirSayisi.Text = dr7[0].ToString();
            }
            bgl.baglanti().Close();

            //Toplam Personel Sayısı
            SqlCommand komut8 = new SqlCommand("select Count(*) from Tbl_Personeller", bgl.baglanti());
            SqlDataReader dr8 = komut8.ExecuteReader();
            while (dr8.Read())
            {
                LblPersonelSayisi.Text = dr8[0].ToString();
            }
            bgl.baglanti().Close();

            //Toplam  stok Ürün Sayısı
            SqlCommand komut9 = new SqlCommand("select sum(ADET) FROM Tbl_Urunler", bgl.baglanti());
            SqlDataReader dr9 = komut9.ExecuteReader();
            while (dr9.Read())
            {
                LblStokSayisi.Text = dr9[0].ToString();
            }
            bgl.baglanti().Close();


        }
        int sayac = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {//ELEKTRIK
            sayac++;
            if (sayac > 0 && sayac <= 5)
            {

                groupControl10.Text = "ELEKTRIK";
                chartControl1.Series["Aylar"].Points.Clear();

                SqlCommand komut10 = new SqlCommand("select  top 5 AY,ELEKTRIK FROM Tbl_Giderler order by GIDERID DESC", bgl.baglanti());
                SqlDataReader dr10 = komut10.ExecuteReader();
                while (dr10.Read())
                {
                    chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr10[0], dr10[1]));
                }
                bgl.baglanti().Close();


            }
            //SU
            if (sayac > 5 && sayac <= 10)
            {
                groupControl10.Text = "SU";
                chartControl1.Series["Aylar"].Points.Clear();


                SqlCommand komut11 = new SqlCommand("select  top 5 AY,SU FROM Tbl_Giderler order by GIDERID DESC", bgl.baglanti());
                SqlDataReader dr11 = komut11.ExecuteReader();
                while (dr11.Read())
                {
                    chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr11[0], dr11[1]));
                }
                bgl.baglanti().Close();


            }
            //DOĞALGAZ
            if (sayac > 10 && sayac <= 15)
            {
                groupControl10.Text = "DOĞALGAZ";
                chartControl1.Series["Aylar"].Points.Clear();


                SqlCommand komut11 = new SqlCommand("select  top 5 AY,DOGALGAZ FROM Tbl_Giderler order by GIDERID DESC", bgl.baglanti());
                SqlDataReader dr11 = komut11.ExecuteReader();
                while (dr11.Read())
                {
                    chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr11[0], dr11[1]));
                }
                bgl.baglanti().Close();


            }
            //INTERNET
            if (sayac > 15 && sayac <= 20)
            {
                groupControl10.Text = "INTERNET";
                chartControl1.Series["Aylar"].Points.Clear();


                SqlCommand komut11 = new SqlCommand("select  top 5 AY,INTERNET FROM Tbl_Giderler order by GIDERID DESC", bgl.baglanti());
                SqlDataReader dr11 = komut11.ExecuteReader();
                while (dr11.Read())
                {
                    chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr11[0], dr11[1]));
                }
                bgl.baglanti().Close();


            }
            //EKSTRA
            if (sayac > 20 && sayac <= 25)
            {
                groupControl10.Text = "EKSTRA";
                chartControl1.Series["Aylar"].Points.Clear();


                SqlCommand komut11 = new SqlCommand("select  top 5 AY,EKSTRA FROM Tbl_Giderler order by GIDERID DESC", bgl.baglanti());
                SqlDataReader dr11 = komut11.ExecuteReader();
                while (dr11.Read())
                {
                    chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr11[0], dr11[1]));
                }
                bgl.baglanti().Close();


            }
            if(sayac==26)
            {
                sayac = 0;
            }
        }
        int sayac2;
        private void timer2_Tick(object sender, EventArgs e)
        {
            //ELEKTRIK
            sayac2++;
            if (sayac2> 0 && sayac2 <= 5)
            {

                groupControl11.Text = "ELEKTRIK";
                chartControl2.Series["Aylar"].Points.Clear();

                SqlCommand komut10 = new SqlCommand("select  top 5 AY,ELEKTRIK FROM Tbl_Giderler order by GIDERID DESC", bgl.baglanti());
                SqlDataReader dr10 = komut10.ExecuteReader();
                while (dr10.Read())
                {
                    chartControl2.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr10[0], dr10[1]));
                }
                bgl.baglanti().Close();


            }
            //SU
            if (sayac2 > 5 && sayac2 <= 10)
            {
                groupControl11.Text = "SU";
                chartControl2.Series["Aylar"].Points.Clear();


                SqlCommand komut11 = new SqlCommand("select  top 5 AY,SU FROM Tbl_Giderler order by GIDERID DESC", bgl.baglanti());
                SqlDataReader dr11 = komut11.ExecuteReader();
                while (dr11.Read())
                {
                    chartControl2.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr11[0], dr11[1]));
                }
                bgl.baglanti().Close();


            }
            //DOĞALGAZ
            if (sayac2 > 10 && sayac2 <= 15)
            {
                groupControl11.Text = "DOĞALGAZ";
                chartControl2.Series["Aylar"].Points.Clear();


                SqlCommand komut11 = new SqlCommand("select  top 5 AY,DOGALGAZ FROM Tbl_Giderler order by GIDERID DESC", bgl.baglanti());
                SqlDataReader dr11 = komut11.ExecuteReader();
                while (dr11.Read())
                {
                    chartControl2.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr11[0], dr11[1]));
                }
                bgl.baglanti().Close();


            }
            //INTERNET
            if (sayac2 > 15 && sayac2 <= 20)
            {
                groupControl11.Text = "INTERNET";
                chartControl2.Series["Aylar"].Points.Clear();


                SqlCommand komut11 = new SqlCommand("select  top 5 AY,INTERNET FROM Tbl_Giderler order by GIDERID DESC", bgl.baglanti());
                SqlDataReader dr11 = komut11.ExecuteReader();
                while (dr11.Read())
                {
                    chartControl2.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr11[0], dr11[1]));
                }
                bgl.baglanti().Close();


            }
            //EKSTRA
            if (sayac2 > 20 && sayac2 <= 25)
            {
                groupControl11.Text = "EKSTRA";
                chartControl2.Series["Aylar"].Points.Clear();


                SqlCommand komut11 = new SqlCommand("select  top 5 AY,EKSTRA FROM Tbl_Giderler order by GIDERID DESC", bgl.baglanti());
                SqlDataReader dr11 = komut11.ExecuteReader();
                while (dr11.Read())
                {
                    chartControl2.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr11[0], dr11[1]));
                }
                bgl.baglanti().Close();


            }
            if (sayac2 == 26)
            {
                sayac2 = 0;
            }
        }
    }
    
}

