   M S B A M L   `   `   `  ����b  ^PresentationFramework.Aero2, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35hKclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.Aero2Microsoft.Windows.Themes  5      E AAuctionApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:AuctionApp.MVVM.ViewAuctionApp.MVVM.View 5      E'clr-namespace:AuctionApp.MVVM.ViewModelAuctionApp.MVVM.ViewModel 6?   #   AuctionApp.MVVM.View.SellView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ^ThemesKclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.Aero2     5      4local"clr-namespace:AuctionApp.MVVM.View     5      =	viewmodel'clr-namespace:AuctionApp.MVVM.ViewModel     6?   $	��525��5	   7     � 	Resources  5
         FocusVisual �� Property �� Value J� SnapsToDevicePixels �� StrokeDashArray / +ComboBoxItem.ItemsviewHoverFocus.Background �� Color + 'ComboBoxItem.ItemsviewHoverFocus.Border  ComboBox.Static.Background  ComboBox.Static.Border ' #ComboBox.Static.Editable.Background # ComboBox.Static.Editable.Border . *ComboBox.Static.Editable.Button.Background * &ComboBox.Static.Editable.Button.Border 	 ComboBox.MouseOver.Glyph !
 ComboBox.MouseOver.Background  ComboBox.MouseOver.Border * &ComboBox.MouseOver.Editable.Background & "ComboBox.MouseOver.Editable.Border 1 -ComboBox.MouseOver.Editable.Button.Background �� EndPoint �� 
StartPoint � Color	 � Offset - )ComboBox.MouseOver.Editable.Button.Border  ComboBox.Pressed.Glyph  ComboBox.Pressed.Background  ComboBox.Pressed.Border ( $ComboBox.Pressed.Editable.Background $  ComboBox.Pressed.Editable.Border / +ComboBox.Pressed.Editable.Button.Background + 'ComboBox.Pressed.Editable.Button.Border  ComboBox.Disabled.Glyph   ComboBox.Disabled.Background  ComboBox.Disabled.Border ) %ComboBox.Disabled.Editable.Background % !ComboBox.Disabled.Editable.Border 0 ,ComboBox.Disabled.Editable.Button.Background , (ComboBox.Disabled.Editable.Button.Border  ComboBox.Static.Glyph  ComboBoxToggleButton
 �� 
TargetType �� 
TargetType ��Name F�Name �� Triggers ^� 
Conditions �� Binding �� RelativeSource �� AncestorType �� Value �� 
TargetName P� Property P� Value   ComboBoxTemplate �Name � ColumnDefinitions �Name � AllowsTransparency �� Mode5   /Microsoft.Windows.Themes.SystemDropShadowChrome  Name   Color �� MaxDropDownHeight �� ElementName  ��Name! �� ClearTypeHint" ��Name# ��Name$ ��Name-  'System.Windows.Input.KeyboardNavigation%   DirectionalNavigation& d�Name' d� 	IsChecked( ��Name) �� SelectionBoxItemTemplate* �� SelectionBoxItem#+ �� SelectionBoxItemStringFormat, �� ContentStringFormat- J� IsHitTestVisible. P� 
SourceName/ ]� 
Conditions0 �� Property ! TextBox.Static.Background " ComboBoxEditableTextBox # ComboBoxEditableTemplate1 ��Name2 �� 
IsReadOnly $ ComboBoxStyle13 �� Triggers % ComboBoxItemStyle1��%�-  &	        &	 �     &	 �     &	 �     &	     &	 *    &	 G    &	 d    &	 �    &		 �    &	
 �    &	 �    &	     &	 :    &	 ]    &	 �    &	     &	 ?    &	 �    &	 �    &	 !    &	 D    &	 �    &	     &	 &    &	 I    &	 l    &	 �    &	 �    &	 �    &	 �    &	     7  7  7  7  7  7  7  7 	 7 
 7  7  7  7  7  7  7  7  7  7  7  7  7  7  7  7  7  7  7  &	  =    7  &	! �    &	" �    &	#     7  7 ! 7 " &	$ t(    7   7  7  7   7 # &	% +    �� 5   
   .�5      ��  � �� 5      �� 5      .R�5      �� $��2q�6$    . #��� ��6J   $��1��6�   $	 1 2R�6�   5      5      5      �� 5   
   $	 red��6N   �� 5   
   $	 red��6J   �� 5   
   $ 	#FF272537��6=   �� 5   
   $ 	#FF02A4C3��69   �� 5   
   $	 red��6F   �� 5   
   $	 red��6B   �� 5   
   $ Transparent��6M   �� 5   
   $ Transparent��6I   �� 5   
   $ 	#FF000000��6;   �� 5   
   $ 	#FF272537��6@   �� 5   
   $ 	#FF7EB4EA��6<   �� 5   
   $ 	#FFFFFFFF��6I   �� 5    
   $ 	#FF7EB4EA��6E   �� 5!   
   $	 0,1&�6T   $	 0,0&�6c   .��5"      � $ 	#FFEBF4FC��6   $		 0.0Q�6-   � 5#      $ 	#FFDCECFC��6   $		 1.0Q�6-   5$      �� 5%   
   $ 	#FF7EB4EA��6L   �� 5&   
   $ 	#FF000000��69   �� 5'   
   $	 0,1&�6B   $	 0,0&�6Q   .��5(      � $ 	#FFDAECFC��6   $		 0.0Q�6-   � 5)      $ 	#FFC4E0FC��6   $		 1.0Q�6-   5*      �� 5+   
   $ 	#FF569DE5��6:   �� 5,   
   $ 	#FFFFFFFF��6G   �� 5-   
   $ 	#FF569DE5��6C   �� 5.   
   $	 0,1&�6R   $	 0,0&�6a   .��5/      � $ 	#FFDAEBFC��6   $		 0.0Q�6-   � 50      $ 	#FFC4E0FC��6   $		 1.0Q�6-   51      �� 52   
   $ 	#FF569DE5��6J   �� 53   
   $ 	#FFBFBFBF��6:   �� 54   
   $ 	#FFF0F0F0��6?   �� 55   
   $ 	#FFD9D9D9��6;   �� 56   
   $ 	#FFFFFFFF��6H   �� 57   
   $ 	#FFBFBFBF��6D   �� 58   
   $ Transparent��6O   �� 59   
   $ Transparent��6K   �� 5:   
   $ 	#FF606060��68   �� 5;   
   "
 d�6-   .�5<      ��  �@�OverridesDefaultStyle . 66   �� 5=       � �� .  6*   �� 5>       � |� .  6*   �� 5?       �@��	ClickMode$ Press=�6*   �� 5@       � �� 5A      �� 5B      " d�6&   .R�5C      �� $ templateRoot��6!   8��  #��z��6n   8��  . ._�5D      �� $ splitBorder��6%   
������ $��1q�6T   $��Right=�6h   $��0q�6�    . #��� r�6�   ._�5E   "   F� $ arrow��6'   F����        ���( ��( јaQ     јaQ P����̰( � �    P����        8�� $��Center=�6�   $��0q�6�   $��Center=�6�   5F      5G       5H      ^� 5I       5J   "   �� 5K   &    60   �� *
IsEditable+ �� " �� true6�   �� 5L   &    60   �� *IsMouseOver+ �� *Self+	 false6v   �� 5M   &    60   �� *	IsPressed+ �� *Self+	 false6t   �� 5N   &    60   �� *	IsEnabled+ �� *Self+ true6t   .0�5P   "   �� $ templateRoot��6?   8   � ��6Y   �� 5Q   "   $ templateRoot��6@   8   � ��6Z   �� 5R   "   $ splitBorder��6?   8   � ��6X   �� 5S   "   $ splitBorder��6@   8   � ��6Y   5T      P� 5U       �@J�IsMouseOver . . �5V   "   �� $ arrow��69   8   � ��6L   5W      ^� 5X       5Y   "   �� 5Z   &    60   �� *IsMouseOver+ �� *Self+ true6v   �� 5[   &    60   �� *
IsEditable+ �� " ��	 false6�   .0�5]   "   �� $ templateRoot��6?   8   � ��6Y   �� 5^   "   $ templateRoot��6@   8 	  � ��6Z   5_      ^� 5`       5a   "   �� 5b   &    60   �� *IsMouseOver+ �� *Self+ true6v   �� 5c   &    60   �� *
IsEditable+ �� " �� true6�   .0�5e   "   �� $ templateRoot��6?   8 
  � ��6Y   �� 5f   "   $ templateRoot��6@   8   � ��6Z   �� 5g   "   $ splitBorder��6?   8   � ��6X   �� 5h   "   $ splitBorder��6@   8   � ��6Y   5i      P� 5j       � �� . . �5k   "   �� $ arrow��69   8   � ��6L   5l      ^� 5m       5n   "   �� 5o   &    60   �� *	IsPressed+ �� *Self+ true6t   �� 5p   &    60   �� *
