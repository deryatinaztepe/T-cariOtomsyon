using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TİcariOtomsyon
{
    public partial class FrmBankalar : Form
    {
        public FrmBankalar()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl=new SqlBaglantisi();

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
        void bankaListele()
        {
            DataTable dt=new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(" execute BankaBilgileri", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        void bankaTemizle()
        {
            TxtBankID.Text = "";
            TxtBankaAdi.Text = "";
            CmbIl.Text = "";
            CmbIlce.Text = "";
            TxtSube.Text = "";
            TxtIBAN.Text = "";
            TxtHesapNo.Text = "";
            TxtYetkili.Text = "";
            MskTelefonB.Text = "";
            MskTarih.Text = "";
            TxtHesapTuru.Text = "";
            LkpFirma.Text = "";
        }
        void firmaListele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select FIRMAID,FIRMA_AD from Tbl_Firmalar", bgl.baglanti());
            da.Fill(dt);
            LkpFirma.Properties.ValueMember = "FIRMAID";
            LkpFirma.Properties.DisplayMember = "FIRMA_AD";
            LkpFirma.Properties.DataSource = dt;
        }
        private void FrmBankalar_Load(object sender, EventArgs e)
        {
            bankaListele();
            sehirListesi();
            bankaTemizle();
            firmaListele();
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
            SqlCommand komut = new SqlCommand("insert into Tbl_Bankalar(BANKAADI,IL,ILCE,SUBE,IBAN,HESAPNO,YETKILI,TELEFON,TARIH,HESAPTURU,FIRMAID) VALUES(@P1,@P2,@P3,@P4,@P5,@P6,@P7,@P8,@P9,@P10,@P11)", bgl.baglanti());
            komut.Parameters.AddWithValue("@P1",TxtBankaAdi.Text);
            komut.Parameters.AddWithValue("@P2",CmbIl.Text);
            komut.Parameters.AddWithValue("@P3",CmbIlce.Text);
            komut.Parameters.AddWithValue("@P4", TxtSube.Text);
            komut.Parameters.AddWithValue("@P5", TxtIBAN.Text);
            komut.Parameters.AddWithValue("@P6", TxtHesapNo.Text);
            komut.Parameters.AddWithValue("@P7", TxtYetkili.Text);
            komut.Parameters.AddWithValue("@P8", MskTelefonB.Text);
            komut.Parameters.AddWithValue("@P9",MskTarih.Text);
            komut.Parameters.AddWithValue("@P10",TxtHesapTuru.Text);
            komut.Parameters.AddWithValue("@P11",LkpFirma.EditValue);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Banka Bilgisi Sisteme Kaydedildi.","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);
            bankaListele();
            bankaTemizle(); 

            

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                TxtBankID.Text = dr["ID"].ToString();
                TxtBankaAdi.Text = dr["BANKAADI"].ToString();
                CmbIl.Text = dr["IL"].ToString();
                CmbIlce.Text = dr["ILCE"].ToString();
                TxtSube.Text = dr["SUBE"].ToString();
                TxtIBAN.Text = dr["IBAN"].ToString();
                TxtHesapNo.Text = dr["HESAPNO"].ToString();
                TxtYetkili.Text = dr["YETKILI"].ToString();
                MskTelefonB.Text = dr["TELEFON"].ToString();
                MskTarih.Text = dr["TARIH"].ToString();
                TxtHesapTuru.Text = dr["HESAPTURU"].ToString();
                
            }
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            bankaTemizle();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from Tbl_Bankalar where ID=@P1",bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", TxtBankID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            bankaListele();
            MessageBox.Show("Banka Bilgisi Sistemden Silindi.","Uyarı",MessageBoxButtons.OK, MessageBoxIcon.Error);
          
            bankaTemizle();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("UPDATE Tbl_Bankalar set BANKAADI=@P1,IL=@P2,ILCE=@P3,SUBE=@P4,IBAN=@P5,HESAPNO=@P6,YETKILI=@P7,TELEFON=@P8,TARIH=@P9,HESAPTURU=@P10,FIRMAID=@P11 WHERE ID=@P11",bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", TxtBankaAdi.Text);
            komut.Parameters.AddWithValue("@P2", CmbIl.Text);
            komut.Parameters.AddWithValue("@P3", CmbIlce.Text);
            komut.Parameters.AddWithValue("@P4", TxtSube.Text);
            komut.Parameters.AddWithValue("@P5", TxtIBAN.Text);
            komut.Parameters.AddWithValue("@P6", TxtHesapNo.Text);
            komut.Parameters.AddWithValue("@P7", TxtYetkili.Text);
            komut.Parameters.AddWithValue("@P8", MskTelefonB.Text);
            komut.Parameters.AddWithValue("@P9", MskTarih.Text);
            komut.Parameters.AddWithValue("@P10", TxtHesapTuru.Text);
            komut.Parameters.AddWithValue("@P11", LkpFirma.EditValue);
            komut.Parameters.AddWithValue("@P12",TxtBankID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Banka Bilgisi Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bankaListele();
            bankaTemizle();
        }
    }
}
