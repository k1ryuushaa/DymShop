   M S B A M L   `   `   `  ????I  EDymShopProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:DymShopProject.PagesDymShopProject.Pages  5      (    "DymShopProject.Pages.PageOrderInfo   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      _ [MaterialDesignThemes.Wpf, Version=4.6.1.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      .local"clr-namespace:DymShopProject.Pages  5        N? Title$  PageCatalog??5
      .??5      ? -   5         ?Name$ catalogGrid??5       ? ColumnDefinitions 5   
   ?? 5      $	??200 ?6   ?? 5      ?? 5      $	??170 ?6    ? RowDefinitions 5   
   ?? 5      $??50 ?6   6*   ?? 5      $	??87* ?6   6+   ?? 5      $??50 ?6   .+?5   
   ?? $??30(?6   $??DemiBold"?6"   $??Berlin Sans FB)?68   $??Center=?6T   $??Center=?6q   $??36,9,36,8.4q?6?   	DymShop6?   ?? 5   
   -   5         ??Name$ ListProducts??5      $??3??6(   $	??Top=?6<   
?????? $??0q?6m   $??Disabled=?6?   $??2??6?   $??1??6?   ??5      ?? 5      .R?5      A?  A? Columns$ 4??6"   5      ??5      ?? 5        ?? 
TargetType" ??6   .?5!      ??  ?? Property ? ?? ?? Value 5"      ?? 5#      	 ?? 
TargetType"	 ??6.   .R?5$   "   ?? 5%      5'      5(      5*      ?? 5+   
   -   5        
 ??Name$
 	ErrNotifi??5+   ?   $??Gabriola)?6   $??40(?6*   $??1??68   $??Center=?6E   $??Center=?6b   $y?Hidden=?6}   $??3??6?   (&Продукция не найдена6?   ?? 5,   
   $??2??6   $??2??6"    ?? Orientation$ 
Horizontal=?66   $??Right=?6O   $??1??6k   $??
0,0,0,-0.4q?6{   .+?5-      ?? -   5         ??Name$ 	logoutBtn??5-      $??18(?6(   $??5q?66   $??Century Gothic)?6A   $??	25 5 25 5q?6]    ,  (MaterialDesignFlatSecondaryLightBgButton#??[  6q   ???	#FFB73A79.??6?   
Выйти6?   5.      ?? 5/   
   -   5        $ backBtn??5/      $??18(?6"   $??2??60   $
??Left=?6=   $??5q?6X   $??Century Gothic)?6c   $??	25 5 25 5q?6   #??[  6?   ???	#FFB73A3A.??6  
Назад51      52      53      