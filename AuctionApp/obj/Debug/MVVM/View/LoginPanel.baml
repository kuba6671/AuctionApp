   M S B A M L   `   `   `  ����E  AAuctionApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:AuctionApp.MVVM.ViewAuctionApp.MVVM.View  5   	   E'clr-namespace:AuctionApp.MVVM.ViewModelAuctionApp.MVVM.ViewModel  5   	   %    AuctionApp.MVVM.View.LoginPanel   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:AuctionApp.MVVM.View     5   	   =	viewModel'clr-namespace:AuctionApp.MVVM.ViewModel     5   	     � Title$  
LoginPanel��5	   	   $	��450��5
   	   $	��800��6   
������  � AllowsTransparency .  � WindowStyle$
 None=�5   	    � 
ResizeMode$ NoResize=�5   	    � DataContext 5      .  (AuctionApp.MVVM.ViewModel.LoginViewModel  5   
   .��5      ��  �� CornerRadius$ 10��6   $��1q�5      $
��Left=�5      $	��450��5      $	��Top=�5      $	��800��5      ��5   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ Black��6   	 � Offset$	 0Q�6-   � 5      $ 	#FF272537��6   $	 1Q�61   5      ._�5   
   � $	��800��6   $	��450��6   $��0,0,0,4q�6(   
 � ColumnDefinitions
 5       �� 5!      �� 5"      $��0* �6#   .+�5$      �� $	��Top=�6   $	��450��61    �� Orientation$ 
Horizontal=�6>   $��3.2,0,-3.2,0q�6W   $��2��6m   $	��800��6�   .+�5%      �� $	��400��6   $��Right=�6)   $	��450��6E   .+�5&      �� 
���   �$��1q�5'      $	��450��5(      ._�5)      �� $��0q�6    $	��400��6+   $	��400��67   $7��1/AuctionApp;component/Images/logo_transparent.png��5*       5+      5,      �� 5-      $	��400��6   .+�5.      �� $��30��6!   $	��400��5/   !    J� RenderTransformOrigin$ 0.511,-6.668&�50   !   $ 
Horizontal=�51   !   .+�52      �� $��x��6!   $��30��53   !   $��30��6,   ���	#FF272537$
��Left=�55   !   $	��Top=�56   !   $��	365,0,0,0q�57   !   ��58   !   �� *CloseCommand+59      �� 5:      -   5         ��Name$ UsernameTextbox��5:       �� TextWrapping$
 Wrap=�5;      ���	#FF272537���	#FFA19DA1$	��200��5?      $��48��5@      $��20(�5A      $��
0,50,101,0q�5B      $��Nazwa uzytkownika��5C      $ -12.304,-3.231&�5D      $��Center=�5E      G� 5G      -   5         G�Name$ PasswordTextbox��5G   "   $	��200��5H   "   $��48��6.   $��
0,20,101,0q�5I   "   $��Center=�5J   "   ���	#FF272537$��20(�5M   "   �� 5P      -   5        $��Zaloguj��5P      $	��200��5Q      $��45��6)   $��
0,35,100,0q�5R      $��20(�5S      ���	#FF198B2B$��Center=�5U      ��5W      �� *LoginCommand+�� 5X      $	��100��6!   $ 
Horizontal=�6.   .+�5Y      �� $
��Wrap=�6$   $��Nie masz konta?��68   $��25(�6O   $��Center=�6]   $��Center=�6z   $��	50,0,0,-3q�6�   �� 5Z      -   5        $��Zarejestruj��5Z   !   $	��100��5[   !   $��17(�5\   !   ���	#FF198B2B$��45��5^   !   $��20,0,0,0q�5_   !   5a      5c      5d      5f      5g      5h      