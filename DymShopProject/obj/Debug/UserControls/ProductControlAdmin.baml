   M S B A M L   `   `   `  ????I  EDymShopProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:DymShopProject.UserControlsDymShopProject.UserControls  5      5    /DymShopProject.UserControls.ProductControlAdmin   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      _ [MaterialDesignThemes.Wpf, Version=4.6.1.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5      :d2http://schemas.microsoft.com/expression/blend/2008  5      5local)clr-namespace:DymShopProject.UserControls  5      $
??auto??5	      .??5
      ?? -   5          ??Name$  
productBrd??5
   L   
??????? ?? CornerRadius$ 10??6    $??10q?62    ? Cursor$
 Hand??6>    J? Effect 5   
   3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 10Q?6      	Direction$	 312Q?6/      ShadowDepth$ 0Q?6?   ._?5   
   ?? .+?5      ?? -   5         ??Name$ productImage??5      $	??150??6*   $??10q?67   6E   ?? 5      -   5         ??Name$ productName??5   ?   $??20(?6   $??Stretch=?6$   $
??15 5q?6B   )  #MaterialDesignThemes.Wpf.HintAssist	   Hint$	 Наименование??6P   $??Center=?6~   
 ?? TextWrapping$

 Wrap=?6?   $
??Bold"?6?   $??Century Gothic)?6?   .??6?   wfwef6  ?? 5      -   5        $ productCost??5   2   $??20(?6   $
??15 5q?6$   $	 Цена??6G   $??Century Gothic)?6m   $??Center=?6?   $??Stretch=?6?   .??6?   wfwef6?   ? 5      $
??15 5q?6    ? ColumnDefinitions 5      ?? 5      6)   ?? 5      6)   .+?5      ?? -   5         ??Name$ EditProductBtn??5   N   $??15(?6   $??2q?6'   $??Century Gothic)?62   ???	#FF3AB749.??6?   Изменить6?   ?? 5      -   5        $ DeleteProductBtn??5   N   $??15(?6   $??2q?6'   $??Century Gothic)?62   $??1??6h   ???	#FFB73A50.??6?   Удалить6?   5      5      5      5      