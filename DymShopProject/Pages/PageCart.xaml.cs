using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
    public partial class PageCart : Page
    {
        public PageCart()
        {
            InitializeComponent();
            CartName.Text = $"Здравствуй,{Classes.ManageClass.User.UserName}! Ваша корзина:";
            List<UserControls.ProductControlCart> products = new List<UserControls.ProductControlCart>();
            var Order = Classes.ManageClass.dymshopEntities.orders.FirstOrDefault(o => o.OrderStatus == "В корзине" && o.OrderBuyer == Classes.ManageClass.User.UserId);
            if (Order != null)
            {
                foreach (var orderproduct in Classes.ManageClass.dymshopEntities.orderproducts.Where(o => o.OrderNumber == Order.OrderNumber).ToList())
                {
                    var product = Classes.ManageClass.dymshopEntities.products.FirstOrDefault(p => p.Article == orderproduct.ProductArticle);
                    UserControls.ProductControlCart productControl = new UserControls.ProductControlCart();
                    if (!string.IsNullOrEmpty(product.ProductPhoto))
                        productControl.productImage.Source = new BitmapImage(new Uri($@"../Images/{product.ProductPhoto}", UriKind.Relative));
                    else
                        productControl.productImage.Source = new BitmapImage(new Uri($@"../Images/picture.png", UriKind.Relative));
                    productControl.productCost.Text = product.ProductCost.ToString() + " р.";
                    productControl.productCostEnd.Text = (Convert.ToInt32(product.ProductCost) * orderproduct.ProductCount).ToString() + " р.";
                    productControl.countTxtBox.Text = orderproduct.ProductCount.ToString();
                    productControl.count = orderproduct.ProductCount;
                    productControl.article = orderproduct.ProductArticle;
                    productControl.productName.Text = product.ProductName;
                    products.Add(productControl);
                }
                ListProducts.ItemsSource = products;
            }
            if (products.Count() == 0)
            {
                ErrNotifi.Visibility = Visibility.Visible;
                createOrderBtn.IsEnabled = false;
            }
            else
                createOrderBtn.Content = $"Заказать({products.Count()})";
            foreach(var point in Classes.ManageClass.dymshopEntities.pickuppoints.ToList())
            {
                cmBoxPickUpPoint.Items.Add(point.City +" "+ point.Street+" "+point.TownNumber.ToString());
            }
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            Classes.ManageClass.FrameMain.Navigate(new Pages.PageCatalog());
        }

        private void createOrderBtn_Click(object sender, RoutedEventArgs e)
        {
            if (cmBoxPickUpPoint.SelectedItem != null)
            {
                Microsoft.Office.Interop.Word.Document document = null;
                Microsoft.Office.Interop.Word.Application application = new Microsoft.Office.Interop.Word.Application();
                String fileName = System.IO.Path.GetTempFileName();
                File.WriteAllBytes(fileName, Properties.Resources.UserOrder);
                document = application.Documents.Open(fileName);
                document.Bookmarks["DateOrder"].Range.Text = DateTime.Now.ToShortDateString();
                document.Bookmarks["UserName"].Range.Text = Classes.ManageClass.User.UserName;
                var Order = Classes.ManageClass.dymshopEntities.orders.FirstOrDefault(o => o.OrderStatus == "В корзине" && o.OrderBuyer == Classes.ManageClass.User.UserId);
                Order.OrderStatus = "Активный";
                Random rnd = new Random();
                Order.OrderCode = rnd.Next(90000, 1002030);
                Order.OrderDateDelivery = DateTime.Now.AddDays(3);
                Order.OrderPickPoint = cmBoxPickUpPoint.SelectedIndex + 1;
                Classes.ManageClass.dymshopEntities.SaveChanges();
                string productNames = "";
                string productCounts = "";
                string productCosts = "";
                int EndCost = 0;
                foreach (var orderproduct in Classes.ManageClass.dymshopEntities.orderproducts.ToList().Where(o=>o.OrderNumber==Order.OrderNumber))
                {
                    productNames += Classes.ManageClass.dymshopEntities.products.FirstOrDefault(p => p.Article == orderproduct.ProductArticle).ProductName + "\n";
                    productCounts += orderproduct.ProductCount.ToString() + "\n";
                    productCosts += (Classes.ManageClass.dymshopEntities.products.FirstOrDefault(p => p.Article == orderproduct.ProductArticle).ProductCost* orderproduct.ProductCount).ToString() + "р.\n";
                    EndCost += Convert.ToInt32(Classes.ManageClass.dymshopEntities.products.FirstOrDefault(p => p.Article == orderproduct.ProductArticle).ProductCost * orderproduct.ProductCount);
                }
                document.Bookmarks["ProductName"].Range.Text = productNames;
                document.Bookmarks["ProductCount"].Range.Text = productCounts;
                document.Bookmarks["ProductCost"].Range.Text = productCosts;
                document.Bookmarks["EndCost"].Range.Text = EndCost.ToString() + "р.";
                SaveFileDialog sfd = new SaveFileDialog();
                if (sfd.ShowDialog() == true)
                {
                    document.SaveAs(sfd.FileName);
                }
                document.Close();
                Classes.ManageClass.FrameMain.Navigate(new Pages.PageCatalog());
                UserControl notifi = new UserControls.Notification("Спасибо за заказ!", 1);
                notifi.HorizontalAlignment = HorizontalAlignment.Left;
                notifi.VerticalAlignment = VerticalAlignment.Bottom;
                Classes.ManageClass.mainWindow.GridMain.Children.Add(notifi);
            }
            else
            {
                UserControl notifi = new UserControls.Notification("Не выбран пункт выдачи!", 2);
                notifi.HorizontalAlignment = HorizontalAlignment.Left;
                notifi.VerticalAlignment = VerticalAlignment.Bottom;
                Classes.ManageClass.FrameMain.Navigate(new Pages.PageCart());
                Classes.ManageClass.mainWindow.GridMain.Children.Add(notifi);
            }
        }

        private void logoutBtn_Click(object sender, RoutedEventArgs e)
        {
            Windows.AuthRegWindow authRegWindow = new Windows.AuthRegWindow();
            authRegWindow.Show();
            Classes.ManageClass.mainWindow.Close();
        }
    }
}
