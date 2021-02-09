namespace YönetimSistemi
{
    partial class OturumAcmaEkrani
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OturumAcmaEkrani));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.girisYap_btn = new System.Windows.Forms.Button();
            this.kullaniciAdi_Txt = new System.Windows.Forms.TextBox();
            this.sifre_Txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(21, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(209, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(241, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(476, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Yönetim sistemine hoşgeldiniz";
            // 
            // girisYap_btn
            // 
            this.girisYap_btn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.girisYap_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.girisYap_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.girisYap_btn.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.girisYap_btn.Location = new System.Drawing.Point(386, 226);
            this.girisYap_btn.Name = "girisYap_btn";
            this.girisYap_btn.Size = new System.Drawing.Size(141, 39);
            this.girisYap_btn.TabIndex = 2;
            this.girisYap_btn.Text = "Giriş yap";
            this.girisYap_btn.UseVisualStyleBackColor = false;
            this.girisYap_btn.Click += new System.EventHandler(this.girisYap_btn_Click);
            // 
            // kullaniciAdi_Txt
            // 
            this.kullaniciAdi_Txt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.kullaniciAdi_Txt.Location = new System.Drawing.Point(359, 158);
            this.kullaniciAdi_Txt.Name = "kullaniciAdi_Txt";
            this.kullaniciAdi_Txt.Size = new System.Drawing.Size(192, 20);
            this.kullaniciAdi_Txt.TabIndex = 3;
            // 
            // sifre_Txt
            // 
            this.sifre_Txt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.sifre_Txt.Location = new System.Drawing.Point(359, 184);
            this.sifre_Txt.Name = "sifre_Txt";
            this.sifre_Txt.Size = new System.Drawing.Size(192, 20);
            this.sifre_Txt.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(258, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kullanıcı adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(266, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Parola:";
            // 
            // OturumAcmaEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(729, 352);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sifre_Txt);
            this.Controls.Add(this.kullaniciAdi_Txt);
            this.Controls.Add(this.girisYap_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "OturumAcmaEkrani";
            this.ShowIcon = false;
            this.Text = "OturumAç";
            this.Load += new System.EventHandler(this.OturumAcmaEkrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button girisYap_btn;
        private System.Windows.Forms.TextBox kullaniciAdi_Txt;
        private System.Windows.Forms.TextBox sifre_Txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

