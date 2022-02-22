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
using ZedGraph;

namespace PresentationLayer
{
    public partial class zedgraph : Form
    {
        public zedgraph()
        {
            InitializeComponent();
        }
        BusinessManager businessManager = new BusinessManager(new AccessDAO("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=AccessDB.mdb"), new StudentComplexCheckService(), new BookAllCheckService(), new BorrowedDeleteCheckService());
        public void graphOlustur(ZedGraphControl zg1)
        { //sütun grafiği oluşturan zedGraph kodları
            GraphPane myPane = zg1.GraphPane;

            
            //sütun değerleri
            double[] y = { businessManager.kitap_sayisi_ogren() };
            double[] y2 = { businessManager.ogrenci_sayisi_ogren() };
            double[] y3 = { businessManager.odunc_alinan_kitap_sayisi() };
            double[] y4 = { businessManager.odunc_teslim_edilmeyen_kitap_sayisi() };



            // Sütu açıklama kodları  

           
            BarItem myBar = myPane.AddBar("Kitap Çeşiti", null, y,
                                                        Color.Gold);
            myBar.Bar.Fill = new Fill(Color.Gold, Color.Gold,
                                                        Color.Gold);

            
            myBar = myPane.AddBar("Öğrenci Sayısı", null, y2, Color.Green);
            myBar.Bar.Fill = new Fill(Color.Green, Color.Green,
                                                        Color.Green);

            
            myBar = myPane.AddBar("Ödünç Alınan Kitap Sayısı", null, y3, Color.DarkBlue);
            myBar.Bar.Fill = new Fill(Color.DarkBlue, Color.DarkBlue,
                                                        Color.DarkBlue);
           
            myBar = myPane.AddBar("Teslim Edilmeyen Kitap Sayısı", null, y4, Color.Red);
            myBar.Bar.Fill = new Fill(Color.Red, Color.Red,
                                                        Color.Red);

          
            myPane.XAxis.MajorTic.IsBetweenLabels = true;

            

           
            myPane.XAxis.Type = AxisType.Text;

           
            myPane.Chart.Fill = new Fill(Color.WhiteSmoke, Color.WhiteSmoke);
            myPane.Fill = new Fill(Color.WhiteSmoke);
            myPane.Title.Text = "Kütüphane Bilgileri (Grafik)";
            myPane.XAxis.Title.Text = "Kütüphane Analizi";
            myPane.YAxis.Title.Text = "Sayısal Değerler";
            myPane.Border.IsVisible = false;
            myPane.Legend.Position = LegendPos.TopCenter;
            myPane.Title.IsVisible = false;

            
            zg1.AxisChange();

        }

        private void zedgraph_Load(object sender, EventArgs e)
        {
            graphOlustur(zedGraph1); // oluşturduğumuz fonksiyonu bu form açılırken çağırıyoruz.
        }
    }
}
