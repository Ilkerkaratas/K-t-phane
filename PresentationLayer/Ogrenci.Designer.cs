
namespace PresentationLayer
{
    partial class Ogrenci
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
            this.kapat = new System.Windows.Forms.PictureBox();
            this.AltaAl = new System.Windows.Forms.PictureBox();
            this.panelMenuHorizontal = new System.Windows.Forms.Panel();
            this.panel_container = new System.Windows.Forms.Panel();
            this.dataGrid_Kitaplar = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label_id = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kapat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AltaAl)).BeginInit();
            this.panelMenuHorizontal.SuspendLayout();
            this.panel_container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Kitaplar)).BeginInit();
            this.SuspendLayout();
            // 
            // kapat
            // 
            this.kapat.Image = global::PresentationLayer.Properties.Resources.icons8_close_50;
            this.kapat.Location = new System.Drawing.Point(1223, 3);
            this.kapat.Name = "kapat";
            this.kapat.Size = new System.Drawing.Size(51, 46);
            this.kapat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kapat.TabIndex = 36;
            this.kapat.TabStop = false;
            this.kapat.Click += new System.EventHandler(this.icon_delete_Click);
            // 
            // AltaAl
            // 
            this.AltaAl.Image = global::PresentationLayer.Properties.Resources.icons8_minimize_window_50;
            this.AltaAl.Location = new System.Drawing.Point(1166, 3);
            this.AltaAl.Name = "AltaAl";
            this.AltaAl.Size = new System.Drawing.Size(51, 46);
            this.AltaAl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AltaAl.TabIndex = 35;
            this.AltaAl.TabStop = false;
            this.AltaAl.Click += new System.EventHandler(this.icon_minimize_Click);
            // 
            // panelMenuHorizontal
            // 
            this.panelMenuHorizontal.Controls.Add(this.label_id);
            this.panelMenuHorizontal.Controls.Add(this.label1);
            this.panelMenuHorizontal.Controls.Add(this.kapat);
            this.panelMenuHorizontal.Controls.Add(this.AltaAl);
            this.panelMenuHorizontal.Location = new System.Drawing.Point(0, -3);
            this.panelMenuHorizontal.Name = "panelMenuHorizontal";
            this.panelMenuHorizontal.Size = new System.Drawing.Size(1280, 52);
            this.panelMenuHorizontal.TabIndex = 37;
            this.panelMenuHorizontal.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelMenuHorizontal_MouseDown);
            // 
            // panel_container
            // 
            this.panel_container.Controls.Add(this.dataGrid_Kitaplar);
            this.panel_container.Location = new System.Drawing.Point(0, 52);
            this.panel_container.Name = "panel_container";
            this.panel_container.Size = new System.Drawing.Size(1285, 397);
            this.panel_container.TabIndex = 39;
            // 
            // dataGrid_Kitaplar
            // 
            this.dataGrid_Kitaplar.AllowUserToAddRows = false;
            this.dataGrid_Kitaplar.AllowUserToDeleteRows = false;
            this.dataGrid_Kitaplar.BackgroundColor = System.Drawing.Color.Red;
            this.dataGrid_Kitaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Kitaplar.Location = new System.Drawing.Point(0, 3);
            this.dataGrid_Kitaplar.Name = "dataGrid_Kitaplar";
            this.dataGrid_Kitaplar.ReadOnly = true;
            this.dataGrid_Kitaplar.RowHeadersVisible = false;
            this.dataGrid_Kitaplar.RowHeadersWidth = 51;
            this.dataGrid_Kitaplar.RowTemplate.Height = 24;
            this.dataGrid_Kitaplar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid_Kitaplar.Size = new System.Drawing.Size(1280, 391);
            this.dataGrid_Kitaplar.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 46);
            this.label1.TabIndex = 37;
            this.label1.Text = "Öğrenci ID:";
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_id.ForeColor = System.Drawing.Color.Red;
            this.label_id.Location = new System.Drawing.Point(230, 12);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(42, 32);
            this.label_id.TabIndex = 38;
            this.label_id.Text = "ID";
            // 
            // Ogrenci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 450);
            this.ControlBox = false;
            this.Controls.Add(this.panel_container);
            this.Controls.Add(this.panelMenuHorizontal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ogrenci";
            this.Text = "Ogrenci";
            this.Load += new System.EventHandler(this.Ogrenciler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kapat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AltaAl)).EndInit();
            this.panelMenuHorizontal.ResumeLayout(false);
            this.panelMenuHorizontal.PerformLayout();
            this.panel_container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Kitaplar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMenuHorizontal;
        private System.Windows.Forms.PictureBox kapat;
        private System.Windows.Forms.PictureBox AltaAl;
        private System.Windows.Forms.Panel panel_container;
        private System.Windows.Forms.DataGridView dataGrid_Kitaplar;
        public System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label1;
    }
}