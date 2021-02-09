
namespace YönetimSistemi.PresantationLayer.stok
{
    partial class UrunListele
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UrunListele));
            this.ürünAdet_Check = new System.Windows.Forms.CheckBox();
            this.ürünAdi_Check = new System.Windows.Forms.CheckBox();
            this.id_Check = new System.Windows.Forms.CheckBox();
            this.secileniListeleradio = new System.Windows.Forms.RadioButton();
            this.hepsiniListeleRadio = new System.Windows.Forms.RadioButton();
            this.anamenüye_Dön = new System.Windows.Forms.Button();
            this.ürün_Listele = new System.Windows.Forms.Button();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ürünAdet_Check
            // 
            this.ürünAdet_Check.AutoSize = true;
            this.ürünAdet_Check.Location = new System.Drawing.Point(127, 137);
            this.ürünAdet_Check.Name = "ürünAdet_Check";
            this.ürünAdet_Check.Size = new System.Drawing.Size(69, 17);
            this.ürünAdet_Check.TabIndex = 48;
            this.ürünAdet_Check.Text = "ürünAdet";
            this.ürünAdet_Check.UseVisualStyleBackColor = true;
            // 
            // ürünAdi_Check
            // 
            this.ürünAdi_Check.AutoSize = true;
            this.ürünAdi_Check.Location = new System.Drawing.Point(128, 116);
            this.ürünAdi_Check.Name = "ürünAdi_Check";
            this.ürünAdi_Check.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ürünAdi_Check.Size = new System.Drawing.Size(62, 17);
            this.ürünAdi_Check.TabIndex = 49;
            this.ürünAdi_Check.Text = "ürünAdı";
            this.ürünAdi_Check.UseVisualStyleBackColor = true;
            // 
            // id_Check
            // 
            this.id_Check.AutoSize = true;
            this.id_Check.Location = new System.Drawing.Point(127, 96);
            this.id_Check.Name = "id_Check";
            this.id_Check.Size = new System.Drawing.Size(34, 17);
            this.id_Check.TabIndex = 47;
            this.id_Check.Text = "id";
            this.id_Check.UseVisualStyleBackColor = true;
            // 
            // secileniListeleradio
            // 
            this.secileniListeleradio.AutoSize = true;
            this.secileniListeleradio.Location = new System.Drawing.Point(87, 63);
            this.secileniListeleradio.Name = "secileniListeleradio";
            this.secileniListeleradio.Size = new System.Drawing.Size(102, 17);
            this.secileniListeleradio.TabIndex = 46;
            this.secileniListeleradio.TabStop = true;
            this.secileniListeleradio.Text = "Seçilenleri listele";
            this.secileniListeleradio.UseVisualStyleBackColor = true;
            this.secileniListeleradio.CheckedChanged += new System.EventHandler(this.secileniListeleradio_CheckedChanged);
            // 
            // hepsiniListeleRadio
            // 
            this.hepsiniListeleRadio.AutoSize = true;
            this.hepsiniListeleRadio.Location = new System.Drawing.Point(87, 31);
            this.hepsiniListeleRadio.Name = "hepsiniListeleRadio";
            this.hepsiniListeleRadio.Size = new System.Drawing.Size(89, 17);
            this.hepsiniListeleRadio.TabIndex = 45;
            this.hepsiniListeleRadio.TabStop = true;
            this.hepsiniListeleRadio.Text = "Hepsini listele";
            this.hepsiniListeleRadio.UseVisualStyleBackColor = true;
            this.hepsiniListeleRadio.CheckedChanged += new System.EventHandler(this.hepsiniListeleRadio_CheckedChanged);
            // 
            // anamenüye_Dön
            // 
            this.anamenüye_Dön.Location = new System.Drawing.Point(883, 161);
            this.anamenüye_Dön.Name = "anamenüye_Dön";
            this.anamenüye_Dön.Size = new System.Drawing.Size(121, 23);
            this.anamenüye_Dön.TabIndex = 44;
            this.anamenüye_Dön.Text = "Ana menüye dön";
            this.anamenüye_Dön.UseVisualStyleBackColor = true;
            this.anamenüye_Dön.Click += new System.EventHandler(this.anamenüye_Dön_Click);
            // 
            // ürün_Listele
            // 
            this.ürün_Listele.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ürün_Listele.BackgroundImage")));
            this.ürün_Listele.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ürün_Listele.Location = new System.Drawing.Point(903, 105);
            this.ürün_Listele.Name = "ürün_Listele";
            this.ürün_Listele.Size = new System.Drawing.Size(61, 39);
            this.ürün_Listele.TabIndex = 43;
            this.ürün_Listele.UseVisualStyleBackColor = true;
            this.ürün_Listele.Click += new System.EventHandler(this.ürün_Listele_Click);
            // 
            // dataGrid
            // 
            this.dataGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(15, 193);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(1000, 305);
            this.dataGrid.TabIndex = 42;
            // 
            // UrunListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1041, 545);
            this.Controls.Add(this.ürünAdet_Check);
            this.Controls.Add(this.ürünAdi_Check);
            this.Controls.Add(this.id_Check);
            this.Controls.Add(this.secileniListeleradio);
            this.Controls.Add(this.hepsiniListeleRadio);
            this.Controls.Add(this.anamenüye_Dön);
            this.Controls.Add(this.ürün_Listele);
            this.Controls.Add(this.dataGrid);
            this.Name = "UrunListele";
            this.Text = "UrunListele";
            this.Load += new System.EventHandler(this.UrunListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox ürünAdet_Check;
        private System.Windows.Forms.CheckBox ürünAdi_Check;
        private System.Windows.Forms.CheckBox id_Check;
        private System.Windows.Forms.RadioButton secileniListeleradio;
        private System.Windows.Forms.RadioButton hepsiniListeleRadio;
        private System.Windows.Forms.Button anamenüye_Dön;
        private System.Windows.Forms.Button ürün_Listele;
        private System.Windows.Forms.DataGridView dataGrid;
    }
}