
namespace PresentationLayer
{
    partial class ÖdünçAlınanKitap
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
            this.btn_oduncAra = new System.Windows.Forms.Button();
            this.txt_aranacakOdunc = new System.Windows.Forms.TextBox();
            this.dataGrid_odunc = new System.Windows.Forms.DataGridView();
            this.btn_ogrenciyiGor = new System.Windows.Forms.Button();
            this.btn_kitabiGor = new System.Windows.Forms.Button();
            this.btn_OduncListele = new System.Windows.Forms.Button();
            this.label_bilgilendirme = new System.Windows.Forms.Label();
            this.groupBox_arama.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_odunc)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_arama
            // 
            this.groupBox_arama.Controls.Add(this.btn_oduncAra);
            this.groupBox_arama.Controls.Add(this.txt_aranacakOdunc);
            this.groupBox_arama.Location = new System.Drawing.Point(790, 11);
            this.groupBox_arama.Name = "groupBox_arama";
            this.groupBox_arama.Size = new System.Drawing.Size(462, 77);
            this.groupBox_arama.TabIndex = 11;
            this.groupBox_arama.TabStop = false;
            // 
            // btn_oduncAra
            // 
            this.btn_oduncAra.BackColor = System.Drawing.Color.Red;
            this.btn_oduncAra.ForeColor = System.Drawing.Color.White;
            this.btn_oduncAra.Location = new System.Drawing.Point(299, 18);
            this.btn_oduncAra.Name = "btn_oduncAra";
            this.btn_oduncAra.Size = new System.Drawing.Size(134, 42);
            this.btn_oduncAra.TabIndex = 6;
            this.btn_oduncAra.Text = "Ödünç Ara";
            this.btn_oduncAra.UseVisualStyleBackColor = false;
            this.btn_oduncAra.Click += new System.EventHandler(this.btn_oduncAra_Click);
            // 
            // txt_aranacakOdunc
            // 
            this.txt_aranacakOdunc.BackColor = System.Drawing.Color.Red;
            this.txt_aranacakOdunc.ForeColor = System.Drawing.Color.White;
            this.txt_aranacakOdunc.Location = new System.Drawing.Point(49, 21);
            this.txt_aranacakOdunc.Multiline = true;
            this.txt_aranacakOdunc.Name = "txt_aranacakOdunc";
            this.txt_aranacakOdunc.Size = new System.Drawing.Size(215, 37);
            this.txt_aranacakOdunc.TabIndex = 5;
            this.txt_aranacakOdunc.Enter += new System.EventHandler(this.txt_aranacakOdunc_Enter);
            this.txt_aranacakOdunc.Leave += new System.EventHandler(this.txt_aranacakOdunc_Leave);
            // 
            // dataGrid_odunc
            // 
            this.dataGrid_odunc.AllowUserToAddRows = false;
            this.dataGrid_odunc.AllowUserToDeleteRows = false;
            this.dataGrid_odunc.BackgroundColor = System.Drawing.Color.Red;
            this.dataGrid_odunc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_odunc.Location = new System.Drawing.Point(0, 118);
            this.dataGrid_odunc.Name = "dataGrid_odunc";
            this.dataGrid_odunc.ReadOnly = true;
            this.dataGrid_odunc.RowHeadersVisible = false;
            this.dataGrid_odunc.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGrid_odunc.RowTemplate.Height = 24;
            this.dataGrid_odunc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid_odunc.Size = new System.Drawing.Size(1266, 449);
            this.dataGrid_odunc.TabIndex = 34;
            this.dataGrid_odunc.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_odunc_CellDoubleClick);
            this.dataGrid_odunc.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dataGrid_odunc_ColumnAdded);
            // 
            // btn_ogrenciyiGor
            // 
            this.btn_ogrenciyiGor.BackColor = System.Drawing.Color.Red;
            this.btn_ogrenciyiGor.ForeColor = System.Drawing.Color.White;
            this.btn_ogrenciyiGor.Location = new System.Drawing.Point(354, 31);
            this.btn_ogrenciyiGor.Name = "btn_ogrenciyiGor";
            this.btn_ogrenciyiGor.Size = new System.Drawing.Size(152, 40);
            this.btn_ogrenciyiGor.TabIndex = 35;
            this.btn_ogrenciyiGor.Text = "Öğrenciyi Gör";
            this.btn_ogrenciyiGor.UseVisualStyleBackColor = false;
            this.btn_ogrenciyiGor.Click += new System.EventHandler(this.btn_ogrenciyiGor_Click);
            // 
            // btn_kitabiGor
            // 
            this.btn_kitabiGor.BackColor = System.Drawing.Color.Red;
            this.btn_kitabiGor.ForeColor = System.Drawing.Color.White;
            this.btn_kitabiGor.Location = new System.Drawing.Point(191, 30);
            this.btn_kitabiGor.Name = "btn_kitabiGor";
            this.btn_kitabiGor.Size = new System.Drawing.Size(157, 40);
            this.btn_kitabiGor.TabIndex = 36;
            this.btn_kitabiGor.Text = "Kitabı Gör";
            this.btn_kitabiGor.UseVisualStyleBackColor = false;
            this.btn_kitabiGor.Click += new System.EventHandler(this.btn_kitabiGor_Click);
            // 
            // btn_OduncListele
            // 
            this.btn_OduncListele.BackColor = System.Drawing.Color.Red;
            this.btn_OduncListele.ForeColor = System.Drawing.Color.White;
            this.btn_OduncListele.Location = new System.Drawing.Point(25, 29);
            this.btn_OduncListele.Name = "btn_OduncListele";
            this.btn_OduncListele.Size = new System.Drawing.Size(160, 42);
            this.btn_OduncListele.TabIndex = 37;
            this.btn_OduncListele.Text = "Ödünç Listele";
            this.btn_OduncListele.UseVisualStyleBackColor = false;
            this.btn_OduncListele.Click += new System.EventHandler(this.btn_oduncListele_Click);
            // 
            // label_bilgilendirme
            // 
            this.label_bilgilendirme.AutoSize = true;
            this.label_bilgilendirme.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_bilgilendirme.ForeColor = System.Drawing.Color.Red;
            this.label_bilgilendirme.Location = new System.Drawing.Point(223, 76);
            this.label_bilgilendirme.Name = "label_bilgilendirme";
            this.label_bilgilendirme.Size = new System.Drawing.Size(533, 38);
            this.label_bilgilendirme.TabIndex = 38;
            this.label_bilgilendirme.Text = "İşlem Yapmak İçin Ödünç Listeleyin";
            // 
            // ÖdünçAlınanKitap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 565);
            this.ControlBox = false;
            this.Controls.Add(this.label_bilgilendirme);
            this.Controls.Add(this.btn_OduncListele);
            this.Controls.Add(this.btn_kitabiGor);
            this.Controls.Add(this.btn_ogrenciyiGor);
            this.Controls.Add(this.dataGrid_odunc);
            this.Controls.Add(this.groupBox_arama);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ÖdünçAlınanKitap";
            this.Text = "ÖdünçAlınanKitap";
            this.Load += new System.EventHandler(this.ÖdünçAlınanKitap_Load);
            this.groupBox_arama.ResumeLayout(false);
            this.groupBox_arama.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_odunc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox_arama;
        private System.Windows.Forms.DataGridView dataGrid_odunc;
        private System.Windows.Forms.TextBox txt_aranacakOdunc;
        private System.Windows.Forms.Button btn_oduncAra;
        private System.Windows.Forms.Button btn_ogrenciyiGor;
        private System.Windows.Forms.Button btn_kitabiGor;
        private System.Windows.Forms.Button btn_OduncListele;
        public System.Windows.Forms.Label label_bilgilendirme;
    }
}