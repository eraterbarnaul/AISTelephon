﻿#pragma checksum "..\..\..\..\Windows\Operator\OperatorMain.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "E028CFE028CCF23877D5EBBDC05FBBC1E8B21DEB9519DBFCF07D9F2634FC36B9"
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
using TelephoneNetwork.Windows.Operator;


namespace TelephoneNetwork.Windows.Operator {
    
    
    /// <summary>
    /// OperatorMain
    /// </summary>
    public partial class OperatorMain : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 30 "..\..\..\..\Windows\Operator\OperatorMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tbkLastNameOperator;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\Windows\Operator\OperatorMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tbkFirstNameOperator;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\Windows\Operator\OperatorMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSubscriber;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\..\Windows\Operator\OperatorMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnTariff;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\..\Windows\Operator\OperatorMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnExit;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\..\Windows\Operator\OperatorMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame frmOperator;
        
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
            System.Uri resourceLocater = new System.Uri("/TelephoneNetwork;component/windows/operator/operatormain.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Windows\Operator\OperatorMain.xaml"
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
            this.tbkLastNameOperator = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.tbkFirstNameOperator = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.btnSubscriber = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\..\..\Windows\Operator\OperatorMain.xaml"
            this.btnSubscriber.Click += new System.Windows.RoutedEventHandler(this.btnSubscriber_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnTariff = ((System.Windows.Controls.Button)(target));
            
            #line 47 "..\..\..\..\Windows\Operator\OperatorMain.xaml"
            this.btnTariff.Click += new System.Windows.RoutedEventHandler(this.btnTariff_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnExit = ((System.Windows.Controls.Button)(target));
            
            #line 52 "..\..\..\..\Windows\Operator\OperatorMain.xaml"
            this.btnExit.Click += new System.Windows.RoutedEventHandler(this.btnExit_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.frmOperator = ((System.Windows.Controls.Frame)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
