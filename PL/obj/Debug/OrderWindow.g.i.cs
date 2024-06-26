﻿#pragma checksum "..\..\OrderWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1BC3D1B9A527BE0BBBFC1E0551F1144C3A11A0E2"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using PL;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace PL {
    
    
    /// <summary>
    /// OrderWindow
    /// </summary>
    public partial class OrderWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\OrderWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView OrderItemsListview;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\OrderWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ID;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\OrderWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TotalPrice;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\OrderWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Status;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\OrderWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DeliveryDate;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\OrderWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ShipDate;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\OrderWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox OrderDate;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\OrderWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CustomerAdress;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\OrderWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CustomerEmail;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\OrderWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CustomerName;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\OrderWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button updateDeliveyBtn;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\OrderWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button updateOredrBtn;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\OrderWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button updateShippingBtn;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\OrderWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BackBtn;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.2.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/PL;component/orderwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\OrderWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.2.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.OrderItemsListview = ((System.Windows.Controls.ListView)(target));
            return;
            case 2:
            this.ID = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.TotalPrice = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.Status = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.DeliveryDate = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.ShipDate = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.OrderDate = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.CustomerAdress = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.CustomerEmail = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.CustomerName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            this.updateDeliveyBtn = ((System.Windows.Controls.Button)(target));
            
            #line 56 "..\..\OrderWindow.xaml"
            this.updateDeliveyBtn.Click += new System.Windows.RoutedEventHandler(this.updateDeliveyBtn_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.updateOredrBtn = ((System.Windows.Controls.Button)(target));
            
            #line 57 "..\..\OrderWindow.xaml"
            this.updateOredrBtn.Click += new System.Windows.RoutedEventHandler(this.updateOredrBtn_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            this.updateShippingBtn = ((System.Windows.Controls.Button)(target));
            
            #line 60 "..\..\OrderWindow.xaml"
            this.updateShippingBtn.Click += new System.Windows.RoutedEventHandler(this.updateShippingBtn_Click);
            
            #line default
            #line hidden
            return;
            case 14:
            this.BackBtn = ((System.Windows.Controls.Button)(target));
            
            #line 61 "..\..\OrderWindow.xaml"
            this.BackBtn.Click += new System.Windows.RoutedEventHandler(this.BackBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

