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
    public partial class FrmGiderler : Form
    {
        public FrmGiderler()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl=new SqlBaglantisi();
        void giderListele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_Giderler order by GIDERID ASC", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        void giderTemizle()
        {
            TxtGiderID.Text = "";
            CmbAy.Text = "";
            CmbYıl.Text = "";
            TxtElektrik.Text = "";
            TxtSu.Text = "";
            TxtDogalgaz.Text = "";
            TxtInternet.Text = "";
            TxtMaaslar.Text = "";
            TxtEkstra.Text = "";
            RchNotlar.Text = "";
        }


        private void FrmGiderler_Load(object sender, EventArgs e)
        {
            giderListele();
            giderTemizle();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Giderler (AY,YIL,ELEKTRIK,SU,DOGALGAZ,INTERNET,MAASLAR,EKSTRA,NOTLAR) VALUES (@P1,@P2,@P3,@P4,@P5,@P6,@P7,@P8,@P9)", bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", CmbAy.Text);
            komut.Parameters.AddWithValue("@P2", CmbYıl.Text);
            komut.Parameters.AddWithValue("@P3", decimal.Parse(TxtElektrik.Text));
            komut.Parameters.AddWithValue("@P4", decimal.Parse(TxtSu.Text));
            komut.Parameters.AddWithValue("@P5", decimal.Parse(TxtDogalgaz.Text));
            komut.Parameters.AddWithValue("@P6", decimal.Parse(TxtInternet.Text));
            komut.Parameters.AddWithValue("@P7", decimal.Parse(TxtMaaslar.Text));
            komut.Parameters.AddWithValue("@P8", decimal.Parse(TxtEkstra.Text));
            komut.Parameters.AddWithValue("@P9", RchNotlar.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Gider Sisteme Kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            giderListele();
            giderTemizle();
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            giderTemizle();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                TxtGiderID.Text = dr["GIDERID"].ToString();
                CmbAy.Text = dr["AY"].ToString();
                CmbYıl.Text = dr["YIL"].ToString();
                TxtElektrik.Text = dr["ELEKTRIK"].ToString();
                TxtSu.Text = dr["SU"].ToString();
                TxtDogalgaz.Text = dr["DOGALGAZ"].ToString();
                TxtInternet.Text = dr["INTERNET"].ToString();
                TxtMaaslar.Text = dr["MAASLAR"].ToString();
                TxtEkstra.Text = dr["EKSTRA"].ToString();
                RchNotlar.Text = dr["NOTLAR"].ToString();
            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from Tbl_Giderler where GIDERID=@P1",bgl.baglanti());
            komut.Parameters.AddWithValue("@P1",TxtGiderID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Gider Sistemden Silindi.","Uyarı",MessageBoxButtons.OK, MessageBoxIcon.Error);
            giderListele();
            giderTemizle();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Tbl_Giderler set AY=@P1,YIL=@P2,ELEKTRIK=@P3,SU=@P4,DOGALGAZ=@P5,INTERNET=@P6,MAASLAR=@P7,EKSTRA=@P8,NOTLAR=@P9 WHERE GIDERID=@P10",bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", CmbAy.Text);
            komut.Parameters.AddWithValue("@P2", CmbYıl.Text);
            komut.Parameters.AddWithValue("@P3", decimal.Parse(TxtElektrik.Text));
            komut.Parameters.AddWithValue("@P4", decimal.Parse(TxtSu.Text));
            komut.Parameters.AddWithValue("@P5", decimal.Parse(TxtDogalgaz.Text));
            komut.Parameters.AddWithValue("@P6", decimal.Parse(TxtInternet.Text));
            komut.Parameters.AddWithValue("@P7", decimal.Parse(TxtMaaslar.Text));
            komut.Parameters.AddWithValue("@P8", decimal.Parse(TxtEkstra.Text));
            komut.Parameters.AddWithValue("@P9", RchNotlar.Text);
            komut.Parameters.AddWithValue("@P10", TxtGiderID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Gider Sistemde Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            giderListele();
            giderTemizle();
        }
    }
}
