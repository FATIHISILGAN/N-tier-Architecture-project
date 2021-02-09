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
using YönetimSistemi.vtBağlanti;



namespace YönetimSistemi.PresantationLayer.kullanicilar
{
    public partial class KullaniciListele : Form
    {

        public SqlCommand sorgu;
        public KullaniciListele()
        {
            InitializeComponent();
        }

        public void listele()
        {
           
            DataTable dataTable = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter(sorgu);

            adapter.Fill(dataTable);

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dataTable;
            dataGrid.DataSource = bindingSource;
        }

        public string secili_idnumber;
        public string secili_adSoyadBilgisi;
        public string secili_parolaBilgisi;
        public string secili_kullaniciAdBilgisi;
        public string secili_telNo1Bilgisi;
        public string secili_telNo2Bilgisi;
        public string secili_cinsiyetBilgisi;
        public string secili_eMailBilgisi;

        private void KullaniciListele_Load(object sender, EventArgs e)
        {
            VtBağlanti vtBağlanti = new VtBağlanti();
            sorgu = new SqlCommand("Select *  from  kullanıcılar", vtBağlanti.bağlanti);

            listele();
            
            id_Check.Enabled = false;
            adSoyad_Check.Enabled = false;
            parola_Check.Enabled = false;
            kullaniciAdi_Check.Enabled = false;
            tel1_Check.Enabled = false;
            tel2_Check.Enabled = false;
            email_Check.Enabled = false;
            cinsiyet_Check.Enabled = false;



        }    


        private void kullanici_Listele_Click(object sender, EventArgs e)
        {
            if (hepsiniListeleRadio.Checked == true)
            {
                VtBağlanti newConnect = new VtBağlanti();
                sorgu = new SqlCommand("Select * from kullanıcılar", newConnect.bağlanti);
                listele();
            }

            if (secileniListeleradio.Checked == true)
            {
                if (id_Check.Checked == true)
                {
                    secili_idnumber = "id,";
                }
                else
                {
                    secili_idnumber = "";
                }

                if (kullaniciAdi_Check.Checked == true)
                {
                    secili_kullaniciAdBilgisi = "kullanıcıAdı,";
                }
                else
                {
                    secili_kullaniciAdBilgisi = "";
                }

                if (parola_Check.Checked == true)
                {
                    secili_parolaBilgisi = "parola,";
                }
                else
                {
                    secili_parolaBilgisi = "";
                }

                if (adSoyad_Check.Checked == true)
                {
                    secili_adSoyadBilgisi = "adSoyad,";
                }
                else
                {
                    secili_adSoyadBilgisi = "";
                }

                if (email_Check.Checked == true)
                {
                    secili_eMailBilgisi = "email,";
                }
                else
                {
                    secili_eMailBilgisi = "";
                }
                if(cinsiyet_Check.Checked == true)
                { 
                    secili_cinsiyetBilgisi = "cinsiyet,";
                }
                else
                {
                    secili_cinsiyetBilgisi = "";
                }
                if(tel1_Check.Checked == true)
                {
                    secili_telNo1Bilgisi = "telno1,";
                }
                else
                {
                    secili_telNo1Bilgisi = "";
                }
                if(tel2_Check.Checked == true)
                {
                    secili_telNo2Bilgisi = "telno2";
                }
                else
                {
                    secili_telNo2Bilgisi = "";
                }


                VtBağlanti vtBağlanti = new VtBağlanti();
                sorgu = new SqlCommand("Select " + secili_idnumber + secili_kullaniciAdBilgisi + secili_parolaBilgisi + secili_adSoyadBilgisi + secili_eMailBilgisi + secili_cinsiyetBilgisi + secili_telNo1Bilgisi + secili_telNo2Bilgisi 
                    + " from kullanıcılar", vtBağlanti.bağlanti);
                listele();


               
            }
        }

        private void secileniListeleradio_CheckedChanged(object sender, EventArgs e)
        {
            id_Check.Enabled = true;
            kullaniciAdi_Check.Enabled = true;
            parola_Check.Enabled = true;
            adSoyad_Check.Enabled = true;
            email_Check.Enabled = true;
            cinsiyet_Check.Enabled = true;
            tel1_Check.Enabled = true;
            tel2_Check.Enabled = true;
            
            
        }

        private void hepsiniListeleRadio_CheckedChanged(object sender, EventArgs e)
        {
            id_Check.Enabled = false;
            kullaniciAdi_Check.Enabled = false;
            parola_Check.Enabled = false;
            adSoyad_Check.Enabled = false;
            email_Check.Enabled = false;
            cinsiyet_Check.Enabled = false;
            tel1_Check.Enabled = false;
            tel2_Check.Enabled = false;
        }

        private void anamenüye_Dön_Click(object sender, EventArgs e)
        {
            AnaMenü anaMenü = new AnaMenü();
            anaMenü.Show();
            Close();
        }
    }
}
