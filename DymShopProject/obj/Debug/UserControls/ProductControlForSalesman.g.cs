﻿#pragma checksum "..\..\..\UserControls\ProductControlForSalesman.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0EF8611C09133F787B382B610A93301CCF00DD039D6639719227D9BF9F5AF914"
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
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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
    /// ProductControlForSalesman
    /// </summary>
    public partial class ProductControlForSalesman : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\UserControls\ProductControlForSalesman.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border productBrd;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\UserControls\ProductControlForSalesman.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image productImage;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\UserControls\ProductControlForSalesman.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock productName;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\UserControls\ProductControlForSalesman.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock productCost;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\UserControls\ProductControlForSalesman.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Documents.Run productSupplier;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\UserControls\ProductControlForSalesman.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button plusItem;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\UserControls\ProductControlForSalesman.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox countTxtBox;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\UserControls\ProductControlForSalesman.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button minusItem;
        
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
            System.Uri resourceLocater = new System.Uri("/DymShopProject;component/usercontrols/productcontrolforsalesman.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UserControls\ProductControlForSalesman.xaml"
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
            this.productBrd = ((System.Windows.Controls.Border)(target));
            return;
            case 2:
            this.productImage = ((System.Windows.Controls.Image)(target));
            return;
            case 3:
            this.productName = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.productCost = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.productSupplier = ((System.Windows.Documents.Run)(target));
            return;
            case 6:
            this.plusItem = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\UserControls\ProductControlForSalesman.xaml"
            this.plusItem.Click += new System.Windows.RoutedEventHandler(this.plusItem_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.countTxtBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 25 "..\..\..\UserControls\ProductControlForSalesman.xaml"
            this.countTxtBox.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.countTxtBox_PreviewTextInput);
            
            #line default
            #line hidden
            
            #line 25 "..\..\..\UserControls\ProductControlForSalesman.xaml"
            this.countTxtBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.countTxtBox_TextChanged);
            
            #line default
            #line hidden
            
            #line 25 "..\..\..\UserControls\ProductControlForSalesman.xaml"
            this.countTxtBox.GotFocus += new System.Windows.RoutedEventHandler(this.countTxtBox_GotFocus);
            
            #line default
            #line hidden
            return;
            case 8:
            this.minusItem = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\UserControls\ProductControlForSalesman.xaml"
            this.minusItem.Click += new System.Windows.RoutedEventHandler(this.minusItem_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

