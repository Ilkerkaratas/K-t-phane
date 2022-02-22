
namespace PresentationLayer
{
    partial class Ogrenciler
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
            this.dataGrid_Ogrenciler = new System.Windows.Forms.DataGridView();
            this.panel_menu = new System.Windows.Forms.Panel();
            this.btn_ogrenciEkle = new System.Windows.Forms.Button();
            this.btn_ogrenciGuncelle = new System.Windows.Forms.Button();
            this.btn_ogrenciSil = new System.Windows.Forms.Button();
            this.btn_oduncIslemleri = new System.Windows.Forms.Button();
            this.btn_ogrenciListele = new System.Windows.Forms.Button();
            this.btn_ogrenciAra = new System.Windows.Forms.Button();
            this.txt_aranacakOgrenci = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Ogrenciler)).BeginInit();
            this.panel_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGrid_Ogrenciler
            // 
            this.dataGrid_Ogrenciler.AllowUserToAddRows = false;
            this.dataGrid_Ogrenciler.AllowUserToDeleteRows = false;
            this.dataGrid_Ogrenciler.BackgroundColor = System.Drawing.Color.Red;
            this.dataGrid_Ogrenciler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Ogrenciler.Location = new System.Drawing.Point(5, 72);
            this.dataGrid_Ogrenciler.Name = "dataGrid_Ogrenciler";
            this.dataGrid_Ogrenciler.ReadOnly = true;
            this.dataGrid_Ogrenciler.RowHeadersVisible = false;
            this.dataGrid_Ogrenciler.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGrid_Ogrenciler.RowTemplate.Height = 24;
            this.dataGrid_Ogrenciler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid_Ogrenciler.Size = new System.Drawing.Size(1314, 467);
            this.dataGrid_Ogrenciler.TabIndex = 14;
            this.dataGrid_Ogrenciler.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dataGrid_student_ColumnAdded);
            // 
            // panel_menu
            // 
            this.panel_menu.Controls.Add(this.btn_ogrenciEkle);
            this.panel_menu.Controls.Add(this.btn_ogrenciGuncelle);
            this.panel_menu.Controls.Add(this.btn_ogrenciSil);
            this.panel_menu.Controls.Add(this.btn_oduncIslemleri);
            this.panel_menu.Controls.Add(this.btn_ogrenciListele);
            this.panel_menu.Controls.Add(this.btn_ogrenciAra);
            this.panel_menu.Controls.Add(this.txt_aranacakOgrenci);
            this.panel_menu.Location = new System.Drawing.Point(5, 1);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(1326, 65);
            this.panel_menu.TabIndex = 15;
            // 
            // btn_ogrenciEkle
            // 
            this.btn_ogrenciEkle.BackColor = System.Drawing.Color.Red;
            this.btn_ogrenciEkle.ForeColor = System.Drawing.Color.White;
            this.btn_ogrenciEkle.Location = new System.Drawing.Point(26, 11);
            this.btn_ogrenciEkle.Name = "btn_ogrenciEkle";
            this.btn_ogrenciEkle.Size = new System.Drawing.Size(159, 37);
            this.btn_ogrenciEkle.TabIndex = 20;
            this.btn_ogrenciEkle.Text = "Öğrenci Ekle";
            this.btn_ogrenciEkle.UseVisualStyleBackColor = false;
            this.btn_ogrenciEkle.Click += new System.EventHandler(this.btn_ogrenciEkle_Click);
            // 
            // btn_ogrenciGuncelle
            // 
            this.btn_ogrenciGuncelle.BackColor = System.Drawing.Color.Red;
            this.btn_ogrenciGuncelle.ForeColor = System.Drawing.Color.White;
            this.btn_ogrenciGuncelle.Location = new System.Drawing.Point(208, 11);
            this.btn_ogrenciGuncelle.Name = "btn_ogrenciGuncelle";
            this.btn_ogrenciGuncelle.Size = new System.Drawing.Size(166, 37);
            this.btn_ogrenciGuncelle.TabIndex = 19;
            this.btn_ogrenciGuncelle.Text = "Öğrenci Güncelle";
            this.btn_ogrenciGuncelle.UseVisualStyleBackColor = false;
            this.btn_ogrenciGuncelle.Click += new System.EventHandler(this.btn_ogrenciGuncelle_Click);
            // 
            // btn_ogrenciSil
            // 
            this.btn_ogrenciSil.BackColor = System.Drawing.Color.Red;
            this.btn_ogrenciSil.ForeColor = System.Drawing.Color.White;
            this.btn_ogrenciSil.Location = new System.Drawing.Point(387, 10);
            this.btn_ogrenciSil.Name = "btn_ogrenciSil";
            this.btn_ogrenciSil.Size = new System.Drawing.Size(174, 39);
            this.btn_ogrenciSil.TabIndex = 18;
            this.btn_ogrenciSil.Text = "Öğrenci Sil";
            this.btn_ogrenciSil.UseVisualStyleBackColor = false;
            this.btn_ogrenciSil.Click += new System.EventHandler(this.btn_ogrenciSil_Click);
            // 
            // btn_oduncIslemleri
            // 
            this.btn_oduncIslemleri.BackColor = System.Drawing.Color.Red;
            this.btn_oduncIslemleri.ForeColor = System.Drawing.Color.White;
            this.btn_oduncIslemleri.Location = new System.Drawing.Point(576, 11);
            this.btn_oduncIslemleri.Name = "btn_oduncIslemleri";
            this.btn_oduncIslemleri.Size = new System.Drawing.Size(154, 37);
            this.btn_oduncIslemleri.TabIndex = 17;
            this.btn_oduncIslemleri.Text = "Ödünç İşlemleri";
            this.btn_oduncIslemleri.UseVisualStyleBackColor = false;
            this.btn_oduncIslemleri.Click += new System.EventHandler(this.btn_oduncIslemleri_Click);
            // 
            // btn_ogrenciListele
            // 
            this.btn_ogrenciListele.BackColor = System.Drawing.Color.Red;
            this.btn_ogrenciListele.ForeColor = System.Drawing.Color.White;
            this.btn_ogrenciListele.Location = new System.Drawing.Point(751, 10);
            this.btn_ogrenciListele.Name = "btn_ogrenciListele";
            this.btn_ogrenciListele.Size = new System.Drawing.Size(147, 39);
            this.btn_ogrenciListele.TabIndex = 16;
            this.btn_ogrenciListele.Text = "Öğrenci Listele";
            this.btn_ogrenciListele.UseVisualStyleBackColor = false;
            this.btn_ogrenciListele.Click += new System.EventHandler(this.btn_ogrenciListele_Click);
            // 
            // btn_ogrenciAra
            // 
            this.btn_ogrenciAra.BackColor = System.Drawing.Color.Red;
            this.btn_ogrenciAra.ForeColor = System.Drawing.Color.White;
            this.btn_ogrenciAra.Location = new System.Drawing.Point(1076, 11);
            this.btn_ogrenciAra.Name = "btn_ogrenciAra";
            this.btn_ogrenciAra.Size = new System.Drawing.Size(159, 39);
            this.btn_ogrenciAra.TabIndex = 15;
            this.btn_ogrenciAra.Text = "Öğrenci Ara";
            this.btn_ogrenciAra.UseVisualStyleBackColor = false;
            this.btn_ogrenciAra.Click += new System.EventHandler(this.btn_ogrenciAra_Click);
            // 
            // txt_aranacakOgrenci
            // 
            this.txt_aranacakOgrenci.BackColor = System.Drawing.Color.Red;
            this.txt_aranacakOgrenci.ForeColor = System.Drawing.Color.White;
            this.txt_aranacakOgrenci.Location = new System.Drawing.Point(904, 11);
            this.txt_aranacakOgrenci.Multiline = true;
            this.txt_aranacakOgrenci.Name = "txt_aranacakOgrenci";
            this.txt_aranacakOgrenci.Size = new System.Drawing.Size(166, 37);
            this.txt_aranacakOgrenci.TabIndex = 14;
            this.txt_aranacakOgrenci.Enter += new System.EventHandler(this.txt_aranacakOgrenci_Enter);
            this.txt_aranacakOgrenci.Leave += new System.EventHandler(this.txt_aranacakOgrenci_Leave);
            // 
            // Ogrenciler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1331, 551);
            this.ControlBox = false;
            this.Controls.Add(this.panel_menu);
            this.Controls.Add(this.dataGrid_Ogrenciler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ogrenciler";
            this.Text = "Ogrenciler";
            this.Load += new System.EventHandler(this.Ogrenciler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Ogrenciler)).EndInit();
            this.panel_menu.ResumeLayout(false);
            this.panel_menu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGrid_Ogrenciler;
        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.TextBox txt_aranacakOgrenci;
        private System.Windows.Forms.Button btn_ogrenciEkle;
        private System.Windows.Forms.Button btn_ogrenciGuncelle;
        private System.Windows.Forms.Button btn_ogrenciSil;
        private System.Windows.Forms.Button btn_oduncIslemleri;
        private System.Windows.Forms.Button btn_ogrenciListele;
        private System.Windows.Forms.Button btn_ogrenciAra;
    }
}