   M S B A M L   `   `   `  ????C  ?Lb.Start, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:Lb.StartLb.Start  5   	       Lb.Start.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Lb.Start     5   	     ? Title$  Fahrtenbuch??5   	   $	??700??6   $
??1400??6*   .??5	      ]? .+?5
   
   o? $	??Top=?6    o? 
IsMainMenu$
 True??6$   ???#8762cc.@?5      ?? $
??Left=?6   $??Webdings)?6/   $	??ACR??6E   m? 5      $??Ansicht??6   6*   m? 5      $??Hilfe??6   6(   5      ? 5   
    ? ColumnDefinitions 5      ?? 5      $??1* ?6#   ?? 5      $??3* ?6#   .+?5      ? $??0??6   $??0??6#   ???#a284db.+?5      ?? -   5        $??Fahrten??5      $??Center=?6+   $??0,75,0,0q?6H   $	??Top=?6Z   $??30??6r   $	??100??6~   
??????????#c0bbc9$??Gadugi)?6?   6?   ?? 5      -   5        $??Fahrer??5      $??Center=?6*   $	??Top=?6G   $??30??6_   $	??100??6k   
??????????#c0bbc9$??Gadugi)?6?   $??	0,150,0,0q?6?   6?   ?? 5      -   5        $??Fahrzeug??5      $??Center=?6,   $	??Top=?6I   $??30??6a   $	??100??6m   
??????????#c0bbc9$??Gadugi)?6?   $??	0,225,0,0q?6?   6?   ?? 5      -   5        $
??Orte??5      $??Center=?6(   $??	0,300,0,0q?6E   $	??Top=?6X   $??30??6p   $	??100??6|   
??????????#c0bbc9$??Gadugi)?6?   6?   ?? 5      -   5        $??Zwecke??5      $??Center=?6*   $??	0,375,0,0q?6G   $	??Top=?6Z   $??30??6r   $	??100??6~   
??????????#c0bbc9$??Gadugi)?6?   6?   5      ? 5      $??1??6   $??0??6#   ???#8762cc ? RowDefinitions 5      ?? 5       $
??150* ?6$   ?? 5!      $	??10* ?6$   .+?5#       ? -   5          ?Name$ 	FrameMain??5#      $??0??6+   $??0??6;     ? Source$ FahrtenPage.xaml??6H   ???#d3c5ed  ? NavigationUIVisibility$ Hidden=?6w   ?? 5$      $??Hinzufügen??6   $
??Left=?6.   $??10,0,0,0q?6I   $??1??6[   $??Center=?6h   $??99??6?   $
??Bold"?6?   ?? 5%      $??
Bearbeiten??6   $??Right=?6.   $??0,0,10,0q?6J   $??1??6\   $??Center=?6i   $??99??6?   $
??Bold"?6?   ?? 5&      -   5        $??Center=?5&      $??1??67    ?? TextWrapping$
 Wrap=?6D   $??Center=?6X   $	??280??6s    ?? TextAlignment$ Center=?6?   5'      5+      5,      5-      