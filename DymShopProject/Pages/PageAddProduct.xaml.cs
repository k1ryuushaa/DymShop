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
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using Microsoft.Win32;

namespace DymShopProject.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageCatalog.xaml
    /// </summary>
    public partial class PageAddProduct : Page
    {
        public PageAddProduct()
        {
            InitializeComponent();
            UserControl notifi = new UserControls.Notification($"Добро пожаловать,{Classes.ManageClass.User.UserName}!", 1);
            notifi.HorizontalAlignment = HorizontalAlignment.Left;
            notifi.VerticalAlignment = VerticalAlignment.Bottom;
            Classes.ManageClass.mainWindow.GridMain.Children.Add(notifi);
            foreach(var category in Classes.ManageClass.dymshopEntities.categories.ToList())
            {
                CategoryCmBox.Items.Add(category.CategoryName);
            }
            foreach (var supplier in Classes.ManageClass.dymshopEntities.suppliers.ToList())
            {
                ProductSupplierCmBox.Items.Add(supplier.SupplierName);
            }
        }
       

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            Classes.ManageClass.FrameMain.Navigate(new Pages.PageCatalogAdmin());
        }

        private void logoutBtn_Click(object sender, RoutedEventArgs e)
        {
            Windows.AuthRegWindow authRegWindow = new Windows.AuthRegWindow();
            authRegWindow.Show();
            Classes.ManageClass.mainWindow.Close();
        }

        private void AddProductBtn_Click(object sender, RoutedEventArgs e)
        {
            if (Classes.ManageClass.dymshopEntities.products.FirstOrDefault(p => p.Article == ArticleTxtBlock.Text) == null)
            {
                if (!string.IsNullOrEmpty(ArticleTxtBlock.Text) && !string.IsNullOrEmpty(ProductNameTxtBlock.Text) && !string.IsNullOrEmpty(ProductCostTxtBlock.Text)
                    && !string.IsNullOrEmpty(ProductDiscountTxtBlock.Text) && !string.IsNullOrEmpty(CategoryCmBox.Text) && !string.IsNullOrEmpty(ProductSupplierCmBox.Text))
                {
                    DataBaseModel.product Product = new DataBaseModel.product();
                    Product.Article = ArticleTxtBlock.Text;
                    Product.ProductName = ProductNameTxtBlock.Text;
                    Product.ProductDescription = ProductDescriptionTxtBlock.Text;
                    Product.ProductPhoto = "picture.png";
                    Product.ProductCost = Convert.ToInt32(ProductCostTxtBlock.Text);
                    Product.ProductCountInStock = Convert.ToInt32(ProductCountInStockTxtBlock.Text);
                    Product.ProductDiscount = Convert.ToInt32(ProductDiscountTxtBlock.Text);
                    Product.ProductCategory = CategoryCmBox.SelectedIndex + 1;
                    Product.ProductSupplier = ProductSupplierCmBox.SelectedIndex + 1;
                    UserControl notifi = new UserControls.Notification("Товар добавлен!", 1);
                    Classes.ManageClass.dymshopEntities.products.Add(Product);
                    Classes.ManageClass.dymshopEntities.SaveChanges();
                    Classes.ManageClass.FrameMain.Navigate(new Pages.PageCatalogAdmin());
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
            else
            {
                UserControl notifi = new UserControls.Notification("Данный артикул уже есть!", 2);
                notifi.HorizontalAlignment = HorizontalAlignment.Left;
                notifi.VerticalAlignment = VerticalAlignment.Bottom;
                Classes.ManageClass.mainWindow.GridMain.Children.Add(notifi);
            }
        }
    }
}
