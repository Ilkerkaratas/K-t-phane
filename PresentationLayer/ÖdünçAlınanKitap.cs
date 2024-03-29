﻿using BusinessLogicServiceLayer;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class ÖdünçAlınanKitap : Form
    {
        public ÖdünçAlınanKitap()
        {
            InitializeComponent();
        }
        // kullanacağımız iş katmanı metotları
        BusinessManager businessManager = new BusinessManager(new AccessDAO("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=AccessDB.mdb"), new StudentComplexCheckService(), new BookAllCheckService(), new BorrowedDeleteCheckService());

        // Ödünç listeleme işlemini tekrar tekrar kullanacağımız için metot olarak yazdık. gerektiğinde kullanacaz. 
        private void odunc_listesini_goster()
        {
            if (businessManager.odunc_alinan_kitap_sayisi() == 0)
            {
                dataGrid_odunc.DataSource = ""; // kitap sayısı 0 sa ekranı temizleyecez
                label_bilgilendirme.Text = "Henüz ödünç alma işlemi yapılmamış.";
                label_bilgilendirme.Visible = true; // ödünç alan öğrenci yoksa, ekranda bilgilendirme mesajı olacak.
            }
            else
            {  // eğer en az 1 tane veri varsa listeleme işlemi yapacak.
                dataGrid_odunc.DataSource = businessManager.odunc_listele().Tables[0];
                // tablo başlıklarını değiştirme kodu
                dataGrid_odunc.Columns[0].HeaderText = "Ödünç ID";
                dataGrid_odunc.Columns[1].HeaderText = "Öğrenci ID";
                dataGrid_odunc.Columns[2].HeaderText = "Kitap ID";
                dataGrid_odunc.Columns[3].HeaderText = "Ödünç Alma Tarihi";
                dataGrid_odunc.Columns[4].HeaderText = "Teslim Etme Tarihi";
                dataGrid_odunc.Columns[5].HeaderText = "Öğrenci Borcu";
                //boyutlarını ayarlama kodu
                dataGrid_odunc.Columns[0].Width = 150;
                dataGrid_odunc.Columns[1].Width = 150;
                dataGrid_odunc.Columns[2].Width = 150;
                dataGrid_odunc.Columns[3].Width = 200;
                dataGrid_odunc.Columns[4].Width = 200;
                dataGrid_odunc.Columns[5].Width = 150;

                // ödünç alınan kitap sayısını yazdıracak.
                label_bilgilendirme.Text = "Ödünç Alınan kitap sayısı: " + businessManager.odunc_alinan_kitap_sayisi().ToString();
            }
        }

        // 20 günlük teslim süresini geçtiyse kırmızı, 2 gün kaldıysa sarı, teslim ettiyse yeşil renkte gözükecek.
        // diğer durumlar beyaz.
        private void grid_renkleri_degistir(DataGridView dataGridView)
        {

            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                DataGridViewCellStyle renk = new DataGridViewCellStyle(); // istediğiimiz renkleri atayacağımız nesne
                
                if (!(dataGridView.Rows[i].Cells["odunc_teslim_tarihi"].Value.ToString()).Equals("Teslim edilmedi"))
                {// eğer öğrenci kitabı teslim ettiyse
                    renk.BackColor = Color.FromArgb(44,212,100); // yeşil tonu arka plan
                    renk.ForeColor = Color.FromArgb(255, 255, 240); // beyaz tonu yazı rengi
                }
                else
                {
                    // 20 gün teslim süresi
                    // kalan zamanın bilgisini bize getirecek.
                    int gecen_zaman = businessManager.odunc_teslim_zaman_kontrol(int.Parse(dataGridView.Rows[i].Cells["odunc_id"].Value.ToString()));

                    if (gecen_zaman > 20) // eğer teslim tarihi geçtiyse
                    {
                        renk.BackColor = Color.FromArgb(252, 35, 35); // kırmızı tonu
                        renk.ForeColor = Color.FromArgb(192, 192, 192); // beyaz tonu

                        int ogrenci_borc = gecen_zaman - 15; // öğrenci borcunu güncelliyoruz.
                        businessManager.odunc_ogrenci_borc_guncelle(int.Parse(dataGridView.Rows[i].Cells["odunc_id"].Value.ToString()), ogrenci_borc);
                        businessManager.ogrenci_borc_guncelle(int.Parse(dataGridView.Rows[i].Cells["ogrenci_id"].Value.ToString()), ogrenci_borc);
                    }
                    else if (gecen_zaman >= 18) // eğer teslim tarihine 2 gün kaldıysa
                    {
                        renk.BackColor = Color.FromArgb(196, 212, 54); // sarı tonu
                        renk.ForeColor = Color.FromArgb(85, 93, 80); 

                    }
                }
                dataGridView.Rows[i].DefaultCellStyle = renk; // rowun o satırına ilgili rengi yerleştiriyoruz.
            }
        }

        // program çalıştığı gibi 
        private void ÖdünçAlınanKitap_Load(object sender, EventArgs e)
        {
            dataGrid_odunc.EnableHeadersVisualStyles = false; // başlık rengi değişimi için bunu false yapıyoruz.
            dataGrid_odunc.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(205, 16, 2);
            dataGrid_odunc.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            
            // program çalıştığı gibi header kısmı mavinin bir tonu olan renge bürünecek.
            txt_aranacakOdunc.Text = "Ödünç ID, Kitap ID veya Öğrenci ID"; // arama işlemi için bilgilendirme mesajı

        }

        // Ödünç listele butonuna tıkladığımızda
        private void btn_oduncListele_Click(object sender, EventArgs e)
        {
            dataGrid_odunc.Visible = true;
            odunc_listesini_goster(); // yazdığımız metotu burada kullanıyoruz. başlangıç olarak ödünç alanlar listeleniyor.
            grid_renkleri_degistir(dataGrid_odunc); // tabloda duruma göre renkler gözükecek.
            dataGrid_odunc.ClearSelection(); // başlangıçta seçili gelmeyecek.
            
        }

        // başlıklara tıklandığında sıralama işlemi yapılmayacak.
        private void dataGrid_odunc_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            e.Column.SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        // kitabı gör butonuna tıklandığında
        private void btn_kitabiGor_Click(object sender, EventArgs e)
        {
            KitapGoruntule kitap_goruntule = new KitapGoruntule(); // Kitap için oluşturduğumuz ödünç formunu açacak.
            if (dataGrid_odunc.SelectedRows.Count > 0)
            {   // kitap id yi yolluyoruz.
                kitap_goruntule.label_id.Text = dataGrid_odunc.CurrentRow.Cells[2].Value.ToString();
                kitap_goruntule.ShowDialog();
                odunc_listesini_goster(); // ödünç alanlar listeleniyor.

                dataGrid_odunc.ClearSelection(); // başlangıçta seçili gelmeyecek.
                grid_renkleri_degistir(dataGrid_odunc); // tabloda duruma göre renkler gözükecek.
                //dataGrid_student.DataSource = businessManager.odunc_ogrenci_listele(int.Parse(dataGrid_student.CurrentRow.Cells[0].Value.ToString())).Tables[0];
            }
            else
            {
                MessageBox.Show("Kitap bilgilerini görmek istediğiniz ödünç alma bilgisini seçiniz.");
            }
        }

        // öğrenciyi gör butonuna tıklandığında
        private void btn_ogrenciyiGor_Click(object sender, EventArgs e)
        {
            OgrenciOdunc ogrenci_odunc = new OgrenciOdunc(); // öğrenci için oluşturduğumuz ödünç formu ekrana gelecek.
            if (dataGrid_odunc.SelectedRows.Count > 0)
            {   // ogrenci id yi yolluyoruz.
                ogrenci_odunc.label_id.Text = dataGrid_odunc.CurrentRow.Cells[1].Value.ToString();
                ogrenci_odunc.ShowDialog();
                odunc_listesini_goster(); // ödünç alanlar listeleniyor.
                dataGrid_odunc.ClearSelection(); // başlangıçta seçili gelmeyecek.
                grid_renkleri_degistir(dataGrid_odunc); // tabloda duruma göre renkler gözükecek.
                //dataGrid_student.DataSource = businessManager.odunc_ogrenci_listele(int.Parse(dataGrid_student.CurrentRow.Cells[0].Value.ToString())).Tables[0];
            }
            else
            {
                MessageBox.Show("Kitap bilgilerini görmek istediğiniz ödünç alma bilgisini seçiniz.");
            }
        }

        // ara butonuna tıklandığında txt de yazılana göre arama işlemi yapacak.
        private void btn_oduncAra_Click(object sender, EventArgs e)
        {
            if (txt_aranacakOdunc.Text.Equals("Ödünç ID, Kitap ID veya Öğrenci ID"))
            {
                MessageBox.Show("Arama yapmak Ödünç ID, Kitap ID veya Öğrenci ID giriniz.");
            } // eğer aranacak bir şey yazmadıysa hata mesajı döndürecek.
            else
            {
                dataGrid_odunc.DataSource = businessManager.odunc_ara(txt_aranacakOdunc.Text).Tables[0];
                dataGrid_odunc.ClearSelection(); // başlangıçta seçili gelmeyecek.
                grid_renkleri_degistir(dataGrid_odunc); // tabloda duruma göre renkler gözükecek.
            }
        }

        // txt nin içine tıklandığında içi temizlenecek
        private void txt_aranacakOdunc_Enter(object sender, EventArgs e)
        {
            if (txt_aranacakOdunc.Text.Equals("Ödünç ID, Kitap ID veya Öğrenci ID"))
            {
                txt_aranacakOdunc.Text = "";
            }
        }

        // başka bir yere tıkladığımızda txt nin içi tekrardan dolacak.
        private void txt_aranacakOdunc_Leave(object sender, EventArgs e)
        {
            if (txt_aranacakOdunc.Text.Equals(""))
            {
                txt_aranacakOdunc.Text = "Ödünç ID, Kitap ID veya Öğrenci ID";
            }

        }

        // çift tıklandığında ilgili kitabın bilgileri ekrana gelecek.
        private void dataGrid_odunc_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            KitapGoruntule Kitap_goruntule = new KitapGoruntule(); dataGrid_odunc.DataSource = businessManager.kitap_ara(dataGrid_odunc.CurrentRow.Cells[2].Value.ToString()).Tables[0];
            // book.check kontorl et ve kitaptan zaten varsa güncelleme
            Kitap_goruntule.label_id.Text = dataGrid_odunc.CurrentRow.Cells[0].Value.ToString();
            Kitap_goruntule.ShowDialog();
            btn_oduncListele_Click(sender, e);
            // güncelleme bilgileri forma aktarılacak.

        }
    }
}
