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

namespace WinFormsControlLab
{
    public partial class Clock : UserControl
    {
        System.Windows.Threading.DispatcherTimer timer;

        public Clock()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            timer = new System.Windows.Threading.DispatcherTimer();
            timer.Tick += new EventHandler(timerTick);
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Start();
        }

        private void timerTick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            second.RenderTransform = new RotateTransform(dt.Second * 6);
            minute.RenderTransform = new RotateTransform(dt.Minute * 6 + dt.Second / 10);
            hour.RenderTransform = new RotateTransform(dt.Hour * 30 + dt.Minute / 2);
        }
    }
}
