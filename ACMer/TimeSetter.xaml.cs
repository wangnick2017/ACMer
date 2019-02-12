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

namespace ACMer
{
    /// <summary>
    /// TimeSetter.xaml 的交互逻辑
    /// </summary>
    public partial class TimeSetter : UserControl
    {
        public TimeSetter()
        {
            InitializeComponent();
            Binding binding1 = new Binding();
            binding1.Source = this;
            binding1.Path = new PropertyPath("Day");
            binding1.Mode = BindingMode.TwoWay;
            Days.SetBinding(ComboBox.SelectedIndexProperty, binding1);

            Binding binding2 = new Binding();
            binding2.Source = this;
            binding2.Path = new PropertyPath("Hour");
            binding2.Mode = BindingMode.TwoWay;
            Hours.SetBinding(ComboBox.SelectedIndexProperty, binding2);

            Binding binding3 = new Binding();
            binding3.Source = this;
            binding3.Path = new PropertyPath("Minute");
            binding3.Mode = BindingMode.TwoWay;
            Minutes.SetBinding(ComboBox.SelectedIndexProperty, binding3);
        }

        
        public int Day
        {
            get { return (int)GetValue(DayProperty); }
            set { SetValue(DayProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Day.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty DayProperty =
            DependencyProperty.Register("Day", typeof(int), typeof(TimeSetter), new PropertyMetadata(0));


        public int Hour
        {
            get { return (int)GetValue(HourProperty); }
            set { SetValue(HourProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Hour.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty HourProperty =
            DependencyProperty.Register("Hour", typeof(int), typeof(TimeSetter), new PropertyMetadata(0));


        public int Minute
        {
            get { return (int)GetValue(MinuteProperty); }
            set { SetValue(MinuteProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Minute.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MinuteProperty =
            DependencyProperty.Register("Minute", typeof(int), typeof(TimeSetter), new PropertyMetadata(0));
    }
}
