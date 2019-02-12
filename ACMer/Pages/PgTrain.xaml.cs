using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
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

namespace ACMer.Pages
{
    /// <summary>
    /// PageTrain.xaml 的交互逻辑
    /// </summary>
    public partial class PgTrain : UserControl
    {
        MainWindow parentWindow;
        Backend backend;
        Train train, tmpTrain;
        ObservableCollection<StationView> source;
        public PgTrain(MainWindow parent, Backend b)
        {
            InitializeComponent();
            parentWindow = parent;
            backend = b;
            source = new ObservableCollection<StationView>();
            grid.ItemsSource = source;
        }

        void SetTrain()
        {
            source.Clear();
            txtID.Text = train.TrainID.ToString();
            txtName.Text = train.Name.ToString();
            foreach (RadioButton rd in stack.Children)
            {
                rd.IsChecked = train.Catalog == rd.Content.ToString()[0];
            }
            foreach (CheckBox ch in stack2.Children)
            {
                ch.IsChecked = false;
                foreach (var str in train.PriceNames)
                    if (str == ch.Content.ToString())
                        ch.IsChecked = true;
            }
            for (int i = 3; i < grid.Columns.Count; ++i)
            {
                bool flag = false;
                foreach (var str in train.PriceNames)
                    if (str == grid.Columns[i].Header.ToString())
                    {
                        flag = true;
                        break;
                    }
                grid.Columns[i].Visibility = flag ? Visibility.Visible : Visibility.Hidden;
            }
            for (int i = 0; i < train.StationNum; ++i)
            {
                StationView s = new StationView();
                s.Name = train.Stations[i].Name.ToString();
                s.ArriveDay = train.Stations[i].TimeArrive.Days;
                s.ArriveHour = train.Stations[i].TimeArrive.Hours;
                s.ArriveMinute = train.Stations[i].TimeArrive.Minutes;
                s.StartDay = train.Stations[i].TimeStart.Days;
                s.StartHour = train.Stations[i].TimeStart.Hours;
                s.StartMinute = train.Stations[i].TimeStart.Minutes;
                for (int j = 0; j < train.PriceNum; ++j)
                    switch (train.PriceNames[j].ToString())
                    {
                        case "一等座":
                            s.P一等座 = train.Stations[i].Prices[j].ToString();
                            break;
                        case "二等座":
                            s.P二等座 = train.Stations[i].Prices[j].ToString();
                            break;
                        case "特等座":
                            s.P特等座 = train.Stations[i].Prices[j].ToString();
                            break;
                        case "商务座":
                            s.P商务座 = train.Stations[i].Prices[j].ToString();
                            break;
                        case "硬卧":
                            s.P硬卧 = train.Stations[i].Prices[j].ToString();
                            break;
                        case "软卧":
                            s.P软卧 = train.Stations[i].Prices[j].ToString();
                            break;
                        case "高级软卧":
                            s.P高级软卧 = train.Stations[i].Prices[j].ToString();
                            break;
                        case "无座":
                            s.P无座 = train.Stations[i].Prices[j].ToString();
                            break;
                        case "硬座":
                            s.P硬座 = train.Stations[i].Prices[j].ToString();
                            break;
                        case "软座":
                            s.P软座 = train.Stations[i].Prices[j].ToString();
                            break;
                        default:
                            break;
                    }
                source.Add(s);
            }
        }

