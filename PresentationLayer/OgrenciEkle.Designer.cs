
namespace PresentationLayer
{
    partial class OgrenciEkle
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
            this.AltaAl = new System.Windows.Forms.PictureBox();
            this.kapat = new System.Windows.Forms.PictureBox();
            this.panelMenuHorizontal = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_adi = new System.Windows.Forms.TextBox();
            this.txt_soyadi = new System.Windows.Forms.TextBox();
            this.txt_bolumu = new System.Windows.Forms.TextBox();
            this.txt_tcNo = new System.Windows.Forms.TextBox();
            this.txt_okulNo = new System.Windows.Forms.TextBox();
            this.txt_cinsiyet = new System.Windows.Forms.TextBox();
            this.btn_Ekle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AltaAl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kapat)).BeginInit();
            this.panelMenuHorizontal.SuspendLayout();
            this.SuspendLayout();
            // 
            // AltaAl
            // 
            this.AltaAl.Image = global::PresentationLayer.Properties.Resources.icons8_minimize_window_50;
            this.AltaAl.Location = new System.Drawing.Point(858, 13);
            this.AltaAl.Name = "AltaAl";
            this.AltaAl.Size = new System.Drawing.Size(51, 39);
            this.AltaAl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AltaAl.TabIndex = 40;
            this.AltaAl.TabStop = false;
            this.AltaAl.Click += new System.EventHandler(this.AltaAl_Click);
            // 
            // kapat
            // 
            this.kapat.Image = global::PresentationLayer.Properties.Resources.icons8_close_50;
            this.kapat.Location = new System.Drawing.Point(915, 13);
            this.kapat.Name = "kapat";
            this.kapat.Size = new System.Drawing.Size(51, 39);
            this.kapat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kapat.TabIndex = 41;
            this.kapat.TabStop = false;
            this.kapat.Click += new System.EventHandler(this.kapat_Click);
            // 
            // panelMenuHorizontal
            // 
            this.panelMenuHorizontal.Controls.Add(this.label7);
            this.panelMenuHorizontal.Controls.Add(this.kapat);
            this.panelMenuHorizontal.Controls.Add(this.AltaAl);
            this.panelMenuHorizontal.Location = new System.Drawing.Point(1, 2);
            this.panelMenuHorizontal.Name = "panelMenuHorizontal";
            this.panelMenuHorizontal.Size = new System.Drawing.Size(983, 68);
            this.panelMenuHorizontal.TabIndex = 42;
            this.panelMenuHorizontal.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelMenuHorizontal_MouseDown_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(7, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(462, 46);
            this.label7.TabIndex = 42;
            this.label7.Text = "Öğrenci Ekleme İşlemleri";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 24);
            this.label1.TabIndex = 55;
            this.label1.Text = "Öğrenci Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(12, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 24);
            this.label2.TabIndex = 56;
            this.label2.Text = "Öğrenci Soyadı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(12, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 24);
            this.label3.TabIndex = 57;
            this.label3.Text = "Öğrenci Bölümü";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(542, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 24);
            this.label4.TabIndex = 58;
            this.label4.Text = "Öğrenci TC No";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(542, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 24);
            this.label5.TabIndex = 59;
            this.label5.Text = "Öğrenci Okul No";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(542, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 24);
            this.label6.TabIndex = 60;
            this.label6.Text = "Öğrenci Cinsiyet";
            // 
            // txt_adi
            // 
            this.txt_adi.BackColor = System.Drawing.Color.Red;
            this.txt_adi.ForeColor = System.Drawing.Color.White;
            this.txt_adi.Location = new System.Drawing.Point(168, 138);
            this.txt_adi.Multiline = true;
            this.txt_adi.Name = "txt_adi";
            this.txt_adi.Size = new System.Drawing.Size(283, 42);
            this.txt_adi.TabIndex = 61;
            // 
            // txt_soyadi
            // 
            this.txt_soyadi.BackColor = System.Drawing.Color.Red;
            this.txt_soyadi.ForeColor = System.Drawing.Color.White;
            this.txt_soyadi.Location = new System.Drawing.Point(168, 205);
            this.txt_soyadi.Multiline = true;
            this.txt_soyadi.Name = "txt_soyadi";
            this.txt_soyadi.Size = new System.Drawing.Size(283, 44);
            this.txt_soyadi.TabIndex = 62;
            // 
            // txt_bolumu
            // 
            this.txt_bolumu.BackColor = System.Drawing.Color.Red;
            this.txt_bolumu.ForeColor = System.Drawing.Color.White;
            this.txt_bolumu.Location = new System.Drawing.Point(168, 280);
            this.txt_bolumu.Multiline = true;
            this.txt_bolumu.Name = "txt_bolumu";
            this.txt_bolumu.Size = new System.Drawing.Size(282, 44);
            this.txt_bolumu.TabIndex = 63;
            // 
            // txt_tcNo
            // 
            this.txt_tcNo.BackColor = System.Drawing.Color.Red;
            this.txt_tcNo.ForeColor = System.Drawing.Color.White;
            this.txt_tcNo.Location = new System.Drawing.Point(705, 138);
            this.txt_tcNo.Multiline = true;
            this.txt_tcNo.Name = "txt_tcNo";
            this.txt_tcNo.Size = new System.Drawing.Size(278, 42);
            this.txt_tcNo.TabIndex = 64;
            // 
            // txt_okulNo
            // 
            this.txt_okulNo.BackColor = System.Drawing.Color.Red;
            this.txt_okulNo.ForeColor = System.Drawing.Color.White;
            this.txt_okulNo.Location = new System.Drawing.Point(705, 205);
            this.txt_okulNo.Multiline = true;
            this.txt_okulNo.Name = "txt_okulNo";
            this.txt_okulNo.Size = new System.Drawing.Size(277, 44);
            this.txt_okulNo.TabIndex = 65;
            // 
            // txt_cinsiyet
            // 
            this.txt_cinsiyet.BackColor = System.Drawing.Color.Red;
            this.txt_cinsiyet.ForeColor = System.Drawing.Color.White;
            this.txt_cinsiyet.Location = new System.Drawing.Point(705, 280);
            this.txt_cinsiyet.Multiline = true;
            this.txt_cinsiyet.Name = "txt_cinsiyet";
            this.txt_cinsiyet.Size = new System.Drawing.Size(277, 44);
            this.txt_cinsiyet.TabIndex = 66;
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.BackColor = System.Drawing.Color.Red;
            this.btn_Ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Ekle.ForeColor = System.Drawing.Color.White;
            this.btn_Ekle.Location = new System.Drawing.Point(12, 354);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(969, 78);
            this.btn_Ekle.TabIndex = 67;
            this.btn_Ekle.Text = "Ekle";
            this.btn_Ekle.UseVisualStyleBackColor = false;
            this.btn_Ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // OgrenciEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 448);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Ekle);
            this.Controls.Add(this.txt_cinsiyet);
            this.Controls.Add(this.txt_okulNo);
            this.Controls.Add(this.txt_tcNo);
            this.Controls.Add(this.txt_bolumu);
            this.Controls.Add(this.txt_soyadi);
            this.Controls.Add(this.txt_adi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelMenuHorizontal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OgrenciEkle";
            this.Text = "OgrenciEkle";
            ((System.ComponentModel.ISupportInitialize)(this.AltaAl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kapat)).EndInit();
            this.panelMenuHorizontal.ResumeLayout(false);
            this.panelMenuHorizontal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelMenuHorizontal;
        private System.Windows.Forms.PictureBox AltaAl;
        private System.Windows.Forms.PictureBox kapat;
        public System.Windows.Forms.TextBox txt_cinsiyet;
        public System.Windows.Forms.TextBox txt_okulNo;
        public System.Windows.Forms.TextBox txt_tcNo;
        public System.Windows.Forms.TextBox txt_bolumu;
        public System.Windows.Forms.TextBox txt_soyadi;
        public System.Windows.Forms.TextBox txt_adi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_Ekle;
    }
}