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
using ACMer.BackendLibrary;

namespace ACMer
{
    /// <summary>
    /// ListItem.xaml 的交互逻辑
    /// </summary>
    public partial class ListItem : ListBoxItem
    {
        TicketDetail ticket;
        Backend backend;
        StackPanel[] stks = new StackPanel[10];
        int userID;
        public int Mode;
        public ListItem()
        {
            InitializeComponent();
        }
        public ListItem(TicketDetail t, Backend b, int id, int mode)
        {
            InitializeComponent();
            Mode = mode;
            backend = b;
            userID = id;
            stks[0] = stk1;
            stks[1] = stk2;
            stks[2] = stk3;
            stks[3] = stk4;
            stks[4] = stk5;
            stks[5] = stk6;
            stks[6] = stk7;
            stks[7] = stk8;
            stks[8] = stk9;
            stks[9] = stk10;
            ticket = t;
            Reset();
        }

        public void Reset()
        {
            ID.Text = ticket.TrainID;
            locFrom.Text = ticket.LocFrom;
            locTo.Text = ticket.LocTo;
            timeFrom.Text = ticket.DateFrom.ToString("yyyy-MM-dd HH:mm");
            timeTo.Text = ticket.DateTo.ToString("yyyy-MM-dd HH:mm");
            for (int i = 0; i < ticket.Cnt; ++i)
            {
                foreach (TextBlock u in stks[i].Children)
                {
                    if (u.Name.Contains("nm"))
                        u.Text = ticket.PriceNames[i];
                    else
                        u.Text = ticket.PriceNums[i].ToString() + " " + (TryFindResource("ticket.ticket") as string) + "\n¥" + ticket.Prices[i].ToString();
                }
                stks[i].Visibility = Visibility.Visible;
            }
            for (int i = ticket.Cnt; i < 10; ++i)
                stks[i].Visibility = Visibility.Collapsed;
        }

        public bool ChangeTicket(int th, int cnt)
        {
            if (Mode == 0)
                return backend.BuyTicket(userID, cnt, ticket.TrainID, ticket.LocFrom, ticket.LocTo, ticket.DateFrom, ticket.PriceNames[th]);
            else
                return backend.RefundTicket(userID, cnt, ticket.TrainID, ticket.LocFrom, ticket.LocTo, ticket.DateFrom, ticket.PriceNames[th]);
        }

        private void ListBoxItem_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Dialogs.DgTicket dg = new Dialogs.DgTicket(ticket, this);
            dg.ShowDialog();
        }
    }
}
