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
    public partial class Ogrenci : Form
    {
        public Ogrenci()
        {
            InitializeComponent();
        }
        // ekranın yerini değiştirmek için gerekli dll
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("USER32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        // kullanacağımız iş katmanı metotları
        BusinessManager businessManager = new BusinessManager(new AccessDAO("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=AccessDB.mdb"), new StudentComplexCheckService(), new BookAllCheckService(), new BorrowedDeleteCheckService());


        // form kapatılacak
        private void icon_delete_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // form alta inecek
        private void icon_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // ekranın yeri değişecek
        private void panelMenuHorizontal_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Ogrenciler_Load(object sender, EventArgs e)
        {
            dataGrid_Kitaplar.EnableHeadersVisualStyles = false; // başlık rengi değişimi için bunu false yapıyoruz.
            dataGrid_Kitaplar.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(205, 16, 2);
            dataGrid_Kitaplar.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dataGrid_Kitaplar.DataSource = businessManager.ogrenci_ara(label_id.Text).Tables[0];
            // kolon isimlerini değiştir
            dataGrid_Kitaplar.Columns[0].HeaderText = "Öğrenci ID";
            dataGrid_Kitaplar.Columns[1].HeaderText = "Öğrenci Adı";
            dataGrid_Kitaplar.Columns[2].HeaderText = "Öğrenci Soyadı";
            dataGrid_Kitaplar.Columns[3].HeaderText = "Öğrenci Bölümü";
            dataGrid_Kitaplar.Columns[4].HeaderText = "Öğrenci Tc Numarası";
            dataGrid_Kitaplar.Columns[5].HeaderText = "Öğrenci Borcu";
            dataGrid_Kitaplar.Columns[6].HeaderText = "Öğrenci Cinsiyeti";
            dataGrid_Kitaplar.Columns[7].HeaderText = "Öğrenci Okul Numarası";
            dataGrid_Kitaplar.Columns[0].Width = 70;
            dataGrid_Kitaplar.Columns[1].Width = 100;
            dataGrid_Kitaplar.Columns[2].Width = 100;
            dataGrid_Kitaplar.Columns[3].Width = 100;
            dataGrid_Kitaplar.Columns[4].Width = 200;
            dataGrid_Kitaplar.Columns[5].Width = 200;
            dataGrid_Kitaplar.Columns[6].Width = 90;
            
            dataGrid_Kitaplar.ClearSelection(); // başlangıçta seçili gelmeyecek.
        }
    }
}
