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
using YönetimSistemi.vtBağlanti;
using System.Data.SqlClient;
using YönetimSistemi.PocosLayer;

namespace YönetimSistemi.PresantationLayer.stok
{
    public partial class UrunGuncelle : Form
    {
        private TblStokBLL _tblStokBLL;
        public UrunGuncelle()
        {
            InitializeComponent();
            _tblStokBLL = new TblStokBLL();
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
            SqlCommand sorgu = new SqlCommand("select * from Stok", vtBağlanti.bağlanti);
            DataTable dataTable = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter(sorgu);

            adapter.Fill(dataTable);

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dataTable;
            dataGrid.DataSource = bindingSource;

        }
        private void Urun_Guncelle_Click(object sender, EventArgs e)
        {
            TblStokPoco tblStokPoco = new TblStokPoco();

            tblStokPoco = _tblStokBLL.stokguncelle(Convert.ToInt32(urunİD_txt.Text), ürünAdi_txt.Text, Convert.ToInt32(ürünAdet_txt.Text));

            MessageBox.Show("güncelleme yapıldı");
            listele();

        }

        private void UrunGuncelle_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            urunİD_txt.Text = dataGrid.CurrentRow.Cells[0].Value.ToString();
            ürünAdi_txt.Text = dataGrid.CurrentRow.Cells[1].Value.ToString();
            ürünAdet_txt.Text = dataGrid.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
