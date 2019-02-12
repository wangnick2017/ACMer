using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ACMer.BackendLibrary;

namespace ACMer.Pages
{
    /// <summary>
    /// PgAdmin.xaml 的交互逻辑
    /// </summary>
    public partial class PgAdmin : UserControl
    {
        MainWindow parentWindow;
        Backend backend;
        public PgAdmin(MainWindow parent, Backend b)
        {
            InitializeComponent();
            parentWindow = parent;
            backend = b;
        }

        public void SetMode()
        {
            txtName.Text = parentWindow.user.Name.ToString();
        }

        private void BtnIamUser_Click(object sender, RoutedEventArgs e)
        {
            parentWindow.GotoUser(1);
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            parentWindow.GotoLogin();
        }

        private void BtnTrains_Click(object sender, RoutedEventArgs e)
        {
            parentWindow.GotoTrains();
        }

        private void BtnUsers_Click(object sender, RoutedEventArgs e)
        {
            parentWindow.GotoUsers();
        }
    }
}
