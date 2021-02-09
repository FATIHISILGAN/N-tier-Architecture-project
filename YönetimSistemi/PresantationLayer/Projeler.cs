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

namespace YönetimSistemi.PresantationLayer
{
    public partial class Projeler : Form
    {
        public Projeler()
        {
            InitializeComponent();
        }

        string id;
        string projeAd;
        string projeAciklamasi;
        private void dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           id = dataGrid.CurrentRow.Cells[0].Value.ToString();
           projeAd = dataGrid.CurrentRow.Cells[1].Value.ToString();
           projeAciklamasi = dataGrid.CurrentRow.Cells[2].Value.ToString();


        }

        private void Projeler_Load(object sender, EventArgs e)
        {
            VtBağlanti vtBağlanti = new VtBağlanti();
            SqlCommand sorgu = new SqlCommand("select * from Projeler", vtBağlanti.bağlanti);
            DataTable dataTable = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter(sorgu);

            adapter.Fill(dataTable);

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dataTable;
            dataGrid.DataSource = bindingSource;
        }

        private void projeGoruntule_Click(object sender, EventArgs e)
        {
            ProjeOpen projeOpen = new ProjeOpen(id,projeAd,projeAciklamasi);
            projeOpen.Show();
            Close();
        }

        private void anaMenuDon_Click(object sender, EventArgs e)
        {
            AnaMenü anaMenü = new AnaMenü();
            anaMenü.Show();
            Close();

        }
    }
}
