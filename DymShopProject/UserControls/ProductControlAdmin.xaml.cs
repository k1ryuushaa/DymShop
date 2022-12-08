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
    public partial class ProductControlAdmin : UserControl
    {
        public string article;
        public ProductControlAdmin()
        {
            InitializeComponent();
        }

        private void EditProductBtn_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(productName.Text) && !string.IsNullOrEmpty(productCost.Text))
            {
                var product = Classes.ManageClass.dymshopEntities.products.FirstOrDefault(p => p.Article == article);
                product.ProductName = productName.Text;
                product.ProductCost = Convert.ToInt32(productCost.Text);
                Classes.ManageClass.dymshopEntities.SaveChanges();
                UserControl notifi = new UserControls.Notification("Изменено успешно", 1);
                notifi.HorizontalAlignment = HorizontalAlignment.Left;
                notifi.VerticalAlignment = VerticalAlignment.Bottom;
                Classes.ManageClass.mainWindow.GridMain.Children.Add(notifi);
            }
            else {
                UserControl notifi = new UserControls.Notification("Пустое(-ые) поле(-я)!", 2);
                notifi.HorizontalAlignment = HorizontalAlignment.Left;
                notifi.VerticalAlignment = VerticalAlignment.Bottom;
                Classes.ManageClass.mainWindow.GridMain.Children.Add(notifi);
            }
        }

        private void DeleteProductBtn_Click(object sender, RoutedEventArgs e)
        {
            var product = Classes.ManageClass.dymshopEntities.products.FirstOrDefault(p => p.Article == article);
            Classes.ManageClass.dymshopEntities.products.Remove(product);
            Classes.ManageClass.dymshopEntities.SaveChanges();
            Classes.ManageClass.FrameMain.Navigate(new Pages.PageCatalogAdmin());
            UserControl notifi = new UserControls.Notification("Товар удалён", 2);
            notifi.HorizontalAlignment = HorizontalAlignment.Left;
            notifi.VerticalAlignment = VerticalAlignment.Bottom;
            Classes.ManageClass.mainWindow.GridMain.Children.Add(notifi);
        }
    }
}
