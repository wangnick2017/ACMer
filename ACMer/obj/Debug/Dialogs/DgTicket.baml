   M S B A M L   `   `   `  ����@  <ACMer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:ACMerACMer  5   	   b ^PresentationFramework.Aero2, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35hKclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.Aero2Microsoft.Windows.Themes 5   	       ACMer.Dialogs.DgTicket   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:ACMer     5   	   ^ThemesKclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.Aero2     5   	     � Title$	  票��5	   	   $	��423��6   $	��639��6     � AllowsTransparency .  � WindowStartupLocation$ CenterScreen=�6F    � 
ResizeMode$ NoResize=�6k    � WindowStyle$
 None=�6�    � 	Resources 5
         ComboBox.Static.Background  ComboBox.Static.Border �� Color ' #ComboBox.Static.Editable.Background # ComboBox.Static.Editable.Border . *ComboBox.Static.Editable.Button.Background * &ComboBox.Static.Editable.Button.Border  ComboBox.MouseOver.Glyph ! ComboBox.MouseOver.Background  ComboBox.MouseOver.Border *	 &ComboBox.MouseOver.Editable.Background &
 "ComboBox.MouseOver.Editable.Border 1 -ComboBox.MouseOver.Editable.Button.Background �� EndPoint �� 
StartPoint	 � Color
 � Offset - )ComboBox.MouseOver.Editable.Button.Border  ComboBox.Pressed.Glyph  ComboBox.Pressed.Background  ComboBox.Pressed.Border ( $ComboBox.Pressed.Editable.Background $  ComboBox.Pressed.Editable.Border / +ComboBox.Pressed.Editable.Button.Background + 'ComboBox.Pressed.Editable.Button.Border  ComboBox.Disabled.Glyph   ComboBox.Disabled.Background  ComboBox.Disabled.Border ) %ComboBox.Disabled.Editable.Background % !ComboBox.Disabled.Editable.Border 0 ,ComboBox.Disabled.Editable.Button.Background , (ComboBox.Disabled.Editable.Button.Border  ComboBox.Static.Glyph  ComboBoxToggleButton2 �� 
TargetType �� Property �� Value �� 
TargetType ��Name J� SnapsToDevicePixels F�Name �� Triggers ^� 
Conditions �� Binding �� RelativeSource �� AncestorType �� Value �� 
TargetName P� Property P� Value  ComboBoxTemplate �Name � ColumnDefinitions �Name � AllowsTransparency �� Mode5  /Microsoft.Windows.Themes.SystemDropShadowChrome   Name!   Color" �� MaxDropDownHeight# �� ElementName$ ��Name% �� ClearTypeHint& ��Name' ��Name( ��Name-  'System.Windows.Input.KeyboardNavigation)   DirectionalNavigation* d�Name+ d� 	IsChecked, ��Name- �� SelectionBoxItemTemplate. �� SelectionBoxItem#/ �� SelectionBoxItemStringFormat0 �� ContentStringFormat1 J� IsHitTestVisible2 P� 
SourceName3 ]� 
Conditions4 �� Property  TextBox.Static.Background  ComboBoxEditableTextBox   ComboBoxEditableTemplate5 ��Name6 �� 
IsReadOnly ! ComboBoxStyle " FocusVisual7 �� Triggers��%�+  &	        &	 '     &	 L     &	 o     &	 �     &	 �     &	 �     &	     &	 (    &		 M    &	
 p    &	 �    &	 /    &	 R    &	 w    &	 �    &	 �    &	 �    &	 	    &	 �    &	 �    &	 �    &	     &	 7    &	 Z    &	 }    &	 �    &	 �    &	 �    7  7   7  7  7  7  7  7  7  7  7 	 7 
 7  7  7  7  7  7  7  7  7  7  7  7  7  7  7  7  &	 
    7  &	 �    &	 �    &	  �    7  7  7  &	! ='    7 " 7   7  7  7   ��5   
   Transparent��5      �� 5   
   $ Transparent��69   �� 5   
   $ 	#FFFFFFFF��6F   �� 5   
   $ 	#FFABADB3��6B   �� 5   
   $ Transparent��6M   �� 5   
   $ Transparent��6I   �� 5   
   $ Transparent��6;   ��5   
   Transparent��5      �� 5   
   $ Transparent��6<   �� 5   
   $ 	#FFFFFFFF��6I   �� 5   
   $ 	#FF7EB4EA��6E   �� 5   
   $	 0,1&�6T   $	 0,0&�6c   .��5      � $	 	#FFEBF4FC��6   $	
 0.0Q�6-   � 5      $	 	#FFDCECFC��6   $	
 1.0Q�6-   5      �� 5   
   $ 	#FF7EB4EA��6L   �� 5   
   $ Transparent��69   ��5    
   Transparent��5"      �� 5#   
   $ Transparent��6:   �� 5$   
   $ 	#FFFFFFFF��6G   �� 5%   
   $ 	#FF569DE5��6C   �� 5&   
   $	 0,1&�6R   $	 0,0&�6a   .��5'      � $	 	#FFDAEBFC��6   $	
 0.0Q�6-   � 5(      $	 	#FFC4E0FC��6   $	
 1.0Q�6-   5)      �� 5*   
   $ 	#FF569DE5��6J   �� 5+   
   $ Transparent��6:   �� 5,   
   $ Transparent��6?   �� 5-   
   $ Transparent��6;   �� 5.   
   $ 	#FFFFFFFF��6H   �� 5/   
   $ 	#FFBFBFBF��6D   �� 50   
   $ Transparent��6O   �� 51   
   $ Transparent��6K   �� 52   
   $ Transparent��68   �� 53   
   " d�6.   .�54      ��  �@�OverridesDefaultStyle . 66   �� 55       � �� .  6*   �� 56       � |� .  6*   �� 57       �@��	ClickMode$ Press=�6*   �� 58       � �� 59      �� 5:      " d�6&   .R�5;      �� $ templateRoot��6!   8��  #��z��6m   8��  . ._�5<      �� $ splitBorder��6%   
������ $��1q�6T   $��Right=�6h   $��0q�6�    . #��� r�6�   ._�5=   "   F� $ arrow��6'   F����        ���( ��( јaQ     јaQ P����̰( � �    P����        8�� $��Center=�6�   $��0q�6�   $��Center=�6�   5>      5?       5@      ^� 5A       5B   "   �� 5C   &    60   �� *
IsEditable+ �� " �� true6�   �� 5D   &    60   �� *IsMouseOver+ �� *Self+	 false6v   �� 5E   &    60   �� *	IsPressed+ �� *Self+	 false6t   �� 5F   &    60   �� *	IsEnabled+ �� *Self+ true6t   .0�5H   "   �� $ templateRoot��6?   8   � ��6Y   �� 5I   "   $ templateRoot��6@   8   � ��6Z   �� 5J   "   $ splitBorder��6?   8   � ��6X   �� 5K   "   $ splitBorder��6@   8   � ��6Y   5L      P� 5M       �@J�IsMouseOver . . �5N   "   �� $ arrow��69   8   � ��6L   5O      ^� 5P       5Q   "   �� 5R   &    60   �� *IsMouseOver+ �� *Self+ true6v   �� 5S   &    60   �� *
IsEditable+ �� " ��	 false6�   .0�5U   "   �� $ templateRoot��6?   8   � ��6Y   �� 5V   "   $ templateRoot��6@   8 	  � ��6Z   5W      ^� 5X       5Y   "   �� 5Z   &    60   �� *IsMouseOver+ �� *Self+ true6v   �� 5[   &    60   �� *
IsEditable+ �� " �� true6�   .0�5]   "   �� $ templateRoot��6?   8 
  � ��6Y   �� 5^   "   $ templateRoot��6@   8   � ��6Z   �� 5_   "   $ splitBorder��6?   8   � ��6X   �� 5`   "   $ splitBorder��6@   8   � ��6Y   5a      P� 5b       � �� . . �5c   "   �� $ arrow��69   8   � ��6L   5d      ^� 5e       5f   "   �� 5g   &    60   �� *	IsPressed+ �� *Self+ true6t   �� 5h   &    60   �� *
