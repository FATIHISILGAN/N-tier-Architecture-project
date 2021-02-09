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

namespace YönetimSistemi.PresantationLayer.stok
{
    public partial class UrunListele : Form
    {

        public SqlCommand sorgu;
        public UrunListele()
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
        public string secili_urunad;
        public string secili_urunadet;



        private void UrunListele_Load(object sender, EventArgs e)
        {
            VtBağlanti vtBağlanti = new VtBağlanti();
            sorgu = new SqlCommand("Select *  from  Stok", vtBağlanti.bağlanti);

            listele();

            id_Check.Enabled = false;
            ürünAdet_Check.Enabled = false;
            ürünAdi_Check.Enabled = false;
        }

        private void ürün_Listele_Click(object sender, EventArgs e)
        {
            if (hepsiniListeleRadio.Checked == true)
            {
                VtBağlanti newConnect = new VtBağlanti();
                sorgu = new SqlCommand("Select * from Stok", newConnect.bağlanti);
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

                if (ürünAdi_Check.Checked == true)
                {
                    secili_urunad = "ürünAdı,";
                }
                else
                {
                    secili_urunad = "";
                }

                if (ürünAdet_Check.Checked == true)
                {
                    secili_urunadet = "ürünAdet";
                }
                else
                {
                    secili_urunadet = "";
                }


                VtBağlanti vtBağlanti = new VtBağlanti();
                sorgu = new SqlCommand("Select " + secili_idnumber + secili_urunad+ secili_urunadet
                    + " from Stok", vtBağlanti.bağlanti);
                listele();



            }
        }

        private void anamenüye_Dön_Click(object sender, EventArgs e)
        {
            AnaMenü anaMenü = new AnaMenü();
            anaMenü.Show();
            Close();
        }

        private void hepsiniListeleRadio_CheckedChanged(object sender, EventArgs e)
        {
            id_Check.Enabled = false;
            ürünAdet_Check.Enabled = false;
            ürünAdi_Check.Enabled =false;
        }

        private void secileniListeleradio_CheckedChanged(object sender, EventArgs e)
        {

            id_Check.Enabled = true;
            ürünAdet_Check.Enabled = true;
            ürünAdi_Check.Enabled = true;
        }
    }
}
