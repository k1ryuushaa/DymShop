﻿#pragma checksum "..\..\..\Pages\PageCatalog.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C1C8E7A45D1A7B914B28E078EEAA945FC9E5143D6D99859B6C326204FB2606A5"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using DymShopProject.Pages;
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


namespace DymShopProject.Pages {
    
    
    /// <summary>
    /// PageCatalog
    /// </summary>
    public partial class PageCatalog : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\Pages\PageCatalog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid catalogGrid;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Pages\PageCatalog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SearchTextBox;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Pages\PageCatalog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CategoryFilter;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\Pages\PageCatalog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CostSort;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\Pages\PageCatalog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox ListProducts;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\Pages\PageCatalog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock ErrNotifi;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\Pages\PageCatalog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button korzinaBtn;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\Pages\PageCatalog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button logoutBtn;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\Pages\PageCatalog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button backBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/DymShopProject;component/pages/pagecatalog.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\PageCatalog.xaml"
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
            this.catalogGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.SearchTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 25 "..\..\..\Pages\PageCatalog.xaml"
            this.SearchTextBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.SearchTextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.CategoryFilter = ((System.Windows.Controls.ComboBox)(target));
            
            #line 26 "..\..\..\Pages\PageCatalog.xaml"
            this.CategoryFilter.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.CategoryFilter_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.CostSort = ((System.Windows.Controls.ComboBox)(target));
            
            #line 27 "..\..\..\Pages\PageCatalog.xaml"
            this.CostSort.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.CostSort_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ListProducts = ((System.Windows.Controls.ListBox)(target));
            return;
            case 6:
            this.ErrNotifi = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.korzinaBtn = ((System.Windows.Controls.Button)(target));
            
            #line 50 "..\..\..\Pages\PageCatalog.xaml"
            this.korzinaBtn.Click += new System.Windows.RoutedEventHandler(this.korzinaBtn_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.logoutBtn = ((System.Windows.Controls.Button)(target));
            
            #line 53 "..\..\..\Pages\PageCatalog.xaml"
            this.logoutBtn.Click += new System.Windows.RoutedEventHandler(this.logoutBtn_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.backBtn = ((System.Windows.Controls.Button)(target));
            
            #line 55 "..\..\..\Pages\PageCatalog.xaml"
            this.backBtn.Click += new System.Windows.RoutedEventHandler(this.backBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

