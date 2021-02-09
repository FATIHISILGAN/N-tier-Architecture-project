
namespace YönetimSistemi.PresantationLayer
{
    partial class ProjeOpen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjeOpen));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.id_lbl = new System.Windows.Forms.Label();
            this.ad_lbl = new System.Windows.Forms.Label();
            this.projeSayfaDon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(85, 33);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(408, 218);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // id_lbl
            // 
            this.id_lbl.AutoSize = true;
            this.id_lbl.Location = new System.Drawing.Point(130, 279);
            this.id_lbl.Name = "id_lbl";
            this.id_lbl.Size = new System.Drawing.Size(42, 13);
            this.id_lbl.TabIndex = 1;
            this.id_lbl.Text = "noData";
            // 
            // ad_lbl
            // 
            this.ad_lbl.AutoSize = true;
            this.ad_lbl.Location = new System.Drawing.Point(390, 279);
            this.ad_lbl.Name = "ad_lbl";
            this.ad_lbl.Size = new System.Drawing.Size(42, 13);
            this.ad_lbl.TabIndex = 2;
            this.ad_lbl.Text = "noData";
            // 
            // projeSayfaDon
            // 
            this.projeSayfaDon.Location = new System.Drawing.Point(488, 331);
            this.projeSayfaDon.Name = "projeSayfaDon";
            this.projeSayfaDon.Size = new System.Drawing.Size(75, 23);
            this.projeSayfaDon.TabIndex = 3;
            this.projeSayfaDon.Text = "dön";
            this.projeSayfaDon.UseVisualStyleBackColor = true;
            this.projeSayfaDon.Click += new System.EventHandler(this.projeSayfaDon_Click);
            // 
            // ProjeOpen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(578, 366);
            this.Controls.Add(this.projeSayfaDon);
            this.Controls.Add(this.ad_lbl);
            this.Controls.Add(this.id_lbl);
            this.Controls.Add(this.richTextBox1);
            this.Name = "ProjeOpen";
            this.Text = "ProjeOpen";
            this.Load += new System.EventHandler(this.ProjeOpen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label id_lbl;
        private System.Windows.Forms.Label ad_lbl;
        private System.Windows.Forms.Button projeSayfaDon;
    }
}