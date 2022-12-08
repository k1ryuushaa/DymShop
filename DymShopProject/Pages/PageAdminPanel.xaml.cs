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
    public partial class PageAdminPanel : Page
    {
        public PageAdminPanel()
        {
            InitializeComponent();
            UserControl notifi = new UserControls.Notification($"Добро пожаловать,{Classes.ManageClass.User.UserName}!", 1);
            notifi.HorizontalAlignment = HorizontalAlignment.Left;
            notifi.VerticalAlignment = VerticalAlignment.Bottom;
            Classes.ManageClass.mainWindow.GridMain.Children.Add(notifi);
            StartDate.DisplayDateStart = Classes.ManageClass.dymshopEntities.orders.ToList().OrderBy(o => o.OrderDateStart).First().OrderDateStart;
            StartDate.DisplayDateEnd = Classes.ManageClass.dymshopEntities.orders.ToList().OrderBy(o => o.OrderDateStart).Last().OrderDateStart;
            EndDate.DisplayDateStart = Classes.ManageClass.dymshopEntities.orders.ToList().OrderBy(o => o.OrderDateStart).First().OrderDateStart;
            EndDate.DisplayDateEnd = Classes.ManageClass.dymshopEntities.orders.ToList().OrderBy(o => o.OrderDateStart).Last().OrderDateStart;
            CreateReport.IsEnabled = false;
        }
       

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            Windows.AuthRegWindow authRegWindow = new Windows.AuthRegWindow();
            authRegWindow.Show();
            Classes.ManageClass.mainWindow.Close();
        }

        private void logoutBtn_Click(object sender, RoutedEventArgs e)
        {
            Windows.AuthRegWindow authRegWindow = new Windows.AuthRegWindow();
            authRegWindow.Show();
            Classes.ManageClass.mainWindow.Close();
        }

        private void StartDate_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            if(StartDate.SelectedDate>EndDate.SelectedDate)
            {
                UserControl notifi = new UserControls.Notification("Нельзя выбрать больше конечной!", 2);
                notifi.HorizontalAlignment = HorizontalAlignment.Left;
                notifi.VerticalAlignment = VerticalAlignment.Bottom;
                Classes.ManageClass.mainWindow.GridMain.Children.Add(notifi);
                StartDate.SelectedDate = null;
            }
            if (StartDate.SelectedDate != null && EndDate.SelectedDate != null)
                CreateReport.IsEnabled = true;
        }

        private void EndDate_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            if (StartDate.SelectedDate > EndDate.SelectedDate)
            {
                UserControl notifi = new UserControls.Notification("Нельзя выбрать меньше конечной!", 2);
                notifi.HorizontalAlignment = HorizontalAlignment.Left;
                notifi.VerticalAlignment = VerticalAlignment.Bottom;
                Classes.ManageClass.mainWindow.GridMain.Children.Add(notifi);
                EndDate.SelectedDate = null;
            }
            if (StartDate.SelectedDate != null && EndDate.SelectedDate != null)
                CreateReport.IsEnabled = true;
        }

        private void CreateReport_Click(object sender, RoutedEventArgs e)
        {
            var orders = Classes.ManageClass.dymshopEntities.orders.Where(o => o.OrderDateStart >= StartDate.SelectedDate && o.OrderDateStart <= EndDate.SelectedDate);
            
            if (orders.ToList().Count()>0)
            {
                Excel.Application xlApp = new Excel.Application();
                if (xlApp == null)
                {
                    MessageBox.Show("Excel is not properly installed!!");
                    return;
                }
                Excel.Workbook xlWorkBook;
                Excel.Worksheet xlWorkSheet;
                object misValue = System.Reflection.Missing.Value;
                xlWorkBook = xlApp.Workbooks.Add(misValue);
                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
                Excel.Range _excelCells1 = xlWorkSheet.get_Range("A1", "D1").Cells;
                _excelCells1.Merge(Type.Missing);
                xlApp.StandardFont = "Century Gothic";
                xlApp.StandardFontSize = 14;
                xlWorkSheet.Cells[1, 1] = "Отчёт по завершённым заказам";
                xlWorkSheet.Cells[1, 1].HorizontalAlignment = -4108;
                xlWorkSheet.Cells[1, 1].EntireRow.Font.Bold = true;
                xlWorkSheet.Cells[2, 1] = "Составил:";
                xlWorkSheet.Cells[2, 2] = Classes.ManageClass.User.UserName;
                xlWorkSheet.Cells[3, 1] = "Дата составления:";
                xlWorkSheet.Cells[3, 2] = DateTime.Now.Date.ToShortDateString();
                xlWorkSheet.Cells[4, 1] = "от:";
                xlWorkSheet.Cells[4, 2] = StartDate.SelectedDate.ToString();
                xlWorkSheet.Cells[5, 1] = "до:";
                xlWorkSheet.Cells[5, 2] = EndDate.SelectedDate.ToString();

                xlWorkSheet.Cells[6, 1] = "Номер заказа";
                xlWorkSheet.Cells[6, 2] = "Артикул";
                xlWorkSheet.Cells[6, 3] = "Количество";
                xlWorkSheet.Cells[6, 4] = "Стоимость";

                var orderproducts = Classes.ManageClass.dymshopEntities.orderproducts.Where(o => o.order.OrderDateStart >= StartDate.SelectedDate && o.order.OrderDateStart <= EndDate.SelectedDate).ToList();
                
                int j = 0;
                int endRow=0;
                for (int i = 7; i < orderproducts.ToList().Count()+7; i++)
                {
                    string article = orderproducts[j].ProductArticle;
                    xlWorkSheet.Cells[i, 1] = orderproducts[j].order.OrderNumber.ToString();
                    xlWorkSheet.Cells[i, 2] = orderproducts[j].ProductArticle.ToString();
                    xlWorkSheet.Cells[i, 3] = orderproducts[j].ProductCount.ToString();
                    xlWorkSheet.Cells[i, 4] = (Classes.ManageClass.dymshopEntities.products.FirstOrDefault(p => p.Article == article).ProductCost* orderproducts[j].ProductCount).ToString();
                    j++;
                    endRow = i;
                }
                xlWorkSheet.Cells[endRow + 1, 3] = "ИТОГО";
                xlWorkSheet.Cells[endRow + 1, 4] = "=SUM(D7:D" + endRow + ")";

                xlWorkSheet.Columns.AutoFit();
                SaveFileDialog sfd = new SaveFileDialog();
                if (sfd.ShowDialog() == true)
                {
                    xlWorkBook.SaveAs(sfd.FileName, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                }
                xlWorkBook.Close();
                xlApp.Quit();
            }
            else
            {
                UserControl notifi = new UserControls.Notification("Завершённых заказов нет!", 2);
                notifi.HorizontalAlignment = HorizontalAlignment.Left;
                notifi.VerticalAlignment = VerticalAlignment.Bottom;
                Classes.ManageClass.mainWindow.GridMain.Children.Add(notifi);
            }
        }

        private void btnProductEdit_Click(object sender, RoutedEventArgs e)
        {
            Classes.ManageClass.FrameMain.Navigate(new Pages.PageCatalogAdmin());
        }

        private void btnWorkers_Click(object sender, RoutedEventArgs e)
        {
            Classes.ManageClass.FrameMain.Navigate(new Pages.PageCatalogWorkers());
        }
    }
}
