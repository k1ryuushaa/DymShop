   M S B A M L   `   `   `  ????I  EDymShopProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:DymShopProject.PagesDymShopProject.Pages  5      I)clr-namespace:DymShopProject.UserControlsDymShopProject.UserControls  5      &     DymShopProject.Pages.ProductInfo   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      _ [MaterialDesignThemes.Wpf, Version=4.6.1.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5      :d2http://schemas.microsoft.com/expression/blend/2008  5      .local"clr-namespace:DymShopProject.Pages  5      6notifi)clr-namespace:DymShopProject.UserControls  5        N? Title$  ProductInfo??5      .??5      ? -   5         ?Name$ mainGrid??5       ? RowDefinitions 5   
   ?? 5      $??50 ?6   6*   ?? 5      $	??400 ?6   6+   ?? 5      $	??73* ?6    ? ColumnDefinitions 5   
   ?? 5      6!   ?? 5      6!   .+?5   
   ?? $??30(?6   $??DemiBold"?6"   $??Berlin Sans FB)?68   $
??Left=?6T   $??
10,8,0,8.6q?6o   $??Center=?6?   ?? 6?   $?DymShop??6?   6?   ?? 5   
   $??Right=?6    ?? Orientation$ 
Horizontal=?61   $??1??6J   $??5q?6Z   .+?5      ?? -   5         ??Name$ 
korzinaBtn??5      $??18(?6)   $??5q?67   $??Century Gothic)?6B   $??	25 5 25 5q?6^    ,  (MaterialDesignFlatSecondaryLightBgButton#??[  6r   ???	#FF3AB7A7.??6?   Корзина5      ?? 5      -   5        $ 	logoutBtn??5      $??18(?6(   $??5q?66   $??Century Gothic)?6A   $??	25 5 25 5q?6]   #??[  6q   ???	#FFB73A79.??6?   
Выйти6?   ?? 5      -   5        $
 back??5      $??18(?6#   $??5q?61   $??Century Gothic)?6<   $??	25 5 25 5q?6X   #??[  6l   ???	#FFB73A3A.??6?   
Назад6?   5      #  MaterialDesignThemes.Wpf.Card  5   
   $??1??6   $??Stretch=?6+   $??30 30 10 10q?6I   $??Stretch=?6^   $??0??6{   .??5       ?? -   5         ??Name$ 
imgProduct??5       6+   5!        5"   
   $??1??6   $??Stretch=?6+   $??1??6J   $??Stretch=?6Z   $??10 30 30 10q?6v   .??5#      ? .+?5$      ?? $??10 30 10 10q?6   $	??Top=?62   .+?5%      ?? -   5         ??Name$ productName??5%   B   $??25(?6    $
??Wrap=?6.   $
??Bold"?6W   $??Century Gothic)?6i   $??Center=?6?   $??5q?6?   Наименование6?   ?? 5&      $??23(?6    $??Century Gothic)?6.   $??Center=?6J   $??5q?6g   ?? 5'      $?Стоимость:??6   $
??Bold"?6,   6@    ?? 5(      -   5         ??Name$ productCost??5(      61   5)      5*      ?? 5+      $ Vertical=?6   $??Bottom=?64   $??5 0 5 40q?6O   .+?5,      ?? $??Century Gothic)?6    $??25(?6<   $??Center=?6J   ???	#FF673AB7'%Выберите количество6?   ? 5-      $??Stretch=?6   .+?5.      ?? -   5        $ plusItem??5.   V   $
??Left=?6!   $??10q?6<   $??50(?6H   $??Century Gothic)?6i   $??0 -3 0 0q?6?    & "MaterialDesignFloatingActionButton#??[ 6?   .??6?   +6?   ?? 5/      -	   5        	 ??Name$	 countTxtBox??5/   "   $??70 10 70 10q?67   $??Stretch=?6L   $??Center=?6j   )  #MaterialDesignThemes.Wpf.HintAssist
   Hint$
 Количество??6?     MaterialDesignTextBox#??[ 6?   $??0q?6?   $??Century Gothic)?6?   $??25(?6  $??Center=?6  6l  ?? 50      -
   5        $ 	minusItem??50   X   $??Right=?6!   $??10q?6>   $??60(?6J   $??Century Gothic)?6k   $??	1 -14 0 0q?6?   #??[ 6?   .??6?   -6?   51      ?? 52      -   5        $ 	AddToCart??52      $??20(?60   $??Century Gothic)?6>   $??Center=?6Z   .??6?   $"Добавить в корзину6?   53      54      55        56   
   $??2??6   $??2??6+   $	??Top=?6?   $??
30 0 30 40q?6W   .??57      ? .+?58      ?? $??30(?6   $??5q?6+   $??Century Gothic)?66   $
??Wrap=?6R   ?? 59      $$?Описание товара:??6   $
??Bold"?62   6F    ?? 5:      -   5        $ productDescription??5:      68   5;      5<      5=      5>      5?      