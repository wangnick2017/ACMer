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
    /// PgQuery.xaml 的交互逻辑
    /// </summary>
    public partial class PgQuery : UserControl
    {
        MainWindow parentWindow;
        Backend backend;
        public PgQuery(MainWindow parent, Backend b)
        {
            InitializeComponent();
            parentWindow = parent;
            backend = b;
        }

        public void SetPlace(string loc1, string loc2, DateTime? d)
        {
            txtLoc1.Text = loc1;
            txtLoc2.Text = loc2;
            date.SelectedDate = d;
            foreach (CheckBox ch in stack.Children)
            {
                ch.IsChecked = ch.Content.ToString() == "G";
            }
            chTransfer.IsChecked = false;
            BtnQuery_Click(null, null);
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            parentWindow.GotoUser(-1);
            lst.Items.Clear();
        }

        private void BtnQuery_Click(object sender, RoutedEventArgs e)
        {
            if (txtLoc1.Text == "" || txtLoc2.Text == "" || txtLoc1.Text.Contains(" ") || txtLoc2.Text.Contains(" ") || date.SelectedDate == null)
            {
                Dialogs.Dialog dg = new Dialogs.Dialog("", TryFindResource("pgquery.failed") as string);
                dg.ShowDialog();
                return;
            }
            string catalog = "";
            foreach (CheckBox ch in stack.Children)
            {
                if (ch.Content.ToString().Length == 1 && ch.IsChecked == true)
                {
                    catalog += ch.Content;
                }
            }
            List<TicketDetail> list = chTransfer.IsChecked == true ?
                backend.QueryTransfer(txtLoc1.Text, txtLoc2.Text, (DateTime)(date.SelectedDate), catalog) :
                backend.QueryTicket(txtLoc1.Text, txtLoc2.Text, (DateTime)(date.SelectedDate), catalog);
            Something.Merge(list);
            lst.Items.Clear();
            if (list != null && list.Count > 0)
                foreach (TicketDetail t in list)
                {
                    lst.Items.Add(new ListItem(t, backend, parentWindow.user.UserID, 0));
                }
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            foreach (CheckBox ch in stack.Children)
            {
                ch.IsChecked = true;
            }
        }

        private void BtnMap_Click(object sender, RoutedEventArgs e)
        {
            Dialogs.DgMap dg = new Dialogs.DgMap();
            dg.ShowDialog();
        }

        private void BtnExchange_MouseUp(object sender, MouseButtonEventArgs e)
        {
            string tmp = txtLoc1.Text;
            txtLoc1.Text = txtLoc2.Text;
            txtLoc2.Text = tmp;
        }
    }
}
