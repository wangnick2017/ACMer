using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.IO;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Maps.MapControl;
using ACMer.BackendLibrary;

namespace ACMer
{
    using Pages;
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        #region About animations
        ThicknessAnimation trec, tstk, trec3, tstk3;
        void SetAnimation()
        {
            trec = new ThicknessAnimation
            {
                Duration = TimeSpan.FromSeconds(5),
                RepeatBehavior = RepeatBehavior.Forever,
                From = new Thickness(5, 5, (Width - 10) / 6 * 5 - 20, 15),
                To = new Thickness((Width - 10) / 6 * 5 - 20, 5, 5, 15)
            };
            rec.BeginAnimation(MarginProperty, trec);

            tstk = new ThicknessAnimation
            {
                Duration = TimeSpan.FromSeconds(5),
                RepeatBehavior = RepeatBehavior.Forever,
                From = new Thickness(5, 0, (Width - 10) / 6 * 5 - 20, 0),
                To = new Thickness((Width - 10) / 6 * 5 - 20, 0, 5, 0)
            };
            stk.BeginAnimation(MarginProperty, tstk);


            trec3 = new ThicknessAnimation
            {
                Duration = TimeSpan.FromSeconds(6.5),
                RepeatBehavior = RepeatBehavior.Forever,
                From = new Thickness(5, 5, (Width - 10) / 6 * 5 - 20, 15),
                To = new Thickness((Width - 10) / 6 * 5 - 20, 5, 5, 15)
            };
            rec3.BeginAnimation(MarginProperty, trec3);

            tstk3 = new ThicknessAnimation
            {
                Duration = TimeSpan.FromSeconds(6.5),
                RepeatBehavior = RepeatBehavior.Forever,
                From = new Thickness(5, 0, (Width - 10) / 6 * 5 - 20, 0),
                To = new Thickness((Width - 10) / 6 * 5 - 20, 0, 5, 0)
            };
            stk3.BeginAnimation(MarginProperty, tstk3);
        }

        public bool Logged = false;
        public void HideAnimation()
        {
            if (Logged)
                return;
            rec.Visibility = Visibility.Hidden;
            stk.Visibility = Visibility.Hidden;
            pan.Visibility = Visibility.Hidden;
            pan2.Visibility = Visibility.Hidden;
            rec3.Visibility = Visibility.Hidden;
            stk3.Visibility = Visibility.Hidden;
            pan3.Visibility = Visibility.Hidden;
        }
        public void ShowAnimation()
        {
            if (Logged)
                return;
            rec.Visibility = Visibility.Visible;
            stk.Visibility = Visibility.Visible;
            pan.Visibility = Visibility.Visible;
            pan2.Visibility = Visibility.Visible;
            rec3.Visibility = Visibility.Visible;
            stk3.Visibility = Visibility.Visible;
            pan3.Visibility = Visibility.Visible;
        }
        bool faked = false;
        void SetFakeAnimation()
        {
            if (!faked)
            {
                faked = true;
                HideAnimation();
            }
        }
        void Unfake()
        {
            faked = false;
            ShowAnimation();
        }
        #endregion

        ResourceDictionary dicZH, dicEN;

        public MainWindow()
        {
            dicZH = new ResourceDictionary
            {
                Source = new Uri(@"Languages\ZH.xaml", UriKind.Relative)
            };
            dicEN = new ResourceDictionary
            {
                Source = new Uri(@"Languages\EN.xaml", UriKind.Relative)
            };

            try
            {
                StreamReader file = new StreamReader("lang.in");
                string s = file.ReadLine();
                if (s == "en")
                {
                    Application.Current.Resources.MergedDictionaries[0] = dicEN;
                }
                else
                {
                    Application.Current.Resources.MergedDictionaries[0] = dicZH;
                }
            }
            catch (Exception)
            {
                Application.Current.Resources.MergedDictionaries[0] = dicZH;
            }

            InitializeComponent();
            SetAnimation();

            if (Application.Current.Resources.MergedDictionaries[0] == dicZH)
                lang.Content = "English";
            else
                lang.Content = "简体中文";

            PreviewMouseMove += OnPreviewMouseMove;

            backend = new Backend();
            pgAdmin = new PgAdmin(this, backend);
            pgLogin = new PgLogin(this, backend);
            pgMyTicket = new PgMyTicket(this, backend);
            pgProfile = new PgProfile(this, backend);
            pgQuery = new PgQuery(this, backend);
            pgRegister = new PgRegister(this, backend);
            pgTrain = new PgTrain(this, backend);
            pgTrains = new PgTrains(this, backend);
            pgUser = new PgUser(this, backend);
            pgUsers = new PgUsers(this, backend);
            Logout();
            pageTransition.ShowPage(pgLogin);
        }

