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
    public partial class RegPage : Page
    {
        public RegPage()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            Classes.ManageClass.authregWindow.Title = "Authorization";
            Classes.ManageClass.FrameAuthReg.Navigate(new Pages.AuthPage());
        }

        private void numberBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0))
            {
                e.Handled = true;
            }
            if (numberBox.Text.Length == 0)
            {
                numberBox.Text += "+";
                numberBox.CaretIndex = numberBox.Text.Length;
            }
            if (numberBox.Text.Length == 2)
            {
                numberBox.Text += " (";
                numberBox.CaretIndex = numberBox.Text.Length;
            }
            if (numberBox.Text.Length == 2)
            {
                numberBox.Text += " (";
                numberBox.CaretIndex = numberBox.Text.Length;
            }
            if (numberBox.Text.Length == 7)
            {
                numberBox.Text += ") ";
                numberBox.CaretIndex = numberBox.Text.Length;
            }
            if (numberBox.Text.Length == 12)
            {
                numberBox.Text += "-";
                numberBox.CaretIndex = numberBox.Text.Length;
            }
            if (numberBox.Text.Length == 15)
            {
                numberBox.Text += "-";
                numberBox.CaretIndex = numberBox.Text.Length;
            }
        }

        private void btnReg_Click(object sender, RoutedEventArgs e)
        {
            if(!string.IsNullOrEmpty(nameBox.Text)&& !string.IsNullOrEmpty(surnameBox.Text)&&!string.IsNullOrEmpty(patronymicBox.Text)
                && !string.IsNullOrEmpty(numberBox.Text)&& !string.IsNullOrEmpty(loginBox.Text)&& !string.IsNullOrEmpty(passwordBox.Password))
            {
                if(Classes.ManageClass.dymshopEntities.users.FirstOrDefault(u=>u.UserLogin==loginBox.Text)==null)
                {
                    int cc = 0;
                    string[] words = emailBox.Text.Split('@', '.');
                    bool proverkamaski = true;
                    for (int i = 0; i < emailBox.Text.Length; i++)
                    {
                        if (emailBox.Text[i] == '@')
                        {
                            cc++;
                            proverkamaski = true;
                        }
                        if (emailBox.Text[i] == '.')
                        {
                            cc++;
                            proverkamaski = false;
                        }
                    }
                    if (words.Length == 3 && words[0].Trim() != "" && words[1].Trim() != "" && words[2].Trim() != "" && cc == 2 && proverkamaski == false)
                    {
                        DataBaseModel.user User = new DataBaseModel.user();
                        User.PhoneNumber = numberBox.Text;
                        User.UserRole = 2;
                        User.UserName = nameBox.Text;
                        User.UserSurname = surnameBox.Text;
                        User.UserPatronymic = patronymicBox.Text;
                        User.UserEmail = emailBox.Text;
                        User.UserLogin = loginBox.Text;
                        User.UserPassword = passwordBox.Password;
                        Classes.ManageClass.dymshopEntities.users.Add(User);
                        Classes.ManageClass.dymshopEntities.SaveChanges();
                        Classes.ManageClass.User = Classes.ManageClass.dymshopEntities.users.FirstOrDefault(u => u.UserLogin == loginBox.Text && u.UserPassword == passwordBox.Password);
                        MainWindow mw = new MainWindow();
                        mw.Show();
                        Classes.ManageClass.authregWindow.Close();
                    }
                    else
                    {
                        UserControl notifi = new UserControls.Notification("Неверно введена почта!", 2);
                        notifi.HorizontalAlignment = HorizontalAlignment.Left;
                        notifi.VerticalAlignment = VerticalAlignment.Bottom;
                        regGrid.Children.Add(notifi);
                    }
                 }
                else
                {
                    UserControl notifi = new UserControls.Notification("Пользователь с таким логином уже существует!", 2);
                    notifi.HorizontalAlignment = HorizontalAlignment.Left;
                    notifi.VerticalAlignment = VerticalAlignment.Bottom;
                    regGrid.Children.Add(notifi);
                }
            }
            else
            {
                UserControl notifi = new UserControls.Notification("Некоторые поля пустые!", 2);
                notifi.HorizontalAlignment = HorizontalAlignment.Left;
                notifi.VerticalAlignment = VerticalAlignment.Bottom;
                regGrid.Children.Add(notifi);
            }
        }
    }
}
