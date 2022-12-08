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

namespace DymShopProject.UserControls
{
    /// <summary>
    /// Логика взаимодействия для WorkerControl.xaml
    /// </summary>
    public partial class WorkerControlAdd : UserControl
    {
        public WorkerControlAdd()
        {
            InitializeComponent();
            foreach(var role in Classes.ManageClass.dymshopEntities.roles.Where(r => r.Role_ID == 3 || r.Role_ID == 4).ToList())
            {
                WRole.Items.Add(role.RoleName);
            }
            
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(WName.Text) && !string.IsNullOrEmpty(WSurname.Text) && !string.IsNullOrEmpty(WPatronymic.Text) && !string.IsNullOrEmpty(WPhone.Text) &&
                !string.IsNullOrEmpty(WBirthday.Text) && !string.IsNullOrEmpty(WLogin.Text) && !string.IsNullOrEmpty(WPassword.Text) && !string.IsNullOrEmpty(WRole.Text))
            {
                DataBaseModel.user worker = new DataBaseModel.user();
                worker.UserName = WName.Text;
                worker.UserSurname = WSurname.Text;
                worker.UserPatronymic = WPatronymic.Text;
                worker.PhoneNumber = WPhone.Text;
                worker.UserLogin = WLogin.Text;
                worker.UserPassword = WPassword.Text;
                worker.UserRole = WRole.SelectedIndex + 1;
                worker.UserBirthday = WBirthday.SelectedDate;
                Classes.ManageClass.dymshopEntities.users.Add(worker);
                Classes.ManageClass.dymshopEntities.SaveChanges();
                Classes.ManageClass.FrameMain.Navigate(new Pages.PageCatalogWorkers());
                UserControl notifi = new UserControls.Notification("Сотрудник добавлен", 1);
                notifi.HorizontalAlignment = HorizontalAlignment.Left;
                notifi.VerticalAlignment = VerticalAlignment.Bottom;
                Classes.ManageClass.mainWindow.GridMain.Children.Add(notifi);
            }
            else
            {
                UserControl notifi = new UserControls.Notification("Не все поля заполнены!", 2);
                notifi.HorizontalAlignment = HorizontalAlignment.Left;
                notifi.VerticalAlignment = VerticalAlignment.Bottom;
                Classes.ManageClass.mainWindow.GridMain.Children.Add(notifi);
            }
        }
    }
}
