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
using System.Xml;

namespace TİcariOtomsyon
{
    public partial class FrmAnaSayfa : Form
    {
        public FrmAnaSayfa()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl=new SqlBaglantisi();

        void stoklar()
        {
            DataTable dt=new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select URUNAD,SUM(ADET) AS 'ADET' FROM Tbl_Urunler group by URUNAD HAVING SUM(ADET)<=20 ORDER BY SUM(ADET)", bgl.baglanti());
            da.Fill(dt);
            GrdStoklar.DataSource = dt;

        }
        void ajanda()
        {
            DataTable dt2=new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("select top 8 NOTTARIH,NOTSAAT,NOTBASLIK,NOTHITAP FROM Tbl_Notlar order by NOTID DESC", bgl.baglanti());
            da2.Fill(dt2);
            GrdAjanda.DataSource = dt2;
        }
        void FirmaHareketler()
        {
            DataTable dt3=new DataTable();
            SqlDataAdapter da3 = new SqlDataAdapter("execute FirmaHareketAnaSayfa", bgl.baglanti());
            da3.Fill(dt3);
            GrdSon10Hareket.DataSource = dt3;
        }
        void fihrist()
        {
            DataTable dt4 = new DataTable();
            SqlDataAdapter da4 = new SqlDataAdapter("select FIRMA_AD,TELEFON1 FROM Tbl_Firmalar", bgl.baglanti());
            da4.Fill(dt4);
            GrdFihrist.DataSource = dt4;
        }
        void haberler()
        {
            XmlTextReader xmloku = new XmlTextReader("http://www.hurriyet.com.tr/rss/anasayfa");
            while (xmloku.Read())
            {
                if(xmloku.Name=="title")
                {
                    listBox1.Items.Add(xmloku.ReadString());
                }
            }
        }
        private void FrmAnaSayfa_Load(object sender, EventArgs e)
        {
            stoklar();
            ajanda();
            FirmaHareketler();
            fihrist();
            WebDoviz.Navigate("https://www.tcmb.gov.tr/wps/wcm/connect/tr/tcmb+tr/main+page+site+area/bugun");
            haberler();
        }
    }
}