        public void SetMode(int mode, Train t = null)
        {
            if (mode == 1)
            {
                title.Content = TryFindResource("pgtrain.add") as string;
                btnModify.Visibility = Visibility.Collapsed;
                btnSell.Visibility = Visibility.Collapsed;
                btnSubmit.Visibility = Visibility.Visible;
                btnDelete.Visibility = Visibility.Collapsed;
                txtID.IsEnabled = true;
                txtID.Text = "";
                txtName.IsEnabled = true;
                txtName.Text = "";
                foreach (RadioButton rd in stack.Children)
                {
                    rd.IsChecked = false;
                }
                foreach (CheckBox ch in stack2.Children)
                {
                    ch.IsChecked = false;
                }
                grid.IsReadOnly = false;
                stack.IsEnabled = true;
                stack2.IsEnabled = true;
                btnAdd.IsEnabled = true;
                btnRemove.IsEnabled = true;
                source.Clear();
                for (int i = 3; i < grid.Columns.Count; ++i)
                    grid.Columns[i].Visibility = Visibility.Hidden;
            }
            else
            {
                modified = false;
                train = t;
                title.Content = TryFindResource("pgtrain.look") as string;
                txtID.IsEnabled = false;
                btnModify.Visibility = Visibility.Visible;
                btnSell.Visibility = Visibility.Visible;
                btnSubmit.Visibility = Visibility.Collapsed;
                btnDelete.Visibility = Visibility.Visible;
                grid.IsReadOnly = true;
                txtName.IsEnabled = false;
                stack.IsEnabled = false;
                stack2.IsEnabled = false;
                btnAdd.IsEnabled = false;
                btnRemove.IsEnabled = false;
                SetTrain();
            }
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            if (modified)
            {
                btnModify_Click(null, null);
            }
            parentWindow.GotoTrains(1);
        }

        private void CheckBox1_Checked(object sender, RoutedEventArgs e)
        {
            foreach (CheckBox ch in stack.Children)
            {
                ch.IsChecked = true;
            }
        }

        private void CheckBox2_Checked(object sender, RoutedEventArgs e)
        {
            foreach (CheckBox ch in stack2.Children)
            {
                ch.IsChecked = true;
            }
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            source.Add(new StationView());
        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            if (grid.SelectedIndex >= 0 && grid.SelectedIndex < source.Count)
                source.RemoveAt(grid.SelectedIndex);
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            string s = ((CheckBox)sender).Content.ToString();
            for (int i = 0; i < grid.Columns.Count; ++i)
                if (grid.Columns[i].Header.ToString() == s)
                    grid.Columns[i].Visibility = Visibility.Hidden;
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            string s = ((CheckBox)sender).Content.ToString();
            for (int i = 0; i < grid.Columns.Count; ++i)
                if (grid.Columns[i].Header.ToString() == s)
                    grid.Columns[i].Visibility = Visibility.Visible;
        }

        bool modified;
        private void btnModify_Click(object sender, RoutedEventArgs e)
        {
            modified = !modified;
            if (modified)
            {
                btnModify.Content = TryFindResource("pgtrain.btnmodify2") as string;
                btnSell.IsEnabled = false;
                btnDelete.IsEnabled = false;
                grid.IsReadOnly = false;
                txtName.IsEnabled = true;
                stack.IsEnabled = true;
                stack2.IsEnabled = true;
                btnAdd.IsEnabled = true;
                btnRemove.IsEnabled = true;
            }
            else
            {
                btnModify.Content = TryFindResource("pgtrain.btnmodify1") as string;
                btnSell.IsEnabled = true;
                btnDelete.IsEnabled = true;
                grid.IsReadOnly = true;
                txtName.IsEnabled = false;
                stack.IsEnabled = false;
                stack2.IsEnabled = false;
                btnAdd.IsEnabled = false;
                btnRemove.IsEnabled = false;
                if (GetTrain() && backend.ModifyTrain(tmpTrain))
                {
                    train = tmpTrain;
                    Dialogs.Dialog dg = new Dialogs.Dialog("", TryFindResource("pgtrain.modok") as string);
                    dg.ShowDialog();
                }
                else
                {
                    Dialogs.Dialog dg = new Dialogs.Dialog("", TryFindResource("pgtrain.moderr") as string);
                    dg.ShowDialog();
                    SetTrain();
                }
            }
        }

