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
    public partial class ProductControl : UserControl
    {
        public string article;
        public string category;
        public int cost;
        public ProductControl()
        {
            InitializeComponent();
        }

        private void productBrd_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            Classes.ManageClass.FrameMain.Navigate(new Pages.ProductInfo(article));
        }
    }
}
