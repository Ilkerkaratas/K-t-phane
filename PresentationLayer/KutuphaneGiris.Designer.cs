
namespace PresentationLayer
{
    partial class KutuphaneGiris
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
            this.panelMenuHorizontal = new System.Windows.Forms.Panel();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.btn_zedgraph = new System.Windows.Forms.Button();
            this.btn_Odunc = new System.Windows.Forms.Button();
            this.btn_kitap = new System.Windows.Forms.Button();
            this.btn_Ogrenci = new System.Windows.Forms.Button();
            this.btn_AnaEkran = new System.Windows.Forms.Button();
            this.btn_kapat = new System.Windows.Forms.PictureBox();
            this.btn_altaAl = new System.Windows.Forms.PictureBox();
            this.panelMenuHorizontal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_kapat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_altaAl)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenuHorizontal
            // 
            this.panelMenuHorizontal.Controls.Add(this.btn_kapat);
            this.panelMenuHorizontal.Controls.Add(this.btn_altaAl);
            this.panelMenuHorizontal.Location = new System.Drawing.Point(1, 1);
            this.panelMenuHorizontal.Name = "panelMenuHorizontal";
            this.panelMenuHorizontal.Size = new System.Drawing.Size(1255, 50);
            this.panelMenuHorizontal.TabIndex = 2;
            this.panelMenuHorizontal.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelMenuHorizontal_MouseDown);
            // 
            // panelContainer
            // 
            this.panelContainer.Location = new System.Drawing.Point(1, 142);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1246, 818);
            this.panelContainer.TabIndex = 44;
            // 
            // btn_zedgraph
            // 
            this.btn_zedgraph.BackColor = System.Drawing.Color.Red;
            this.btn_zedgraph.ForeColor = System.Drawing.Color.White;
            this.btn_zedgraph.Image = global::PresentationLayer.Properties.Resources.icons8_graph_64;
            this.btn_zedgraph.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_zedgraph.Location = new System.Drawing.Point(890, 57);
            this.btn_zedgraph.Name = "btn_zedgraph";
            this.btn_zedgraph.Size = new System.Drawing.Size(256, 81);
            this.btn_zedgraph.TabIndex = 4;
            this.btn_zedgraph.Text = "Zedgraph";
            this.btn_zedgraph.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_zedgraph.UseVisualStyleBackColor = false;
            this.btn_zedgraph.Click += new System.EventHandler(this.btn_zedgraph_Click);
            // 
            // btn_Odunc
            // 
            this.btn_Odunc.BackColor = System.Drawing.Color.Red;
            this.btn_Odunc.ForeColor = System.Drawing.Color.White;
            this.btn_Odunc.Image = global::PresentationLayer.Properties.Resources.icons8_give_80;
            this.btn_Odunc.Location = new System.Drawing.Point(674, 57);
            this.btn_Odunc.Name = "btn_Odunc";
            this.btn_Odunc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Odunc.Size = new System.Drawing.Size(198, 81);
            this.btn_Odunc.TabIndex = 3;
            this.btn_Odunc.Text = "Ödünç";
            this.btn_Odunc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Odunc.UseVisualStyleBackColor = false;
            this.btn_Odunc.UseWaitCursor = true;
            this.btn_Odunc.Click += new System.EventHandler(this.btn_Odunc_Click);
            // 
            // btn_kitap
            // 
            this.btn_kitap.BackColor = System.Drawing.Color.Red;
            this.btn_kitap.ForeColor = System.Drawing.Color.White;
            this.btn_kitap.Image = global::PresentationLayer.Properties.Resources.icons8_book_64;
            this.btn_kitap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_kitap.Location = new System.Drawing.Point(446, 57);
            this.btn_kitap.Name = "btn_kitap";
            this.btn_kitap.Size = new System.Drawing.Size(222, 81);
            this.btn_kitap.TabIndex = 2;
            this.btn_kitap.Text = "Kitap";
            this.btn_kitap.UseVisualStyleBackColor = false;
            this.btn_kitap.Click += new System.EventHandler(this.btn_Kitap_Click);
            // 
            // btn_Ogrenci
            // 
            this.btn_Ogrenci.BackColor = System.Drawing.Color.Red;
            this.btn_Ogrenci.ForeColor = System.Drawing.Color.White;
            this.btn_Ogrenci.Image = global::PresentationLayer.Properties.Resources.Student_3_icon;
            this.btn_Ogrenci.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Ogrenci.Location = new System.Drawing.Point(221, 57);
            this.btn_Ogrenci.Name = "btn_Ogrenci";
            this.btn_Ogrenci.Size = new System.Drawing.Size(219, 81);
            this.btn_Ogrenci.TabIndex = 1;
            this.btn_Ogrenci.Text = "Öğrenci";
            this.btn_Ogrenci.UseVisualStyleBackColor = false;
            this.btn_Ogrenci.Click += new System.EventHandler(this.btn_Ogrenci_Click);
            // 
            // btn_AnaEkran
            // 
            this.btn_AnaEkran.BackColor = System.Drawing.Color.Red;
            this.btn_AnaEkran.ForeColor = System.Drawing.Color.White;
            this.btn_AnaEkran.Image = global::PresentationLayer.Properties.Resources.Home_icon;
            this.btn_AnaEkran.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AnaEkran.Location = new System.Drawing.Point(4, 57);
            this.btn_AnaEkran.Name = "btn_AnaEkran";
            this.btn_AnaEkran.Size = new System.Drawing.Size(211, 81);
            this.btn_AnaEkran.TabIndex = 0;
            this.btn_AnaEkran.Text = "Ana Ekran";
            this.btn_AnaEkran.UseVisualStyleBackColor = false;
            this.btn_AnaEkran.Click += new System.EventHandler(this.btn_AnaEkran_Click);
            // 
            // btn_kapat
            // 
            this.btn_kapat.Image = global::PresentationLayer.Properties.Resources.icons8_close_50;
            this.btn_kapat.Location = new System.Drawing.Point(1185, 3);
            this.btn_kapat.Name = "btn_kapat";
            this.btn_kapat.Size = new System.Drawing.Size(51, 39);
            this.btn_kapat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_kapat.TabIndex = 34;
            this.btn_kapat.TabStop = false;
            this.btn_kapat.Click += new System.EventHandler(this.btn_kapat_Click_1);
            // 
            // btn_altaAl
            // 
            this.btn_altaAl.Image = global::PresentationLayer.Properties.Resources.icons8_minimize_window_50;
            this.btn_altaAl.Location = new System.Drawing.Point(1128, 3);
            this.btn_altaAl.Name = "btn_altaAl";
            this.btn_altaAl.Size = new System.Drawing.Size(51, 39);
            this.btn_altaAl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_altaAl.TabIndex = 33;
            this.btn_altaAl.TabStop = false;
            this.btn_altaAl.Click += new System.EventHandler(this.btn_altaAl_Click_1);
            // 
            // KutuphaneGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 971);
            this.ControlBox = false;
            this.Controls.Add(this.btn_zedgraph);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.btn_Odunc);
            this.Controls.Add(this.btn_kitap);
            this.Controls.Add(this.btn_Ogrenci);
            this.Controls.Add(this.btn_AnaEkran);
            this.Controls.Add(this.panelMenuHorizontal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KutuphaneGiris";
            this.Text = "KutuphaneGiris";
            this.Load += new System.EventHandler(this.KutuphaneGiris_Load);
            this.panelMenuHorizontal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_kapat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_altaAl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMenuHorizontal;
        private System.Windows.Forms.PictureBox btn_kapat;
        private System.Windows.Forms.PictureBox btn_altaAl;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Button btn_AnaEkran;
        private System.Windows.Forms.Button btn_Ogrenci;
        private System.Windows.Forms.Button btn_Odunc;
        private System.Windows.Forms.Button btn_kitap;
        private System.Windows.Forms.Button btn_zedgraph;
    }
}