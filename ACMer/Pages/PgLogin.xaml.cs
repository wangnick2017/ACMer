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
    /// PgLogin.xaml 的交互逻辑
    /// </summary>
    public partial class PgLogin : UserControl
    {
        MainWindow parentWindow;
        Backend backend;
        public PgLogin(MainWindow parent, Backend b)
        {
            InitializeComponent();
            parentWindow = parent;
            backend = b;
        }

        public string ID
        {
            get;
            set;
        }

        private void BtnRegister_Click(object sender, RoutedEventArgs e)
        {
            parentWindow.GotoRegister();
        }

        public void Clear()
        {
            txtPassword.Password = "";
            errPassword.Visibility = Visibility.Hidden;
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            TxtID_TextChanged(null, null);
            TxtPassword_PasswordChanged(null, null);
            if (errID.Visibility == Visibility.Visible || errPassword.Visibility == Visibility.Visible)
                return;
            int id = Convert.ToInt32(txtID.Text);
            string pass = Something.MD5Encrypt(txtPassword.Password);
            User user = backend.Login(id, pass);
            if (user != null)
            {
                parentWindow.user = user;
                if (parentWindow.user.Privilege == 1)
                {
                    parentWindow.HideAnimation();
                    parentWindow.GotoUser(0);
                }
                else if (parentWindow.user.Privilege == 2)
                {
                    parentWindow.GotoAdmin(0);
                }
            }
            else
            {
                Dialogs.Dialog dg = new Dialogs.Dialog("", TryFindResource("pglog.failed") as string);
                dg.ShowDialog();
            }
        }
        private void TxtID_TextChanged(object sender, TextChangedEventArgs e)
        {
            errID.Visibility = (Int32.TryParse(txtID.Text, out int result)) ? Visibility.Hidden : Visibility.Visible;
        }

        private void TxtPassword_PasswordChanged(object sender, RoutedEventArgs e)
        {
            errPassword.Visibility = (txtPassword.Password == "" || txtPassword.Password.Contains(" ")) ? Visibility.Visible : Visibility.Hidden;
        }
    }
}
