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
using System.Windows.Shapes;

namespace RobotMonitoringSystem
{
    /// <summary>
    /// LoginWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void UsernameInput_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            // TODO : 로그인 화면 재개발(관리자 id: root, password: root로 임시개발)

            if(UsernameInput.Text == "root" && PasswordInput.Password == "root")
            {
                MainWindow mainWindow = new MainWindow("관리자");
                mainWindow.Show();

                Close();
            }
            else
            {
                MessageBox.Show(
                    "아이디 또는 비밀번호를 확인하세요.",
                    "로그인 실패",
                    MessageBoxButton.OK,
                    MessageBoxImage.Warning);
            }
        }
    }
}
