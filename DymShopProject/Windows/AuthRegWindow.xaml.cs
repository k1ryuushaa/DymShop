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
using System.Windows.Shapes;

namespace DymShopProject.Windows
{
    /// <summary>
    /// Логика взаимодействия для AuthRegWindow.xaml
    /// </summary>
    public partial class AuthRegWindow : Window
    {
        public AuthRegWindow()
        {
            InitializeComponent();
            Classes.ManageClass.FrameAuthReg = AuthRegFrame;
            Classes.ManageClass.authregWindow = this;
            Classes.ManageClass.dymshopEntities = new DataBaseModel.dymshopEntities();
            AuthRegFrame.Navigate(new Pages.AuthPage());
        }
    }
}
