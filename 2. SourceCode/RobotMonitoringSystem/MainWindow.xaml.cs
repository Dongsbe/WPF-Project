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


namespace RobotMonitoringSystem
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public MainWindow(string userName) : this()
        {
            MainHeader.SetUserName(userName);
        }

        private void RobotManagementView_Checked(object sender, RoutedEventArgs e)
        {
            MainViewport.Content = new RobotManagementView();
        }

        private void DashboardView_Checked(object sender, RoutedEventArgs e)
        {
            if (MainViewport == null)
                return;

            MainViewport.Content = new DashboardView();
        }

        private void TaskManagementView_Checked(object sender, RoutedEventArgs e)
        {
            MainViewport.Content = new TaskManagementView();
        }

        private void TaskControlView_Checked(object sender, RoutedEventArgs e)
        {
            MainViewport.Content = new TaskControlView();
        }

        private void AlarmManagementView_Checked(object sender, RoutedEventArgs e)
        {
            MainViewport.Content = new AlarmManagementView();
        }

        private void HistoryView_Checked(object sender, RoutedEventArgs e)
        {
            MainViewport.Content = new HistoryView();
        }
    }

}
