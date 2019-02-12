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
    /// PgTrains.xaml 的交互逻辑
    /// </summary>
    public partial class PgTrains : UserControl
    {
        MainWindow parentWindow;
        Backend backend;
        public PgTrains(MainWindow parent, Backend b)
        {
            InitializeComponent();
            parentWindow = parent;
            backend = b;
        }

        public void Clear()
        {
            txtID.Clear();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            parentWindow.GotoAdmin(1);
        }

        private void btnQuery_Click(object sender, RoutedEventArgs e)
        {
            if (txtID.Text == "" || txtID.Text.Contains(" "))
            {
                Dialogs.Dialog dg = new Dialogs.Dialog("", TryFindResource("pgtrains.failed") as string);
                dg.ShowDialog();
                return;
            }
            Train t = backend.QueryTrain(txtID.Text);
            if (t == null)
            {
                Dialogs.Dialog dg = new Dialogs.Dialog("", TryFindResource("pgtrains.failed") as string);
                dg.ShowDialog();
                return;
            }
            parentWindow.GotoTrain(0, t);
        }

        private void btnNew_Click(object sender, RoutedEventArgs e)
        {
            parentWindow.GotoTrain(1);
        }
    }
}
