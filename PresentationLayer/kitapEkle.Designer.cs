
namespace PresentationLayer
{
    partial class kitapEkle
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.AltaAl = new System.Windows.Forms.PictureBox();
            this.panelMenuHorizontal = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_ismi = new System.Windows.Forms.TextBox();
            this.txt_turu = new System.Windows.Forms.TextBox();
            this.txt_yazari = new System.Windows.Forms.TextBox();
            this.txt_yayinevi = new System.Windows.Forms.TextBox();
            this.txt_sayfasi = new System.Windows.Forms.TextBox();
            this.txt_adeti = new System.Windows.Forms.TextBox();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AltaAl)).BeginInit();
            this.panelMenuHorizontal.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PresentationLayer.Properties.Resources.icons8_close_50;
            this.pictureBox2.Location = new System.Drawing.Point(1034, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(51, 57);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // AltaAl
            // 
            this.AltaAl.Image = global::PresentationLayer.Properties.Resources.icons8_minimize_window_50;
            this.AltaAl.Location = new System.Drawing.Point(977, 0);
            this.AltaAl.Name = "AltaAl";
            this.AltaAl.Size = new System.Drawing.Size(51, 57);
            this.AltaAl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AltaAl.TabIndex = 30;
            this.AltaAl.TabStop = false;
            this.AltaAl.Click += new System.EventHandler(this.AltaAl_Click);
            // 
            // panelMenuHorizontal
            // 
            this.panelMenuHorizontal.Controls.Add(this.label1);
            this.panelMenuHorizontal.Controls.Add(this.AltaAl);
            this.panelMenuHorizontal.Controls.Add(this.pictureBox2);
            this.panelMenuHorizontal.Location = new System.Drawing.Point(0, 1);
            this.panelMenuHorizontal.Name = "panelMenuHorizontal";
            this.panelMenuHorizontal.Size = new System.Drawing.Size(1094, 61);
            this.panelMenuHorizontal.TabIndex = 46;
            this.panelMenuHorizontal.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelMenuHorizontal_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 46);
            this.label1.TabIndex = 32;
            this.label1.Text = "Kitap Ekleme";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(27, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 24);
            this.label3.TabIndex = 48;
            this.label3.Text = "Kitap Türü";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(27, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 24);
            this.label2.TabIndex = 49;
            this.label2.Text = "Kitap Adı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(619, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 24);
            this.label4.TabIndex = 50;
            this.label4.Text = "Kitap Yayınevi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(619, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 24);
            this.label5.TabIndex = 51;
            this.label5.Text = "Kitap Sayfası";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(619, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 24);
            this.label6.TabIndex = 52;
            this.label6.Text = "Kitap Adeti";
            // 
            // txt_ismi
            // 
            this.txt_ismi.BackColor = System.Drawing.Color.Red;
            this.txt_ismi.ForeColor = System.Drawing.Color.White;
            this.txt_ismi.Location = new System.Drawing.Point(220, 89);
            this.txt_ismi.Multiline = true;
            this.txt_ismi.Name = "txt_ismi";
            this.txt_ismi.Size = new System.Drawing.Size(283, 44);
            this.txt_ismi.TabIndex = 53;
            // 
            // txt_turu
            // 
            this.txt_turu.BackColor = System.Drawing.Color.Red;
            this.txt_turu.ForeColor = System.Drawing.Color.White;
            this.txt_turu.Location = new System.Drawing.Point(220, 176);
            this.txt_turu.Multiline = true;
            this.txt_turu.Name = "txt_turu";
            this.txt_turu.Size = new System.Drawing.Size(283, 44);
            this.txt_turu.TabIndex = 54;
            // 
            // txt_yazari
            // 
            this.txt_yazari.BackColor = System.Drawing.Color.Red;
            this.txt_yazari.ForeColor = System.Drawing.Color.White;
            this.txt_yazari.Location = new System.Drawing.Point(220, 276);
            this.txt_yazari.Multiline = true;
            this.txt_yazari.Name = "txt_yazari";
            this.txt_yazari.Size = new System.Drawing.Size(283, 44);
            this.txt_yazari.TabIndex = 55;
            // 
            // txt_yayinevi
            // 
            this.txt_yayinevi.BackColor = System.Drawing.Color.Red;
            this.txt_yayinevi.ForeColor = System.Drawing.Color.White;
            this.txt_yayinevi.Location = new System.Drawing.Point(801, 89);
            this.txt_yayinevi.Multiline = true;
            this.txt_yayinevi.Name = "txt_yayinevi";
            this.txt_yayinevi.Size = new System.Drawing.Size(281, 44);
            this.txt_yayinevi.TabIndex = 56;
            // 
            // txt_sayfasi
            // 
            this.txt_sayfasi.BackColor = System.Drawing.Color.Red;
            this.txt_sayfasi.ForeColor = System.Drawing.Color.White;
            this.txt_sayfasi.Location = new System.Drawing.Point(801, 176);
            this.txt_sayfasi.Multiline = true;
            this.txt_sayfasi.Name = "txt_sayfasi";
            this.txt_sayfasi.Size = new System.Drawing.Size(281, 44);
            this.txt_sayfasi.TabIndex = 57;
            // 
            // txt_adeti
            // 
            this.txt_adeti.BackColor = System.Drawing.Color.Red;
            this.txt_adeti.ForeColor = System.Drawing.Color.White;
            this.txt_adeti.Location = new System.Drawing.Point(801, 276);
            this.txt_adeti.Multiline = true;
            this.txt_adeti.Name = "txt_adeti";
            this.txt_adeti.Size = new System.Drawing.Size(281, 44);
            this.txt_adeti.TabIndex = 58;
            // 
            // btn_ekle
            // 
            this.btn_ekle.BackColor = System.Drawing.Color.Red;
            this.btn_ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ekle.ForeColor = System.Drawing.Color.White;
            this.btn_ekle.Location = new System.Drawing.Point(24, 345);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(1057, 71);
            this.btn_ekle.TabIndex = 59;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = false;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(27, 286);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 24);
            this.label7.TabIndex = 60;
            this.label7.Text = "Kitap Yazarı";
            // 
            // kitapEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 428);
            this.ControlBox = false;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.txt_adeti);
            this.Controls.Add(this.txt_sayfasi);
            this.Controls.Add(this.txt_yayinevi);
            this.Controls.Add(this.txt_yazari);
            this.Controls.Add(this.txt_turu);
            this.Controls.Add(this.txt_ismi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panelMenuHorizontal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "kitapEkle";
            this.Text = "kitapEkle";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AltaAl)).EndInit();
            this.panelMenuHorizontal.ResumeLayout(false);
            this.panelMenuHorizontal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox AltaAl;
        private System.Windows.Forms.Panel panelMenuHorizontal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_ekle;
        public System.Windows.Forms.TextBox txt_ismi;
        public System.Windows.Forms.TextBox txt_turu;
        public System.Windows.Forms.TextBox txt_yazari;
        public System.Windows.Forms.TextBox txt_yayinevi;
        public System.Windows.Forms.TextBox txt_sayfasi;
        public System.Windows.Forms.TextBox txt_adeti;
        private System.Windows.Forms.Label label7;
    }
}