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
    /// Логика взаимодействия для PageCatalog.xaml
    /// </summary>
    public partial class PageCatalogWorkers : Page
    {
        List<UserControls.WorkerControl> WorkerControls = new List<UserControls.WorkerControl>();
        public PageCatalogWorkers()
        {
            InitializeComponent();
            foreach (var worker in Classes.ManageClass.dymshopEntities.users.ToList().Where(u=>u.UserRole==3||u.UserRole==4))
            {
                UserControls.WorkerControl workerControl = new UserControls.WorkerControl();
                workerControl.WName.Text = worker.UserName;
                workerControl.WSurname.Text = worker.UserSurname;
                workerControl.WPatronymic.Text = worker.UserPatronymic;
                workerControl.worker_id = worker.UserId;
                workerControl.WLogin.Text = worker.UserLogin;
                workerControl.WPassword.Text = worker.UserPassword;
                workerControl.WPhone.Text = worker.PhoneNumber;
                workerControl.WRole.SelectedIndex = worker.UserRole-1;
                workerControl.WBirthday.Text = worker.UserBirthday.GetValueOrDefault().Date.ToShortDateString();
                WorkerControls.Add(workerControl);
            }
            ListWorkers.ItemsSource = WorkerControls;
        }
        private void SearchSortFilter()
        {
            var products = WorkerControls.Where(p => p.WName.Text.ToLower().Contains(SearchTextBox.Text.ToLower())|| p.WSurname.Text.ToLower().Contains(SearchTextBox.Text.ToLower())|| p.WPatronymic.Text.ToLower().Contains(SearchTextBox.Text.ToLower()));
            ListWorkers.ItemsSource = products.ToList();
            if (products.ToList().Count > 0)
                ErrNotifi.Visibility = Visibility.Hidden;
            else
                ErrNotifi.Visibility = Visibility.Visible;

        }

        private void SearchTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            SearchSortFilter();
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            Classes.ManageClass.FrameMain.Navigate(new Pages.PageAdminPanel());
        }

        private void logoutBtn_Click(object sender, RoutedEventArgs e)
        {
            Windows.AuthRegWindow authRegWindow = new Windows.AuthRegWindow();
            authRegWindow.Show();
            Classes.ManageClass.mainWindow.Close();
        }

        private void AddNewWorkerBtn_Click(object sender, RoutedEventArgs e)
        {
            ListWorkers.ItemsSource = null;
            ListWorkers.Items.Add(new UserControls.WorkerControlAdd());
        }
    }
}
