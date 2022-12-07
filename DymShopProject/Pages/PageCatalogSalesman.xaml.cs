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
    public partial class PageCatalogSalesman : Page
    {
        List<UserControls.ProductControlForSalesman> ProductControls = new List<UserControls.ProductControlForSalesman>();
        bool filter = false;
        bool sort = false;
        public PageCatalogSalesman()
        {
            InitializeComponent();
            foreach (var product in Classes.ManageClass.dymshopEntities.products.ToList())
            {
                UserControls.ProductControlForSalesman productControl = new UserControls.ProductControlForSalesman();
                productControl.cost = product.ProductCost;
                productControl.article = product.Article;
                productControl.productSupplier.Text = product.supplier.SupplierName;
                productControl.countTxtBox.Text = product.ProductCountInStock.ToString();
                productControl.category = product.category.CategoryName;
                productControl.productName.Text= product.ProductName;
                if (!string.IsNullOrEmpty(product.ProductPhoto))
                    productControl.productImage.Source = new BitmapImage(new Uri($@"../Images/{product.ProductPhoto}", UriKind.Relative));
                else
                    productControl.productImage.Source = new BitmapImage(new Uri($@"../Images/picture.png", UriKind.Relative));
                productControl.productCost.Text = product.ProductCost.ToString()+" р.";
                ProductControls.Add(productControl);
            }
            ListProducts.ItemsSource = ProductControls;
            CategoryFilter.Items.Add("Категория");
            CostSort.Items.Add("Цена");
            foreach(var category in Classes.ManageClass.dymshopEntities.categories.ToList())
            {
                CategoryFilter.Items.Add(category.CategoryName);
            }
            CostSort.Items.Add("от 0 до 499");
            CostSort.Items.Add("от 500 до 999");
            CostSort.Items.Add("от 1000 и более");

            UserControl notifi = new UserControls.Notification($"Добро пожаловать,{Classes.ManageClass.User.UserName}!", 1);
            notifi.HorizontalAlignment = HorizontalAlignment.Left;
            notifi.VerticalAlignment = VerticalAlignment.Bottom;
            catalogGrid.Children.Add(notifi);
            Grid.SetRowSpan(notifi, 3);
            Grid.SetColumnSpan(notifi, 4);
        }
        private void SearchSortFilter()
        {
            var products = ProductControls.Where(p => p.productName.Text.ToLower().Contains(SearchTextBox.Text.ToLower()));
            if (filter)
                products = products.Where(p => p.category == CategoryFilter.SelectedValue.ToString());
            if (sort)
            {
                if (CostSort.SelectedIndex == 1)
                    products = products.Where(p => p.cost >= 0 && p.cost<=499);
                if (CostSort.SelectedIndex == 2)
                    products = products.Where(p => p.cost >= 500 && p.cost <= 999);
                if (CostSort.SelectedIndex == 3)
                    products = products.Where(p => p.cost >= 1000);
            }
            ListProducts.ItemsSource = products.ToList();
            if (products.ToList().Count > 0)
                ErrNotifi.Visibility = Visibility.Hidden;
            else
                ErrNotifi.Visibility = Visibility.Visible;

        }

        private void CategoryFilter_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (CategoryFilter.SelectedIndex == 0)
                filter = false;
            else
                filter = true;
            SearchSortFilter();
        }

        private void CostSort_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (CostSort.SelectedIndex == 0)
                sort = false;
            else
                sort = true;
            SearchSortFilter();
        }

        private void SearchTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            SearchSortFilter();
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            Windows.AuthRegWindow authRegWindow = new Windows.AuthRegWindow();
            authRegWindow.Show();
            Classes.ManageClass.mainWindow.Close();
        }

        private void korzinaBtn_Click(object sender, RoutedEventArgs e)
        {
            Classes.ManageClass.FrameMain.Navigate(new Pages.PageCart());
        }

        private void logoutBtn_Click(object sender, RoutedEventArgs e)
        {
            Windows.AuthRegWindow authRegWindow = new Windows.AuthRegWindow();
            authRegWindow.Show();
            Classes.ManageClass.mainWindow.Close();
        }

        private void ordersBtn_Click(object sender, RoutedEventArgs e)
        {
            Classes.ManageClass.FrameMain.Navigate(new Pages.PageOrders());
        }
    }
}
