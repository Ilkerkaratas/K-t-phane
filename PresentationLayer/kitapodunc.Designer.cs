
namespace PresentationLayer
{
    partial class kitapodunc
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
            this.groupBox_arama = new System.Windows.Forms.GroupBox();
            this.btn_ogrenciAra = new System.Windows.Forms.Button();
            this.txt_aranacakOgrenci = new System.Windows.Forms.TextBox();
            this.panelMenuHorizontal = new System.Windows.Forms.Panel();
            this.label_id = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AltaAl = new System.Windows.Forms.PictureBox();
            this.Kapat = new System.Windows.Forms.PictureBox();
            this.dataGrid_odunc = new System.Windows.Forms.DataGridView();
            this.label_bilgilendirme = new System.Windows.Forms.Label();
            this.btn_oduncVer = new System.Windows.Forms.Button();
            this.btn_iadeAl = new System.Windows.Forms.Button();
            this.btn_ogrenciler = new System.Windows.Forms.Button();
            this.btn_alanOgrenciler = new System.Windows.Forms.Button();
            this.groupBox_arama.SuspendLayout();
            this.panelMenuHorizontal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AltaAl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kapat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_odunc)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_arama
            // 
            this.groupBox_arama.Controls.Add(this.btn_ogrenciAra);
            this.groupBox_arama.Controls.Add(this.txt_aranacakOgrenci);
            this.groupBox_arama.Location = new System.Drawing.Point(800, 44);
            this.groupBox_arama.Name = "groupBox_arama";
            this.groupBox_arama.Size = new System.Drawing.Size(462, 93);
            this.groupBox_arama.TabIndex = 7;
            this.groupBox_arama.TabStop = false;
            // 
            // btn_ogrenciAra
            // 
            this.btn_ogrenciAra.BackColor = System.Drawing.Color.Red;
            this.btn_ogrenciAra.ForeColor = System.Drawing.Color.White;
            this.btn_ogrenciAra.Location = new System.Drawing.Point(298, 23);
            this.btn_ogrenciAra.Name = "btn_ogrenciAra";
            this.btn_ogrenciAra.Size = new System.Drawing.Size(155, 34);
            this.btn_ogrenciAra.TabIndex = 6;
            this.btn_ogrenciAra.Text = "Öğrenci Ara";
            this.btn_ogrenciAra.UseVisualStyleBackColor = false;
            this.btn_ogrenciAra.Click += new System.EventHandler(this.btn_ogrenciAra_Click);
            // 
            // txt_aranacakOgrenci
            // 
            this.txt_aranacakOgrenci.BackColor = System.Drawing.Color.Red;
            this.txt_aranacakOgrenci.ForeColor = System.Drawing.Color.White;
            this.txt_aranacakOgrenci.Location = new System.Drawing.Point(96, 23);
            this.txt_aranacakOgrenci.Multiline = true;
            this.txt_aranacakOgrenci.Name = "txt_aranacakOgrenci";
            this.txt_aranacakOgrenci.Size = new System.Drawing.Size(173, 35);
            this.txt_aranacakOgrenci.TabIndex = 5;
            this.txt_aranacakOgrenci.Enter += new System.EventHandler(this.txt_aranacakOgrenci_Enter);
            this.txt_aranacakOgrenci.Leave += new System.EventHandler(this.txt_aranacakOgrenci_Leave);
            // 
            // panelMenuHorizontal
            // 
            this.panelMenuHorizontal.Controls.Add(this.label_id);
            this.panelMenuHorizontal.Controls.Add(this.label1);
            this.panelMenuHorizontal.Controls.Add(this.AltaAl);
            this.panelMenuHorizontal.Controls.Add(this.Kapat);
            this.panelMenuHorizontal.Location = new System.Drawing.Point(2, -1);
            this.panelMenuHorizontal.Name = "panelMenuHorizontal";
            this.panelMenuHorizontal.Size = new System.Drawing.Size(1268, 60);
            this.panelMenuHorizontal.TabIndex = 34;
            this.panelMenuHorizontal.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelMenuHorizontal_MouseDown);
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_id.ForeColor = System.Drawing.Color.Red;
            this.label_id.Location = new System.Drawing.Point(553, 12);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(42, 32);
            this.label_id.TabIndex = 32;
            this.label_id.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(544, 46);
            this.label1.TabIndex = 31;
            this.label1.Text = "Ödünç işlemi yapılan kitap ID:";
            // 
            // AltaAl
            // 
            this.AltaAl.Image = global::PresentationLayer.Properties.Resources.icons8_minimize_window_50;
            this.AltaAl.Location = new System.Drawing.Point(1144, 5);
            this.AltaAl.Name = "AltaAl";
            this.AltaAl.Size = new System.Drawing.Size(51, 39);
            this.AltaAl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AltaAl.TabIndex = 27;
            this.AltaAl.TabStop = false;
            this.AltaAl.Click += new System.EventHandler(this.AltaAl_Click);
            // 
            // Kapat
            // 
            this.Kapat.Image = global::PresentationLayer.Properties.Resources.icons8_close_50;
            this.Kapat.Location = new System.Drawing.Point(1201, 5);
            this.Kapat.Name = "Kapat";
            this.Kapat.Size = new System.Drawing.Size(51, 39);
            this.Kapat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Kapat.TabIndex = 28;
            this.Kapat.TabStop = false;
            this.Kapat.Click += new System.EventHandler(this.kapat_Click);
            // 
            // dataGrid_odunc
            // 
            this.dataGrid_odunc.AllowUserToAddRows = false;
            this.dataGrid_odunc.AllowUserToDeleteRows = false;
            this.dataGrid_odunc.BackgroundColor = System.Drawing.Color.Red;
            this.dataGrid_odunc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_odunc.Location = new System.Drawing.Point(2, 160);
            this.dataGrid_odunc.Name = "dataGrid_odunc";
            this.dataGrid_odunc.ReadOnly = true;
            this.dataGrid_odunc.RowHeadersVisible = false;
            this.dataGrid_odunc.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGrid_odunc.RowTemplate.Height = 24;
            this.dataGrid_odunc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid_odunc.Size = new System.Drawing.Size(1268, 339);
            this.dataGrid_odunc.TabIndex = 35;
            this.dataGrid_odunc.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_odunc_CellDoubleClick);
            this.dataGrid_odunc.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dataGrid_odunc_ColumnAdded);
            // 
            // label_bilgilendirme
            // 
            this.label_bilgilendirme.AutoSize = true;
            this.label_bilgilendirme.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_bilgilendirme.ForeColor = System.Drawing.Color.Red;
            this.label_bilgilendirme.Location = new System.Drawing.Point(371, 118);
            this.label_bilgilendirme.Name = "label_bilgilendirme";
            this.label_bilgilendirme.Size = new System.Drawing.Size(396, 38);
            this.label_bilgilendirme.TabIndex = 36;
            this.label_bilgilendirme.Text = "Ödünç Alaan Öğrenci Yok";
            // 
            // btn_oduncVer
            // 
            this.btn_oduncVer.BackColor = System.Drawing.Color.Red;
            this.btn_oduncVer.ForeColor = System.Drawing.Color.White;
            this.btn_oduncVer.Location = new System.Drawing.Point(571, 74);
            this.btn_oduncVer.Name = "btn_oduncVer";
            this.btn_oduncVer.Size = new System.Drawing.Size(138, 42);
            this.btn_oduncVer.TabIndex = 37;
            this.btn_oduncVer.Text = "Ödünç Ver";
            this.btn_oduncVer.UseVisualStyleBackColor = false;
            this.btn_oduncVer.Click += new System.EventHandler(this.btn_oduncVer_Click);
            // 
            // btn_iadeAl
            // 
            this.btn_iadeAl.BackColor = System.Drawing.Color.Red;
            this.btn_iadeAl.ForeColor = System.Drawing.Color.White;
            this.btn_iadeAl.Location = new System.Drawing.Point(399, 75);
            this.btn_iadeAl.Name = "btn_iadeAl";
            this.btn_iadeAl.Size = new System.Drawing.Size(150, 41);
            this.btn_iadeAl.TabIndex = 38;
            this.btn_iadeAl.Text = "İade Al";
            this.btn_iadeAl.UseVisualStyleBackColor = false;
            this.btn_iadeAl.Click += new System.EventHandler(this.btn_iadeAl_Click);
            // 
            // btn_ogrenciler
            // 
            this.btn_ogrenciler.BackColor = System.Drawing.Color.Red;
            this.btn_ogrenciler.ForeColor = System.Drawing.Color.White;
            this.btn_ogrenciler.Location = new System.Drawing.Point(219, 79);
            this.btn_ogrenciler.Name = "btn_ogrenciler";
            this.btn_ogrenciler.Size = new System.Drawing.Size(159, 36);
            this.btn_ogrenciler.TabIndex = 39;
            this.btn_ogrenciler.Text = "Öğrenciler";
            this.btn_ogrenciler.UseVisualStyleBackColor = false;
            this.btn_ogrenciler.Click += new System.EventHandler(this.btn_ogrenciler_Click);
            // 
            // btn_alanOgrenciler
            // 
            this.btn_alanOgrenciler.BackColor = System.Drawing.Color.Red;
            this.btn_alanOgrenciler.ForeColor = System.Drawing.Color.White;
            this.btn_alanOgrenciler.Location = new System.Drawing.Point(21, 79);
            this.btn_alanOgrenciler.Name = "btn_alanOgrenciler";
            this.btn_alanOgrenciler.Size = new System.Drawing.Size(183, 35);
            this.btn_alanOgrenciler.TabIndex = 40;
            this.btn_alanOgrenciler.Text = "Alan Öğrenciler";
            this.btn_alanOgrenciler.UseVisualStyleBackColor = false;
            this.btn_alanOgrenciler.Click += new System.EventHandler(this.btn_alanOgrenciler_Click);
            // 
            // kitapodunc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 505);
            this.ControlBox = false;
            this.Controls.Add(this.btn_alanOgrenciler);
            this.Controls.Add(this.btn_ogrenciler);
            this.Controls.Add(this.btn_iadeAl);
            this.Controls.Add(this.btn_oduncVer);
            this.Controls.Add(this.label_bilgilendirme);
            this.Controls.Add(this.dataGrid_odunc);
            this.Controls.Add(this.panelMenuHorizontal);
            this.Controls.Add(this.groupBox_arama);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "kitapodunc";
            this.Text = "kitapodunc";
            this.Load += new System.EventHandler(this.kitapodunc_Load);
            this.groupBox_arama.ResumeLayout(false);
            this.groupBox_arama.PerformLayout();
            this.panelMenuHorizontal.ResumeLayout(false);
            this.panelMenuHorizontal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AltaAl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kapat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_odunc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox_arama;
        private System.Windows.Forms.PictureBox Kapat;
        private System.Windows.Forms.PictureBox AltaAl;
        private System.Windows.Forms.Panel panelMenuHorizontal;
        private System.Windows.Forms.DataGridView dataGrid_odunc;
        private System.Windows.Forms.TextBox txt_aranacakOgrenci;
        private System.Windows.Forms.Button btn_alanOgrenciler;
        private System.Windows.Forms.Button btn_ogrenciler;
        private System.Windows.Forms.Button btn_iadeAl;
        private System.Windows.Forms.Button btn_oduncVer;
        private System.Windows.Forms.Label label_bilgilendirme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ogrenciAra;
        public System.Windows.Forms.Label label_id;
    }
}