   M S B A M L   `   `   `  ????I  EDymShopProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:DymShopProject.UserControlsDymShopProject.UserControls  5      ;    5DymShopProject.UserControls.ProductControlForSalesman   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      _ [MaterialDesignThemes.Wpf, Version=4.6.1.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5      :d2http://schemas.microsoft.com/expression/blend/2008  5      5local)clr-namespace:DymShopProject.UserControls  5      $
??auto??5	      .??5
      ?? -   5          ??Name$  
productBrd??5
   L   
??????? ?? CornerRadius$ 30??6    $??10q?62    ? Cursor$
 Hand??6>    J? Effect 5   
   3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 10Q?6      	Direction$	 312Q?6/      ShadowDepth$ 0Q?6?   ._?5   
   ?? .+?5      ?? -   5         ??Name$ productImage??5      $	??150??6*   $??10q?67   6E   ?? 5      -   5         ??Name$ productName??5   o   $??20(?6   $??5 5 5 -4q?6&   	 ?? LineStackingStrategy$	 BlockLineHeight=?68   
 ?? 
LineHeight$
 20??6_   $
??Wrap=?6?   $
??Bold"?6?   $??Century Gothic)?6?   $??Center=?6?   wfwef6?   ?? 5      -   5        $ productCost??5   &   $??30(?6   $??Gabriola)?6;   $??Center=?6Q   wfwef6u   ?? 5      $??30(?6   $??Gabriola)?6&   $??Center=?6<   ?? 5      $?Поставщик:??6   $
??Bold"?6(   .?6:   6=    ?? 5      -   5         ??Name$ productSupplier??5      61   5      ? 5      $??Stretch=?6   .+?5      ?? -   5         ??Name$ plusItem??5   N   $
??Left=?6   $??10q?64   $??50(?6@   $??Century Gothic)?6a   $??0 -3 0 0q?6}    &  "MaterialDesignFloatingActionButton#??[  6?   .??6?   +6?   ?? 5      $??Century Gothic)?6   $??15(?68   $??Center=?6F   $	??Top=?6c   Кол-во на складе6?   ?? 5      -   5         ??Name$ countTxtBox??5      $??70 10 70 10q?6/   $??Stretch=?6D   $??Center=?6b     MaterialDesignTextBox#??[ 6?   $??0q?6?   $??Century Gothic)?6?   $??23(?6?   $??Center=?6?   6~  ?? 5      -   5        $ 	minusItem??5   P   $??Right=?6   $??10q?66   $??60(?6B   $??Century Gothic)?6c   $??	1 -14 0 0q?6   #??[  6?   .??6?   -6?   5      5      5      5      