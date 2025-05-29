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
    /// Логика взаимодействия для PageTO.xaml
    /// </summary>
    public partial class PageTO : Page
    {
        public PageTO()
        {
            InitializeComponent();
            DtGridTransport.ItemsSource = ApplicationData.BD_2905Entities.GetContext().Transport.ToList();
            DtGridTransport.ItemsSource = ApplicationData.BD_2905Entities.GetContext().TOTransport.ToList();
        }

        private void BtnBack2_Click(object sender, RoutedEventArgs e)
        {
            ApplicationData.AppFrame.FrmMain.Navigate(new PageMain.PageTransport());
        }
    }
}
