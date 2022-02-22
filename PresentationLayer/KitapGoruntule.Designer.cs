
namespace PresentationLayer
{
    partial class KitapGoruntule
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
            this.label_id = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGrid_kitap = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.kapat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AltaAl)).BeginInit();
            this.panelMenuHorizontal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_kitap)).BeginInit();
            this.SuspendLayout();
            // 
            // kapat
            // 
            this.kapat.Image = global::PresentationLayer.Properties.Resources.icons8_close_50;
            this.kapat.Location = new System.Drawing.Point(1178, 14);
            this.kapat.Name = "kapat";
            this.kapat.Size = new System.Drawing.Size(51, 39);
            this.kapat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kapat.TabIndex = 30;
            this.kapat.TabStop = false;
            this.kapat.Click += new System.EventHandler(this.Kapat_Click);
            // 
            // AltaAl
            // 
            this.AltaAl.Image = global::PresentationLayer.Properties.Resources.icons8_minimize_window_50;
            this.AltaAl.Location = new System.Drawing.Point(1121, 14);
            this.AltaAl.Name = "AltaAl";
            this.AltaAl.Size = new System.Drawing.Size(51, 39);
            this.AltaAl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AltaAl.TabIndex = 29;
            this.AltaAl.TabStop = false;
            this.AltaAl.Click += new System.EventHandler(this.AltaAl_Click);
            // 
            // panelMenuHorizontal
            // 
            this.panelMenuHorizontal.Controls.Add(this.label_id);
            this.panelMenuHorizontal.Controls.Add(this.label1);
            this.panelMenuHorizontal.Controls.Add(this.kapat);
            this.panelMenuHorizontal.Controls.Add(this.AltaAl);
            this.panelMenuHorizontal.Location = new System.Drawing.Point(0, -1);
            this.panelMenuHorizontal.Name = "panelMenuHorizontal";
            this.panelMenuHorizontal.Size = new System.Drawing.Size(1257, 82);
            this.panelMenuHorizontal.TabIndex = 34;
            this.panelMenuHorizontal.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelMenuHorizontal_MouseDown);
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_id.ForeColor = System.Drawing.Color.Red;
            this.label_id.Location = new System.Drawing.Point(180, 21);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(42, 32);
            this.label_id.TabIndex = 34;
            this.label_id.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(3, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 46);
            this.label1.TabIndex = 33;
            this.label1.Text = "Kitap ID:";
            // 
            // dataGrid_kitap
            // 
            this.dataGrid_kitap.AllowUserToAddRows = false;
            this.dataGrid_kitap.AllowUserToDeleteRows = false;
            this.dataGrid_kitap.BackgroundColor = System.Drawing.Color.White;
            this.dataGrid_kitap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_kitap.Location = new System.Drawing.Point(0, 87);
            this.dataGrid_kitap.Name = "dataGrid_kitap";
            this.dataGrid_kitap.ReadOnly = true;
            this.dataGrid_kitap.RowHeadersVisible = false;
            this.dataGrid_kitap.RowHeadersWidth = 51;
            this.dataGrid_kitap.RowTemplate.Height = 24;
            this.dataGrid_kitap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid_kitap.Size = new System.Drawing.Size(1254, 268);
            this.dataGrid_kitap.TabIndex = 35;
            // 
            // KitapGoruntule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 359);
            this.ControlBox = false;
            this.Controls.Add(this.dataGrid_kitap);
            this.Controls.Add(this.panelMenuHorizontal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KitapGoruntule";
            this.Text = "KitapGoruntule";
            this.Load += new System.EventHandler(this.KitapGoruntule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kapat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AltaAl)).EndInit();
            this.panelMenuHorizontal.ResumeLayout(false);
            this.panelMenuHorizontal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_kitap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox kapat;
        private System.Windows.Forms.PictureBox AltaAl;
        private System.Windows.Forms.Panel panelMenuHorizontal;
        private System.Windows.Forms.DataGridView dataGrid_kitap;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label_id;
    }
}