        public User user;

        Backend backend;
        PgAdmin pgAdmin;
        PgLogin pgLogin;
        PgMyTicket pgMyTicket;
        PgProfile pgProfile;
        PgQuery pgQuery;
        PgRegister pgRegister;
        PgTrain pgTrain;
        PgTrains pgTrains;
        PgUser pgUser;
        PgUsers pgUsers;

        void Logout()
        {
            user = null;
            pgMyTicket.Clear();
            pgTrains.Clear();
            pgUsers.Clear();
            pgUser.Clear();
        }

        /// <summary>
        /// 进入管理员界面
        /// </summary>
        /// <param name="mode">mode == 0 表示是管理员登录； 否则表示从其他状态返回来的</param>
        public void GotoAdmin(int mode)
        {
            HideAnimation();
            Logged = true;
            if (mode == 0)
                pgAdmin.SetMode();
            if (mode == 0)
                pageTransition.TransitionType = PageTransitions.PageTransitionType.GrowAndFade;
            else if (mode == 1)
                pageTransition.TransitionType = PageTransitions.PageTransitionType.Fade;
            else
                pageTransition.TransitionType = PageTransitions.PageTransitionType.Fade;
            pageTransition.ShowPage(pgAdmin);pageTransition.Opacity = 1;
        }
        public void GotoLogin()
        {
            Logged = false;
            ShowAnimation();
            if (user != null)
                pageTransition.TransitionType = PageTransitions.PageTransitionType.GrowAndFade;
            else
                pageTransition.TransitionType = PageTransitions.PageTransitionType.Slide;
            Logout();
            pgLogin.Clear();
            pageTransition.ShowPage(pgLogin);
        }
        public void GotoMyTicket()
        {
            pageTransition.TransitionType = PageTransitions.PageTransitionType.Slide;
            pageTransition.ShowPage(pgMyTicket);
        }
        public void GotoProfile()
        {
            pageTransition.TransitionType = PageTransitions.PageTransitionType.Slide;
            pgProfile.In();
            pgProfile.SetID(user.UserID);
            pageTransition.ShowPage(pgProfile);
        }
        public void GotoQuery(string loc1, string loc2, DateTime? date)
        {
            pageTransition.TransitionType = PageTransitions.PageTransitionType.Slide;
            pageTransition.ShowPage(pgQuery);
            pgQuery.SetPlace(loc1, loc2, date);
        }
        public void GotoRegister()
        {
            pageTransition.TransitionType = PageTransitions.PageTransitionType.Slide;
            pgRegister.In();
            pageTransition.ShowPage(pgRegister);
        }
        public void GotoTrain(int mode, Train t = null)
        {
            pageTransition.TransitionType = PageTransitions.PageTransitionType.Slide;
            pgTrain.SetMode(mode, t);
            pageTransition.ShowPage(pgTrain);
        }
        public void GotoTrains(int mode = 0)
        {
            pageTransition.TransitionType = mode == 0 ? PageTransitions.PageTransitionType.Slide : PageTransitions.PageTransitionType.Fade;
            pageTransition.ShowPage(pgTrains);
        }
        /// <summary>
        /// 进入普通用户界面
        /// </summary>
        /// <param name="mode">mode == 0 表示是普通用户登录； mode == 1 表示是管理员进入了普通用户模式； 否则表示从其他状态返回来的</param>
        public void GotoUser(int mode)
        {
            HideAnimation();
            Logged = true;
            if (mode >= 0)
                pgUser.SetMode(mode);
            if (mode == 0)
                pageTransition.TransitionType = PageTransitions.PageTransitionType.GrowAndFade;
            else if (mode == 1)
                pageTransition.TransitionType = PageTransitions.PageTransitionType.Slide;
            else
                pageTransition.TransitionType = PageTransitions.PageTransitionType.Fade;
            pgUser.SetInformation();
            pageTransition.ShowPage(pgUser);
        }
        public void GotoUsers()
        {
            pageTransition.TransitionType = PageTransitions.PageTransitionType.Fade;
            pageTransition.ShowPage(pgUsers);
        }



