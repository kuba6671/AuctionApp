   M S B A M L   `   `   `  ����E  AAuctionApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:AuctionApp
AuctionApp  5   	   E'clr-namespace:AuctionApp.MVVM.ViewModelAuctionApp.MVVM.ViewModel  5   	       AuctionApp.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:AuctionApp     5   	   =	viewModel'clr-namespace:AuctionApp.MVVM.ViewModel     5   	     � Title$  
MainWindow��5	   	   $	��650��5
   	   $	��920��5   	    � WindowStyle$
 None=�5   	    � 
ResizeMode$ NoResize=�5   	   
������  � AllowsTransparency .  � DataContext 5      -  'AuctionApp.MVVM.ViewModel.MainViewModel  5   
   .��5      �� ���#272537 �� CornerRadius$ 10��5   	   ._�5   
   �  � ColumnDefinitions 5      �� 5      $	��200 �6#   �� 5       � RowDefinitions 5      �� 5      $��75 �6    �� 5      .+�5"      �� $��Auction App��6   $��Center=�5#      $
��Left=�5$      
�������$��22(�5&      $��20,0,0,0q�5'      �� 5)      $��1��6   .+�5*      	� $��Strona główna��6   $��50��5+      
�������$��14(�5-         MenuButtonTheme#��[  5.       d� 	IsChecked$
 TrueY�5/      ��50      �� *HomeViewCommand+	� 52      $��Sprzedaj��6   $��50��53      
�������$��14(�55      #��[  56      ��57      �� *SellViewCommand+	� 59      $	��Kup��6   $��50��5:      
�������$��14(�5<      #��[  5=      ��5>      �� *PurchaseViewCommand+5?      �� 5A      $	��250��6   $��40��5B      $��Center=�5C      $
��Left=�5D      $��5q�5E      $��1��5F        ModernTextBox#��[ 5G      �� 5J      $��x��6   $��30��5K      $��30��5L      ���#272537$	��Top=�5N      $��Right=�5O      $��1��5Q      ��5P      �� *CloseCommand+5Q      �� 5S      $��1��6   $��1��5T      $��10q�5U      ��5V      �� *CurrentView+5W      5X      5Y      