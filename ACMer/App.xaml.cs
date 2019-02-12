﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;

namespace ACMer
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {
        System.Threading.Mutex mutex;

        public App()
        {
            Startup += new StartupEventHandler(App_Startup);
        }

        void App_Startup(object sender, StartupEventArgs e)
        {
            mutex = new System.Threading.Mutex(true, "ElectronicNeedleTherapySystem", out bool ret);

            if (!ret)
            {
                MessageBox.Show("error");
                Environment.Exit(0);
            }

        }
    }
}
