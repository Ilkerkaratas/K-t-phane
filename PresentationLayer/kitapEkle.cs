using BusinessLogicServiceLayer;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class kitapEkle : Form
    {
        public kitapEkle()
        {
            InitializeComponent();
        }
        // Ekranın yerini değiştirmek için gerekli dll
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("USER32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        // Textlerin boş olup olmadığını kontrol etme metodu
        public Boolean textler_bosMu()
        {
            if (txt_ismi.Text.Equals("") || txt_turu.Text.Equals("") || txt_yazari.Text.Equals("") || txt_yayinevi.Text.Equals("") || txt_sayfasi.Text.Equals("") || txt_adeti.Text.Equals(""))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        // Kullanacağımız iş katmanı metotları
        BusinessManager businessManager = new BusinessManager(new AccessDAO("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=AccessDB.mdb"), new StudentComplexCheckService(), new BookAllCheckService(), new BorrowedDeleteCheckService());


       
        //Form kapanacak
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Formu alta alacak
        private void AltaAl_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //Formun yerini değiştirecek
        private void panelMenuHorizontal_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void btn_ekle_Click(object sender, EventArgs e)
        {
            if (textler_bosMu())
            {
                MessageBox.Show("Lütfen boş Alan Bırakmayınız...");
            }
            else
            {
                if (businessManager.kitap_ekle(txt_ismi.Text, txt_turu.Text, txt_yazari.Text, txt_yayinevi.Text, int.Parse(txt_sayfasi.Text), int.Parse(txt_adeti.Text)))
                {
                    MessageBox.Show("Bu bilgilere ait kitap zaten var. Ekleme işlemi başarısız.");
                }
                else
                {    
                    MessageBox.Show("Ekleme işlemi başarılı.");
                    this.Close();
                }
            }
        }
    }
}
