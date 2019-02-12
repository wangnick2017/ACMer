﻿using System;
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
    /// PgUsers.xaml 的交互逻辑
    /// </summary>
    public partial class PgUsers : UserControl
    {
        MainWindow parentWindow;
        Backend backend;
        public PgUsers(MainWindow parent, Backend b)
        {
            InitializeComponent();
            parentWindow = parent;
            backend = b;
        }

        public void Clear()
        {
            txtUserID.Clear();
        }

        private void BtnModify_Click(object sender, RoutedEventArgs e)
        {
            TxtUserID_TextChanged(null, null);
            if (errID.Visibility == Visibility.Visible)
                return;
            if (backend.ModifyPrivilege(parentWindow.user.UserID, Convert.ToInt32(txtUserID.Text), 2))
            {
                Dialogs.Dialog dg = new Dialogs.Dialog("", TryFindResource("pgusers.ok") as string);
                dg.ShowDialog();
            }
            else
            {
                Dialogs.Dialog dg = new Dialogs.Dialog("", TryFindResource("pgusers.failed") as string);
                dg.ShowDialog();
            }
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            parentWindow.GotoAdmin(1);
        }

        private void TxtUserID_TextChanged(object sender, TextChangedEventArgs e)
        {
            errID.Visibility = (Int32.TryParse(txtUserID.Text, out int result)) ? Visibility.Hidden : Visibility.Visible;
        }
    }
}
