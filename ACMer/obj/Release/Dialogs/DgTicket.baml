   M S B A M L   `   `   `  ���� @  <ACMer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:ACMerACMer  b ^PresentationFramework.Aero2, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35hKclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.Aero2Microsoft.Windows.Themes     ACMer.Dialogs.DgTicket   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     %localclr-namespace:ACMer     ^ThemesKclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.Aero2       � Title$	  票��$	��423��$	��639�� � AllowsTransparency .  � WindowStartupLocation$ CenterScreen=� � 
ResizeMode$ NoResize=� � WindowStyle$
 None=� � 	Resources    ComboBox.Static.Background  ComboBox.Static.Border �� Color ' #ComboBox.Static.Editable.Background # ComboBox.Static.Editable.Border . *ComboBox.Static.Editable.Button.Background * &ComboBox.Static.Editable.Button.Border  ComboBox.MouseOver.Glyph ! ComboBox.MouseOver.Background  ComboBox.MouseOver.Border *	 &ComboBox.MouseOver.Editable.Background &
 "ComboBox.MouseOver.Editable.Border 1 -ComboBox.MouseOver.Editable.Button.Background �� EndPoint �� 
StartPoint	 � Color
 � Offset - )ComboBox.MouseOver.Editable.Button.Border  ComboBox.Pressed.Glyph  ComboBox.Pressed.Background  ComboBox.Pressed.Border ( $ComboBox.Pressed.Editable.Background $  ComboBox.Pressed.Editable.Border / +ComboBox.Pressed.Editable.Button.Background + 'ComboBox.Pressed.Editable.Button.Border  ComboBox.Disabled.Glyph   ComboBox.Disabled.Background  ComboBox.Disabled.Border ) %ComboBox.Disabled.Editable.Background % !ComboBox.Disabled.Editable.Border 0 ,ComboBox.Disabled.Editable.Button.Background , (ComboBox.Disabled.Editable.Button.Border  ComboBox.Static.Glyph  ComboBoxToggleButton2 �� 
TargetType �� Property �� Value �� 
TargetType ��Name J� SnapsToDevicePixels F�Name �� Triggers ^� 
Conditions �� Binding �� RelativeSource �� AncestorType �� Value �� 
TargetName P� Property P� Value  ComboBoxTemplate �Name � ColumnDefinitions �Name � AllowsTransparency �� Mode5  /Microsoft.Windows.Themes.SystemDropShadowChrome   Name!   Color" �� MaxDropDownHeight# �� ElementName$ ��Name% �� ClearTypeHint& ��Name' ��Name( ��Name-  'System.Windows.Input.KeyboardNavigation)   DirectionalNavigation* d�Name+ d� 	IsChecked, ��Name- �� SelectionBoxItemTemplate. �� SelectionBoxItem#/ �� SelectionBoxItemStringFormat0 �� ContentStringFormat1 J� IsHitTestVisible2 P� 
SourceName3 ]� 
Conditions4 �� Property  TextBox.Static.Background  ComboBoxEditableTextBox   ComboBoxEditableTemplate5 ��Name6 �� 
IsReadOnly ! ComboBoxStyle " FocusVisual7 �� Triggers��%J  &	        &	      &	 ,     &	 A     &	 V     &	 m     &	 �     &	 �     &	 �     &		 �     &	
 �     &	 �     &	 K    &	 `    &	 w    &	 �    &	 �    &	 �    &	 �    &	 '    &	 <    &	 S    &	 j    &	 �    &	 �    &	 �    &	 �    &	 �    &	 �    7  7   7  7  7  7  7  7  7  7  7 	 7 
 7  7  7  7  7  7  7  7  7  7  7  7  7  7  7  7  &	 "    7  &	 �    &	 �    &	  [    7  7  7  &	! �    7 " 7   7  7  7   ��Transparent���� $ Transparent���� $ 	#FFFFFFFF���� $ 	#FFABADB3���� $ Transparent���� $ Transparent���� $ Transparent����Transparent���� $ Transparent���� $ 	#FFFFFFFF���� $ 	#FF7EB4EA���� $	 0,1&�$	 0,0&�.��� $	 	#FFEBF4FC��$	
 0.0Q�� $	 	#FFDCECFC��$	
 1.0Q��� $ 	#FF7EB4EA���� $ Transparent����Transparent���� $ Transparent���� $ 	#FFFFFFFF���� $ 	#FF569DE5���� $	 0,1&�$	 0,0&�.��� $	 	#FFDAEBFC��$	
 0.0Q�� $	 	#FFC4E0FC��$	
 1.0Q��� $ 	#FF569DE5���� $ Transparent���� $ Transparent���� $ Transparent���� $ 	#FFFFFFFF���� $ 	#FFBFBFBF���� $ Transparent���� $ Transparent���� $ Transparent���� " d�.���  �@�OverridesDefaultStyle . ��  � �� .  ��  � |� .  ��  �@��	ClickMode$ Press=���  � �� �� " d�.R��� $ templateRoot��8��  #��z��8��  . ._��� $ splitBorder��
