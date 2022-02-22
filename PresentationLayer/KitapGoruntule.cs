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
    public partial class KitapGoruntule : Form
    {
        public KitapGoruntule()
        {
            InitializeComponent();
        }
        // Ekranın yerini değiştirmek için gerekli dll
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("USER32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        // Kullanacağımız iş katmanı metotları
        BusinessManager businessManager = new BusinessManager(new AccessDAO("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=AccessDB.mdb"), new StudentComplexCheckService(), new BookAllCheckService(), new BorrowedDeleteCheckService());

        // Form kapatılacak
        private void Kapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Form alta inecek
        private void AltaAl_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // Ekranın yeri değişecek
        private void panelMenuHorizontal_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void   KitapGoruntule_Load(object sender, EventArgs e)
        {
            dataGrid_kitap.EnableHeadersVisualStyles = false; //  Başlıkların rengini değiştirmek için bunu false yapıyoruz.
            dataGrid_kitap.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(205, 16, 2);
            dataGrid_kitap.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dataGrid_kitap.DataSource = businessManager.kitap_ara(label_id.Text).Tables[0];
            dataGrid_kitap.Columns[0].HeaderText = "Kitap ID";
            dataGrid_kitap.Columns[1].HeaderText = "Kitap İsmi";
            dataGrid_kitap.Columns[2].HeaderText = "Kitap Türü";
            dataGrid_kitap.Columns[3].HeaderText = "Kitap Yazarı";
            dataGrid_kitap.Columns[4].HeaderText = "Kitap Yayınevi";
            dataGrid_kitap.Columns[5].HeaderText = "Kitap Sayfası";
            dataGrid_kitap.Columns[6].HeaderText = "Kitap Adeti";
            dataGrid_kitap.Columns[0].Width = 94;
            dataGrid_kitap.Columns[1].Width = 150;
            dataGrid_kitap.Columns[2].Width = 150;
            dataGrid_kitap.Columns[3].Width = 150;
            dataGrid_kitap.Columns[4].Width = 150;
            dataGrid_kitap.Columns[5].Width = 150;
            dataGrid_kitap.Columns[6].Width = 94;
            dataGrid_kitap.ClearSelection();
        }
    }
}

