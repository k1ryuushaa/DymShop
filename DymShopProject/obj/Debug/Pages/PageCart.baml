   M S B A M L   `   `   `  ????I  EDymShopProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:DymShopProject.PagesDymShopProject.Pages  5      #    DymShopProject.Pages.PageCart   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      _ [MaterialDesignThemes.Wpf, Version=4.6.1.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      .local"clr-namespace:DymShopProject.Pages  5        N? Title$  PageCatalog??5
      .??5      ? -   5         ?Name$ catalogGrid??5       ? ColumnDefinitions 5   
   ?? 5      $	??200 ?6   ?? 5       ? RowDefinitions 5   
   ?? 5      $??50 ?6   6*   ?? 5      $	??87* ?6   6+   ?? 5      $??50 ?6   .+?5   
   ?? $??30(?6   $??DemiBold"?6"   $??Berlin Sans FB)?68   $??Center=?6T   $??Center=?6q   $??10q?6?   	DymShop6?   ?? 5   
   -   5         ??Name$ CartName??5   $   $??1??6   $
??Left=?66   $??Center=?6Q   $??23(?6l   $??Century Gothic)?6z   $??10q?6?   5      ?? 5   
   -   5         ??Name$ ListProducts??5      $??2??6(   $??1??6<   $	??Top=?6I   
?????? $??0q?6z   $??Disabled=?6?   $??2??6?   ??5      ?? 5      .R?5      A?  A? Columns$ 4??6"   5      ??5       ?? 5!       ?? 
TargetType" ??6   .?5"      ??  ?? Property ? ??	 ?? Value	 5#      ?? 5$      
 ?? 
TargetType"
 ??6.   .R?5%   "   ?? 5&      5(      5)      5+      ?? 5,   
   -   5        $ 	ErrNotifi??5,   ?   $??Gabriola)?6   $??40(?6*   $??1??68   $??Center=?6E   $??Center=?6b   $y?Hidden=?6}   $??2??6?   *(Товаров в корзине нет!6?   ?? 5-   
   $??2??6    ?? Orientation$ 
Horizontal=?6"   $??Right=?6;   $??1??6W   $??
0,0,0,-0.4q?6g   .+?5.      ?? -   5         ??Name$ cmBoxPickUpPoint??5.         MaterialDesignComboBox#??[  61   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Пункт выдачи??6a   $??Century Gothic)?6?   $??20(?6?   $??0q?6?   6?   ?? 5/      -   5         ??Name$ createOrderBtn??5/      $??18(?6-   $??5q?6;   $??Century Gothic)?6F   $??	25 5 25 5q?6b    , (MaterialDesignFlatSecondaryLightBgButton#??[ 6v   ???	#FF3AB7A7.??6?   Заказать51      ?? 52      -   5        $ 	logoutBtn??52      $??18(?6(   $??5q?66   $??Century Gothic)?6A   $??	25 5 25 5q?6]   #??[ 6q   ???	#FFB73A79.??6?   
Выйти6?   53      ?? 54   
   -   5        $ backBtn??54      $??18(?6"   $??2??60   $
??Left=?6=   $??	5,9,0,8.6q?6X   $??Century Gothic)?6k   $??	25 5 25 5q?6?   #??[ 6?   ???	#FFB73A3A.??6  
Назад56      57      58      