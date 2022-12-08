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
    /// Логика взаимодействия для ProductInfo.xaml
    /// </summary>
    public partial class ProductInfo : Page
    {
        public DataBaseModel.product product;
        public ProductInfo(string article)
        {
            InitializeComponent();
            product = Classes.ManageClass.dymshopEntities.products.FirstOrDefault(p => p.Article == article);
            if (!string.IsNullOrEmpty(product.ProductPhoto))
                imgProduct.Source = new BitmapImage(new Uri($@"../Images/{product.ProductPhoto}", UriKind.Relative));
            else
                imgProduct.Source = new BitmapImage(new Uri($@"../Images/picture.png", UriKind.Relative));
            productName.Text = product.ProductName;
            productCost.Text = product.ProductCost.ToString()+" р.";
            productDescription.Text = product.ProductDescription;
        }

        private void AddToCart_Click(object sender, RoutedEventArgs e)
        {
            if (Classes.ManageClass.User != null)
            {
                if (countTxtBox.Text != "" && Convert.ToInt32(countTxtBox.Text) > 0)
                {
                    if (Classes.ManageClass.dymshopEntities.orders.FirstOrDefault(o => o.OrderBuyer == Classes.ManageClass.User.UserId&&o.OrderStatus=="В корзине") == null)
                    {
                        DataBaseModel.order OrderNotExist = new DataBaseModel.order();
                        OrderNotExist.OrderDateStart = DateTime.Now;
                        OrderNotExist.OrderBuyer = Classes.ManageClass.User.UserId;
                        OrderNotExist.OrderStatus = "В корзине";
                        Classes.ManageClass.dymshopEntities.orders.Add(OrderNotExist);
                        Classes.ManageClass.dymshopEntities.SaveChanges();
                    }
                    var Order = Classes.ManageClass.dymshopEntities.orders.FirstOrDefault(o => o.OrderStatus == "В корзине" && o.OrderBuyer == Classes.ManageClass.User.UserId);
                    if (Classes.ManageClass.dymshopEntities.orderproducts.FirstOrDefault(o => o.OrderNumber == Order.OrderNumber && o.ProductArticle == product.Article) == null)
                    {
                        DataBaseModel.orderproduct OrderProduct = new DataBaseModel.orderproduct();
                        OrderProduct.OrderNumber = Order.OrderNumber;
                        OrderProduct.ProductArticle = product.Article;
                        OrderProduct.ProductCount = Convert.ToInt32(countTxtBox.Text);
                        Classes.ManageClass.dymshopEntities.orderproducts.Add(OrderProduct);
                        Classes.ManageClass.dymshopEntities.SaveChanges();
                        UserControl notifi = new UserControls.Notification("Добавлено успешно", 1);
                        notifi.HorizontalAlignment = HorizontalAlignment.Left;
                        notifi.VerticalAlignment = VerticalAlignment.Bottom;
                        Classes.ManageClass.mainWindow.GridMain.Children.Add(notifi);
                    }
                    else
                    {
                        UserControl notifi = new UserControls.Notification("Данный товар уже есть в корзине", 2);
                        notifi.HorizontalAlignment = HorizontalAlignment.Left;
                        notifi.VerticalAlignment = VerticalAlignment.Bottom;
                        mainGrid.Children.Add(notifi);
                        Grid.SetRow(notifi, 2);
                        Grid.SetColumnSpan(notifi, 2);
                    }
                }
                else
                {
                    UserControl notifi = new UserControls.Notification("Введите количество!", 2);
                    notifi.HorizontalAlignment = HorizontalAlignment.Left;
                    notifi.VerticalAlignment = VerticalAlignment.Bottom;
                    mainGrid.Children.Add(notifi);
                    Grid.SetRow(notifi, 2);
                    Grid.SetColumnSpan(notifi, 2);
                }
            }
            else
            {
                UserControl notifi = new UserControls.Notification("Вы не авторизованы!", 2);
                notifi.HorizontalAlignment = HorizontalAlignment.Left;
                notifi.VerticalAlignment = VerticalAlignment.Bottom;
                mainGrid.Children.Add(notifi);
                Grid.SetRow(notifi, 2);
                Grid.SetColumnSpan(notifi, 2);
            }
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            Classes.ManageClass.FrameMain.Navigate(new Pages.PageCatalog());
        }

        private void countTxtBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0))
            {
                e.Handled = true;
            }
        }

        private void plusItem_Click(object sender, RoutedEventArgs e)
        {
            if (countTxtBox.Text != "")
            { 
                countTxtBox.Text = (Convert.ToInt32(countTxtBox.Text) + 1).ToString();
            }
            else
            {
                countTxtBox.Text = "1";
            }

        }

        private void minusItem_Click(object sender, RoutedEventArgs e)
        {
            if (countTxtBox.Text != ""&& Convert.ToInt32(countTxtBox.Text)>0)
            {
                countTxtBox.Text = (Convert.ToInt32(countTxtBox.Text) - 1).ToString();
            }
            else
            {
                UserControl notifi = new UserControls.Notification("Ошибка!", 2);
                notifi.HorizontalAlignment = HorizontalAlignment.Left;
                notifi.VerticalAlignment = VerticalAlignment.Bottom;
                mainGrid.Children.Add(notifi);
                Grid.SetRow(notifi, 2);
                Grid.SetColumnSpan(notifi, 2);
            }
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
    }
}
