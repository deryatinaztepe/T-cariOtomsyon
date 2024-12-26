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
    public partial class FrmNotlar : Form
    {
        public FrmNotlar()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl=new SqlBaglantisi();
        void notListele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da=new SqlDataAdapter("select * from Tbl_Notlar",bgl.baglanti());
            da.Fill(dt);
           gridControl1.DataSource = dt;
        }
        void notTemizle()
        {
            TxtNotID.Text = "";
            MskTarihN.Text = "";
            MskSaatN.Text = "";
            TxtOlusturan.Text = "";
            TxtBaslik.Text = "";
            TxtHitap.Text = "";
            RchDetay.Text = "";
        }
        private void FrmNotlar_Load(object sender, EventArgs e)
        {
            notListele();
            notTemizle();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Notlar (NOTTARIH,NOTSAAT,NOTBASLIK,NOTDETAY,NOTOLUSTURAN,NOTHITAP) VALUES(@P1,@P2,@P3,@P4,@P5,@P6)",bgl.baglanti());
            komut.Parameters.AddWithValue("@P1",MskTarihN.Text);
            komut.Parameters.AddWithValue("@P2",MskSaatN.Text);
            komut.Parameters.AddWithValue("@P3",TxtBaslik.Text);
            komut.Parameters.AddWithValue("@P4",RchDetay.Text);
            komut.Parameters.AddWithValue("@P5",TxtOlusturan.Text);
            komut.Parameters.AddWithValue("@P6",TxtHitap.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Not Bilgisi Sisteme Kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            notListele();
            notTemizle();

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr=gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if (dr != null)
            {
                TxtNotID.Text = dr["NOTID"].ToString();
                MskTarihN.Text = dr["NOTTARIH"].ToString();
                MskSaatN.Text = dr["NOTSAAT"].ToString();
                TxtBaslik.Text = dr["NOTBASLIK"].ToString();
                RchDetay.Text = dr["NOTDETAY"].ToString();
                TxtOlusturan.Text = dr["NOTOLUSTURAN"].ToString();
                TxtHitap.Text = dr["NOTHITAP"].ToString();
            }
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            notTemizle();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from Tbl_Notlar where NOTID=@P1",bgl.baglanti());
            komut.Parameters.AddWithValue("@P1",TxtNotID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Not Sistemden Silindi.","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Error);
            notListele();
            notTemizle();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Tbl_Notlar set NOTTARIH=@P1,NOTSAAT=@P2,NOTBASLIK=@P3,NOTDETAY=@P4,NOTOLUSTURAN=@P5,NOTHITAP=@P6 WHERE NOTID=@P7", bgl.baglanti());
            komut.Parameters.AddWithValue("@P1",MskTarihN.Text);
            komut.Parameters.AddWithValue("@P2",MskSaatN.Text);
            komut.Parameters.AddWithValue("@P3", TxtBaslik.Text);
            komut.Parameters.AddWithValue("@P4",RchDetay.Text);
            komut.Parameters.AddWithValue("@P5",TxtOlusturan.Text);
            komut.Parameters.AddWithValue("@P6",TxtHitap.Text);
            komut.Parameters.AddWithValue("@P7", TxtNotID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Not Bilgisi Güncellendi.","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);
            notListele();
            notTemizle();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmNotDetay frmNotDetay = new FrmNotDetay();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                frmNotDetay.metin = dr["NOTDETAY"].ToString();
            }
            frmNotDetay.Show();
        }

    }
}