IsEditable+ �� " ��	 false6�   .0�5r   "   �� $ templateRoot��6?   8   � ��6Y   �� 5s   "   $ templateRoot��6@   8   � ��6Z   5t      ^� 5u       5v   "   �� 5w   &    60   �� *	IsPressed+ �� *Self+ true6t   �� 5x   &    60   �� *
IsEditable+ �� " �� true6�   .0�5z   "   �� $ templateRoot��6?   8   � ��6Y   �� 5{   "   $ templateRoot��6@   8   � ��6Z   �� 5|   "   $ splitBorder��6?   8   � ��6X   �� 5}   "   $ splitBorder��6@   8   � ��6Y   5~      P� 5       � {� .  . �5�   "   �� $ arrow��69   8   � ��6L   5�      ^� 5�       5�   "   �� 5�   &    60   �� *	IsEnabled+ �� *Self+	 false6t   �� 5�   &    60   �� *
IsEditable+ �� " ��	 false6�   .0�5�   "   �� $ templateRoot��6?   8   � ��6Y   �� 5�   "   $ templateRoot��6@   8   � ��6Z   5�      ^� 5�       5�   "   �� 5�   &    60   �� *	IsEnabled+ �� *Self+	 false6t   �� 5�   &    60   �� *
IsEditable+ �� " �� true6�   .0�5�   "   �� $ templateRoot��6?   8   � ��6Y   �� 5�   "   $ templateRoot��6@   8   � ��6Z   �� 5�   "   $ splitBorder��6?   8   � ��6X   �� 5�   "   $ splitBorder��6@   8   � ��6Y   5�      5�      5�      5�      �� 5�   
   " ��63   .R�5�      � $ templateRoot��6    .  5�      �� 5�      $��* �6'   �� 5�      #��� r�6'   $��0 �6z   .+�5�      � $ 
