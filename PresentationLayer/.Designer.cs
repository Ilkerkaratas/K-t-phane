
namespace PresentationLayer
{
    partial class Form1
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
            this.panel_menu = new System.Windows.Forms.Panel();
            this.txt_aranacakKitap = new System.Windows.Forms.TextBox();
            this.dataGrid_kitap = new System.Windows.Forms.DataGridView();
            this.btn_kitapAra = new System.Windows.Forms.Button();
            this.btn_kitapListele = new System.Windows.Forms.Button();
            this.btn_oduncIslemleri = new System.Windows.Forms.Button();
            this.btn_kitapSil = new System.Windows.Forms.Button();
            this.btn_kitapGuncelle = new System.Windows.Forms.Button();
            this.btn_kitapEkle = new System.Windows.Forms.Button();
            this.panel_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_kitap)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_menu
            // 
            this.panel_menu.Controls.Add(this.btn_kitapEkle);
            this.panel_menu.Controls.Add(this.btn_kitapGuncelle);
            this.panel_menu.Controls.Add(this.btn_kitapSil);
            this.panel_menu.Controls.Add(this.btn_oduncIslemleri);
            this.panel_menu.Controls.Add(this.btn_kitapListele);
            this.panel_menu.Controls.Add(this.btn_kitapAra);
            this.panel_menu.Controls.Add(this.txt_aranacakKitap);
            this.panel_menu.Location = new System.Drawing.Point(12, 1);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(1168, 102);
            this.panel_menu.TabIndex = 8;
            // 
            // txt_aranacakKitap
            // 
            this.txt_aranacakKitap.BackColor = System.Drawing.Color.Red;
            this.txt_aranacakKitap.ForeColor = System.Drawing.Color.White;
            this.txt_aranacakKitap.Location = new System.Drawing.Point(819, 28);
            this.txt_aranacakKitap.Multiline = true;
            this.txt_aranacakKitap.Name = "txt_aranacakKitap";
            this.txt_aranacakKitap.Size = new System.Drawing.Size(151, 31);
            this.txt_aranacakKitap.TabIndex = 7;
            this.txt_aranacakKitap.Enter += new System.EventHandler(this.txt_aranacakKitap_Enter);
            this.txt_aranacakKitap.Leave += new System.EventHandler(this.txt_aranacakKitap_Leave);
            // 
            // dataGrid_kitap
            // 
            this.dataGrid_kitap.AllowUserToAddRows = false;
            this.dataGrid_kitap.AllowUserToDeleteRows = false;
            this.dataGrid_kitap.BackgroundColor = System.Drawing.Color.Red;
            this.dataGrid_kitap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_kitap.GridColor = System.Drawing.Color.Red;
            this.dataGrid_kitap.Location = new System.Drawing.Point(12, 118);
            this.dataGrid_kitap.Name = "dataGrid_kitap";
            this.dataGrid_kitap.ReadOnly = true;
            this.dataGrid_kitap.RowHeadersVisible = false;
            this.dataGrid_kitap.RowHeadersWidth = 51;
            this.dataGrid_kitap.RowTemplate.Height = 24;
            this.dataGrid_kitap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid_kitap.Size = new System.Drawing.Size(1168, 404);
            this.dataGrid_kitap.TabIndex = 9;
            this.dataGrid_kitap.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dataGrid_kitap_ColumnAdded);
            // 
            // btn_kitapAra
            // 
            this.btn_kitapAra.BackColor = System.Drawing.Color.Red;
            this.btn_kitapAra.ForeColor = System.Drawing.Color.White;
            this.btn_kitapAra.Location = new System.Drawing.Point(998, 20);
            this.btn_kitapAra.Name = "btn_kitapAra";
            this.btn_kitapAra.Size = new System.Drawing.Size(158, 52);
            this.btn_kitapAra.TabIndex = 8;
            this.btn_kitapAra.Text = "Kitap Ara";
            this.btn_kitapAra.UseVisualStyleBackColor = false;
            this.btn_kitapAra.Click += new System.EventHandler(this.btn_kitapAra_Click);
            // 
            // btn_kitapListele
            // 
            this.btn_kitapListele.BackColor = System.Drawing.Color.Red;
            this.btn_kitapListele.ForeColor = System.Drawing.Color.White;
            this.btn_kitapListele.Location = new System.Drawing.Point(670, 20);
            this.btn_kitapListele.Name = "btn_kitapListele";
            this.btn_kitapListele.Size = new System.Drawing.Size(132, 52);
            this.btn_kitapListele.TabIndex = 9;
            this.btn_kitapListele.Text = "Kitap Listele";
            this.btn_kitapListele.UseVisualStyleBackColor = false;
            this.btn_kitapListele.Click += new System.EventHandler(this.btn_kitapListele_Click);
            // 
            // btn_oduncIslemleri
            // 
            this.btn_oduncIslemleri.BackColor = System.Drawing.Color.Red;
            this.btn_oduncIslemleri.ForeColor = System.Drawing.Color.White;
            this.btn_oduncIslemleri.Location = new System.Drawing.Point(508, 23);
            this.btn_oduncIslemleri.Name = "btn_oduncIslemleri";
            this.btn_oduncIslemleri.Size = new System.Drawing.Size(142, 48);
            this.btn_oduncIslemleri.TabIndex = 10;
            this.btn_oduncIslemleri.Text = "Ödünç İşlemleri";
            this.btn_oduncIslemleri.UseVisualStyleBackColor = false;
            this.btn_oduncIslemleri.Click += new System.EventHandler(this.btn_oduncIslemleri_Click);
            // 
            // btn_kitapSil
            // 
            this.btn_kitapSil.BackColor = System.Drawing.Color.Red;
            this.btn_kitapSil.ForeColor = System.Drawing.Color.White;
            this.btn_kitapSil.Location = new System.Drawing.Point(350, 23);
            this.btn_kitapSil.Name = "btn_kitapSil";
            this.btn_kitapSil.Size = new System.Drawing.Size(141, 48);
            this.btn_kitapSil.TabIndex = 11;
            this.btn_kitapSil.Text = "Kitap Sİl";
            this.btn_kitapSil.UseVisualStyleBackColor = false;
            this.btn_kitapSil.Click += new System.EventHandler(this.btn_kitapSil_Click);
            // 
            // btn_kitapGuncelle
            // 
            this.btn_kitapGuncelle.BackColor = System.Drawing.Color.Red;
            this.btn_kitapGuncelle.ForeColor = System.Drawing.Color.White;
            this.btn_kitapGuncelle.Location = new System.Drawing.Point(187, 23);
            this.btn_kitapGuncelle.Name = "btn_kitapGuncelle";
            this.btn_kitapGuncelle.Size = new System.Drawing.Size(143, 49);
            this.btn_kitapGuncelle.TabIndex = 12;
            this.btn_kitapGuncelle.Text = "Kitap Güncelle";
            this.btn_kitapGuncelle.UseVisualStyleBackColor = false;
            this.btn_kitapGuncelle.Click += new System.EventHandler(this.btn_kitapGuncelle_Click);
            // 
            // btn_kitapEkle
            // 
            this.btn_kitapEkle.BackColor = System.Drawing.Color.Red;
            this.btn_kitapEkle.ForeColor = System.Drawing.Color.White;
            this.btn_kitapEkle.Location = new System.Drawing.Point(19, 28);
            this.btn_kitapEkle.Name = "btn_kitapEkle";
            this.btn_kitapEkle.Size = new System.Drawing.Size(148, 44);
            this.btn_kitapEkle.TabIndex = 13;
            this.btn_kitapEkle.Text = "Kitap Ekle";
            this.btn_kitapEkle.UseVisualStyleBackColor = false;
            this.btn_kitapEkle.Click += new System.EventHandler(this.btn_kitapEkle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 534);
            this.ControlBox = false;
            this.Controls.Add(this.dataGrid_kitap);
            this.Controls.Add(this.panel_menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.kolonrenk_kitap_Load);
            this.panel_menu.ResumeLayout(false);
            this.panel_menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_kitap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.DataGridView dataGrid_kitap;
        private System.Windows.Forms.TextBox txt_aranacakKitap;
        private System.Windows.Forms.Button btn_kitapEkle;
        private System.Windows.Forms.Button btn_kitapGuncelle;
        private System.Windows.Forms.Button btn_kitapSil;
        private System.Windows.Forms.Button btn_oduncIslemleri;
        private System.Windows.Forms.Button btn_kitapListele;
        private System.Windows.Forms.Button btn_kitapAra;
    }
}

