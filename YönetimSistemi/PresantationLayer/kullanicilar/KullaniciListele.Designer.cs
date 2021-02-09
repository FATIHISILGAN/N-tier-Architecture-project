namespace YönetimSistemi.PresantationLayer.kullanicilar
{
    partial class KullaniciListele
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullaniciListele));
            this.anamenüye_Dön = new System.Windows.Forms.Button();
            this.kullanici_Listele = new System.Windows.Forms.Button();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.hepsiniListeleRadio = new System.Windows.Forms.RadioButton();
            this.secileniListeleradio = new System.Windows.Forms.RadioButton();
            this.id_Check = new System.Windows.Forms.CheckBox();
            this.kullaniciAdi_Check = new System.Windows.Forms.CheckBox();
            this.parola_Check = new System.Windows.Forms.CheckBox();
            this.adSoyad_Check = new System.Windows.Forms.CheckBox();
            this.tel2_Check = new System.Windows.Forms.CheckBox();
            this.cinsiyet_Check = new System.Windows.Forms.CheckBox();
            this.tel1_Check = new System.Windows.Forms.CheckBox();
            this.email_Check = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // anamenüye_Dön
            // 
            this.anamenüye_Dön.Location = new System.Drawing.Point(881, 163);
            this.anamenüye_Dön.Name = "anamenüye_Dön";
            this.anamenüye_Dön.Size = new System.Drawing.Size(121, 23);
            this.anamenüye_Dön.TabIndex = 32;
            this.anamenüye_Dön.Text = "Ana menüye dön";
            this.anamenüye_Dön.UseVisualStyleBackColor = true;
            this.anamenüye_Dön.Click += new System.EventHandler(this.anamenüye_Dön_Click);
            // 
            // kullanici_Listele
            // 
            this.kullanici_Listele.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("kullanici_Listele.BackgroundImage")));
            this.kullanici_Listele.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.kullanici_Listele.Location = new System.Drawing.Point(901, 107);
            this.kullanici_Listele.Name = "kullanici_Listele";
            this.kullanici_Listele.Size = new System.Drawing.Size(61, 39);
            this.kullanici_Listele.TabIndex = 31;
            this.kullanici_Listele.UseVisualStyleBackColor = true;
            this.kullanici_Listele.Click += new System.EventHandler(this.kullanici_Listele_Click);
            // 
            // dataGrid
            // 
            this.dataGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(13, 195);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(1000, 305);
            this.dataGrid.TabIndex = 23;
            // 
            // hepsiniListeleRadio
            // 
            this.hepsiniListeleRadio.AutoSize = true;
            this.hepsiniListeleRadio.Location = new System.Drawing.Point(85, 33);
            this.hepsiniListeleRadio.Name = "hepsiniListeleRadio";
            this.hepsiniListeleRadio.Size = new System.Drawing.Size(89, 17);
            this.hepsiniListeleRadio.TabIndex = 33;
            this.hepsiniListeleRadio.TabStop = true;
            this.hepsiniListeleRadio.Text = "Hepsini listele";
            this.hepsiniListeleRadio.UseVisualStyleBackColor = true;
            this.hepsiniListeleRadio.CheckedChanged += new System.EventHandler(this.hepsiniListeleRadio_CheckedChanged);
            // 
            // secileniListeleradio
            // 
            this.secileniListeleradio.AutoSize = true;
            this.secileniListeleradio.Location = new System.Drawing.Point(85, 65);
            this.secileniListeleradio.Name = "secileniListeleradio";
            this.secileniListeleradio.Size = new System.Drawing.Size(102, 17);
            this.secileniListeleradio.TabIndex = 34;
            this.secileniListeleradio.TabStop = true;
            this.secileniListeleradio.Text = "Seçilenleri listele";
            this.secileniListeleradio.UseVisualStyleBackColor = true;
            this.secileniListeleradio.CheckedChanged += new System.EventHandler(this.secileniListeleradio_CheckedChanged);
            // 
            // id_Check
            // 
            this.id_Check.AutoSize = true;
            this.id_Check.Location = new System.Drawing.Point(125, 98);
            this.id_Check.Name = "id_Check";
            this.id_Check.Size = new System.Drawing.Size(34, 17);
            this.id_Check.TabIndex = 35;
            this.id_Check.Text = "id";
            this.id_Check.UseVisualStyleBackColor = true;
            // 
            // kullaniciAdi_Check
            // 
            this.kullaniciAdi_Check.AutoSize = true;
            this.kullaniciAdi_Check.Location = new System.Drawing.Point(126, 118);
            this.kullaniciAdi_Check.Name = "kullaniciAdi_Check";
            this.kullaniciAdi_Check.Size = new System.Drawing.Size(79, 17);
            this.kullaniciAdi_Check.TabIndex = 36;
            this.kullaniciAdi_Check.Text = "kullanıcıAdı";
            this.kullaniciAdi_Check.UseVisualStyleBackColor = true;
            // 
            // parola_Check
            // 
            this.parola_Check.AutoSize = true;
            this.parola_Check.Location = new System.Drawing.Point(125, 139);
            this.parola_Check.Name = "parola_Check";
            this.parola_Check.Size = new System.Drawing.Size(55, 17);
            this.parola_Check.TabIndex = 36;
            this.parola_Check.Text = "parola";
            this.parola_Check.UseVisualStyleBackColor = true;
            // 
            // adSoyad_Check
            // 
            this.adSoyad_Check.AutoSize = true;
            this.adSoyad_Check.Location = new System.Drawing.Point(125, 161);
            this.adSoyad_Check.Name = "adSoyad_Check";
            this.adSoyad_Check.Size = new System.Drawing.Size(68, 17);
            this.adSoyad_Check.TabIndex = 37;
            this.adSoyad_Check.Text = "adSoyad";
            this.adSoyad_Check.UseVisualStyleBackColor = true;
            // 
            // tel2_Check
            // 
            this.tel2_Check.AutoSize = true;
            this.tel2_Check.Location = new System.Drawing.Point(224, 161);
            this.tel2_Check.Name = "tel2_Check";
            this.tel2_Check.Size = new System.Drawing.Size(43, 17);
            this.tel2_Check.TabIndex = 41;
            this.tel2_Check.Text = "tel2";
            this.tel2_Check.UseVisualStyleBackColor = true;
            // 
            // cinsiyet_Check
            // 
            this.cinsiyet_Check.AutoSize = true;
            this.cinsiyet_Check.Location = new System.Drawing.Point(224, 119);
            this.cinsiyet_Check.Name = "cinsiyet_Check";
            this.cinsiyet_Check.Size = new System.Drawing.Size(61, 17);
            this.cinsiyet_Check.TabIndex = 39;
            this.cinsiyet_Check.Text = "cinsiyet";
            this.cinsiyet_Check.UseVisualStyleBackColor = true;
            // 
            // tel1_Check
            // 
            this.tel1_Check.AutoSize = true;
            this.tel1_Check.Location = new System.Drawing.Point(224, 140);
            this.tel1_Check.Name = "tel1_Check";
            this.tel1_Check.Size = new System.Drawing.Size(43, 17);
            this.tel1_Check.TabIndex = 40;
            this.tel1_Check.Text = "tel1";
            this.tel1_Check.UseVisualStyleBackColor = true;
            // 
            // email_Check
            // 
            this.email_Check.AutoSize = true;
            this.email_Check.Location = new System.Drawing.Point(224, 98);
            this.email_Check.Name = "email_Check";
            this.email_Check.Size = new System.Drawing.Size(50, 17);
            this.email_Check.TabIndex = 38;
            this.email_Check.Text = "email";
            this.email_Check.UseVisualStyleBackColor = true;
            // 
            // KullaniciListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1026, 506);
            this.Controls.Add(this.tel2_Check);
            this.Controls.Add(this.cinsiyet_Check);
            this.Controls.Add(this.tel1_Check);
            this.Controls.Add(this.email_Check);
            this.Controls.Add(this.adSoyad_Check);
            this.Controls.Add(this.parola_Check);
            this.Controls.Add(this.kullaniciAdi_Check);
            this.Controls.Add(this.id_Check);
            this.Controls.Add(this.secileniListeleradio);
            this.Controls.Add(this.hepsiniListeleRadio);
            this.Controls.Add(this.anamenüye_Dön);
            this.Controls.Add(this.kullanici_Listele);
            this.Controls.Add(this.dataGrid);
            this.Name = "KullaniciListele";
            this.Text = "KullaniciListele";
            this.Load += new System.EventHandler(this.KullaniciListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button anamenüye_Dön;
        private System.Windows.Forms.Button kullanici_Listele;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.RadioButton hepsiniListeleRadio;
        private System.Windows.Forms.RadioButton secileniListeleradio;
        private System.Windows.Forms.CheckBox id_Check;
        private System.Windows.Forms.CheckBox kullaniciAdi_Check;
        private System.Windows.Forms.CheckBox parola_Check;
        private System.Windows.Forms.CheckBox adSoyad_Check;
        private System.Windows.Forms.CheckBox tel2_Check;
        private System.Windows.Forms.CheckBox cinsiyet_Check;
        private System.Windows.Forms.CheckBox tel1_Check;
        private System.Windows.Forms.CheckBox email_Check;
    }
}