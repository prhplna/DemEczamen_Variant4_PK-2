using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TransportCompany.PageMain
{
    /// <summary>
    /// Логика взаимодействия для PageTransport.xaml
    /// </summary>
    public partial class PageTransport : Page
    {
        public PageTransport()
        {
            InitializeComponent();
            DtGridTransport.ItemsSource = ApplicationData.BD_2905Entities.GetContext().Transport.ToList(); //заполнение данных из БД в приложение
            DtGridTransport.ItemsSource = ApplicationData.BD_2905Entities.GetContext().StatusTransport.ToList();
        }

        private void BtnOrder_Click(object sender, RoutedEventArgs e)
        {
            ApplicationData.AppFrame.FrmMain.Navigate(new PageMain.PageOrder()); //Переход на страницу с заказами
        }

        private void BtnDelivery_Click(object sender, RoutedEventArgs e)
        {
            ApplicationData.AppFrame.FrmMain.Navigate(new PageMain.PageDelivery());
        }

        private void BtnTO_Click(object sender, RoutedEventArgs e)
        {
            ApplicationData.AppFrame.FrmMain.Navigate(new PageMain.PageTO());
        }
    }
}
