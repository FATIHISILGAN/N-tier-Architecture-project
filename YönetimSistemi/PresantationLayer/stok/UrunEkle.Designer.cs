﻿
namespace YönetimSistemi.PresantationLayer.stok
{
    partial class UrunEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UrunEkle));
            this.anamenüye_Dön = new System.Windows.Forms.Button();
            this.Urun_Ekle = new System.Windows.Forms.Button();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.urunİD_txt = new System.Windows.Forms.TextBox();
            this.ürünAdi_txt = new System.Windows.Forms.TextBox();
            this.ürünAdet_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // anamenüye_Dön
            // 
            this.anamenüye_Dön.Location = new System.Drawing.Point(793, 167);
            this.anamenüye_Dön.Name = "anamenüye_Dön";
            this.anamenüye_Dön.Size = new System.Drawing.Size(121, 23);
            this.anamenüye_Dön.TabIndex = 32;
            this.anamenüye_Dön.Text = "Ana menüye dön";
            this.anamenüye_Dön.UseVisualStyleBackColor = true;
            this.anamenüye_Dön.Click += new System.EventHandler(this.anamenüye_Dön_Click);
            // 
            // Urun_Ekle
            // 
            this.Urun_Ekle.Location = new System.Drawing.Point(793, 142);
            this.Urun_Ekle.Name = "Urun_Ekle";
            this.Urun_Ekle.Size = new System.Drawing.Size(121, 23);
            this.Urun_Ekle.TabIndex = 31;
            this.Urun_Ekle.Text = "Ekle";
            this.Urun_Ekle.UseVisualStyleBackColor = true;
            this.Urun_Ekle.Click += new System.EventHandler(this.Urun_Ekle_Click);
            // 
            // dataGrid
            // 
            this.dataGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(23, 206);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(938, 278);
            this.dataGrid.TabIndex = 23;
            this.dataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellContentClick);
            // 
            // urunİD_txt
            // 
            this.urunİD_txt.Location = new System.Drawing.Point(397, 66);
            this.urunİD_txt.Name = "urunİD_txt";
            this.urunİD_txt.Size = new System.Drawing.Size(204, 20);
            this.urunİD_txt.TabIndex = 33;
            // 
            // ürünAdi_txt
            // 
            this.ürünAdi_txt.Location = new System.Drawing.Point(397, 92);
            this.ürünAdi_txt.Name = "ürünAdi_txt";
            this.ürünAdi_txt.Size = new System.Drawing.Size(204, 20);
            this.ürünAdi_txt.TabIndex = 34;
            // 
            // ürünAdet_txt
            // 
            this.ürünAdet_txt.Location = new System.Drawing.Point(397, 117);
            this.ürünAdet_txt.Name = "ürünAdet_txt";
            this.ürünAdet_txt.Size = new System.Drawing.Size(204, 20);
            this.ürünAdet_txt.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(368, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(348, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "ürünAdı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(344, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "ürünAdet:";
            // 
            // UrunEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 496);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ürünAdet_txt);
            this.Controls.Add(this.ürünAdi_txt);
            this.Controls.Add(this.urunİD_txt);
            this.Controls.Add(this.anamenüye_Dön);
            this.Controls.Add(this.Urun_Ekle);
            this.Controls.Add(this.dataGrid);
            this.Name = "UrunEkle";
            this.Text = "UrunEkle";
            this.Load += new System.EventHandler(this.UrunEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button anamenüye_Dön;
        private System.Windows.Forms.Button Urun_Ekle;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.TextBox urunİD_txt;
        private System.Windows.Forms.TextBox ürünAdi_txt;
        private System.Windows.Forms.TextBox ürünAdet_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}