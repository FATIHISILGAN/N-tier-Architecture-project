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



namespace YönetimSistemi.PresantationLayer.kullanicilar
{
    public partial class KullaniciEkle : Form
    {

        private TblKullanicilarBLL _tblKullanicilarBLL;
     

        public KullaniciEkle()
        {
            InitializeComponent();
            _tblKullanicilarBLL = new TblKullanicilarBLL();
        }
        public void listele()
        {
            VtBağlanti vtBağlanti = new VtBağlanti();
            SqlCommand sorgu = new SqlCommand("select * from kullanıcılar",vtBağlanti.bağlanti);
            DataTable dataTable = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter(sorgu);

            adapter.Fill(dataTable);

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dataTable;
            dataGrid.DataSource = bindingSource;
            


        }
        private void kullanici_Ekle_Click(object sender, EventArgs e)
        {
            try
            {
                TblKullanicilarPoco tblKullanicilarPoco = new TblKullanicilarPoco();
                tblKullanicilarPoco = _tblKullanicilarBLL.kullaniciKaydet(Convert.ToInt32(id_txt.Text), kullaniciAdi_txt.Text, parola_txt.Text, isimSoyisim_txt.Text, email_txt.Text, cinsiyet_txt.Text, tel1_txt.Text, tel2_txt.Text);

                MessageBox.Show("eklendi");
                listele();
            }
            catch 
            {

                MessageBox.Show("eklenmedi");
            }
        }

        private void anamenüye_Dön_Click(object sender, EventArgs e)
        {
            AnaMenü anaMenü = new AnaMenü();
        
            anaMenü.Show();
            Hide();
        }

        private void KullaniciEkle_Load(object sender, EventArgs e)
        {
            Console.WriteLine("kullanıcı ekle sayfası yüklendi");
            listele();
            Console.WriteLine("kullancıı ekle sayfasında İlk listeleme işlemi gerçekleşti");
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
    }
}
