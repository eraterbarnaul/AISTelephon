﻿#pragma checksum "..\..\..\..\Windows\Manager\TariffManagerPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "E5232820F1D9965246F98862CA5F71FE5C2ADC77185E03422E0E2E0D8977D80B"
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
using TelephoneNetwork.Windows.Manager;


namespace TelephoneNetwork.Windows.Manager {
    
    
    /// <summary>
    /// TariffManagerPage
    /// </summary>
    public partial class TariffManagerPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\..\..\Windows\Manager\TariffManagerPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnBack;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\..\Windows\Manager\TariffManagerPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnUpdate;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\..\Windows\Manager\TariffManagerPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbSearch;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\..\Windows\Manager\TariffManagerPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lvTariffPlan;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\..\..\Windows\Manager\TariffManagerPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAddTariff;
        
        #line default
        #line hidden
        
        
        #line 91 "..\..\..\..\Windows\Manager\TariffManagerPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnEditTariff;
        
        #line default
        #line hidden
        
        
        #line 100 "..\..\..\..\Windows\Manager\TariffManagerPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDeleteTariff;
        
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
            System.Uri resourceLocater = new System.Uri("/TelephoneNetwork;component/windows/manager/tariffmanagerpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Windows\Manager\TariffManagerPage.xaml"
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
            
            #line 28 "..\..\..\..\Windows\Manager\TariffManagerPage.xaml"
            this.btnBack.Click += new System.Windows.RoutedEventHandler(this.btnBack_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnUpdate = ((System.Windows.Controls.Button)(target));
            
            #line 48 "..\..\..\..\Windows\Manager\TariffManagerPage.xaml"
            this.btnUpdate.Click += new System.Windows.RoutedEventHandler(this.btnUpdate_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txbSearch = ((System.Windows.Controls.TextBox)(target));
            
            #line 57 "..\..\..\..\Windows\Manager\TariffManagerPage.xaml"
            this.txbSearch.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txbSearch_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.lvTariffPlan = ((System.Windows.Controls.ListView)(target));
            
            #line 64 "..\..\..\..\Windows\Manager\TariffManagerPage.xaml"
            this.lvTariffPlan.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.lvTariffPlan_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnAddTariff = ((System.Windows.Controls.Button)(target));
            
            #line 90 "..\..\..\..\Windows\Manager\TariffManagerPage.xaml"
            this.btnAddTariff.Click += new System.Windows.RoutedEventHandler(this.btnAddTariff_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnEditTariff = ((System.Windows.Controls.Button)(target));
            
            #line 99 "..\..\..\..\Windows\Manager\TariffManagerPage.xaml"
            this.btnEditTariff.Click += new System.Windows.RoutedEventHandler(this.btnEditTariff_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnDeleteTariff = ((System.Windows.Controls.Button)(target));
            
            #line 107 "..\..\..\..\Windows\Manager\TariffManagerPage.xaml"
            this.btnDeleteTariff.Click += new System.Windows.RoutedEventHandler(this.btnDeleteTariff_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

