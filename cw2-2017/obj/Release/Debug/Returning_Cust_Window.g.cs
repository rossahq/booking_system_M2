﻿#pragma checksum "..\..\Returning_Cust_Window.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "893410C35211FCB1506BAAA4EBDEEDFD"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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


namespace cw2_2017 {
    
    
    /// <summary>
    /// Returning_Cust_Window
    /// </summary>
    public partial class Returning_Cust_Window : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\Returning_Cust_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_invoice;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\Returning_Cust_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_delete_booking;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\Returning_Cust_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_delete_cust;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\Returning_Cust_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lstbox_cust;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\Returning_Cust_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_customer_ref;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\Returning_Cust_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_booking_ref;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\Returning_Cust_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lstbox_booking;
        
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
            System.Uri resourceLocater = new System.Uri("/cw2-2017;component/returning_cust_window.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Returning_Cust_Window.xaml"
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
            this.btn_invoice = ((System.Windows.Controls.Button)(target));
            
            #line 10 "..\..\Returning_Cust_Window.xaml"
            this.btn_invoice.Click += new System.Windows.RoutedEventHandler(this.btn_invoice_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btn_delete_booking = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\Returning_Cust_Window.xaml"
            this.btn_delete_booking.Click += new System.Windows.RoutedEventHandler(this.delete_cust_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btn_delete_cust = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\Returning_Cust_Window.xaml"
            this.btn_delete_cust.Click += new System.Windows.RoutedEventHandler(this.delete_book);
            
            #line default
            #line hidden
            return;
            case 4:
            this.lstbox_cust = ((System.Windows.Controls.ListBox)(target));
            
            #line 13 "..\..\Returning_Cust_Window.xaml"
            this.lstbox_cust.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.customer_listbox);
            
            #line default
            #line hidden
            return;
            case 5:
            this.txt_customer_ref = ((System.Windows.Controls.TextBox)(target));
            
            #line 16 "..\..\Returning_Cust_Window.xaml"
            this.txt_customer_ref.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txt_customer_ref_TextChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.txt_booking_ref = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.lstbox_booking = ((System.Windows.Controls.ListBox)(target));
            
            #line 20 "..\..\Returning_Cust_Window.xaml"
            this.lstbox_booking.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.lstbox_booking_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

