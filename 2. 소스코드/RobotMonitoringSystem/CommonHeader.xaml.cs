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
using System.Windows.Threading;

namespace RobotMonitoringSystem
{
    /// <summary>
    /// CommonHeader.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class CommonHeader : UserControl
    {
        private readonly DispatcherTimer clockTimer = new DispatcherTimer();
        public CommonHeader()
        {
            InitializeComponent();

            UpdateClock();

            clockTimer.Interval = TimeSpan.FromSeconds(1);
            clockTimer.Tick += ClockTimer_Tick;
            clockTimer.Start();
        }

        public void SetUserName(string name)
        {
            UsernameText.Text = name + "님";
        }
        private void ClockTimer_Tick(object sender, EventArgs e)
        {
            UpdateClock();
        }

        private void UpdateClock()
        {
            CurrentTimeText.Text = DateTime.Now.ToString("yyyy. MM. dd. (ddd) HH:mm:ss");
        }

        // 최소화 기능
        private void Minimize_Click(object sender, RoutedEventArgs e)
        {
            Window window = Window.GetWindow(this);

            if(window != null)
            {
                window.WindowState = WindowState.Minimized;
            }
        }
        private void Maximize_Click(object sender, RoutedEventArgs e)
        {
            Window window = Window.GetWindow(this);

            if (window != null)
            {
                if (window.WindowState == WindowState.Maximized)
                    window.WindowState = WindowState.Normal;
                else
                    window.WindowState = WindowState.Maximized;
            }
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Window window = Window.GetWindow(this);

            if (window != null)
            {
                window.Close();
            }
        }
        private void Header_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Window window = Window.GetWindow(this);

            if (window != null &&
                e.ButtonState == MouseButtonState.Pressed)
            {
                window.DragMove();
            }
        }
    }
}
