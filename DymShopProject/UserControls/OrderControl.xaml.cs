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
    /// Логика взаимодействия для OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {
        public int ordernumber;
        public OrderControl()
        {
            InitializeComponent();
        }

        private void OrderGive_Click(object sender, RoutedEventArgs e)
        {
            var order = Classes.ManageClass.dymshopEntities.orders.FirstOrDefault(o => o.OrderNumber == ordernumber);
            order.OrderStatus = "Завершён";
            Classes.ManageClass.dymshopEntities.SaveChanges();
            UserControl notifi = new UserControls.Notification($"Заказ №{ordernumber} отдан получателю!", 1);
            notifi.HorizontalAlignment = HorizontalAlignment.Left;
            notifi.VerticalAlignment = VerticalAlignment.Bottom;
            Classes.ManageClass.mainWindow.GridMain.Children.Add(notifi);
            Classes.ManageClass.FrameMain.Navigate(new Pages.PageOrders());
        }

        private void SeeContent_Click(object sender, RoutedEventArgs e)
        {
            Classes.ManageClass.FrameMain.Navigate(new Pages.PageOrderInfo(ordernumber));
        }
    }
}
