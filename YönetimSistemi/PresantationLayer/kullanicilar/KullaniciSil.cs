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
using YönetimSistemi.PresantationLayer;
using YönetimSistemi.PocosLayer;
using YönetimSistemi.BussinessLogicLayer;


namespace YönetimSistemi.PresantationLayer.kullanicilar
{
    public partial class KullaniciSil : Form
    {
        private TblKullanicilarBLL _tblKullanicilarBLL;
        public KullaniciSil()
        {
            InitializeComponent();
            _tblKullanicilarBLL = new TblKullanicilarBLL();
        }
        public void listele()
        {
            VtBağlanti vtBağlanti = new VtBağlanti();
            SqlCommand sorgu = new SqlCommand("select * from kullanıcılar", vtBağlanti.bağlanti);
            DataTable dataTable = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter(sorgu);

            adapter.Fill(dataTable);

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dataTable;
            dataGrid.DataSource = bindingSource;

        }
        private void kullanici_Sil_Click(object sender, EventArgs e)
        {
            TblKullanicilarPoco kullaniciSil = new TblKullanicilarPoco();
            kullaniciSil = _tblKullanicilarBLL.silKullanici(id_txt.Text);
            listele();
            MessageBox.Show("silindi");

        }

        private void KullaniciSil_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id_txt.Text = dataGrid.CurrentRow.Cells[0].Value.ToString();
            kullaniciAdi_txt.Text = dataGrid.CurrentRow.Cells[1].Value.ToString();
            parola_txt.Text = dataGrid.CurrentRow.Cells[2].Value.ToString();
            isimSoyisim_txt.Text = dataGrid.CurrentRow.Cells[3].Value.ToString();
            email_txt.Text = dataGrid.CurrentRow.Cells[4].Value.ToString();
            cinsiyet_txt.Text = dataGrid.CurrentRow.Cells[5].Value.ToString();
            tel1_txt.Text = dataGrid.CurrentRow.Cells[6].Value.ToString();
            tel2_txt.Text = dataGrid.CurrentRow.Cells[7].Value.ToString();

        }

        private void anamenüye_Dön_Click(object sender, EventArgs e)
        {
            AnaMenü anaMenü = new AnaMenü();
            anaMenü.Show();
            Close();

        }
    }
}
