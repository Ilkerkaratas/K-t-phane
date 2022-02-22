
namespace PresentationLayer
{
    partial class OgrenciOdunc
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
            this.btn_kitapAra = new System.Windows.Forms.Button();
            this.txt_aranacakKitap = new System.Windows.Forms.TextBox();
            this.panelMenuHorizontal = new System.Windows.Forms.Panel();
            this.label_id = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AltaAl = new System.Windows.Forms.PictureBox();
            this.kapat = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_alinankitaplar = new System.Windows.Forms.Button();
            this.btn_kitaplar = new System.Windows.Forms.Button();
            this.btn_oduncAl = new System.Windows.Forms.Button();
            this.btn_iadeEt = new System.Windows.Forms.Button();
            this.dataGrid_odunc = new System.Windows.Forms.DataGridView();
            this.label_bilgilendirme = new System.Windows.Forms.Label();
            this.groupBox_arama.SuspendLayout();
            this.panelMenuHorizontal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AltaAl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kapat)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_odunc)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_arama
            // 
            this.groupBox_arama.Controls.Add(this.btn_kitapAra);
            this.groupBox_arama.Controls.Add(this.txt_aranacakKitap);
            this.groupBox_arama.Location = new System.Drawing.Point(604, 3);
            this.groupBox_arama.Name = "groupBox_arama";
            this.groupBox_arama.Size = new System.Drawing.Size(477, 99);
            this.groupBox_arama.TabIndex = 38;
            this.groupBox_arama.TabStop = false;
            // 
            // btn_kitapAra
            // 
            this.btn_kitapAra.BackColor = System.Drawing.Color.Red;
            this.btn_kitapAra.ForeColor = System.Drawing.Color.White;
            this.btn_kitapAra.Location = new System.Drawing.Point(300, 26);
            this.btn_kitapAra.Name = "btn_kitapAra";
            this.btn_kitapAra.Size = new System.Drawing.Size(156, 53);
            this.btn_kitapAra.TabIndex = 6;
            this.btn_kitapAra.Text = "Kitap Ara";
            this.btn_kitapAra.UseVisualStyleBackColor = false;
            this.btn_kitapAra.Click += new System.EventHandler(this.btn_kitapAra_Click);
            // 
            // txt_aranacakKitap
            // 
            this.txt_aranacakKitap.BackColor = System.Drawing.Color.Red;
            this.txt_aranacakKitap.Location = new System.Drawing.Point(56, 29);
            this.txt_aranacakKitap.Multiline = true;
            this.txt_aranacakKitap.Name = "txt_aranacakKitap";
            this.txt_aranacakKitap.Size = new System.Drawing.Size(201, 50);
            this.txt_aranacakKitap.TabIndex = 5;
            this.txt_aranacakKitap.Enter += new System.EventHandler(this.txt_aranacakKitap_Enter);
            this.txt_aranacakKitap.MouseLeave += new System.EventHandler(this.txt_aranacakKitap_Leave);
            // 
            // panelMenuHorizontal
            // 
            this.panelMenuHorizontal.Controls.Add(this.label_id);
            this.panelMenuHorizontal.Controls.Add(this.label1);
            this.panelMenuHorizontal.Controls.Add(this.AltaAl);
            this.panelMenuHorizontal.Controls.Add(this.kapat);
            this.panelMenuHorizontal.Location = new System.Drawing.Point(-1, -2);
            this.panelMenuHorizontal.Name = "panelMenuHorizontal";
            this.panelMenuHorizontal.Size = new System.Drawing.Size(1084, 83);
            this.panelMenuHorizontal.TabIndex = 39;
            this.panelMenuHorizontal.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelMenuHorizontal_MouseDown);
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_id.ForeColor = System.Drawing.Color.Red;
            this.label_id.Location = new System.Drawing.Point(553, 24);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(42, 32);
            this.label_id.TabIndex = 36;
            this.label_id.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(544, 46);
            this.label1.TabIndex = 35;
            this.label1.Text = "Ödünç işlemi yapılan kitap ID:";
            // 
            // AltaAl
            // 
            this.AltaAl.Image = global::PresentationLayer.Properties.Resources.icons8_minimize_window_50;
            this.AltaAl.Location = new System.Drawing.Point(956, 6);
            this.AltaAl.Name = "AltaAl";
            this.AltaAl.Size = new System.Drawing.Size(51, 51);
            this.AltaAl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AltaAl.TabIndex = 33;
            this.AltaAl.TabStop = false;
            this.AltaAl.Click += new System.EventHandler(this.AltaAlClick);
            // 
            // kapat
            // 
            this.kapat.Image = global::PresentationLayer.Properties.Resources.icons8_close_50;
            this.kapat.Location = new System.Drawing.Point(1013, 6);
            this.kapat.Name = "kapat";
            this.kapat.Size = new System.Drawing.Size(51, 51);
            this.kapat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kapat.TabIndex = 34;
            this.kapat.TabStop = false;
            this.kapat.Click += new System.EventHandler(this.kapat_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_bilgilendirme);
            this.panel1.Controls.Add(this.btn_alinankitaplar);
            this.panel1.Controls.Add(this.btn_kitaplar);
            this.panel1.Controls.Add(this.btn_oduncAl);
            this.panel1.Controls.Add(this.groupBox_arama);
            this.panel1.Controls.Add(this.btn_iadeEt);
            this.panel1.Location = new System.Drawing.Point(2, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1084, 118);
            this.panel1.TabIndex = 42;
            // 
            // btn_alinankitaplar
            // 
            this.btn_alinankitaplar.BackColor = System.Drawing.Color.Red;
            this.btn_alinankitaplar.ForeColor = System.Drawing.Color.White;
            this.btn_alinankitaplar.Location = new System.Drawing.Point(31, 31);
            this.btn_alinankitaplar.Name = "btn_alinankitaplar";
            this.btn_alinankitaplar.Size = new System.Drawing.Size(138, 51);
            this.btn_alinankitaplar.TabIndex = 42;
            this.btn_alinankitaplar.Text = "Alınan Kitaplar";
            this.btn_alinankitaplar.UseVisualStyleBackColor = false;
            this.btn_alinankitaplar.Click += new System.EventHandler(this.btn_aldigimKitap_Click);
            // 
            // btn_kitaplar
            // 
            this.btn_kitaplar.BackColor = System.Drawing.Color.Red;
            this.btn_kitaplar.ForeColor = System.Drawing.Color.White;
            this.btn_kitaplar.Location = new System.Drawing.Point(350, 32);
            this.btn_kitaplar.Name = "btn_kitaplar";
            this.btn_kitaplar.Size = new System.Drawing.Size(144, 52);
            this.btn_kitaplar.TabIndex = 41;
            this.btn_kitaplar.Text = "Kitaplar";
            this.btn_kitaplar.UseVisualStyleBackColor = false;
            this.btn_kitaplar.Click += new System.EventHandler(this.btn_kitaplar_Click);
            // 
            // btn_oduncAl
            // 
            this.btn_oduncAl.BackColor = System.Drawing.Color.Red;
            this.btn_oduncAl.ForeColor = System.Drawing.Color.White;
            this.btn_oduncAl.Location = new System.Drawing.Point(189, 29);
            this.btn_oduncAl.Name = "btn_oduncAl";
            this.btn_oduncAl.Size = new System.Drawing.Size(138, 54);
            this.btn_oduncAl.TabIndex = 39;
            this.btn_oduncAl.Text = "Ödünç Al";
            this.btn_oduncAl.UseVisualStyleBackColor = false;
            this.btn_oduncAl.Click += new System.EventHandler(this.btn_oduncAl_Click);
            // 
            // btn_iadeEt
            // 
            this.btn_iadeEt.BackColor = System.Drawing.Color.Red;
            this.btn_iadeEt.ForeColor = System.Drawing.Color.White;
            this.btn_iadeEt.Location = new System.Drawing.Point(189, 31);
            this.btn_iadeEt.Name = "btn_iadeEt";
            this.btn_iadeEt.Size = new System.Drawing.Size(138, 52);
            this.btn_iadeEt.TabIndex = 40;
            this.btn_iadeEt.Text = "İade Et";
            this.btn_iadeEt.UseVisualStyleBackColor = false;
            this.btn_iadeEt.Click += new System.EventHandler(this.btn_iadeEt_Click);
            // 
            // dataGrid_odunc
            // 
            this.dataGrid_odunc.AllowUserToAddRows = false;
            this.dataGrid_odunc.AllowUserToDeleteRows = false;
            this.dataGrid_odunc.BackgroundColor = System.Drawing.Color.Red;
            this.dataGrid_odunc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_odunc.Location = new System.Drawing.Point(-1, 207);
            this.dataGrid_odunc.Name = "dataGrid_odunc";
            this.dataGrid_odunc.ReadOnly = true;
            this.dataGrid_odunc.RowHeadersVisible = false;
            this.dataGrid_odunc.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGrid_odunc.RowTemplate.Height = 24;
            this.dataGrid_odunc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid_odunc.Size = new System.Drawing.Size(1084, 334);
            this.dataGrid_odunc.TabIndex = 43;
            this.dataGrid_odunc.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_odunc_CellDoubleClick);
            this.dataGrid_odunc.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dataGrid_odunc_ColumnAdded);
            // 
            // label_bilgilendirme
            // 
            this.label_bilgilendirme.AutoSize = true;
            this.label_bilgilendirme.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_bilgilendirme.ForeColor = System.Drawing.Color.Red;
            this.label_bilgilendirme.Location = new System.Drawing.Point(246, 85);
            this.label_bilgilendirme.Name = "label_bilgilendirme";
            this.label_bilgilendirme.Size = new System.Drawing.Size(452, 46);
            this.label_bilgilendirme.TabIndex = 37;
            this.label_bilgilendirme.Text = "ödünç Alan Öğrenci Yok";
            // 
            // OgrenciOdunc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 538);
            this.ControlBox = false;
            this.Controls.Add(this.dataGrid_odunc);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenuHorizontal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OgrenciOdunc";
            this.Text = "OgrenciOdunc";
            this.Load += new System.EventHandler(this.OgrenciOdunc_Load);
            this.groupBox_arama.ResumeLayout(false);
            this.groupBox_arama.PerformLayout();
            this.panelMenuHorizontal.ResumeLayout(false);
            this.panelMenuHorizontal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AltaAl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kapat)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_odunc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox kapat;
        private System.Windows.Forms.PictureBox AltaAl;
        private System.Windows.Forms.Panel panelMenuHorizontal;
        private System.Windows.Forms.GroupBox groupBox_arama;
        
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGrid_odunc;
        private System.Windows.Forms.TextBox txt_aranacakKitap;
        private System.Windows.Forms.Button btn_kitapAra;
        public System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_alinankitaplar;
        private System.Windows.Forms.Button btn_kitaplar;
        private System.Windows.Forms.Button btn_oduncAl;
        private System.Windows.Forms.Button btn_iadeEt;
        private System.Windows.Forms.Label label_bilgilendirme;
    }
}