using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TİcariOtomsyon
{
    public partial class AnaModul : Form
    {
        public AnaModul()
        {
            InitializeComponent();
        }
        FrmUrunler frmUrunler;
        private void Btn_Urun_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(frmUrunler==null || frmUrunler.IsDisposed)
            {

                frmUrunler = new FrmUrunler();
                frmUrunler.MdiParent = this;
                frmUrunler.Show();

            }

        }
        FrmMusteriler frmMusteriler;
        private void Btn_Musteri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmMusteriler == null || frmMusteriler.IsDisposed)
            {

                frmMusteriler = new FrmMusteriler();
                frmMusteriler.MdiParent = this;
                frmMusteriler.Show();

            }
        }
        FrmFirmalar frmFirmalar;
        private void Btn_Firma_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {  
            if (frmFirmalar==null ||frmFirmalar.IsDisposed)
            {
                frmFirmalar = new FrmFirmalar();
                frmFirmalar.MdiParent = this;
                frmFirmalar.Show();
            }
        }
        FrmPersoneller frmPersoneller;
        private void Btn_Personel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(frmPersoneller==null|| frmPersoneller.IsDisposed)
            {
                frmPersoneller = new FrmPersoneller();
                frmPersoneller.MdiParent = this;
                frmPersoneller.Show();
            }
        }
        FrmRehber frmRehber;
        private void Btn_Rehber_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(frmRehber==null|| frmRehber.IsDisposed)
            {
                frmRehber = new FrmRehber();
                frmRehber.MdiParent = this;
                frmRehber.Show();
            }
        }
        FrmGiderler frmGiderler;

        private void Btn_Gider_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmGiderler==null || frmGiderler.IsDisposed)
            {
                frmGiderler = new FrmGiderler();
                frmGiderler.MdiParent = this;
                frmGiderler.Show();
            }
        }
        FrmBankalar frmBankalar;
        private void Btn_Banka_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if( frmBankalar==null ||frmBankalar.IsDisposed)
            {
                frmBankalar = new FrmBankalar();
                frmBankalar.MdiParent = this;
                frmBankalar.Show();
            }
        }
        FrmFaturalar frmFaturalar;
        private void Btn_Fatura_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(frmFaturalar==null || frmFaturalar.IsDisposed)
            {
                frmFaturalar = new FrmFaturalar();
                frmFaturalar.MdiParent = this;
                frmFaturalar.Show();
            }
        }
        FrmNotlar frmNotlar;
        private void Btn_Notlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(frmNotlar==null || frmNotlar.IsDisposed)
            {
                frmNotlar = new FrmNotlar();
                frmNotlar.MdiParent = this;
                frmNotlar .Show();
            }
        }
        FrmHareketler frmHareketler;
        private void Btn_Hareketler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(frmHareketler==null || frmHareketler.IsDisposed)
            {
                frmHareketler = new FrmHareketler();
                frmHareketler.MdiParent = this;
                frmHareketler.Show();
            }
        }
        FrmRaporlar frmRaporlar;
        private void Btn_Raporlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmRaporlar==null || frmRaporlar.IsDisposed)
            {
                frmRaporlar = new FrmRaporlar();
                frmRaporlar.MdiParent = this;
                frmRaporlar .Show();
            }
        }
        FrmStoklar frmStoklar;
        private void Btn_Stok_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(frmStoklar==null ||frmStoklar.IsDisposed)
            {
                frmStoklar = new FrmStoklar();
                frmStoklar.MdiParent = this;
                frmStoklar .Show();
            }
        }
        FrmAyarlar frmAyarlar;
        private void Btn_Ayarlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if( frmAyarlar==null || frmAyarlar.IsDisposed)
            {
                frmAyarlar = new FrmAyarlar();
                frmAyarlar .Show();
            }
        }

        FrmKasa frmKasa;
        private void Btn_Kasa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(frmKasa==null ||frmKasa.IsDisposed)
            {
                frmKasa = new FrmKasa();
                frmKasa.ad = kullanici;
                frmKasa.MdiParent= this;
                frmKasa .Show();
            }
        }
        public string kullanici;
        private void AnaModul_Load(object sender, EventArgs e)
        {
            if (frmAnaSayfa == null )
            {
                frmAnaSayfa = new FrmAnaSayfa();
                frmAnaSayfa.MdiParent = this;
                frmAnaSayfa.Show();
            }

        }
        FrmAnaSayfa frmAnaSayfa;
        private void Btn_AnaSayfa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmAnaSayfa == null || frmAnaSayfa.IsDisposed)
            {
                frmAnaSayfa = new FrmAnaSayfa();
                frmAnaSayfa.MdiParent = this;
                frmAnaSayfa.Show();
            }

        }
    }
}
