using BusinessLogicServiceLayer;
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
    public partial class Form1 : Form
    {
        // Kullanacağımız iş katmanı metotları
        BusinessManager businessManager = new BusinessManager(new AccessDAO("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=AccessDB.mdb"), new StudentComplexCheckService(), new BookAllCheckService(), new BorrowedDeleteCheckService());
        // Kitaplar listelenecek
        public void kitap_listele()
        {
            if (businessManager.kitap_sayisi_ogren() == 0) // Eğer kitaplar tablosunda kitap yoksa 
            {
                dataGrid_kitap.DataSource = "";
            }
            //Kitap tablosunda kitap varsa
            else
            {
                // Kitapları listele ve colon başlıklarını değiştir
                dataGrid_kitap.DataSource = businessManager.kitap_listele().Tables[0];
                dataGrid_kitap.Columns[0].HeaderText = "Kitap ID";
                dataGrid_kitap.Columns[1].HeaderText = "Kitap İsmi";
                dataGrid_kitap.Columns[2].HeaderText = "Kitap Türü";
                dataGrid_kitap.Columns[3].HeaderText = "Kitap Yazarı";
                dataGrid_kitap.Columns[4].HeaderText = "Kitap Yayınevi";
                dataGrid_kitap.Columns[5].HeaderText = "Kitap Sayfası";
                dataGrid_kitap.Columns[6].HeaderText = "Kitap Adeti";
                //Başlıkların boyutunu ayarla
                dataGrid_kitap.Columns[0].Width = 87;
                dataGrid_kitap.Columns[1].Width = 150;
                dataGrid_kitap.Columns[2].Width = 150;
                dataGrid_kitap.Columns[3].Width = 150;
                dataGrid_kitap.Columns[4].Width = 150;
                dataGrid_kitap.Columns[5].Width = 150;
                dataGrid_kitap.Columns[6].Width = 87;

            }
        }
        // Program yüklenirken colon başlıklarının rengini değiştir ve kitapları listele
        private void kolonrenk_kitap_Load(object sender, EventArgs e)
        {
            dataGrid_kitap.EnableHeadersVisualStyles = false;
            dataGrid_kitap.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(205, 16, 2);
            dataGrid_kitap.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            kitap_listele();
            txt_aranacakKitap.Text = "ID veya İsmi";
        }
        public Form1()
        {
            InitializeComponent();
        }
        // Kitap ekleme işlemi için yeni bir form açılacak işlem bittikten sonra kitaplar tekrar listenecek.
        private void btn_kitapEkle_Click(object sender, EventArgs e)
        {
            kitapEkle fBookEkle = new kitapEkle();
            fBookEkle.ShowDialog();
            dataGrid_kitap.DataSource = businessManager.kitap_listele().Tables[0];
        }
        //Kitaplar listelenicek
        private void btn_kitapListele_Click(object sender, EventArgs e)
        {
            kitap_listele();
        }
        // Güncelleme işlemi için yeni bi form açılacak işlem bititkten sonra kitaplar tekrar listenecek.
        private void btn_kitapGuncelle_Click(object sender, EventArgs e)
        {
            kitapGuncelle kitapGuncelle = new kitapGuncelle();
            if (dataGrid_kitap.SelectedRows.Count > 0)
            { // book.check kontorl et ve kitaptan zaten varsa güncelleme 
                kitapGuncelle.label_id.Text = dataGrid_kitap.CurrentRow.Cells[0].Value.ToString();
                kitapGuncelle.txt_ismi.Text = dataGrid_kitap.CurrentRow.Cells[1].Value.ToString();
                kitapGuncelle.txt_turu.Text = dataGrid_kitap.CurrentRow.Cells[2].Value.ToString();
                kitapGuncelle.txt_yazari.Text = dataGrid_kitap.CurrentRow.Cells[3].Value.ToString();
                kitapGuncelle.txt_yayinevi.Text = dataGrid_kitap.CurrentRow.Cells[4].Value.ToString();
                kitapGuncelle.txt_sayfasi.Text = dataGrid_kitap.CurrentRow.Cells[5].Value.ToString();
                kitapGuncelle.txt_adeti.Text = dataGrid_kitap.CurrentRow.Cells[6].Value.ToString();
                kitapGuncelle.ShowDialog();
                // Güncelleme bilgileri forma aktarılacak.
                dataGrid_kitap.DataSource = businessManager.kitap_listele().Tables[0];

            }
            else
            {
                MessageBox.Show("Güncellemek istediğiniz kitabı seçiniz.");
            }
        }
        // İlgili kitabın teslim edilip edilmeme durumu kontrol edilecek.
        // Teslim edilmediyse emin misiniz penceresi açılacak.
        private void btn_kitapSil_Click(object sender, EventArgs e)
        {
            if (dataGrid_kitap.SelectedRows.Count > 0)
            {
                // id'yi birden çok kullanacağımız için bi değişkene atadık.
                int id = int.Parse(dataGrid_kitap.CurrentRow.Cells[0].Value.ToString());

                // Eğer kitabı teslim etmeyen öğrenci varsa uyarı mesajı gönderecek ve soracak.
                if (businessManager.odunc_kitap_teslim_edildiMi(id))
                {
                    DialogResult dialogResult = new DialogResult();
                    dialogResult = MessageBox.Show("Bu kitabı teslim etmeyen öğrenci bulunuyor. Silmek istediğinizden emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        businessManager.odunc_kitap_sil(id);
                        businessManager.kitap_sil(id); // Her iki tablodan da kitap silindi.
                        MessageBox.Show("Kitap her iki tablodan da silindi.");

                        kitap_listele();
                    }
                    else
                    {
                        MessageBox.Show("Silme işlemi yapılmadı.");
                    }
                }
                else
                { // kitap tablodan silinecek.
                    businessManager.odunc_kitap_sil(id);
                    businessManager.kitap_sil(id);
                    MessageBox.Show("Kitap silindi.");
                    kitap_listele();
                }
            }
            else
            {
                MessageBox.Show("Silmek istediğiniz öğrenceiyi seçiniz.");
            }
        }
        // Kitap için oluşturduğumuz ödünç formu açılacak.
        private void btn_oduncIslemleri_Click(object sender, EventArgs e)
        {
            kitapodunc kitapOdunc = new kitapodunc();
            if (dataGrid_kitap.SelectedRows.Count > 0)
            {
                // Kitap  id yi aktardık
               
                kitapOdunc.label_id.Text = dataGrid_kitap.CurrentRow.Cells[0].Value.ToString();
                kitapOdunc.ShowDialog();
                dataGrid_kitap.DataSource = businessManager.kitap_listele().Tables[0];
               
            }
            else
            {
                MessageBox.Show("Ödünç İşlemleri yapmak istediğiniz öğrenciyi seçiniz.");
            }
        }
        // Arnacak kitap için oluşturduğumuz text kısmında ID veya Ad ile arama yapması için ipucu bırakıyoruz.
        // bu kısma tıkladığında text silinecek, tekrar geri çektiğimizde tekrardan ipucumuz yazacak.
        // eğer içerisine bir şey yazdıysak silinmeyecek.
        private void txt_aranacakKitap_Enter(object sender, EventArgs e)
        {
            if (txt_aranacakKitap.Text.Equals("ID veya İsmi"))
            {
                txt_aranacakKitap.Text = "";
            }
        }

        private void txt_aranacakKitap_Leave(object sender, EventArgs e)
        {
            if (txt_aranacakKitap.Text.Equals(""))
            {
                txt_aranacakKitap.Text = "ID veya İsmi";
            }
        }
        // Colonlara tıklandığında sıralama işlemi yapmayacak.
        private void dataGrid_kitap_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            e.Column.SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void btn_kitapAra_Click(object sender, EventArgs e)
        {

            if (txt_aranacakKitap.Text.Equals("ID veya İsmi"))
            {
                MessageBox.Show("Arama yapmak için ID veya Kitap İsmini giriniz.");
            }
            else
            {
                dataGrid_kitap.DataSource = businessManager.kitap_ara(txt_aranacakKitap.Text).Tables[0];
            }
        }
    }
}
