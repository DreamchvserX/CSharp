   M S B A M L   `   `   `  ????F  BStep14.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:DataApplicationDataApplication  5      O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5           DataApplication.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      /localclr-namespace:DataApplication     5      9system&clr-namespace:System;assembly=mscorlib     5        ? Title$  Window1??5      $	??350??6   $	??600??6"    ? 	Resources 5         CustomerDataProvider ? Source ? XPath  D1 S? 
ObjectType   DataApplication.Customer S? 
MethodName S? MethodParameters  SearchFieldsU QSystem.Runtime, Version=4.2.2.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a  System.Enum M? TypeName  SearchFieldMenuItemStyle ?? 
TargetType	 ?? Property
 ?? Value ?? DataType   DataApplication.SortField??%?  &	        &	 3     &	 ?     &	 ?     ? 5	   
   $ Data.xml??67   $ /Data??6I   S? 5   
   "  6(   $ GetCustomers??6M    5      ??5      5??6#   5      S? 5   
   "  62   $ 	GetValues??6T    5      M? 5      $ local:SortField??6   5      ?? 5   
   " m?61   .?5      ?? 	 ? ??
 5      ?? 5      "  6#   .R?5      ?? ??6$   ?? 5      5      ?? 5      	 ?@?Tag
 6$   ?? -   5        5!      5"       J? CommandBindings 5$      )  #System.Windows.Input.CommandBinding  5%   
   -   5           Command$) #local:MainWindow.NewCustomerCommand??5&      5'      .??5*      ]?  ? LayoutTransform 5+   
   ?? 5,       ?? ScaleX$	 1.5Q?6    ?? ScaleY$	 1.5Q?6*   .+?5.   
   o? $	??Top=?6   .@?5/      m? $??	Sortieren??6   #??[ 50   N   ??6   ??  ?? Source# [ 6N   51      `? 52   
   $	??Top=?6   .?53      c? .@?54      ?? $??80??6    ?? TextAlignment$ Right=?6%   .??6;   ??55      ?? 56      # [ 57       ?? BindsDirectlyToSource$
 True??58       ?? Path$ MethodParameters[0]?59       ?? UpdateSourceTrigger$ PropertyChanged=?5:      .??5;   $   5<      ?? 5=      -   5        .??5>      ?? $??16??6   $??16??6(   $
}?True??64   .+?5?      F? "???? 	=  z ? ? ??- ? ? @]? 	
???   ?67   5@      5A      ?? 5B      -   5        .??5C      ?? $??16??6   $??16??6(   $
}?True??64   .+?5D      F? "???? 	= ??- ? ?  z ? 	= @]? 	
???   ?66   5E      5F      ?? 5G      .??6   Gruppieren:6%   ?? 5H      -   5        $??GroupingComboBox??5H      $??85??63   .@?5I      ?? 6%   ?? 5J      .??6#   Name6)   ?? 5K      .??6#   Datum6*   5L      5M      5N      ?? 5O   
   $??Bottom=?6   .@?5P      ?? $	??100??6   .??6(   Ready6/   ?? 5Q      ?? 5R      .??6   Bitte hier angeben60   5S      ? 5U   
   $??Bottom=?6   $??6q?6'    ? ColumnDefinitions 5V      ?? 5W      $??75 ?6#   ?? 5X      $??6 ?6#   ?? 5Y       ? RowDefinitions 5[      ?? 5\      ?? 5]      .+?5_      ?? $??0??6   $??0??6(   $??Name:??65   $??Right=?6B   ?? 5`      $??2??6   $??0??6(   ??65   ?? # [ $ CurrentItem.Name??? 5a      $??0??6   $??1??6(   $??Erstellt am:??65   $??Right=?6I   ?? 5b      $??2??6   $??1??6(   ??65   ?? # [ $ /Created?5c      ?? 5d   
   -   5        $??	ListView1??5d      $ ?? IsSynchronizedWithCurrentItem$
 TrueY?5e   @   ??6   ?? # [  ?? 
GroupStyle 5g      (  "System.Windows.Controls.GroupStyle  5h         HeaderTemplate 5i      ?? 5j      .R?5k      ?? 
???   ?$??0 2 0 0q?69   ._?5l   "   ?? ?? 5m   &   $
??Bold"?60   $??Italic$?6B   ??6U   ?? $
 Name? ?? 5n   &   $??10(?60   $??Italic$?6>   
???????$??10 0 0 0q?6e   ?? 5o   *   $??(??64    ?? 5p   *   ??64   ?? $ 	ItemCount? ?? 5q   *   $??)??64   5r   '   5s   #   5t      5u      5w       5y        5z      -   5        $ ApplicationCommands.Open??5{      5|       ? ContextMenu 5~      ?? 5       ?? 	Placement$ Absolute=?6    ?? HorizontalOffset$ 10??63    ?? VerticalOffset$ 10??6I   .@?5?      m? $??Öffnen??6    m? Command$ ApplicationCommands.Open??6/   5?        ?? View  5?      ?? 5?      .P?5?      ?? $??Kunde??6%   ! ?? Width$	! 200??6_   " ?? DisplayMemberBinding" 64   ?? $
 Name?6_   ?? 5?      $??Erstellt am??6%   $	! 100??6h   " 6:   ?? $ Created?6h   5?      5?      5?      5?      