        protected void OnPreviewMouseMove(object sender, MouseEventArgs e)
        {
            if (Mouse.LeftButton != MouseButtonState.Pressed)
                Cursor = Cursors.Arrow;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ObjectSize.InitSizes();
            backend.Init();
            InitializeControl();
            pgRegister.Generate();
            pgProfile.Generate();
        }

        Button btnMinimize, btnRestore, btnClose;
        Rect sizeNormal;
        bool maxed = false;

        void InitializeControl()
        {
            if (Application.Current.FindResource("ACMWindowControlTemplate") is ControlTemplate template)
            {
                Label moveableLabel = template.FindName("MoveableLabel", this) as Label;
                moveableLabel.MouseMove += MoveableLabel_MouseMove;
                moveableLabel.MouseDown += MoveableLabel_MouseDown;
                btnMinimize = template.FindName("MinimizeButton", this) as Button;
                btnRestore = template.FindName("RestoreButton", this) as Button;
                btnClose = template.FindName("CloseButton", this) as Button;
                btnMinimize.Click += BtnMinimize_Click;
                btnRestore.Click += BtnRestore_Click;
                btnClose.Click += BtnClose_Click;

            }
        }

        private void MoveableLabel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ClickCount == 2)
            {
                BtnRestore_Click(null, null);
            }
        }

        void MoveableLabel_MouseMove(object sender, MouseEventArgs e)
        {
            if (Mouse.LeftButton == MouseButtonState.Pressed)
            {
                if (maxed)
                {
                    btnRestore.Content = "1";
                    Left = e.GetPosition(this).X * (1 - (sizeNormal.Width - btnClose.Width * 3) / (Width - btnClose.Width * 3));
                    Width = sizeNormal.Width;
                    Height = sizeNormal.Height;

                    maxed = !maxed;
                }
                DragMove();
            }
        }

        private void BtnMinimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void Lang_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (lang.Content.ToString() == "English")
            {
                Application.Current.Resources.MergedDictionaries[0] = dicEN;
                lang.Content = "简体中文";
            }
            else
            {
                Application.Current.Resources.MergedDictionaries[0] = dicZH;
                lang.Content = "English";
            }
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            using (StreamWriter file = new StreamWriter("lang.in"))
                file.WriteLine(lang.Content.ToString() == "English" ? "zh" : "en");
            backend.Dispose();
        }

        private void LabAbout_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Dialogs.DgAbout dg = new Dialogs.DgAbout();
            dg.ShowDialog();
        }

        private void BtnRestore_Click(object sender, RoutedEventArgs e)
        {
            if (!maxed)
            {
                btnRestore.Content = "2";
                sizeNormal = new Rect(Left, Top, Width, Height);
                Rect rc = SystemParameters.WorkArea;
                Left = rc.Left;
                Top = rc.Top;
                Width = rc.Width;
                Height = rc.Height;
            }
            else
            {
                btnRestore.Content = "1";
                Left = sizeNormal.Left;
                Top = sizeNormal.Top;
                Width = sizeNormal.Width;
                Height = sizeNormal.Height;
            }
            maxed = !maxed;
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        
        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            if (ActualHeight > SystemParameters.WorkArea.Height || ActualWidth > SystemParameters.WorkArea.Width)
            {
                WindowState = WindowState.Normal;
                BtnRestore_Click(null, null);
            }
        }
    }
}
