namespace YönetimSistemi.PresantationLayer.kullanicilar
{
    partial class KullaniciEkle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullaniciEkle));
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.kullanici_Ekle = new System.Windows.Forms.Button();
            this.anamenüye_Dön = new System.Windows.Forms.Button();
            this.kullaniciAdi_txt = new System.Windows.Forms.TextBox();
            this.parola_txt = new System.Windows.Forms.TextBox();
            this.isimSoyisim_txt = new System.Windows.Forms.TextBox();
            this.email_txt = new System.Windows.Forms.TextBox();
            this.cinsiyet_txt = new System.Windows.Forms.TextBox();
            this.tel1_txt = new System.Windows.Forms.TextBox();
            this.tel2_txt = new System.Windows.Forms.TextBox();
            this.id_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(15, 226);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(1000, 305);
            this.dataGrid.TabIndex = 0;
            this.dataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(171, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(171, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "parola:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(172, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "İsim Soyisim:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(172, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(530, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Cinsiyet:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(530, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Tel no1:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(532, 145);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Tel no2:";
            // 
            // kullanici_Ekle
            // 
            this.kullanici_Ekle.Location = new System.Drawing.Point(883, 169);
            this.kullanici_Ekle.Name = "kullanici_Ekle";
            this.kullanici_Ekle.Size = new System.Drawing.Size(121, 23);
            this.kullanici_Ekle.TabIndex = 10;
            this.kullanici_Ekle.Text = "Ekle";
            this.kullanici_Ekle.UseVisualStyleBackColor = true;
            this.kullanici_Ekle.Click += new System.EventHandler(this.kullanici_Ekle_Click);
            // 
            // anamenüye_Dön
            // 
            this.anamenüye_Dön.Location = new System.Drawing.Point(883, 194);
            this.anamenüye_Dön.Name = "anamenüye_Dön";
            this.anamenüye_Dön.Size = new System.Drawing.Size(121, 23);
            this.anamenüye_Dön.TabIndex = 11;
            this.anamenüye_Dön.Text = "Ana menüye dön";
            this.anamenüye_Dön.UseVisualStyleBackColor = true;
            this.anamenüye_Dön.Click += new System.EventHandler(this.anamenüye_Dön_Click);
            // 
            // kullaniciAdi_txt
            // 
            this.kullaniciAdi_txt.Location = new System.Drawing.Point(241, 61);
            this.kullaniciAdi_txt.Name = "kullaniciAdi_txt";
            this.kullaniciAdi_txt.Size = new System.Drawing.Size(173, 20);
            this.kullaniciAdi_txt.TabIndex = 12;
            // 
            // parola_txt
            // 
            this.parola_txt.Location = new System.Drawing.Point(241, 95);
            this.parola_txt.Name = "parola_txt";
            this.parola_txt.Size = new System.Drawing.Size(173, 20);
            this.parola_txt.TabIndex = 13;
            // 
            // isimSoyisim_txt
            // 
            this.isimSoyisim_txt.Location = new System.Drawing.Point(241, 125);
            this.isimSoyisim_txt.Name = "isimSoyisim_txt";
            this.isimSoyisim_txt.Size = new System.Drawing.Size(173, 20);
            this.isimSoyisim_txt.TabIndex = 14;
            // 
            // email_txt
            // 
            this.email_txt.Location = new System.Drawing.Point(241, 156);
            this.email_txt.Name = "email_txt";
            this.email_txt.Size = new System.Drawing.Size(173, 20);
            this.email_txt.TabIndex = 15;
            // 
            // cinsiyet_txt
            // 
            this.cinsiyet_txt.Location = new System.Drawing.Point(618, 72);
            this.cinsiyet_txt.Name = "cinsiyet_txt";
            this.cinsiyet_txt.Size = new System.Drawing.Size(173, 20);
            this.cinsiyet_txt.TabIndex = 16;
            // 
            // tel1_txt
            // 
            this.tel1_txt.Location = new System.Drawing.Point(618, 108);
            this.tel1_txt.Name = "tel1_txt";
            this.tel1_txt.Size = new System.Drawing.Size(173, 20);
            this.tel1_txt.TabIndex = 19;
            // 
            // tel2_txt
            // 
            this.tel2_txt.Location = new System.Drawing.Point(618, 142);
            this.tel2_txt.Name = "tel2_txt";
            this.tel2_txt.Size = new System.Drawing.Size(173, 20);
            this.tel2_txt.TabIndex = 20;
            // 
            // id_txt
            // 
            this.id_txt.Location = new System.Drawing.Point(445, 24);
            this.id_txt.Name = "id_txt";
            this.id_txt.Size = new System.Drawing.Size(173, 20);
            this.id_txt.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(375, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Kullanıcı id:";
            // 
            // KullaniciEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1029, 562);
            this.Controls.Add(this.id_txt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tel2_txt);
            this.Controls.Add(this.tel1_txt);
            this.Controls.Add(this.cinsiyet_txt);
            this.Controls.Add(this.email_txt);
            this.Controls.Add(this.isimSoyisim_txt);
            this.Controls.Add(this.parola_txt);
            this.Controls.Add(this.kullaniciAdi_txt);
            this.Controls.Add(this.anamenüye_Dön);
            this.Controls.Add(this.kullanici_Ekle);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGrid);
            this.Name = "KullaniciEkle";
            this.ShowIcon = false;
            this.Text = "KullaniciEkle";
            this.Load += new System.EventHandler(this.KullaniciEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button kullanici_Ekle;
        private System.Windows.Forms.Button anamenüye_Dön;
        private System.Windows.Forms.TextBox kullaniciAdi_txt;
        private System.Windows.Forms.TextBox parola_txt;
        private System.Windows.Forms.TextBox isimSoyisim_txt;
        private System.Windows.Forms.TextBox email_txt;
        private System.Windows.Forms.TextBox cinsiyet_txt;
        private System.Windows.Forms.TextBox tel1_txt;
        private System.Windows.Forms.TextBox tel2_txt;
        private System.Windows.Forms.TextBox id_txt;
        private System.Windows.Forms.Label label5;
    }
}