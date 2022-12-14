#pragma checksum "..\..\..\Pages\PageCart.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1E89968E61803F28BC55E2C75E921064F4245830936622ECCAA869E080A1E8A8"
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
    /// PageCart
    /// </summary>
    public partial class PageCart : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\Pages\PageCart.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid catalogGrid;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\Pages\PageCart.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock CartName;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Pages\PageCart.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox ListProducts;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\Pages\PageCart.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock ErrNotifi;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\Pages\PageCart.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmBoxPickUpPoint;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\Pages\PageCart.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button createOrderBtn;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\Pages\PageCart.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button logoutBtn;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\Pages\PageCart.xaml"
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
            System.Uri resourceLocater = new System.Uri("/DymShopProject;component/pages/pagecart.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\PageCart.xaml"
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
            this.CartName = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.ListProducts = ((System.Windows.Controls.ListBox)(target));
            return;
            case 4:
            this.ErrNotifi = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.cmBoxPickUpPoint = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.createOrderBtn = ((System.Windows.Controls.Button)(target));
            
            #line 47 "..\..\..\Pages\PageCart.xaml"
            this.createOrderBtn.Click += new System.Windows.RoutedEventHandler(this.createOrderBtn_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.logoutBtn = ((System.Windows.Controls.Button)(target));
            
            #line 50 "..\..\..\Pages\PageCart.xaml"
            this.logoutBtn.Click += new System.Windows.RoutedEventHandler(this.logoutBtn_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.backBtn = ((System.Windows.Controls.Button)(target));
            
            #line 52 "..\..\..\Pages\PageCart.xaml"
            this.backBtn.Click += new System.Windows.RoutedEventHandler(this.backBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

