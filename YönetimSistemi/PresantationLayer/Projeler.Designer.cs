
namespace YönetimSistemi.PresantationLayer
{
    partial class Projeler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Projeler));
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.projeGoruntule = new System.Windows.Forms.Button();
            this.anaMenuDon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(43, 27);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(968, 303);
            this.dataGrid.TabIndex = 0;
            this.dataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellClick);
            // 
            // projeGoruntule
            // 
            this.projeGoruntule.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.projeGoruntule.Location = new System.Drawing.Point(425, 349);
            this.projeGoruntule.Name = "projeGoruntule";
            this.projeGoruntule.Size = new System.Drawing.Size(213, 37);
            this.projeGoruntule.TabIndex = 2;
            this.projeGoruntule.Text = "Projeyi Görüntüle";
            this.projeGoruntule.UseVisualStyleBackColor = true;
            this.projeGoruntule.Click += new System.EventHandler(this.projeGoruntule_Click);
            // 
            // anaMenuDon
            // 
            this.anaMenuDon.Location = new System.Drawing.Point(939, 385);
            this.anaMenuDon.Name = "anaMenuDon";
            this.anaMenuDon.Size = new System.Drawing.Size(100, 23);
            this.anaMenuDon.TabIndex = 3;
            this.anaMenuDon.Text = "ana menüye dön";
            this.anaMenuDon.UseVisualStyleBackColor = true;
            this.anaMenuDon.Click += new System.EventHandler(this.anaMenuDon_Click);
            // 
            // Projeler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1051, 420);
            this.Controls.Add(this.anaMenuDon);
            this.Controls.Add(this.projeGoruntule);
            this.Controls.Add(this.dataGrid);
            this.Name = "Projeler";
            this.Text = "Projeler";
            this.Load += new System.EventHandler(this.Projeler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Button projeGoruntule;
        private System.Windows.Forms.Button anaMenuDon;
    }
}