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

namespace DymShopProject
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Classes.ManageClass.FrameMain = frmMain;
            Classes.ManageClass.mainWindow = this;
            Classes.ManageClass.dymshopEntities = new DataBaseModel.dymshopEntities();
            if(Classes.ManageClass.User== null||Classes.ManageClass.User.UserRole == 2)
                frmMain.Navigate(new Pages.PageCatalog());
            else if (Classes.ManageClass.User.UserRole == 3)
                frmMain.Navigate(new Pages.PageCatalogSalesman());
            else if (Classes.ManageClass.User.UserRole == 4)
                frmMain.Navigate(new Pages.PageAdminPanel());
        }
    }
}
