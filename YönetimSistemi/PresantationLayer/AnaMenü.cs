using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YönetimSistemi.PresantationLayer.kullanicilar;
using YönetimSistemi.PresantationLayer.stok;
using YönetimSistemi.PresantationLayer.Siparis;
using System.IO;

namespace YönetimSistemi.PresantationLayer
{
    public partial class AnaMenü : Form
    {
        
        public AnaMenü()
        {
            InitializeComponent();
        }

        private void kullanıcıYeniKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KullaniciEkle kullaniciEkle = new  KullaniciEkle();
            
            kullaniciEkle.Show();
            Hide();
                        
        }


        private void AnaMenü_Load(object sender, EventArgs e)
        {
            string curDir = Directory.GetCurrentDirectory();
            this.webBrowser1.Url = new Uri(String.Format("file:///{0}/index.html", curDir));

        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OturumAcmaEkrani oturumAcmaEkrani = new OturumAcmaEkrani();
            oturumAcmaEkrani.Show();
            Close();
        }

        private void dToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KullaniciGuncelle kullaniciGuncelle = new KullaniciGuncelle();
            kullaniciGuncelle.Show();
            Close();


        }

        private void kullanıcıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KullaniciSil kullaniciSil = new KullaniciSil();
            kullaniciSil.Show();
            Close();
        }

        private void kullanıcıListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KullaniciListele kullaniciListele = new KullaniciListele();
            kullaniciListele.Show();
            Close();
        }

        private void ürünüSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UrunSil urunSil = new UrunSil();
            urunSil.Show();
            Close();
        }

        private void ürünEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UrunEkle urunEkle = new UrunEkle();
            urunEkle.Show();
            Close();
        }

        private void ürünGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UrunGuncelle urunGuncelle = new UrunGuncelle(); ;
            urunGuncelle.Show();
            Close();
        }

        private void ürünListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UrunListele urunListele = new UrunListele();
            urunListele.Show();
            Close();
        }

        private void siparişEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SiparisEkle siparisEkle = new SiparisEkle();
            siparisEkle.Show();
            Close();
        }

        private void siparişGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SiparisGuncelle siparisGuncelle = new SiparisGuncelle();
            siparisGuncelle.Show();
            Close();
        }

        private void ürünSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SiparisSil siparisSil = new SiparisSil();
            siparisSil.Show();
            Close();
        }

      

        private void projelerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Projeler projeler = new Projeler();
            projeler.Show();
            Close();
        }

        private void SiparisSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SiparisSil siparisSil = new SiparisSil();
            siparisSil.Show();
            Close();
        }

        private void SiparisListeleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SiparisListele siparisListele = new SiparisListele();
            siparisListele.Show();
            Close();
        }
    }
}
