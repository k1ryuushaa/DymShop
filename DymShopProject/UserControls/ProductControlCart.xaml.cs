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
    /// Логика взаимодействия для ProductControl.xaml
    /// </summary>
    public partial class ProductControlCart : UserControl
    {
        public string article;
        public string category;
        public int cost;
        public int count;
        bool countTextBox = false;
        public ProductControlCart()
        {
            InitializeComponent();
        }


        private void plusItem_Click(object sender, RoutedEventArgs e)
        {
            countTxtBox.Text = (Convert.ToInt32(countTxtBox.Text) + 1).ToString();
            var Order = Classes.ManageClass.dymshopEntities.orders.FirstOrDefault(o => o.OrderStatus == "В корзине" && o.OrderBuyer == Classes.ManageClass.User.UserId);
            var OrderProduct = Classes.ManageClass.dymshopEntities.orderproducts.FirstOrDefault(o => o.OrderNumber == Order.OrderNumber && o.ProductArticle == article);
            OrderProduct.ProductCount++;
            Classes.ManageClass.dymshopEntities.SaveChanges();
            UserControl notifi = new UserControls.Notification("Добавлено +1", 1);
            notifi.HorizontalAlignment = HorizontalAlignment.Left;
            notifi.VerticalAlignment = VerticalAlignment.Bottom;
            Classes.ManageClass.mainWindow.GridMain.Children.Add(notifi);
        }

        private void minusItem_Click(object sender, RoutedEventArgs e)
        {
            if (countTxtBox.Text != "" && Convert.ToInt32(countTxtBox.Text) > 0)
            {
                countTxtBox.Text = (Convert.ToInt32(countTxtBox.Text) - 1).ToString();
                var Order = Classes.ManageClass.dymshopEntities.orders.FirstOrDefault(o => o.OrderStatus == "В корзине" && o.OrderBuyer == Classes.ManageClass.User.UserId);
                var OrderProduct = Classes.ManageClass.dymshopEntities.orderproducts.FirstOrDefault(o => o.OrderNumber == Order.OrderNumber && o.ProductArticle == article);
                OrderProduct.ProductCount--;
                Classes.ManageClass.dymshopEntities.SaveChanges();
                UserControl notifi = new UserControls.Notification("Убавлено -1", 2);
                notifi.HorizontalAlignment = HorizontalAlignment.Left;
                notifi.VerticalAlignment = VerticalAlignment.Bottom;
                Classes.ManageClass.mainWindow.GridMain.Children.Add(notifi);
            }
            if(Convert.ToInt32(countTxtBox.Text) == 0)
            {
                var Order = Classes.ManageClass.dymshopEntities.orders.FirstOrDefault(o => o.OrderStatus == "В корзине" && o.OrderBuyer == Classes.ManageClass.User.UserId);
                var OrderProduct = Classes.ManageClass.dymshopEntities.orderproducts.FirstOrDefault(o=>o.OrderNumber==Order.OrderNumber&&o.ProductArticle==article);
                Classes.ManageClass.dymshopEntities.orderproducts.Remove(OrderProduct);
                Classes.ManageClass.dymshopEntities.SaveChanges();
                UserControl notifi = new UserControls.Notification("Продукт удалён", 2);
                notifi.HorizontalAlignment = HorizontalAlignment.Left;
                notifi.VerticalAlignment = VerticalAlignment.Bottom;
                Classes.ManageClass.FrameMain.Navigate(new Pages.PageCart());
                Classes.ManageClass.mainWindow.GridMain.Children.Add(notifi);
            }
        }

        private void countTxtBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0))
            {
                e.Handled = true;
            }
        }

        private void countTxtBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (countTextBox)
            {
                try
                {
                    if (Convert.ToInt32(countTxtBox.Text) == 0)
                    {
                        var Order = Classes.ManageClass.dymshopEntities.orders.FirstOrDefault(o => o.OrderStatus == "В корзине" && o.OrderBuyer == Classes.ManageClass.User.UserId);
                        var OrderProduct = Classes.ManageClass.dymshopEntities.orderproducts.FirstOrDefault(o => o.OrderNumber == Order.OrderNumber && o.ProductArticle == article);
                        Classes.ManageClass.dymshopEntities.orderproducts.Remove(OrderProduct);
                        Classes.ManageClass.dymshopEntities.SaveChanges();
                        UserControl notifi = new UserControls.Notification("Продукт удалён", 2);
                        notifi.HorizontalAlignment = HorizontalAlignment.Left;
                        notifi.VerticalAlignment = VerticalAlignment.Bottom;
                        Classes.ManageClass.FrameMain.Navigate(new Pages.PageCart());
                        Classes.ManageClass.mainWindow.GridMain.Children.Add(notifi);
                    }
                    else
                    {
                        if (Convert.ToInt32(countTxtBox.Text) > count)
                        {
                            var Order = Classes.ManageClass.dymshopEntities.orders.FirstOrDefault(o => o.OrderStatus == "В корзине" && o.OrderBuyer == Classes.ManageClass.User.UserId);
                            var OrderProduct = Classes.ManageClass.dymshopEntities.orderproducts.FirstOrDefault(o => o.OrderNumber == Order.OrderNumber && o.ProductArticle == article);
                            OrderProduct.ProductCount = Convert.ToInt32(countTxtBox.Text);
                            Classes.ManageClass.dymshopEntities.SaveChanges();
                            UserControl notifi = new UserControls.Notification($"Добавлено +{Convert.ToInt32(countTxtBox.Text) - count}", 1);
                            notifi.HorizontalAlignment = HorizontalAlignment.Left;
                            notifi.VerticalAlignment = VerticalAlignment.Bottom;
                            Classes.ManageClass.mainWindow.GridMain.Children.Add(notifi);
                            count = Convert.ToInt32(countTxtBox.Text);
                        }
                        else
                        {
                            var Order = Classes.ManageClass.dymshopEntities.orders.FirstOrDefault(o => o.OrderStatus == "В корзине" && o.OrderBuyer == Classes.ManageClass.User.UserId);
                            var OrderProduct = Classes.ManageClass.dymshopEntities.orderproducts.FirstOrDefault(o => o.OrderNumber == Order.OrderNumber && o.ProductArticle == article);
                            OrderProduct.ProductCount = Convert.ToInt32(countTxtBox.Text);
                            Classes.ManageClass.dymshopEntities.SaveChanges();
                            UserControl notifi = new UserControls.Notification($"Убавлено -{count - Convert.ToInt32(countTxtBox.Text)}", 2);
                            notifi.HorizontalAlignment = HorizontalAlignment.Left;
                            notifi.VerticalAlignment = VerticalAlignment.Bottom;
                            Classes.ManageClass.mainWindow.GridMain.Children.Add(notifi);
                            count = Convert.ToInt32(countTxtBox.Text);
                        }
                    }
                    productCostEnd.Text = (Classes.ManageClass.dymshopEntities.products.FirstOrDefault(p => p.Article == article).ProductCost * Convert.ToInt32(countTxtBox)).ToString();
                }
                catch
                {

                }
            }
        }

        private void countTxtBox_GotFocus(object sender, RoutedEventArgs e)
        {
            countTextBox = true;
        }
    }
}
