using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YönetimSistemi.PresantationLayer;
using YönetimSistemi.BussinessLogicLayer;
using YönetimSistemi.PocosLayer;


namespace YönetimSistemi
{
    
    public partial class OturumAcmaEkrani : Form

    {
        TblKullanicilarBLL tblKullanicilarBLL;
        public OturumAcmaEkrani()
        {
            InitializeComponent();
            tblKullanicilarBLL = new TblKullanicilarBLL();
        }

        private void girisYap_btn_Click(object sender, EventArgs e)
        {

            TblKullanicilarPoco tblKullanicilarPoco = new TblKullanicilarPoco();
            tblKullanicilarPoco = tblKullanicilarBLL.getSorgu(kullaniciAdi_Txt.Text,sifre_Txt.Text);

            if (tblKullanicilarPoco.kullaniciAdi==null || tblKullanicilarPoco.kullaniciPassword==null)
            {
                MessageBox.Show("hatali giriş yaptık");
            }
            else
            {
                Hide();
                MessageBox.Show("hoş geldiniz");
                AnaMenü anaMenü = new AnaMenü();
                anaMenü.Show();
 
            }





        }

        private void OturumAcmaEkrani_Load(object sender, EventArgs e)
        {
            sifre_Txt.PasswordChar = '*';
        }
    }
}
