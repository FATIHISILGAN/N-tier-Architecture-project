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

namespace YönetimSistemi.PresantationLayer.Siparis
{
    public partial class SiparisListele : Form
    {
        public SqlCommand sorgu;
        public SiparisListele()
        {
            InitializeComponent();
        }



        public string secili_idnumber;
        public string secili_urunid;
        public string secili_siparisiVerenİd;
        public string secili_ürünAdı;
        public string secili_siparisAdet;



        private void siparis_Listele_Click(object sender, EventArgs e)
        {

            if (hepsiniListeleRadio.Checked == true)
            {
                VtBağlanti newConnect = new VtBağlanti();
                sorgu = new SqlCommand("Select * from Siparis", newConnect.bağlanti);
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

                if (urunId_Check.Checked == true)
                {
                    secili_urunid = "ürünİd,";
                }
                else
                {
                    secili_urunid = "";
                }

                if (siparisVerenId_Check.Checked == true)
                {
                    secili_siparisiVerenİd = "siparisiVerenKullaniciİd,";
                }
                else
                {
                    secili_siparisiVerenİd = "";

                }

                if (ürünAdi_Check.Checked == true)
                {
                   secili_ürünAdı = "ürünAdı,";
                }
                else
                {
                    secili_ürünAdı = "";

                }

                if (siparisAdet_Check.Checked == true)
                {
                    secili_siparisAdet = "siparisAdet";
                }
                else
                {
                    secili_siparisAdet = "";


                }

                VtBağlanti vtBağlanti = new VtBağlanti();
                sorgu = new SqlCommand("Select " + secili_idnumber + secili_urunid + secili_siparisiVerenİd +secili_ürünAdı +secili_siparisAdet
                    + " from Siparis", vtBağlanti.bağlanti);
                listele();



            }
        }

        private void anamenüye_Dön_Click(object sender, EventArgs e)
        {
            AnaMenü anaMenü = new AnaMenü();
            anaMenü.Show();
            Close();

        }

        private void SiparisListele_Load(object sender, EventArgs e)
        {
            VtBağlanti vtBağlanti = new VtBağlanti();
            sorgu = new SqlCommand("Select *  from  Siparis", vtBağlanti.bağlanti);

            listele();

            id_Check.Enabled = false;
            urunId_Check.Enabled = false;

            siparisVerenId_Check.Enabled = false;
            ürünAdi_Check.Enabled = false;

            siparisAdet_Check.Enabled = false;
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

        private void hepsiniListeleRadio_CheckedChanged(object sender, EventArgs e)
        {
            id_Check.Enabled = false;
            urunId_Check.Enabled = false;

            siparisVerenId_Check.Enabled = false;
            ürünAdi_Check.Enabled = false;

            siparisAdet_Check.Enabled = false;

        }

        private void secileniListeleradio_CheckedChanged(object sender, EventArgs e)
        {
            id_Check.Enabled = true;
            urunId_Check.Enabled = true;
            siparisVerenId_Check.Enabled = true;
            ürünAdi_Check.Enabled = true;
            siparisAdet_Check.Enabled = true;
        }
    }
}
