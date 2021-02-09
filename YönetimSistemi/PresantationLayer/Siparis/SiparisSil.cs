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
using YönetimSistemi.PocosLayer;
using YönetimSistemi.DataAccessObjectLayer;
using YönetimSistemi.BussinessLogicLayer;




namespace YönetimSistemi.PresantationLayer.Siparis
{
    public partial class SiparisSil : Form
    {
        private TblSiparisDAO tblSiparisDAO;


        private TblSiparisBLL _tblSiparisBLL;
        public SiparisSil()
        {
            InitializeComponent();
            _tblSiparisBLL = new TblSiparisBLL();

        }


        private void Siparis_Sil_Click(object sender, EventArgs e)
        {
            _tblSiparisBLL.silSiparis(siparisİD_txt.Text);

            listele();
            MessageBox.Show("silindi");
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
        private void dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            siparisİD_txt.Text = dataGrid.CurrentRow.Cells[0].Value.ToString();
            ürünİd_txt.Text = dataGrid.CurrentRow.Cells[1].Value.ToString();
            siparisiVerenKullaniciİd_txt.Text = dataGrid.CurrentRow.Cells[2].Value.ToString();
            ürünAdi_txt.Text = dataGrid.CurrentRow.Cells[3].Value.ToString();
            siparisAdet.Text = dataGrid.CurrentRow.Cells[4].Value.ToString();
        }

        private void SiparisSil_Load(object sender, EventArgs e)
        {
            listele();
        }
    }
}
