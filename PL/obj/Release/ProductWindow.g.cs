﻿#pragma checksum "..\..\ProductWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4C935863837F388FAFEC78127148917DCB4E6BB4"
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
    /// ProductWindow
    /// </summary>
    public partial class ProductWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\ProductWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox catergorySelector;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\ProductWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Name_text;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\ProductWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Instock_text;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\ProductWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Price_text;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\ProductWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CRUD_btn1;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\ProductWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CRUD_btn2;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\ProductWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ID_text;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\ProductWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label ID_lbl;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\ProductWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addProductToCartBtn;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\ProductWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Back;
        
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
            System.Uri resourceLocater = new System.Uri("/PL;component/productwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ProductWindow.xaml"
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
            this.catergorySelector = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 2:
            this.Name_text = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.Instock_text = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.Price_text = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.CRUD_btn1 = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\ProductWindow.xaml"
            this.CRUD_btn1.Click += new System.Windows.RoutedEventHandler(this.CRUD_Click_btn);
            
            #line default
            #line hidden
            return;
            case 6:
            this.CRUD_btn2 = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\ProductWindow.xaml"
            this.CRUD_btn2.Click += new System.Windows.RoutedEventHandler(this.CRUD_Click_btn);
            
            #line default
            #line hidden
            return;
            case 7:
            this.ID_text = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.ID_lbl = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.addProductToCartBtn = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\ProductWindow.xaml"
            this.addProductToCartBtn.Click += new System.Windows.RoutedEventHandler(this.addProductToCartBtn_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.Back = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\ProductWindow.xaml"
            this.Back.Click += new System.Windows.RoutedEventHandler(this.BackButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