        bool GetTrain()
        {
            if (txtID.Text == "" || txtName.Text == "" || txtID.Text.Contains(" ") || txtName.Text.Contains(" "))
                return false;
            char c = '\0';
            foreach (RadioButton rd in stack.Children)
            {
                if (rd.IsChecked == true && rd.Content.ToString().Length == 1)
                {
                    c = rd.Content.ToString()[0];
                }
            }
            int priceNum = 0;
            for (int i = 3; i < grid.Columns.Count; ++i)
                if (grid.Columns[i].Visibility == Visibility.Visible)
                    ++priceNum;
            string[] priceNames = new string[priceNum];
            for (int i = 3, j = 0; i < grid.Columns.Count; ++i)
                if (grid.Columns[i].Visibility == Visibility.Visible)
                {
                    priceNames[j] = grid.Columns[i].Header.ToString();
                    ++j;
                }
            Station[] stations = new Station[source.Count];
            for (int i = 0, sz = source.Count; i < sz; ++i)
            {
                double[] prices = new double[priceNum];
                for (int ii = 3, j = 0; ii < grid.Columns.Count; ++ii)
                    if (grid.Columns[ii].Visibility == Visibility.Visible)
                    {
                        string str;
                        switch (priceNames[j])
                        {
                            case "一等座":
                                str = source[i].P一等座;
                                break;
                            case "二等座":
                                str = source[i].P二等座;
                                break;
                            case "特等座":
                                str = source[i].P特等座;
                                break;
                            case "商务座":
                                str = source[i].P商务座;
                                break;
                            case "硬卧":
                                str = source[i].P硬卧;
                                break;
                            case "软卧":
                                str = source[i].P软卧;
                                break;
                            case "高级软卧":
                                str = source[i].P高级软卧;
                                break;
                            case "硬座":
                                str = source[i].P硬座;
                                break;
                            case "软座":
                                str = source[i].P软座;
                                break;
                            case "无座":
                                str = source[i].P无座;
                                break;
                            default:
                                str = "";
                                break;
                        }
                        if (!Double.TryParse(str, out prices[j]))
                            return false;
                        ++j;
                    }
                stations[i] = new Station(source[i].Name, new TimeSpan(source[i].ArriveDay * 24 + source[i].ArriveHour, source[i].ArriveMinute, 0), new TimeSpan(source[i].StartDay * 24 + source[i].StartHour, source[i].StartMinute, 0), prices);
            }
            tmpTrain = new Train(txtID.Text, txtName.Text, c, priceNames, stations);
            return true;
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            if (GetTrain() && backend.AddTrain(tmpTrain))
            {
                train = tmpTrain;
                Dialogs.Dialog dg = new Dialogs.Dialog("", TryFindResource("pgtrain.addok") as string);
                dg.ShowDialog();
                btnBack_Click(null, null);
            }
            else
            {
                Dialogs.Dialog dg = new Dialogs.Dialog("", TryFindResource("pgtrain.adderr") as string);
                dg.ShowDialog();
            }
        }

        private void btnSale_Click(object sender, RoutedEventArgs e)
        {
            if (backend.SellTrain(train.TrainID))
            {
                Dialogs.Dialog dg = new Dialogs.Dialog("", TryFindResource("pgtrain.saleok") as string);
                dg.ShowDialog();
            }
            else
            {
                Dialogs.Dialog dg = new Dialogs.Dialog("", TryFindResource("pgtrain.saleerr") as string);
                dg.ShowDialog();
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (backend.RemoveTrain(train.TrainID))
            {
                Dialogs.Dialog dg = new Dialogs.Dialog("", TryFindResource("pgtrain.deleteok") as string);
                dg.ShowDialog();
                btnBack_Click(null, null);
            }
            else
            {
                Dialogs.Dialog dg = new Dialogs.Dialog("", TryFindResource("pgtrain.deleteerr") as string);
                dg.ShowDialog();
            }
        }
    }
}
