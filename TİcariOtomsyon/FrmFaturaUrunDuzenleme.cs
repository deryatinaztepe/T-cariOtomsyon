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
    public partial class FrmFaturaUrunDuzenleme : Form
    {
        public FrmFaturaUrunDuzenleme()
        {
            InitializeComponent();
        }
        public string urunid;
        SqlBaglantisi bgl = new SqlBaglantisi();
        private void FrmFaturaUrunDuzenleme_Load(object sender, EventArgs e)
        {
            TxtUrunID.Text= urunid;
            SqlCommand komut=new SqlCommand("select * from Tbl_FaturaDetay where FATURAURUNID=@P1",bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", urunid);
            SqlDataReader dr=komut.ExecuteReader();
            while(dr.Read())
            {
                TxtFiyat.Text = dr[3].ToString();
                TxtMiktar.Text = dr[2].ToString();
                TxtTutar.Text = dr[4].ToString();
                TxtUrunAdi.Text = dr[1].ToString();

                bgl.baglanti().Close();
            }

        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Tbl_FaturaDetay set URUNAD=@P1,MIKTAR=@P2,FIYAT=@P3,TUTAR=@P4 WHERE FATURAURUNID=@P5", bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", TxtUrunAdi.Text);
            komut.Parameters.AddWithValue("@P2",TxtMiktar.Text);
            komut.Parameters.AddWithValue("@P3",decimal.Parse(TxtFiyat.Text));
            komut.Parameters.AddWithValue("@P4",decimal.Parse(TxtTutar.Text));
            komut.Parameters.AddWithValue("@P5",TxtUrunID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Değişiklikler Kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from Tbl_FaturaDetay where FATURAURUNID=@P1",bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", TxtUrunID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün Silindi.","Uyarı",MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
