﻿#pragma checksum "..\..\..\Pages\PgMyTicket.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1332ECCFCCA59193A6E8F1ADFCB1B44CCE736E4DDDDB87A4FA0A61DB070F4C17"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using ACMer.Pages;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace ACMer.Pages {
    
    
    /// <summary>
    /// PgMyTicket
    /// </summary>
    public partial class PgMyTicket : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 31 "..\..\..\Pages\PgMyTicket.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker date1;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\Pages\PgMyTicket.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker date2;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\Pages\PgMyTicket.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel stack;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\Pages\PgMyTicket.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnQuery;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\Pages\PgMyTicket.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lst;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\Pages\PgMyTicket.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnBack;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ACMer;component/pages/pgmyticket.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\PgMyTicket.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.date1 = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 2:
            this.date2 = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 3:
            this.stack = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 4:
            
            #line 34 "..\..\..\Pages\PgMyTicket.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Checked += new System.Windows.RoutedEventHandler(this.CheckBox_Checked);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnQuery = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\..\Pages\PgMyTicket.xaml"
            this.btnQuery.Click += new System.Windows.RoutedEventHandler(this.BtnQuery_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.lst = ((System.Windows.Controls.ListBox)(target));
            return;
            case 7:
            this.btnBack = ((System.Windows.Controls.Button)(target));
            
            #line 48 "..\..\..\Pages\PgMyTicket.xaml"
            this.btnBack.Click += new System.Windows.RoutedEventHandler(this.BtnBack_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

