using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YönetimSistemi.BussinessLogicLayer;
using YönetimSistemi.DataAccessObjectLayer;
using YönetimSistemi.PocosLayer;
using YönetimSistemi.vtBağlanti;
using System.Data.SqlClient;



namespace YönetimSistemi.PresantationLayer.Siparis
{
    public partial class SiparisGuncelle : Form
    {
        TblSiparisBLL _tblSiparisBLL;
        public SiparisGuncelle()
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
        private void Siparis_Güncelle_Click(object sender, EventArgs e)
        {
            TblSiparisPoco tblSiparisPoco = new TblSiparisPoco();

            tblSiparisPoco = _tblSiparisBLL.siparisguncelle(Convert.ToInt32(siparisİD_txt.Text), Convert.ToInt32( ürünİd_txt.Text), Convert.ToInt32(siparisiVerenKullaniciİd_txt.Text),ürünAdi_txt.Text,Convert.ToInt32(siparisAdet.Text));

            MessageBox.Show("güncelleme yapıldı");
            listele();
        }

        private void SiparisGuncelle_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            siparisİD_txt.Text = dataGrid.CurrentRow.Cells[0].Value.ToString();
            ürünİd_txt.Text = dataGrid.CurrentRow.Cells[1].Value.ToString();
            siparisiVerenKullaniciİd_txt.Text = dataGrid.CurrentRow.Cells[2].Value.ToString();
            ürünAdi_txt.Text = dataGrid.CurrentRow.Cells[3].Value.ToString();
            siparisAdet.Text = dataGrid.CurrentRow.Cells[4].Value.ToString();


        }
    }
}
