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
    public partial class Ogrenciler : Form
    {
        public Ogrenciler()
        {
            InitializeComponent();
        }

        // kullanacağımız iş katmanı metotları
        BusinessManager businessManager = new BusinessManager(new AccessDAO("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=AccessDB.mdb"), new StudentComplexCheckService(), new BookAllCheckService(), new BorrowedDeleteCheckService());

        

        //  öğrencileri listeleyecez
        private void ogrenci_goster()
        {
            if (businessManager.ogrenci_sayisi_ogren() > 0) // öğrenci varsa listele
            {
                dataGrid_Ogrenciler.DataSource = "";
                dataGrid_Ogrenciler.DataSource = businessManager.ogrenci_listele().Tables[0];
                // kolon isimlerini değiştir
                dataGrid_Ogrenciler.Columns[0].HeaderText = "Öğrenci ID";
                dataGrid_Ogrenciler.Columns[1].HeaderText = "Öğrenci Adı";
                dataGrid_Ogrenciler.Columns[2].HeaderText = "Öğrenci Soyadı";
                dataGrid_Ogrenciler.Columns[3].HeaderText = "Öğrenci Bölümü";
                dataGrid_Ogrenciler.Columns[4].HeaderText = "Öğrenci Tc Numarası";
                dataGrid_Ogrenciler.Columns[5].HeaderText = "Öğrenci Okul Numarası"; 
                dataGrid_Ogrenciler.Columns[6].HeaderText = "Öğrenci Cinsiyeti"; 
                dataGrid_Ogrenciler.Columns[7].HeaderText = "Öğrenci Borcu";
                dataGrid_Ogrenciler.Columns[0].Width = 80;
                dataGrid_Ogrenciler.Columns[1].Width = 150;
                dataGrid_Ogrenciler.Columns[2].Width = 150;
                dataGrid_Ogrenciler.Columns[3].Width = 150;
                dataGrid_Ogrenciler.Columns[4].Width = 150;
                dataGrid_Ogrenciler.Columns[5].Width = 150;
                dataGrid_Ogrenciler.Columns[6].Width = 80;
                dataGrid_Ogrenciler.Columns[7].Width = 150;
                dataGrid_Ogrenciler.ClearSelection(); // başlangıçta seçili gelmeyecek.

               
            }
        }

        // program yüklenirken kolon isimlerini değiştir ve öğrencileri listele
        private void Ogrenciler_Load(object sender, EventArgs e)
        {
            dataGrid_Ogrenciler.EnableHeadersVisualStyles = false;
            dataGrid_Ogrenciler.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(205, 16, 2);
            dataGrid_Ogrenciler.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            ogrenci_goster();
            dataGrid_Ogrenciler.ClearSelection(); // başlangıçta seçili gelmeyecek.
            txt_aranacakOgrenci.Text = "ID veya Ad";
        }
        

        // ekleme işlemi için bi form açılacak ve işlem bittikten sonra öğrenciler listelenecek.
        private void btn_ogrenciEkle_Click(object sender, EventArgs e)
        {
            OgrenciEkle OgrenciEkle = new OgrenciEkle();
            OgrenciEkle.ShowDialog();
            ogrenci_goster();
            dataGrid_Ogrenciler.ClearSelection(); // başlangıçta seçili gelmeyecek.
        }

        // guncelleme işlemi için bi form açılacak ve işlem bittikten sonra öğrenciler listelenecek.
        private void btn_ogrenciGuncelle_Click(object sender, EventArgs e)
        {
            OgrenciGuncelle ogrenciGuncelle = new OgrenciGuncelle();
            if (dataGrid_Ogrenciler.SelectedRows.Count > 0) // seçili öğrenci varsa
            {
                ogrenciGuncelle.label_id.Text = dataGrid_Ogrenciler.CurrentRow.Cells[0].Value.ToString();
                ogrenciGuncelle.txt_adi.Text = dataGrid_Ogrenciler.CurrentRow.Cells[1].Value.ToString();
                ogrenciGuncelle.txt_soyadi.Text = dataGrid_Ogrenciler.CurrentRow.Cells[2].Value.ToString();
                ogrenciGuncelle.txt_bolumu.Text = dataGrid_Ogrenciler.CurrentRow.Cells[3].Value.ToString();
                ogrenciGuncelle.txt_tcNo.Text = dataGrid_Ogrenciler.CurrentRow.Cells[4].Value.ToString();
                ogrenciGuncelle.txt_okulNo.Text = dataGrid_Ogrenciler.CurrentRow.Cells[5].Value.ToString();
                ogrenciGuncelle.txt_cinsiyet.Text = dataGrid_Ogrenciler.CurrentRow.Cells[6].Value.ToString();
                ogrenciGuncelle.ShowDialog(); // başlangıç olarak öğrencinin bilgilierini diğer forma gönderiyoruz
                ogrenci_goster();
                dataGrid_Ogrenciler.ClearSelection(); // başlangıçta seçili gelmeyecek.
            }
            else
            {
                MessageBox.Show("Güncellemek istediğiniz öğrenciyi seçiniz.");
            }
        }

        // ödünç tablosunda öğrenci var mı kontrol edecek.
        // eğer teslim etmediği kitap varsa emin misiniz diye soracak.
        private void btn_ogrenciSil_Click(object sender, EventArgs e)
        {
            if (dataGrid_Ogrenciler.SelectedRows.Count > 0) // seçili öğrenci vrasa
            {
                // id'yi birden çok kullanacağımız için bi değişkene atadık.
                int id = int.Parse(dataGrid_Ogrenciler.CurrentRow.Cells[0].Value.ToString());

                // eğer öğrencinin teslim etmediği kitap varsa uyarı mesajı gönderecek ve soracak.
                if (!businessManager.odunc_teslim_edildiMi(id))
                {
                    DialogResult dialogResult = new DialogResult();
                    dialogResult = MessageBox.Show("Bu öğrencinin teslim etmediği kitap bulunuyor. Silmek istediğinizden emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        businessManager.odunc_ogrenci_sil(id);
                        businessManager.ogrenci_sil(id); // her iki tablodan da öğrenci silindi.
                        MessageBox.Show("Öğrenci her iki tablodan da silindi.");
                        ogrenci_goster();
                        dataGrid_Ogrenciler.ClearSelection(); // başlangıçta seçili gelmeyecek.
                    }
                    else
                    {
                        MessageBox.Show("Silme işlemi yapılmadı.");
                    }
                }
                else
                { // öğrenci tablodan silinecek.
                    businessManager.odunc_ogrenci_sil(id);
                    businessManager.ogrenci_sil(id);
                    MessageBox.Show("Öğrenci silindi.");
                    ogrenci_goster();
                    dataGrid_Ogrenciler.ClearSelection(); // başlangıçta seçili gelmeyecek.
                }

            }
            else
            {
                MessageBox.Show("Silmek istediğiniz öğrenceiyi seçiniz.");
            }
        }

        // seçili öğrenci varsa ödünç işlemleri için yeni bi form açılacak.
        // bu formlara id'leri gönderiyoruz. !
        // işlemden sonra öğrenci için listeleme işlemi tekrar yapılacak.
        private void btn_oduncIslemleri_Click(object sender, EventArgs e)
        {
            OgrenciOdunc ogrenciOdunc = new OgrenciOdunc();
            if (dataGrid_Ogrenciler.SelectedRows.Count > 0)
            {
                ogrenciOdunc.label_id.Text = dataGrid_Ogrenciler.CurrentRow.Cells[0].Value.ToString();
                ogrenciOdunc.ShowDialog();
                ogrenci_goster();
                dataGrid_Ogrenciler.ClearSelection(); // başlangıçta seçili gelmeyecek.
                
            }
            else
            {
                MessageBox.Show("Ödünç İşlemleri yapmak istediğiniz öğrenciyi seçiniz.");
            }
        }

        // öğrenci varsa listeleyecek.
        // yoksa uyarı mesajı
        private void btn_ogrenciListele_Click(object sender, EventArgs e)
        {
            if (businessManager.ogrenci_sayisi_ogren() == 0)
            {
                MessageBox.Show("Kütüphanede kayıtlı öğrenci yok.");
            }
            else
            {
                ogrenci_goster();
                dataGrid_Ogrenciler.ClearSelection(); // başlangıçta seçili gelmeyecek.
            }
        }

        // txt içi dolu değilse uyarı mesajı, doluysa arayacak.
        private void btn_ogrenciAra_Click(object sender, EventArgs e)
        {
            if (txt_aranacakOgrenci.Text.Equals("ID veya Ad"))
            {
                MessageBox.Show("Arama yapmak için ID veya Öğrenci Adını giriniz.");
            }
            else
            {
                dataGrid_Ogrenciler.DataSource = businessManager.ogrenci_ara(txt_aranacakOgrenci.Text).Tables[0];
            }
        }

        // arnacak öğrenci için oluşturduğumuz text kısmında ID veya Ad ile arama yapması için ipucu bırakıyoruz.
        // bu kısma tıkladığında text silinecek, tekrar geri çektiğimizde tekrardan ipucumuz yazacak.
        // eğer içerisine bir şey yazdıysak silinmeyecek.
        private void txt_aranacakOgrenci_Enter(object sender, EventArgs e)
        {
            if (txt_aranacakOgrenci.Text.Equals("ID veya Ad"))
            {
                txt_aranacakOgrenci.Text = "";
            }
        }

        private void txt_aranacakOgrenci_Leave(object sender, EventArgs e)
        {
            if (txt_aranacakOgrenci.Text.Equals(""))
            {
                txt_aranacakOgrenci.Text = "ID veya Ad";
            }
        }

        // colon sıralamaları iptal
        private void dataGrid_student_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            e.Column.SortMode = DataGridViewColumnSortMode.NotSortable;

        }
    }
}