������ $��1q�$��Right=�$��0q� . #��� r�._�F� $ arrow��F����        ���( ��( јaQ     јaQ P����̰( � �    P����        8�� $��Center=�$��0q�$��Center=� ^�  ��  �� *
IsEditable+ �� " �� true��  �� *IsMouseOver+ �� *Self+	 false��  �� *	IsPressed+ �� *Self+	 false��  �� *	IsEnabled+ �� *Self+ true.0��� $ templateRoot��8   � ���� $ templateRoot��8   � ���� $ splitBorder��8   � ���� $ splitBorder��8   � ��P�  �@J�IsMouseOver . . ��� $ arrow��8   � ��^�  ��  �� *IsMouseOver+ �� *Self+ true��  �� *
IsEditable+ �� " ��	 false.0��� $ templateRoot��8   � ���� $ templateRoot��8 	  � ��^�  ��  �� *IsMouseOver+ �� *Self+ true��  �� *
IsEditable+ �� " �� true.0��� $ templateRoot��8 
  � ���� $ templateRoot��8   � ���� $ splitBorder��8   � ���� $ splitBorder��8   � ��P�  � �� . . ��� $ arrow��8   � ��^�  ��  �� *	IsPressed+ �� *Self+ true��  �� *
IsEditable+ �� " ��	 false.0��� $ templateRoot��8   � ���� $ templateRoot��8   � ��^�  ��  �� *	IsPressed+ �� *Self+ true��  �� *
IsEditable+ �� " �� true.0��� $ templateRoot��8   � ���� $ templateRoot��8   � ���� $ splitBorder��8   � ���� $ splitBorder��8   � ��P�  � {� .  . ��� $ arrow��8   � ��^�  ��  �� *	IsEnabled+ �� *Self+	 false��  �� *
IsEditable+ �� " ��	 false.0��� $ templateRoot��8   � ���� $ templateRoot��8   � ��^�  ��  �� *	IsEnabled+ �� *Self+	 false��  �� *
IsEditable+ �� " �� true.0��� $ templateRoot��8   � ���� $ templateRoot��8   � ���� $ splitBorder��8   � ���� $ splitBorder��8   � ���� " ��.R�� $ templateRoot�� .  �� $��* ��� #��� r�$��0 �.+�� $ 
PART_Popup�� . $��2��$��1q�#��� .�$��Bottom=����� *IsDropDownOpen+$ TwoWay=� �� *TemplatedParent+.��  $  shadow��$! Transparent��#��z" ���� *ActualWidth+$# templateRoot��._��� $ dropDownBorder��#��� ��$��1q�#��� ��._��� $$ DropDownScrollViewer��.��� $
 grid��$% Enabled=�.+��� $& canvas��$
��Left=�$��0��$	��Top=�$��0��.+��� $' 
opaqueRect������ *
Background+$# dropDownBorder������ *ActualHeight+$# dropDownBorder������ *ActualWidth+$# dropDownBorder���� $( ItemsPresenter��$) 	Contained=�# z d� $* toggleButton��#��z��#��z��#��z��$��2��8��  + �� *IsDropDownOpen+$ TwoWay=� �� *TemplatedParent+�� $, contentPresenter��#��z- #��z��#��z. #0 z/ #��z��1 .  #��z��# z #��z�� P� $2 
PART_Popup�� �@�HasDropShadow . . ��� $ shadow�� � ��$ 0,0,5,5q��� $ shadow�� �@ Color$ 	#71000000��P�  �@��HasItems .  . ��� $ dropDownBorder�� � ��$ 95��]� 3 �� 4 �@��
IsGrouping . �� "4 �@%�IsVirtualizingWhenGrouping .  ./���  � �� .  P� $2 DropDownScrollViewer�� � �� .  . ��� $ 
opaqueRect�� �� *VerticalOffset+$# DropDownScrollViewer�� �@��Top�� $ 
opaqueRect�� �� *HorizontalOffset+$# DropDownScrollViewer�� �@��Left�� $ 	#FFFFFFFF���� " ��.���  �@�OverridesDefaultStyle . ��  �@J�	AllowDrop . ��  � ��$ 0����  � ��$ 0����  �@�FocusVisualStyle Z� ��  �@��PanningMode$ VerticalFirst=���  �@��IsFlicksEnabled .  ��  � �� �� " ��.R��� $$ PART_ContentHost��
������ |�.  $��Hidden=�$��Hidden=��� " ��.R�� $ templateRoot�� .  �� $��* ��� #��� r�$��0 �.+�� $ 
PART_Popup�� . $��2��#��� .�$��Bottom=����� *IsDropDownOpen+ �� *TemplatedParent+.��  $  shadow��$! Transparent��#��z" ���� *ActualWidth+$# templateRoot��._��� $ dropDownBorder��#��� ��$��1q�#��� ��._��� $$ DropDownScrollViewer��.��� $
 grid��$% Enabled=�.+��� $& canvas��$
