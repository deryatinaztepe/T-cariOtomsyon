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
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl=new SqlBaglantisi();
        private void BtnGirisYap_MouseHover(object sender, EventArgs e)
        {
            BtnGirisYap.BackColor = Color.Yellow;
        }

        private void BtnGirisYap_MouseLeave(object sender, EventArgs e)
        {
            BtnGirisYap.BackColor=Color.PeachPuff;
        }

        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from Tbl_Admin  where KULLANICIADI=@P1 AND SIFRE=@P2", bgl.baglanti());
            komut.Parameters.AddWithValue("@P1",TxtKullaniciAdi.Text);
            komut.Parameters.AddWithValue("@P2", TxtSifre.Text);
            SqlDataReader dr=komut.ExecuteReader();
            if (dr.Read())
            { 
               AnaModul anaModul = new AnaModul();
                anaModul.kullanici=TxtKullaniciAdi.Text;
                anaModul.Show();
                this.Hide();
             }
            else
            {
                MessageBox.Show("Hatalı Kullanıc Adı ya da Şifre", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            bgl.baglanti().Close();
        }
    }
}
