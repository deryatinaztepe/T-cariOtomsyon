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
    public partial class FrmUrunler : Form
    {
        public FrmUrunler()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        void urunListele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Urunler",bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        void urunTemizle()
        {
            TxtUrunID.Text = "";
            TxtUrunAdi.Text = "";
            TxtMarka.Text = "";
            TxtModel.Text = "";
            MskYil.Text = "";
            NmrAdet.Value = 0;
            TxtAlisFiyati.Text = "";
            TxtSatisFiyati.Text = "";
            RchDetay.Text = "";
        }
        private void FrmUrunler_Load(object sender, EventArgs e)
        {
            urunListele();
            urunTemizle();
        }


        private void gridView1_FocusedRowChanged_1(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            TxtUrunID.Text = dr["URUNID"].ToString();
            TxtUrunAdi.Text = dr["URUNAD"].ToString();
            TxtMarka.Text = dr["URUNMARKA"].ToString();
            TxtModel.Text = dr["MODEL"].ToString();
            MskYil.Text = dr["YIL"].ToString();
            NmrAdet.Value = decimal.Parse(dr["ADET"].ToString());
            TxtAlisFiyati.Text = dr["ALISFIYAT"].ToString();
            TxtSatisFiyati.Text = dr["SATISFIYAT"].ToString();
            RchDetay.Text = dr["DETAY"].ToString();
        }

        private void BtnKaydet_Click_1(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Urunler(URUNAD,URUNMARKA,MODEL,YIL,ADET,ALISFIYAT,SATISFIYAT,DETAY) VALUES(@P1,@P2,@P3,@P4,@P5,@P6,@P7,@P8)", bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", TxtUrunAdi.Text);
            komut.Parameters.AddWithValue("@P2", TxtMarka.Text);
            komut.Parameters.AddWithValue("@P3", TxtModel.Text);
            komut.Parameters.AddWithValue("@P4", MskYil.Text);
            komut.Parameters.AddWithValue("@P5", int.Parse((NmrAdet.Value).ToString()));
            komut.Parameters.AddWithValue("@P6", decimal.Parse(TxtAlisFiyati.Text));
            komut.Parameters.AddWithValue("@P7", decimal.Parse(TxtSatisFiyati.Text));
            komut.Parameters.AddWithValue("@P8", RchDetay.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün Sisteme Kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            urunListele();
            urunTemizle();
        }

        private void BtnSil_Click_1(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from Tbl_Urunler where URUNID=@P1", bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", TxtUrunID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün Sistemden Silindi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            urunListele();
            urunTemizle();
        }

        private void BtnGuncelle_Click_1(object sender, EventArgs e)
        {

            SqlCommand komut = new SqlCommand("update Tbl_Urunler set URUNAD=@P1,URUNMARKA=@P2,MODEL=@P3,YIL=@P4,ADET=@P5,ALISFIYAT=@P6,SATISFIYAT=@P7,DETAY=@P8 WHERE URUNID=@P9", bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", TxtUrunAdi.Text);
            komut.Parameters.AddWithValue("@P2", TxtMarka.Text);
            komut.Parameters.AddWithValue("@P3", TxtModel.Text);
            komut.Parameters.AddWithValue("@P4", MskYil.Text);
            komut.Parameters.AddWithValue("@P5", int.Parse((NmrAdet.Value).ToString()));
            komut.Parameters.AddWithValue("@P6", decimal.Parse(TxtAlisFiyati.Text));
            komut.Parameters.AddWithValue("@P7", decimal.Parse(TxtSatisFiyati.Text));
            komut.Parameters.AddWithValue("@P8", RchDetay.Text);
            komut.Parameters.AddWithValue("@P9", TxtUrunID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün Bilgisi Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            urunListele();
            urunTemizle();
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            urunTemizle();
        }
    }
}
