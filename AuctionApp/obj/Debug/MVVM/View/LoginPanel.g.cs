﻿#pragma checksum "..\..\..\..\MVVM\View\LoginPanel.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "82F64404CA5940F5A60A7FE82D493632DA06D26AAAED9E6EF482CD5741496604"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using AuctionApp.MVVM.View;
using AuctionApp.MVVM.ViewModel;
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


namespace AuctionApp.MVVM.View {
    
    
    /// <summary>
    /// LoginPanel
    /// </summary>
    public partial class LoginPanel : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 35 "..\..\..\..\MVVM\View\LoginPanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox UsernameTextbox;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\..\MVVM\View\LoginPanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox PasswordTextbox;
        
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
            System.Uri resourceLocater = new System.Uri("/AuctionApp;component/mvvm/view/loginpanel.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\MVVM\View\LoginPanel.xaml"
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
            this.UsernameTextbox = ((System.Windows.Controls.TextBox)(target));
            
            #line 37 "..\..\..\..\MVVM\View\LoginPanel.xaml"
            this.UsernameTextbox.GotFocus += new System.Windows.RoutedEventHandler(this.UsernameTextbox_OnGotFocus);
            
            #line default
            #line hidden
            return;
            case 2:
            this.PasswordTextbox = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 52 "..\..\..\..\MVVM\View\LoginPanel.xaml"
            this.PasswordTextbox.PasswordChanged += new System.Windows.RoutedEventHandler(this.PasswordTextbox_PasswordChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 60 "..\..\..\..\MVVM\View\LoginPanel.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SignIn);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 69 "..\..\..\..\MVVM\View\LoginPanel.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SignUp);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

