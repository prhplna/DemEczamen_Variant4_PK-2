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
using TransportCompany.ApplicationData;

namespace TransportCompany
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ApplicationData.AppConnect.ModelOdb = new ApplicationData.BD_2905Entities(); //подключение к БД
            ApplicationData.AppFrame.FrmMain = FrameMain; //загрузка фрейма с началом работы программы
            FrameMain.Navigate(new PageMain.PageLogin()); //подключение во фрейм стартовой страницы авторизации
        }

    }
}
