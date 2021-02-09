using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YönetimSistemi.PresantationLayer
{
    public partial class ProjeOpen : Form
    {
        
        string id;
        string projeAd;
        string projeAciklamasi;

        public ProjeOpen()
        {
            InitializeComponent();

        }

        public ProjeOpen(string _id, string _projeAd, string _projeAciklamasi)
        {
            InitializeComponent();

            id = _id;
            projeAd = _projeAd;
            projeAciklamasi = _projeAciklamasi;
        }

        private void ProjeOpen_Load(object sender, EventArgs e)
        {
            ad_lbl.BackColor = Color.Transparent;
            id_lbl.BackColor = Color.Transparent;
            richTextBox1.Enabled = false;

            richTextBox1.Text = projeAciklamasi;

            ad_lbl.Text = projeAd;
            id_lbl.Text = id;

        }

        private void projeSayfaDon_Click(object sender, EventArgs e)
        {
            Projeler projeler = new Projeler();
            projeler.Show();
            Close();
        }
    }
}
