﻿#pragma checksum "..\..\..\UserControls\OrderControl.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "E2EB28D2E235FAB76FDE20F704CDDE4F8D884B1D07778D10058047E9BF931BF1"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using DymShopProject.UserControls;
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


namespace DymShopProject.UserControls {
    
    
    /// <summary>
    /// OrderControl
    /// </summary>
    public partial class OrderControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\..\UserControls\OrderControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Documents.Run InfoBuyer;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\UserControls\OrderControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Documents.Run OrderNumber;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\UserControls\OrderControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Documents.Run OrderStatus;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\UserControls\OrderControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Documents.Run CodeOrder;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\UserControls\OrderControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Documents.Run DateOrder;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\UserControls\OrderControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Documents.Run OrderCost;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\UserControls\OrderControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button OrderGive;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\UserControls\OrderControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SeeContent;
        
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
            System.Uri resourceLocater = new System.Uri("/DymShopProject;component/usercontrols/ordercontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UserControls\OrderControl.xaml"
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
            this.InfoBuyer = ((System.Windows.Documents.Run)(target));
            return;
            case 2:
            this.OrderNumber = ((System.Windows.Documents.Run)(target));
            return;
            case 3:
            this.OrderStatus = ((System.Windows.Documents.Run)(target));
            return;
            case 4:
            this.CodeOrder = ((System.Windows.Documents.Run)(target));
            return;
            case 5:
            this.DateOrder = ((System.Windows.Documents.Run)(target));
            return;
            case 6:
            this.OrderCost = ((System.Windows.Documents.Run)(target));
            return;
            case 7:
            this.OrderGive = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\..\UserControls\OrderControl.xaml"
            this.OrderGive.Click += new System.Windows.RoutedEventHandler(this.OrderGive_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.SeeContent = ((System.Windows.Controls.Button)(target));
            
            #line 44 "..\..\..\UserControls\OrderControl.xaml"
            this.SeeContent.Click += new System.Windows.RoutedEventHandler(this.SeeContent_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
