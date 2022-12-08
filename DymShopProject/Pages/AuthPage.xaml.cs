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

namespace DymShopProject.Pages
{
    /// <summary>
    /// Логика взаимодействия для AuthPage.xaml
    /// </summary>
    public partial class AuthPage : Page
    {
        public AuthPage()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(loginBox.Text) && !string.IsNullOrEmpty(passwordBox.Password))
            {
                Classes.ManageClass.User = Classes.ManageClass.dymshopEntities.users.FirstOrDefault(u => u.UserLogin == loginBox.Text && u.UserPassword == passwordBox.Password);
                if (Classes.ManageClass.User != null)
                {
                    MainWindow mw = new MainWindow();
                    mw.Show();
                    Classes.ManageClass.authregWindow.Close();

                }
                else
                {
                    UserControl notifi = new UserControls.Notification("Пользователь не найден!", 2);
                    notifi.HorizontalAlignment = HorizontalAlignment.Left;
                    notifi.VerticalAlignment = VerticalAlignment.Bottom;
                    authGrid.Children.Add(notifi);
                }
            }
            else
            {
                UserControl notifi = new UserControls.Notification("Некоторые поля пустые!", 2);
                notifi.HorizontalAlignment = HorizontalAlignment.Left;
                notifi.VerticalAlignment = VerticalAlignment.Bottom;
                authGrid.Children.Add(notifi);
            }
        }

        private void btnLoginGuest_Click(object sender, RoutedEventArgs e)
        {
            Classes.ManageClass.User = null;
            MainWindow mw = new MainWindow();
            mw.Show();
            Classes.ManageClass.authregWindow.Close();
        }

        private void btnReg_Click(object sender, RoutedEventArgs e)
        {
            Classes.ManageClass.authregWindow.Title = "Registration";
            Classes.ManageClass.FrameAuthReg.Navigate(new Pages.RegPage());
        }
    }
}