IsEditable+ �� " ��	 false6�   .0�5j   "   �� $ templateRoot��6?   8   � ��6Y   �� 5k   "   $ templateRoot��6@   8   � ��6Z   5l      ^� 5m       5n   "   �� 5o   &    60   �� *	IsPressed+ �� *Self+ true6t   �� 5p   &    60   �� *
IsEditable+ �� " �� true6�   .0�5r   "   �� $ templateRoot��6?   8   � ��6Y   �� 5s   "   $ templateRoot��6@   8   � ��6Z   �� 5t   "   $ splitBorder��6?   8   � ��6X   �� 5u   "   $ splitBorder��6@   8   � ��6Y   5v      P� 5w       � {� .  . �5x   "   �� $ arrow��69   8   � ��6L   5y      ^� 5z       5{   "   �� 5|   &    60   �� *	IsEnabled+ �� *Self+	 false6t   �� 5}   &    60   �� *
IsEditable+ �� " ��	 false6�   .0�5   "   �� $ templateRoot��6?   8   � ��6Y   �� 5�   "   $ templateRoot��6@   8   � ��6Z   5�      ^� 5�       5�   "   �� 5�   &    60   �� *	IsEnabled+ �� *Self+	 false6t   �� 5�   &    60   �� *
IsEditable+ �� " �� true6�   .0�5�   "   �� $ templateRoot��6?   8   � ��6Y   �� 5�   "   $ templateRoot��6@   8   � ��6Z   �� 5�   "   $ splitBorder��6?   8   � ��6X   �� 5�   "   $ splitBorder��6@   8   � ��6Y   5�      5�      5�      5�      �� 5�   
   " ��63   .R�5�      � $ templateRoot��6    .  5�      �� 5�      $��* �6'   �� 5�      #��� r�6'   $��0 �6z   .+�5�      � $ 
PART_Popup��6    . $��2��6F   $��1q�6�   #��� .�6�   $��Bottom=�6  ��6Z   �� *IsDropDownOpen+$ TwoWay=� �� *TemplatedParent+.��5�        $  shadow��64   $! Transparent��6D   #��z" 6X   ��6�   �� *ActualWidth+$# templateRoot��._�5�      �� $ dropDownBorder��6!   #��� ��69   $��1q�6�   #��� ��6�   ._�5�      �� $$ DropDownScrollViewer��6+   .��5�   "   � $
 grid��6'   $% Enabled=�65   .+�5�   &   �� $& canvas��6-   $
��Left=�6=   $��0��6X   $	��Top=�6c   $��0��6{   .+�5�   *   �� $' 
opaqueRect��64   ��6H   �� *
Background+$# dropDownBorder����6�   �� *ActualHeight+$# dropDownBorder����6�   �� *ActualWidth+$# dropDownBorder��5�   '   �� 5�   &   $( ItemsPresenter��65   $) 	Contained=�6M   # z 6�   5�   #   5�      5�      5�      5�      d� 5�      $* toggleButton��6   #��z��65   #��z��6a   #��z��6�   $��2��6�   8��  + 6�   �� *IsDropDownOpen+$ TwoWay=� �� *TemplatedParent+66  �� 5�      $, contentPresenter��6#   #��z- 6=   #��z��6z   #��z. 6�   #0 z/ 6�   #��z��6-  1 .  #��z��6�  # z 6�  #��z��6�  5�       5�      P� 5�      $2 
PART_Popup��63    �@�HasDropShadow . . �5�      �� $ shadow��6/    � ��$ 0,0,5,5q�6C   �� 5�      $ shadow��6.    �@ Color$ 	#71000000��6B   5�      P� 5�       �@��HasItems .  . �5�      �� $ dropDownBorder��6/    � ��$ 95��6K   5�      ]� 5�      3 5�      �� 5�      4 �@��
IsGrouping . 6:   �� 5�      "4 �@%�IsVirtualizingWhenGrouping .  6\   ./�5�      ��  � �� .  6F   5�      P� 5�      $2 DropDownScrollViewer��6C    � �� .  . �5�      �� $ 
opaqueRect��63    6K   �� *VerticalOffset+$# DropDownScrollViewer�� �@��Top�� 5�      $ 
opaqueRect��64    6L   �� *HorizontalOffset+$# DropDownScrollViewer�� �@��Left5�      5�      �� 5�   
   $ 	#FFFFFFFF��6<   �� 5�   
   " ��60   .�5�      ��  �@�OverridesDefaultStyle . 66   �� 5�       �@J�	AllowDrop . 6*   �� 5�       � ��$ 0��6)   �� 5�       � ��$ 0��6*   �� 5�       �@�FocusVisualStyle 61   Z� �� 5�       �@��PanningMode$ VerticalFirst=�69   �� 5�       �@��IsFlicksEnabled .  67   �� 5�       � �� 5�      �� 5�      " ��6&   .R�5�      �� $$ PART_ContentHost��6'   
������ |�.  $��Hidden=�6l   $��Hidden=�6�   5�      5�      5�      �� 5�   
   " ��6;   .R�5�      � $ templateRoot��6    .  5�      �� 5�      $��* �6'   �� 5�      #��� r�6'   $��0 �6z   .+�5�      � $ 
PART_Popup��6    . $��2��6F   #��� .�6�   $��Bottom=�6  ��6Z   �� *IsDropDownOpen+ �� *TemplatedParent+.��5�        $  shadow��64   $! Transparent��6D   #��z" 6X   ��6�   �� *ActualWidth+$# templateRoot��._�5�      �� $ dropDownBorder��6!   #��� ��69   $��1q�6�   #��� ��6�   ._�5�      �� $$ DropDownScrollViewer��6+   .��5�   "   � $
 grid��6'   $% Enabled=�65   .+�5�   &   �� $& canvas��6-   $
��Left=�6=   $��0��6X   $	��Top=�6c   $��0��6{   .+�5�   *   �� $' 
opaqueRect��64   ��6H   �� *
Background+$# dropDownBorder����6�   �� *ActualHeight+$# dropDownBorder����6�   �� *ActualWidth+$# dropDownBorder��5�   '   �� 5�   &   $( ItemsPresenter��65   $) 	Contained=�6M   # z 6�   5�   #   5�      5�      5�      5�      d� 5�      $* toggleButton��6   #��z��65   #��z��6a   #��z��6�   $��2��6�   8��  + 6�   �� *IsDropDownOpen+$ TwoWay=� �� *TemplatedParent+66  �� 5�      $ border��6   8�� #��z��6a   ._�5�      �� $5 PART_EditableTextBox��6   #��z��6<   #��z��6�   8�� #��z��6-  6 6�   �� *
IsReadOnly+ �� *TemplatedParent+6-  5�      5�       5�      P� 5�       � {� .  . �5�      �� $ border��60    �@J�Opacity$
 0.56Q�6D   5�      P� 5�       �@J�IsKeyboardFocusWithin . . �5�      ��  � ��
 �   �63   5�      P� 5�      $2 
PART_Popup��63    �@�HasDropShadow . . �5�      �� $ shadow��6/    � ��$ 0,0,5,5q�6C   �� 5�      $ shadow��6.    �@ Color$ 	#71000000��6B   5�      P� 5�       �@��HasItems .  . �5�      �� $ dropDownBorder��6/    � ��$ 95��6K   5�      ]� 5�      3 5�      �� 5�      4 �@��
IsGrouping . 6:   �� 5�      "4 �@%�IsVirtualizingWhenGrouping .  6\   ./�5�      ��  � �� .  6F   5�      P� 5�      $2 DropDownScrollViewer��6C    � �� .  . �5�      �� $ 
opaqueRect��63    6K   �� *VerticalOffset+$# DropDownScrollViewer�� �@��Top�� 5�      $ 
opaqueRect��64    6L   �� *HorizontalOffset+$# DropDownScrollViewer�� �@��Left5�      5     �� 5  
   " ��6&   .�5     ��  �@�FocusVisualStyle8   61   �� 5      � ��8  6+   �� 5      � ��8  6,   �� 5      � ��# � ��6+   �� 5      � ��$ 1q�60   �� 5      � ��$
 Auto=�6K   �� 5	      � ��$
 Auto=�6I   �� 5
      � ��$ 6,3,5,3q�6(   �� 5      � �� . 6>   �� 5      �@��PanningMode$
 Both=�69   �� 5      �@��IsFlicksEnabled .  67   �� 5      � ��8  6)   7 5     P� 5      �@��
IsEditable . . �5     ��  � �� .  62   �� 5      � ��$ 2q�60   �� 5      � ��8  61   5     5     5     ��5     �� 5  
   8 �� ImageSource$)8 #/ACMer;component/Images/Ticket2.png��6   .��5     � 9 � RowDefinitions9 5  
   �� 5     $
��143* �6   �� 5     $
��280* �6    5   
   �� 5!     $
��267* �6   �� 5"     $
��133* �6   �� 5#     $
��161* �6   �� 5$     $	��78* �6   .+�5&  
   �� -   5        $��4��5&     $��60��6$   $	��Top=�60   6H   �� 5'  
   -   5        : J� Opacity$: 0Q�5'     $
��Left=�6   $��42��67   $��9,23,0,0q�6C   $	��Top=�6U   $��38��6m   $��3��6�   ��5(     �� 5)     $'8 !/ACMer;component/Images/close.jpg��6   ��5+     �� 5,     " ��6   7 5-     :� 5.     ; :� RoutedEvent$; UIElement.MouseEnter��6'   .[�5/     �� .��50  "   �� .��51  &   W� < �� TargetProperty$< Opacity�66   	= W� To$= 1X�6Z   > g� Duration$> 0:0:0.15D�6a   52  #   53     54     :� 55     $; UIElement.MouseLeave��6'   .[�56     �� .��57  "   �� .��58  &   W� $< Opacity�66   $> 0:0:0.15D�6[   59  #   5:     5;     5=     5?     �� 5@  
   -   5        ? ��Name$? locFrom��5@     $��Right=�6!   $��	0,0,30,10q�6=   $��测试��6P   $��Bottom=�6]   $��Center=�6x   $��Center=�6�   $��STSong)�6�   $
��Bold"�6�   $��36(�6�   �� 5A  
   -   5        $? ID��5A     $��1��6   $
��0,50q�6,   $��测试��6:   $��Bottom=�6G   $��Center=�6b   $��Center=�6�   $��STSong)�6�   $
��Bold"�6�   $��28(�6�   �� 5B  
   -   5        $? locTo��5B     $��2��6   $��2��6/   $
��Left=�6C   $��	30,0,0,10q�6^   $��测试��6q   $��Bottom=�6~   $��Center=�6�   $��Center=�6�   $��STSong)�6�   $
��Bold"�6�   $��36(�6  �� 5C  
   -   5        $? timeFrom��5C     $��1��6"   $��测试��6/   $	��Top=�6<   $��Center=�6T   $��Center=�6x   $��STSong)�6�   $
��Bold"�6�   $��24(�6�   �� 5D  
   -   5        $? timeTo��5D     $��2��6    $��2��60   $��1��6D   $��测试��6Q   $	��Top=�6^   $��Center=�6v   $��Center=�6�   $��STSong)�6�   $
