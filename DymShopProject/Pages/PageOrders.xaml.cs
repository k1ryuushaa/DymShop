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
    public partial class PageOrders : Page
    {
        List<UserControls.OrderControl> OrderControls = new List<UserControls.OrderControl>();
        bool sort = false;
        public PageOrders()
        {
            InitializeComponent();
            foreach (var order in Classes.ManageClass.dymshopEntities.orders.ToList())
            {
                UserControls.OrderControl orderControl = new UserControls.OrderControl();
                orderControl.OrderNumber.Text = order.OrderNumber.ToString();
                orderControl.ordernumber = order.OrderNumber;
                var Buyer = Classes.ManageClass.dymshopEntities.users.FirstOrDefault(u => u.UserId == order.OrderBuyer);
                orderControl.InfoBuyer.Text = Buyer.UserSurname + " " + Buyer.UserName + " " + Buyer.UserPatronymic + "\n" + Buyer.PhoneNumber;
                if (!string.IsNullOrEmpty(order.OrderCode.ToString()))
                    orderControl.CodeOrder.Text = order.OrderCode.ToString();
                else
                    orderControl.CodeOrder.Text = "-";
                if (!string.IsNullOrEmpty(order.OrderStatus))
                    orderControl.OrderStatus.Text = order.OrderStatus;
                else
                    orderControl.OrderStatus.Text = "-";
                if (!string.IsNullOrEmpty(order.OrderDateStart.ToString()))
                    orderControl.DateOrder.Text = order.OrderDateStart.ToString();
                else
                    orderControl.DateOrder.Text = "-";
                if (order.OrderStatus == "Завершён")
                    orderControl.OrderGive.IsEnabled = false;
                OrderControls.Add(orderControl);
                int ordercost = 0;
                foreach(var orderproduct in Classes.ManageClass.dymshopEntities.orderproducts.Where(o=>o.OrderNumber==order.OrderNumber).ToList())
                {
                    ordercost += Classes.ManageClass.dymshopEntities.products.FirstOrDefault(p => p.Article == orderproduct.ProductArticle).ProductCost * orderproduct.ProductCount;
                }
                orderControl.OrderCost.Text = ordercost.ToString() + "р.";

            }
            ListProducts.ItemsSource = OrderControls;
            OrderStatusSort.Items.Add("Статус");
            OrderStatusSort.Items.Add("Активный");
            OrderStatusSort.Items.Add("Завершён");
            OrderStatusSort.Items.Add("В корзине");
        }
        private void logoutBtn_Click(object sender, RoutedEventArgs e)
        {
            Windows.AuthRegWindow authRegWindow = new Windows.AuthRegWindow();
            authRegWindow.Show();
            Classes.ManageClass.mainWindow.Close();
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            Classes.ManageClass.FrameMain.Navigate(new Pages.PageCatalogSalesman());
        }

        private void SearchTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            SearchSort();
        }

        private void OrderStatusSort_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (OrderStatusSort.SelectedIndex == 0)
                sort = false;
            else
                sort = true;
            SearchSort();
        }
        private void SearchSort()
        {
            var orders = OrderControls.Where(o => o.OrderNumber.Text.Contains(SearchTextBox.Text));
            if (sort)
            {
                if (OrderStatusSort.SelectedIndex == 1)
                    orders = orders.Where(o => o.OrderStatus.Text == "Активный");
                if (OrderStatusSort.SelectedIndex == 2)
                    orders = orders.Where(o => o.OrderStatus.Text == "Завершён");
                if (OrderStatusSort.SelectedIndex == 3)
                    orders = orders.Where(o => o.OrderStatus.Text == "В корзине");
            }
            ListProducts.ItemsSource = orders;
            if (orders.ToList().Count > 0)
                ErrNotifi.Visibility = Visibility.Hidden;
            else
                ErrNotifi.Visibility = Visibility.Visible;
        }
    }
}
