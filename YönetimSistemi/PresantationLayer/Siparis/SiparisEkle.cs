using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YönetimSistemi.vtBağlanti;
using System.Data.SqlClient;
using YönetimSistemi.BussinessLogicLayer;
using YönetimSistemi.PocosLayer;

namespace YönetimSistemi.PresantationLayer.Siparis
{
    public partial class SiparisEkle : Form
    {
        private TblSiparisBLL _tblSiparisBLL;
        public SiparisEkle()
        {
            InitializeComponent();
            _tblSiparisBLL = new TblSiparisBLL();

        }

        private void anamenüye_Dön_Click(object sender, EventArgs e)
        {
            AnaMenü anaMenü = new AnaMenü();
            anaMenü.Show();
            Close();
        }
        public void listele()
        {
            VtBağlanti vtBağlanti = new VtBağlanti();
            SqlCommand sorgu = new SqlCommand("select * from Siparis", vtBağlanti.bağlanti);
            DataTable dataTable = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter(sorgu);

            adapter.Fill(dataTable);

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dataTable;
            dataGrid.DataSource = bindingSource;


        }
        private void Siparis_Ekle_Click(object sender, EventArgs e)
        {
            try
            {
                TblSiparisPoco tblSiparisPoco = new TblSiparisPoco();
                tblSiparisPoco = _tblSiparisBLL.siparisKaydet(Convert.ToInt32(siparisİD_txt.Text), Convert.ToInt32(ürünİd_txt.Text), Convert.ToInt32(siparisiVerenKullaniciİd_txt.Text),ürünAdi_txt.Text,Convert.ToInt32(siparisAdet_txt.Text));

                MessageBox.Show("eklendi");
                listele();
            }
            catch (Exception ex)
            {

                MessageBox.Show("eklenmedi" + ex.Message);
            }
        }

        private void SiparisEkle_Load(object sender, EventArgs e)
        {
            listele();
        }
    }
}
