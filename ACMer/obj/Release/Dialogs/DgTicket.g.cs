﻿#pragma checksum "..\..\..\Dialogs\DgTicket.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "A236D316858CB58C6A956F06FF6AB18D61F7846F"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using ACMer;
using Microsoft.Windows.Themes;
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


namespace ACMer.Dialogs {
    
    
    /// <summary>
    /// DgTicket
    /// </summary>
    public partial class DgTicket : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 320 "..\..\..\Dialogs\DgTicket.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label locFrom;
        
        #line default
        #line hidden
        
        
        #line 321 "..\..\..\Dialogs\DgTicket.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label ID;
        
        #line default
        #line hidden
        
        
        #line 322 "..\..\..\Dialogs\DgTicket.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label locTo;
        
        #line default
        #line hidden
        
        
        #line 323 "..\..\..\Dialogs\DgTicket.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label timeFrom;
        
        #line default
        #line hidden
        
        
        #line 324 "..\..\..\Dialogs\DgTicket.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label timeTo;
        
        #line default
        #line hidden
        
        
        #line 325 "..\..\..\Dialogs\DgTicket.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox com;
        
        #line default
        #line hidden
        
        
        #line 326 "..\..\..\Dialogs\DgTicket.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox com2;
        
        #line default
        #line hidden
        
        
        #line 330 "..\..\..\Dialogs\DgTicket.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCnt;
        
        #line default
        #line hidden
        
        
        #line 333 "..\..\..\Dialogs\DgTicket.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock err;
        
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
            System.Uri resourceLocater = new System.Uri("/ACMer;component/dialogs/dgticket.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Dialogs\DgTicket.xaml"
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
            
            #line 294 "..\..\..\Dialogs\DgTicket.xaml"
            ((System.Windows.Controls.Label)(target)).MouseMove += new System.Windows.Input.MouseEventHandler(this.Label_MouseMove);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 295 "..\..\..\Dialogs\DgTicket.xaml"
            ((System.Windows.Controls.Label)(target)).MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.Label_MouseUp);
            
            #line default
            #line hidden
            return;
            case 3:
            this.locFrom = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.ID = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.locTo = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.timeFrom = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.timeTo = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.com = ((System.Windows.Controls.ComboBox)(target));
            
            #line 325 "..\..\..\Dialogs\DgTicket.xaml"
            this.com.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Com_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.com2 = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 10:
            this.txtCnt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            
            #line 331 "..\..\..\Dialogs\DgTicket.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.err = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

