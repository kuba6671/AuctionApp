   M S B A M L   `   `   `  ����E  AAuctionApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:AuctionApp.MVVM.ViewAuctionApp.MVVM.View  5      '    !AuctionApp.MVVM.View.PurchaseView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:AuctionApp.MVVM.View     5      _ [Microsoft.Xaml.Behaviors, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a3i+http://schemas.microsoft.com/xaml/behaviors  6?   $	��800��5
      $	��525��5      .��5      �� $
��Left=�6   $	��525��5      $	��Top=�6   $	��800��5      .+�5   
   � $	��525��6   .+�5      �� -   5          ��Name$  ItemsScrollViewer��5      $
��Left=�5      $	��465��5      $��0,60,0,0q�6(   $	��Top=�5      $	��800��5      .��5      �� $
��Left=�5      $	��Top=�5      .+�5      �� ��5      �� *	itemsList+5      5      5      �� 5      $
��Left=�6   $��	60,27,0,0q�5      $	��Top=�5       $	��120��5!      ���	#FF272537 �� SelectedItem 5#      �� *
getState+.@�5%      �� $��Bardzo Dobry��6   �� 5&      $��Dobry��6   �� 5'      $��Zadowalajacy��6   �� 5(      $��
Uszkodzony��6   *  $Microsoft.Xaml.Behaviors.Interaction   Triggers 5)      +  %Microsoft.Xaml.Behaviors.EventTrigger  5*         	EventName$ SelectionChanged��6%   *  $Microsoft.Xaml.Behaviors.TriggerBase   Actions. 5+      2  ,Microsoft.Xaml.Behaviors.InvokeCommandAction     Command 60   �� *StateItemCommand+5,      5.      �� 5/      $
��Left=�6   $��
260,27,0,0q�50      $	��Top=�51      $	��120��52       53      �� *	getSize+.@�54      �� $��XS��6   �� 55      $��S��6   �� 56      $��M��6   �� 57      $��L��6   �� 58      $��XL��6    59        5:      $ SelectionChanged��6%   . 5;         60   �� *SizeItemCommand+5<      5>      �� 5?      $
��Left=�6   $��
460,27,0,0q�5@      $	��Top=�5A      $	��120��5B       5C      �� *getCategory+.@�5D      �� $��Mężczyzna��6   �� 5E      $��Kobieta��6   �� 5F      $��Dziecko��6    5G        5H      $ SelectionChanged��6%   . 5I         60   �� *CategoryItemCommand+5J      5L      �� 5M      $
��Left=�6   $��99.332,6.04,0,0q�5N      $
��Wrap=�5O      $
��Stan��5P      $	��Top=�5Q      ���	#FF02A4C35R      �� 5S      ���	#FF02A4C3$
��Left=�5T      $��300.5,6.04,0,0q�6,   $
��Wrap=�6D   $��Rozmiar��6X   $	��Top=�6g   �� 5U      ���	#FF02A4C3$
��Left=�5V      $��500.633,6.04,0,0q�6,   $
��Wrap=�6F   $��	Kategoria��6Z   $	��Top=�6k   5W      5X      5Y      