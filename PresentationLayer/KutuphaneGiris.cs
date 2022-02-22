using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices; // Programı ekranda gezdirmek için gerekli

namespace PresentationLayer
{
    public partial class KutuphaneGiris : Form
    {
        public KutuphaneGiris()
        {
            InitializeComponent();
        }
        
        private void KutuphaneGiris_Load(object sender, EventArgs e)
        {
            openPanel(new Ana_Ekran()); // KütüphaneGiris formunun containerinda Ana_Ekran formu açılacak.
        }
        //  Program çalışırken ekranın konumunu değiştirmek için gerekli
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("USER32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btn_AnaEkran_Click(object sender, EventArgs e)
        {
            openPanel(new Ana_Ekran()); // KütüphaneGiris formunun containerinde Ana_Ekran formu açılacak.
        }
        


        // Programın masaüstünde istediğimiz gibi yerini değiştirmemiz için gerekli method 
        private void panelMenuHorizontal_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        // Container panel de başka bir form çağırma
        private void openPanel(object formLast) // Form objesini parametre olarak yollayacğaız
        {
            if (this.panelContainer.Controls.Count > 0) // panelde bir eleman varsa üst üste gelmemesi için temizleyecez
            {
                this.panelContainer.Controls.RemoveAt(0); // veya Clear olabilir. kontrol et.
            }
            Form fl = formLast as Form; // yeni bir form oluşturuyoruz.
            fl.TopLevel = false;
            fl.Dock = DockStyle.Fill; // oluşturduğumuz formun ekranda nasıl gözükeceği 
            this.panelContainer.Controls.Add(fl); // formu control olarak ekliyoruz.
            this.panelContainer.Tag = fl;
            fl.Show(); // ekranda gösteriyoruz.
        }

        private void btn_Ogrenci_Click(object sender, EventArgs e)
        {
            openPanel(new Ogrenciler()); // KütüphaneGiris formunun containerinda Öğrenciler formu açılacak.
        }

        private void btn_Kitap_Click(object sender, EventArgs e)
        {
            openPanel(new Form1()); // Kitap formu açılacak.
        }

        private void btn_Odunc_Click(object sender, EventArgs e)
        {
            openPanel(new ÖdünçAlınanKitap()); // Ödünç formu açılacak.
        }

       
        // Program alta inecek
        private void btn_altaAl_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        // çarpıya tıklandığında rogram kapatılacak
        private void btn_kapat_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btn_zedgraph_Click(object sender, EventArgs e)
        {
            openPanel(new zedgraph()); // zedgraph formu açılacak.
        }
    }
}
