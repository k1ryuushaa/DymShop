   M S B A M L   `   `   `  ????I  EDymShopProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:DymShopProject.PagesDymShopProject.Pages  5      )    #DymShopProject.Pages.PageAdminPanel   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      _ [MaterialDesignThemes.Wpf, Version=4.6.1.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      .local"clr-namespace:DymShopProject.Pages  5        N? Title$  PageCatalog??5
      .??5      ? -   5         ?Name$ catalogGrid??5       ? ColumnDefinitions 5   
   ?? 5      $	??200 ?6   ?? 5      $
??341* ?6   ?? 5      $	??170 ?6   ?? 5      $	??170 ?6    ? RowDefinitions 5   
   ?? 5      $??50 ?6   6*   ?? 5      $	??87* ?6   6+   ?? 5      $??50 ?6   .+?5   
   ?? $??30(?6   $??DemiBold"?6"   $??Berlin Sans FB)?68   $??Center=?6T   $??Center=?6q   $??5q?6?   	DymShop6?   ?? 5   
   $??0??6   $??1??6!   $??3??61   $??25(?6E   $??Century Gothic)?6S   $??10q?6o   $
??Left=?6{   $??Center=?6?   Админ-панель6?   ?? 5   
   $??1??6   $??0??6"   $??4??62   .+?5      ?? -   5         ??Name$ btnProductEdit??5   `   $??100 10q?6   $-??'Редактировать товары??6%   $??Century Gothic)?6D   $??25(?6x   $
??auto??6?   6?   ?? 5      -   5        $ 
btnWorkers??5   V   $??100 10q?6   $??Сотрудники??6%   $??Century Gothic)?6:   $??25(?6j   $
??auto??6x   6?   #  MaterialDesignThemes.Wpf.Card  5      $??100 10q?6"   .??5      ?? $??10q?6   .+?5      ? .+?5       ?? $??5q?6$   $??Century Gothic)?6/   $??25(?6K   $??Center=?6Y   От:6y   (  "System.Windows.Controls.DatePicker  5!      -   5          Name$ 	StartDate??5!   %   $??Century Gothic)?68   $??25(?6T   $??50 5 5 5q?6b   $??Center=?6t   6?   5"      ? 5#       5$      ?? 5%      .+?5'      ?? $??	5,9,5,8.8q?6$   $??Century Gothic)?67   $??25(?6S   $??Center=?6a   До:6?     5(      -   5        $ EndDate??5(   %   $??Century Gothic)?66   $??25(?6R   $??
50,5,5,4.8q?6`   $??Center=?6t   6?   5)      ?? 5*      -   5        $ CreateReport??5*   9   $??Century Gothic)?6   $??25(?6O   $
??auto??6]   .??6?   Создть отчёт6?   5+      5,      5-      ?? 5.   
   $??2??6   $??4??6"    ?? Orientation$ 
Horizontal=?66   $??Right=?6O   .+?5/      ?? -   5        $ 	logoutBtn??5/      $??18(?6(   $??5q?66   $??Century Gothic)?6A   $??	25 5 25 5q?6]    ,  (MaterialDesignFlatSecondaryLightBgButton#??[  6q   ???	#FFB73A79.??6?   
Выйти6?   50      ?? 51   
   -   5        $ backBtn??51      $??18(?6"   $??3??60   $
??Left=?6=   $??5q?6X   $??Century Gothic)?6c   $??	25 5 25 5q?6   #??[  6?   ???	#FFB73A3A.??6  
Назад53      54      55      