﻿#pragma checksum "..\..\..\Windows\SubscriberPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "27D4FCC72B89E422CADCE3E7A105EA7C1B49A94006C42C8576CFDDB5F953A4EB"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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
using TelephoneNetwork.Windows;


namespace TelephoneNetwork.Windows {
    
    
    /// <summary>
    /// SubscriberPage
    /// </summary>
    public partial class SubscriberPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\..\Windows\SubscriberPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnBack;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\Windows\SubscriberPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnUpdate;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\Windows\SubscriberPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbSearch;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\Windows\SubscriberPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbGenderFiltr;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\Windows\SubscriberPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lvSubscriber;
        
        #line default
        #line hidden
        
        
        #line 95 "..\..\..\Windows\SubscriberPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAddSubscriber;
        
        #line default
        #line hidden
        
        
        #line 104 "..\..\..\Windows\SubscriberPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnOpenSubscriber;
        
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
            System.Uri resourceLocater = new System.Uri("/TelephoneNetwork;component/windows/subscriberpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\SubscriberPage.xaml"
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
            this.btnBack = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\Windows\SubscriberPage.xaml"
            this.btnBack.Click += new System.Windows.RoutedEventHandler(this.btnBack_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnUpdate = ((System.Windows.Controls.Button)(target));
            
            #line 52 "..\..\..\Windows\SubscriberPage.xaml"
            this.btnUpdate.Click += new System.Windows.RoutedEventHandler(this.btnUpdate_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txbSearch = ((System.Windows.Controls.TextBox)(target));
            
            #line 61 "..\..\..\Windows\SubscriberPage.xaml"
            this.txbSearch.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txbSearch_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.cmbGenderFiltr = ((System.Windows.Controls.ComboBox)(target));
            
            #line 69 "..\..\..\Windows\SubscriberPage.xaml"
            this.cmbGenderFiltr.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cmbFiltration_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.lvSubscriber = ((System.Windows.Controls.ListView)(target));
            
            #line 75 "..\..\..\Windows\SubscriberPage.xaml"
            this.lvSubscriber.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.lvSubscriber_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnAddSubscriber = ((System.Windows.Controls.Button)(target));
            
            #line 103 "..\..\..\Windows\SubscriberPage.xaml"
            this.btnAddSubscriber.Click += new System.Windows.RoutedEventHandler(this.btnAddSubscriber_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnOpenSubscriber = ((System.Windows.Controls.Button)(target));
            
            #line 112 "..\..\..\Windows\SubscriberPage.xaml"
            this.btnOpenSubscriber.Click += new System.Windows.RoutedEventHandler(this.btnOpenSubscriber_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