��Bold"�6�   $��24(�6�   �� 5E  
   -   5        @ ��Name$	@ com��5E     $��2��6    $��40��64   $��
40,64,30,0q�6@   $��1��6T   $	��Top=�6a   $��STSong)�6y   $
��Bold"�6�   $��22(�6�   $��Center=�6�   $��Center=�6�   #��[! 6�   6  �� 5F  
   -	   5        $
@ com2��5F     $��1��6!   $
��Left=�61   $��
120,68,0,0q�6L   $��1��6`   $	��Top=�6m   #��[! 6�   A �� SelectedIndex$A 0��6�   $��STSong)�6�   $
��Bold"�6�   $��18(�6�   {�.  $��2��6  .@�5G     ��  # ticket.book#��� # 6   $
��Bold"�6C   $��22(�6U   $��STSong)�6c   �� 5H      $ ticket.refund#��� $ 6   $
��Bold"�6E   $��22(�6W   $��STSong)�6e   5I     �� 5J  
   -
   5        $5 txtCnt��5J      B �� 	MaxLength$B 4��6   $��2��60   $
��Left=�6@   $��30��6[   $��35��6g   $��	50,66,0,0q�6r   $��1��6�   $	��Top=�6�   $��0��6�   $��STSong)�6�   $��22(�6�   $
��Bold"�6�   $��Center=�6�   $��Center=�6  
������ ��6F  Z� �� 5K  
   -   5         % PageButtonSimple#��[% 5K      & ticket.submit#��� & 6;   $��3��6e   $
��Left=�6u   $��0,61,0,0q�6�   $��1��6�   $	��Top=�6�   $	��4,6q�6�   $��STSong)�6�   $��18(�6�   $
��Bold"�6�   6	  �� 5L  
   $��2��6   $
��Left=�6$   $��	85,70,0,0q�6?   $��1��6R   $
��Wrap=�6_    ' ticket.ticket#��� ' 6s   $	��Top=�6�   $��STSong)�6�   $��18(�6�   $
��Bold"�6�   �� 5M  
   -   5        C ��Name$	C err��5M     $��2��6!   $
��Left=�61   $��
28,100,0,0q�6L   $��1��6`   $
��Wrap=�6m    ( 
ticket.err#��� ( 6�   $	��Top=�6�   ���	#FFEE2121$��STSong)�6�   $��22(�6�   $
��Bold"�6�   $	��123��6  $y�Hidden=�6  5N     5O     