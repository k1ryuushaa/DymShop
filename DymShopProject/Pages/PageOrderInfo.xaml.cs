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
    public partial class PageOrderInfo : Page
    {
        List<UserControls.ProductControl> productControls = new List<UserControls.ProductControl>();
        public PageOrderInfo(int ordernumber)
        {
            InitializeComponent();
            foreach (var orderproducts in Classes.ManageClass.dymshopEntities.orderproducts.Where(o=>o.OrderNumber==ordernumber).ToList())
            {
                UserControls.ProductControl productControl = new UserControls.ProductControl();
                var product = Classes.ManageClass.dymshopEntities.products.FirstOrDefault(p => p.Article == orderproducts.ProductArticle);
                if (!string.IsNullOrEmpty(product.ProductPhoto))
                    productControl.productImage.Source = new BitmapImage(new Uri($@"../Images/{product.ProductPhoto}", UriKind.Relative));
                else
                    productControl.productImage.Source = new BitmapImage(new Uri($@"../Images/picture.png", UriKind.Relative));

                productControl.productName.Text = product.ProductName;
                productControl.productCost.Text = $"Кол-во:{orderproducts.ProductCount}";
                productControls.Add(productControl);

            }
            ListProducts.ItemsSource = productControls;
        }
        private void logoutBtn_Click(object sender, RoutedEventArgs e)
        {
            Windows.AuthRegWindow authRegWindow = new Windows.AuthRegWindow();
            authRegWindow.Show();
            Classes.ManageClass.mainWindow.Close();
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            Classes.ManageClass.FrameMain.Navigate(new Pages.PageOrders());
        }
    }
}
