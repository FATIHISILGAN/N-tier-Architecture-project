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
using YönetimSistemi.vtBağlanti;
using System.Data.SqlClient;
using YönetimSistemi.BussinessLogicLayer;
using YönetimSistemi.PocosLayer;

namespace YönetimSistemi.PresantationLayer.stok
{
    public partial class UrunEkle : Form
    {
        private TblStokBLL _tblStokBLL;
        public UrunEkle()
        {
            InitializeComponent();
            _tblStokBLL = new TblStokBLL();

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
        private void UrunEkle_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void Urun_Ekle_Click(object sender, EventArgs e)
        {
            try
            {
                TblStokPoco tblStokPoco = new TblStokPoco();
                tblStokPoco = _tblStokBLL.stokKaydet(Convert.ToInt32(urunİD_txt.Text),ürünAdi_txt.Text,Convert.ToInt32(ürünAdet_txt.Text));

                MessageBox.Show("eklendi");
                listele();
            }
            catch(Exception ex)
            {

                MessageBox.Show("eklenmedi" +ex.Message);
            }
        }

        private void anamenüye_Dön_Click(object sender, EventArgs e)
        {
            AnaMenü anaMenü = new AnaMenü();
            anaMenü.Show();
            Close();

        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            urunİD_txt.Text = dataGrid.CurrentRow.Cells[0].Value.ToString();
            ürünAdi_txt.Text = dataGrid.CurrentRow.Cells[1].Value.ToString();
            ürünAdet_txt.Text = dataGrid.CurrentRow.Cells[2].Value.ToString();
          
         
        }
    }
}
