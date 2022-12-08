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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace DymShopProject.UserControls
{
    /// <summary>
    /// Логика взаимодействия для Notification.xaml
    /// </summary>
    public partial class Notification : UserControl
    {
        Color green = (Color)ColorConverter.ConvertFromString("#FF56E456");
        Color red = (Color)ColorConverter.ConvertFromString("#FFE45660");
        DispatcherTimer timer = new DispatcherTimer();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        /// <param name="color">1-зелёный, 2-красный</param>
        public Notification(string message,int color)
        {
            InitializeComponent();
            textNotifi.Text = message;
            if(color==1)
                notifiBrd.Background = new SolidColorBrush(green);
            else
                notifiBrd.Background = new SolidColorBrush(red);
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Interval = TimeSpan.FromSeconds(3);
            timer.Start();
        }
        int sec = 0;
        private void Timer_Tick(object sender, EventArgs e)
        {
            sec++;
            if(sec==2)
            {
                this.Visibility = Visibility.Hidden;
                sec = 0;
                timer.Stop();
            }
        }
    }
}