��Left=�$��0��$	��Top=�$��0��.+��� $' 
opaqueRect������ *
Background+$# dropDownBorder������ *ActualHeight+$# dropDownBorder������ *ActualWidth+$# dropDownBorder���� $( ItemsPresenter��$) 	Contained=�# z d� $* toggleButton��#��z��#��z��#��z��$��2��8��  + �� *IsDropDownOpen+$ TwoWay=� �� *TemplatedParent+�� $ border��8�� #��z��._��� $5 PART_EditableTextBox��#��z��#��z��8�� #��z��6 �� *
IsReadOnly+ �� *TemplatedParent+ P�  � {� .  . ��� $ border�� �@J�Opacity$
 0.56Q�P�  �@J�IsKeyboardFocusWithin . . ���  � ��
 �   �P� $2 
PART_Popup�� �@�HasDropShadow . . ��� $ shadow�� � ��$ 0,0,5,5q��� $ shadow�� �@ Color$ 	#71000000��P�  �@��HasItems .  . ��� $ dropDownBorder�� � ��$ 95��]� 3 �� 4 �@��
IsGrouping . �� "4 �@%�IsVirtualizingWhenGrouping .  ./���  � �� .  P� $2 DropDownScrollViewer�� � �� .  . ��� $ 
opaqueRect�� �� *VerticalOffset+$# DropDownScrollViewer�� �@��Top�� $ 
opaqueRect�� �� *HorizontalOffset+$# DropDownScrollViewer�� �@��Left�� " ��.���  �@�FocusVisualStyle8   ��  � ��8  ��  � ��8  ��  � ��# � ����  � ��$ 1q���  � ��$
 Auto=���  � ��$
 Auto=���  � ��$ 6,3,5,3q���  � �� . ��  �@��PanningMode$
 Both=���  �@��IsFlicksEnabled .  ��  � ��8  7 P�  �@��
IsEditable . . ���  � �� .  ��  � ��$ 2q���  � ��8  ���� 8 �� ImageSource$)8 #/ACMer;component/Images/Ticket2.png��.��� 9 � RowDefinitions9 �� $
��143* ��� $
��280* � �� $
��267* ��� $
��133* ��� $
��161* ��� $	��78* �.+��� -   $��4��$��60��$	��Top=��� -   : J� Opacity$: 0Q�$
��Left=�$��42��$��9,23,0,0q�$	��Top=�$��38��$��3������ $'8 !/ACMer;component/Images/close.jpg������ " ��7 :� ; :� RoutedEvent$; UIElement.MouseEnter��.[��� .���� .��W� < �� TargetProperty$< Opacity�	= W� To$= 1X�> g� Duration$> 0:0:0.15D�:� $; UIElement.MouseLeave��.[��� .���� .��W� $< Opacity�$> 0:0:0.15D��� -   ? ��Name$? locFrom��$��Right=�$��	0,0,30,10q�$��测试��$��Bottom=�$��Center=�$��Center=�$��STSong)�$
��Bold"�$��36(��� -   $? ID��$��1��$
��0,50q�$��测试��$��Bottom=�$��Center=�$��Center=�$��STSong)�$
��Bold"�$��28(��� -   $? locTo��$��2��$��2��$
��Left=�$��	30,0,0,10q�$��测试��$��Bottom=�$��Center=�$��Center=�$��STSong)�$
��Bold"�$��36(��� -   $? timeFrom��$��1��$��测试��$	��Top=�$��Center=�$��Center=�$��STSong)�$
��Bold"�$��24(��� -   $? timeTo��$��2��$��2��$��1��$��测试��$	��Top=�$��Center=�$��Center=�$��STSong)�$
��Bold"�$��24(��� -   @ ��Name$	@ com��$��2��$��40��$��
40,64,30,0q�$��1��$	��Top=�$��STSong)�$
��Bold"�$��22(�$��Center=�$��Center=�#��[! �� -	   $
@ com2��$��1��$
��Left=�$��
120,68,0,0q�$��1��$	��Top=�#��[! A �� SelectedIndex$A 0��$��STSong)�$
��Bold"�$��18(�{�.  $��2��.@���  # ticket.book#��� # $
��Bold"�$��22(�$��STSong)���  $ ticket.refund#��� $ $
��Bold"�$��22(�$��STSong)��� -
   $5 txtCnt��B �� 	MaxLength$B 4��$��2��$
��Left=�$��30��$��35��$��	50,66,0,0q�$��1��$	��Top=�$��0��$��STSong)�$��22(�$
��Bold"�$��Center=�$��Center=�
������ ��Z� �� -    % PageButtonSimple#��[%  & ticket.submit#��� & $��3��$
��Left=�$��0,61,0,0q�$��1��$	��Top=�$	��4,6q�$��STSong)�$��18(�$
��Bold"��� $��2��$
��Left=�$��	85,70,0,0q�$��1��$
��Wrap=� ' ticket.ticket#��� ' $	��Top=�$��STSong)�$��18(�$
��Bold"��� -   C ��Name$	C err��$��2��$
��Left=�$��
28,100,0,0q�$��1��$
��Wrap=� ( 
ticket.err#��� ( $	��Top=����	#FFEE2121$��STSong)�$��22(�$
��Bold"�$	��123��$y�Hidden=