PART_Popup��6    . $��2��6F   $��1q�6�   #��� .�6�   $��Bottom=�6  ��6Z   �� *IsDropDownOpen+$ TwoWay=� �� *TemplatedParent+.��5�        $ shadow��64   $ Transparent��6D   #��z 6X   ��6�   �� *ActualWidth+$ templateRoot��._�5�      �� $ dropDownBorder��6!   #��� ��69   $��1q�6�   #��� ��6�   ._�5�      �� $  DropDownScrollViewer��6+   .��5�   "   � $
 grid��6'   $! Enabled=�65   .+�5�   &   �� $" canvas��6-   $
��Left=�6=   $��0��6X   $	��Top=�6c   $��0��6{   .+�5�   *   �� $# 
opaqueRect��64   ��6H   �� *
Background+$ dropDownBorder����6�   �� *ActualHeight+$ dropDownBorder����6�   �� *ActualWidth+$ dropDownBorder��5�   '   �� 5�   &   $$ ItemsPresenter��65   $% 	Contained=�6M   # z 6�   5�   #   5�      5�      5�      5�      d� 5�      $& toggleButton��6   #��z��65   #��z��6a   #��z��6�   $��2��6�   8��  ' 5�      �� *IsDropDownOpen+$ TwoWay=� �� *TemplatedParent+6�   �� 5�      $( contentPresenter��6#   #��z) 6=   #��z��6z   #��z* 6�   #, z+ 6�   #��z��6-  - .  #��z��6�  # z 6�  #��z��6�  5�       5�      P� 5�      $. 
PART_Popup��63    �@�HasDropShadow . . �5�      �� $ shadow��6/    � ��$ 0,0,5,5q�6C   �� 5�      $ shadow��6.    �@ Color$ 	#71000000��6B   5�      P� 5�       �@��HasItems .  . �5�      �� $ dropDownBorder��6/    � ��$ 95��6K   5�      ]� 5�      / 5�      �� 5�      0 �@��
IsGrouping . 6:   �� 5�      "0 �@%�IsVirtualizingWhenGrouping .  6\   ./�5�      ��  � �� .  6F   5�      P� 5�      $. DropDownScrollViewer��6C    � �� .  . �5�      �� $ 
opaqueRect��63    6K   �� *VerticalOffset+$ DropDownScrollViewer�� �@��Top�� 5�      $ 
opaqueRect��64    6L   �� *HorizontalOffset+$ DropDownScrollViewer�� �@��Left5�      5�      �� 5�   
   $ 	#FFFFFFFF��6<   �� 5�   
   "
 ��60   .�5�      ��  �@�OverridesDefaultStyle . 66   �� 5�       �@J�	AllowDrop . 6*   �� 5�       � ��$ 0��6)   �� 5�       � ��$ 0��6*   �� 5�       �@�FocusVisualStyle 61   Z� �� 5�       �@��PanningMode$ VerticalFirst=�69   �� 5�       �@��IsFlicksEnabled .  67   �� 5�       � �� 5�      �� 5�      " ��6&   .R�5�      �� $  PART_ContentHost��6'   
������ |�.  $��Hidden=�6l   $��Hidden=�6�   5�      5�      5�      �� 5�   
   " ��6;   .R�5�      � $ templateRoot��6    .  5�      �� 5�      $��* �6'   �� 5�      #��� r�6'   $��0 �6z   .+�5�      � $ 
PART_Popup��6    . $��2��6F   #��� .�6�   $��Bottom=�6  ��6Z   �� *IsDropDownOpen+ �� *TemplatedParent+.��5�        $ shadow��64   $ Transparent��6D   #��z 6X   ��6�   �� *ActualWidth+$ templateRoot��._�5�      �� $ dropDownBorder��6!   #��� ��69   $��1q�6�   #��� ��6�   ._�5�      �� $  DropDownScrollViewer��6+   .��5�   "   � $
 grid��6'   $! Enabled=�65   .+�5�   &   �� $" canvas��6-   $
��Left=�6=   $��0��6X   $	��Top=�6c   $��0��6{   .+�5�   *   �� $# 
opaqueRect��64   ��6H   �� *
Background+$ dropDownBorder����6�   �� *ActualHeight+$ dropDownBorder����6�   �� *ActualWidth+$ dropDownBorder��5�   '   �� 5�   &   $$ ItemsPresenter��65   $% 	Contained=�6M   # z 6�   5�   #   5�      5�      5�      5�      d� 5�      $& toggleButton��6   #��z��65   #��z��6a   #��z��6�   $��2��6�   8��  ' 6�   �� *IsDropDownOpen+$ TwoWay=� �� *TemplatedParent+66  �� 5�      $ border��6   8�� #��z��6a   ._�5�      �� $1 PART_EditableTextBox��6   #��z��6<   #��z��6�   8�� #��z��6-  2 6�   �� *
IsReadOnly+ �� *TemplatedParent+6-  5�      5�       5�      P� 5�       � {� .  . �5�      �� $ border��60    �@J�Opacity$
 0.56Q�6D   5�      P� 5�       �@J�IsKeyboardFocusWithin . . �5�      ��  � ��
 �   �63   5�      P� 5�      $. 
PART_Popup��63    �@�HasDropShadow . . �5�      �� $ shadow��6/    � ��$ 0,0,5,5q�6C   �� 5�      $ shadow��6.    �@ Color$ 	#71000000��6B   5�      P� 5�       �@��HasItems .  . �5�      �� $ dropDownBorder��6/    � ��$ 95��6K   5�      ]� 5�      / 5�      �� 5      0 �@��
IsGrouping . 6:   �� 5     "0 �@%�IsVirtualizingWhenGrouping .  6\   ./�5     ��  � �� .  6F   5     P� 5     $. DropDownScrollViewer��6C    � �� .  . �5     �� $ 
opaqueRect��63    6K   �� *VerticalOffset+$ DropDownScrollViewer�� �@��Top�� 5     $ 
opaqueRect��64    6L   �� *HorizontalOffset+$ DropDownScrollViewer�� �@��Left5     5
     �� 5  
   "
 ��6'   .�5     ��  �@�FocusVisualStyle8   61   �� 5      � ��8  6+   �� 5      � ��8  6,   �� 5      � ��# � ��6+   �� 5      � ��$ 1q�60   �� 5      � ��$
 Auto=�6K   �� 5      � ��$
 Auto=�6I   �� 5      � ��$ 6,3,5,3q�6(   �� 5      � �� . 6>   �� 5      �@��PanningMode$
 Both=�69   �� 5      �@��IsFlicksEnabled .  67   �� 5      � ��8  6)   3 5     P� 5      �@��
IsEditable . . �5     ��  � �� .  62   �� 5      � ��$ 2q�60   �� 5      � ��8  61   5     5     �� 5   
   "
 ��6+   .�5!     ��  � �� �	#FF2725376+   �� 5"      � �� �	#FF02A4C36,   5#     5$     .��5%     �� $
��Left=�6   $	��525��6,   $	��Top=�69   $	��800��6Q   .+�5&  
   �� $
��Left=�6   $��75��60   $	��Top=�6<   $	��800��6T   $��
0,0,-700,0q�6`   4 �� Orientation$4 
Horizontal=�6t   .+�5'     �� 
���   �$��1q�6)   $	��151��6=   $��	260,0,0,0q�6I   $��60��6\   ���	#FF02A4C3._�5(     �� $��56��6   $��+ Dodaj zdjęcie��5)     ���	#FF02A4C35 J� RenderTransformOrigin$5 0.5,0.5&�5,     $��2.2,1.2,1.4,0q�5-     ���	#FF272537$	��146��5/     $	��Top=�6%   ��5*     �� *addPhotoCommand+5/  %   50     �� 51     -   5        6 ��Name$6 	SellImage��51     $��30,0,0,0q�52     $	��150��53     $��75��54     ��55     �� *	ItemPhoto+56     �� 57  
   $��75��6   $��0q�6!   $	��800��6,   $4 
Horizontal=�68   .+�58     �� $
��Wrap=�6   $��	Kategoria��59     $��20(�6)   ���	#FF02A4C3$��
260,20,0,0q�5;     $��85��5<     $��55��6#   �� 5=     -   5        7 ��Name$7 CategoryTextbox��5=     8 �� SelectedIndex$8 0��5>     $	��150��5?     $��50��6#   ���	#FF272537#��� $ 5A     $��20,0,0,0q�5C     ���	#FF02A4C3#��� % 5E     9 �� Text9 5B     �� *getCategory+.@�5F     �� $��Mężczyzna��6   �� 5G     $��Kobieta��6   �� 5H     $��Dziecko��6   5I     5K     �� 5L  
   $��75��6   $4 
Horizontal=�6!   .+�5M     �� $
��Wrap=�6   $��Rozmiar��6,   $��20(�6;   ���	#FF02A4C3$��260,20,20,0q�6`   $��85��6u   $��55��6�   �� 5N     -   5        $1 SizeTextbox��5N     : �� TextWrapping$
: Wrap=�5P     ���	#FF02A4C3$	��150��5R     $��50��6"   $��0q�5S     ���	#FF272537$��20(�5U     ���	#FF02A4C3��5O     �� *
SizeText+5V     5W     �� 5X  
   $��75��6   $4 
Horizontal=�6!   .+�5Y     �� $
��Wrap=�6   $
��Stan��6,   ���	#FF02A4C3$��20(�6O   $��260,20,20,0q�6]   $��85��6r   $��55��6}   �� 5Z     -   5        $1 StateTextbox��5Z     ���	#FF02A4C3$
: Wrap=�5]     $	��150��6*   $��48��66   $��0q�6B   ���	#FF272537$��20(�6d   ���	#FF02A4C3��5\     �� *	StateText+5]  r   5^     �� 5_  
   $��75��6   $4 
Horizontal=�6!   .+�5`     �� $
��Wrap=�6   $
��Cena��6,   ���	#FF02A4C3$��20(�6O   $��260,20,20,0q�6]   $��85��6r   $��55��6}   �� 5a     -   5        $1 PriceTextbox��5a     ���	#FF02A4C3$
: Wrap=�5d     $	��150��6*   $��50��66   ���	#FF272537$��20(�6Y   ���	#FF02A4C3��5c     �� *	PriceText+5d  g   5e     �� 5f  
   $
��75.3��6   $4 
Horizontal=�6#   .+�5g     �� $
��Wrap=�6   $��Nazwa��6,   ���	#FF02A4C3$��20(�6P   $��260,20,20,0q�6^   $��85��6s   $��55��6~   �� 5h     -   5        $1 NameTextBox��5h     ���	#FF02A4C3$
: Wrap=�5k     $	��150��6*   $��52��66   ���	#FF272537$��16(�6Y   ���	#FF02A4C3��5j     �� *
NameText+5k  g   5l     �� 5m  
   $��75��6   .+�5n     �� -   5        ; ��Name$; 	addButton��5n     ���	#FF02A4C3���	#FF272537$��Dodaj��5r     $	��250��6%   $��50��61   $��	0,10,20,0q�5s     ���	#FF02A4C3��5o     �� *
addCommand+5t     5u     5v     5w     