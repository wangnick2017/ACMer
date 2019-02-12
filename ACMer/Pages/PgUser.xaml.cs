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
    /// PgUser.xaml 的交互逻辑
    /// </summary>
    public partial class PgUser : UserControl
    {
        MainWindow parentWindow;
        Backend backend;
        public PgUser(MainWindow parent, Backend b)
        {
            InitializeComponent();
            parentWindow = parent;
            backend = b;
            
        }

        public void Clear()
        {
            lst.Items.Clear();
            loc1.Clear();
            loc2.Clear();
            date.SelectedDate = DateTime.Today;
        }

        int mode;
        public void SetMode(int m)
        {
            mode = m;
            btnBack.ToolTip = mode == 0 ? (TryFindResource("pguser.backTip0") as string) : (TryFindResource("pguser.backTip1") as string);
            BtnRefresh_Click(null, null);
            date.SelectedDate = DateTime.Today;
            SetInformation();
        }

        public void SetInformation()
        {
            txtName.Text = parentWindow.user.Name.ToString();
            labID.Content = "ID: " + parentWindow.user.UserID;
            labEmail.Content = "Email: " + parentWindow.user.Email.ToString();
            labPhone.Content = "Phone: " + parentWindow.user.Phone.ToString();
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            if (mode==0)
            {
                parentWindow.GotoLogin();
            }
            else
            {
                parentWindow.GotoAdmin(1);
            }
        }

        private void BtnQuery_Click(object sender, RoutedEventArgs e)
        {
            parentWindow.GotoQuery(loc1.Text, loc2.Text, date.SelectedDate);
        }

        private void BtnMyTicket_Click(object sender, RoutedEventArgs e)
        {
            parentWindow.GotoMyTicket();
        }

        private void BtnRefresh_Click(object sender, RoutedEventArgs e)
        {
            List<TicketDetail> list = backend.QueryOrder(parentWindow.user.UserID, DateTime.Today, "GDCZTKO");
            Something.Merge(list);
            lst.Items.Clear();
            if (list != null)
                for (int i = 0, s = list.Count; i < s; ++i)
                {
                    lst.Items.Add(new ListItem(list[i], backend, parentWindow.user.UserID, 1));
                }
        }

        private void BtnProfile_Click(object sender, RoutedEventArgs e)
        {
            parentWindow.GotoProfile();
        }

        private void BtnExchange_MouseUp(object sender, MouseButtonEventArgs e)
        {
            string tmp = loc1.Text;
            loc1.Text = loc2.Text;
            loc2.Text = tmp;
        }
    }
}
