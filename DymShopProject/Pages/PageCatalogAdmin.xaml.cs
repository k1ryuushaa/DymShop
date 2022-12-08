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
    public partial class PageCatalogAdmin : Page
    {
        List<UserControls.ProductControlAdmin> ProductControls = new List<UserControls.ProductControlAdmin>();
        public PageCatalogAdmin()
        {
            InitializeComponent();
            foreach (var product in Classes.ManageClass.dymshopEntities.products.ToList())
            {
                UserControls.ProductControlAdmin productControl = new UserControls.ProductControlAdmin();
                productControl.article = product.Article;
                productControl.productName.Text= product.ProductName;
                if (!string.IsNullOrEmpty(product.ProductPhoto))
                    productControl.productImage.Source = new BitmapImage(new Uri($@"../Images/{product.ProductPhoto}", UriKind.Relative));
                else
                    productControl.productImage.Source = new BitmapImage(new Uri($@"../Images/picture.png", UriKind.Relative));
                productControl.productCost.Text = product.ProductCost.ToString();
                ProductControls.Add(productControl);
            }
            ListProducts.ItemsSource = ProductControls;
        }
        private void SearchSortFilter()
        {
            var products = ProductControls.Where(p => p.productName.Text.ToLower().Contains(SearchTextBox.Text.ToLower()));
            ListProducts.ItemsSource = products.ToList();
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

        private void AddNewProductBtn_Click(object sender, RoutedEventArgs e)
        {
            Classes.ManageClass.FrameMain.Navigate(new Pages.PageAddProduct());
        }
    }
}
