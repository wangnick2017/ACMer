   M S B A M L   `   `   `  ���� @  <ACMer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:ACMerACMer      ACMer.Pages.PgTrain   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     &parentclr-namespace:ACMer     $	��558��$	��872��  � 	Resources     DataGridStyle �� 
TargetType&   System.Windows.Controls.DataGrid �� Property �� Value �� 
TargetType �� CornerRadius �� Padding J� SnapsToDevicePixels ��Name	 � ColumnDefinitions
 � RowDefinitions   SelectAllCommand �� 
ResourceId �� TypeInTargetAssembly7  1System.Windows.Controls.DataGridHeadersVisibility
   All �� ConverterParameter!   HeadersVisibilityConverter �� 	Converter �� RelativeSource �� AncestorTypeG  ASystem.Windows.Controls.Primitives.DataGridColumnHeadersPresenter  Name   Column ��Name �� CanContentScroll ��Name  SimpleScrollBar �� ScrollableHeight � Maximum �� Orientation* �� #ComputedVerticalScrollBarVisibility �� ViewportHeight �� ViewportSize � Value  �� Mode! �� ScrollableWidth," �� %ComputedHorizontalScrollBarVisibility# �� ViewportWidth$ �� Triggers% ]� 
Conditions& �� Property' �� Value��%�  &	        7  7  �� "  .���  � ��
 �������  � ��# � ����  � �� �	#FF674AB7��  � ��$ 2q���   �@ RowDetailsVisibilityMode$ VisibleWhenSelected=���  � �� . ��  �@��PanningMode$
 Both=���  �@��IsFlicksEnabled .  ��  � �� �� "  .R��� $ 8��#��z��#��z��#��z��# z�� . ._��� $ DG_ScrollViewer��$��4q�|�.  ���� " ��.R�� 	 �� $
��Auto ��� $��* ��� $
��Auto �
 �� $
��Auto ��� $��* ��� $
��Auto �.+��� #��Z |�.  ��C� *�� $" DataGridSelectAllButtonStyle��"  +y��� *HeadersVisibility+# Z # Z  �� "  ���� *CellsPanelHorizontalOffset+ �� "    $! PART_ColumnHeadersPresenter��$��1��y��� *HeadersVisibility+# Z # Z  �� "  �� $! PART_ScrollContentPresenter��# z��$��2��$��1���� $ PART_VerticalScrollBar��8��  $��2��# z $ Vertical=�$��1��#y�z # z  �� *VerticalOffset+$  OneWay=� �� *TemplatedParent+� $��1��$��2��	 �� ���� **(NonFrozenColumnsViewportHorizontalOffset+ �� "  �� $��* �.+��� $ PART_HorizontalScrollBar��8�� $��1��# z! $ 
Horizontal=�#y�z" # z#  �� *HorizontalOffset+$  OneWay=� �� *TemplatedParent+.���� # z $ ]� % �� & �@��
IsGrouping' . �� "& �@%�IsVirtualizingWhenGrouping' .  ./���  � �� .  .��� 
 �� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� �� $
��Auto �.+��� -   ( ��Name$( btnBack��  ButtonBackStyle#��[ $
��Left=�$��
20,20,0,20q�$��Center=��� ) �� Orientation$) 
Horizontal=�$��1��$
��0,10q�$��Center=�.+���   pgtrain.labid#���  $��20(�$��Light"�$
��10,0q��� -   * ��Name$* txtID��  PageTextBoxStyle#��[ + �� 	MaxLength$+ 10��$	��120��$��35��$��16(���   pgtrain.labname#���  $��20(�$��Light"�$��	20,0,10,0q��� -   $* txtName��#��[ $+ 10��$	��120��$��35��$��16(�  -   ,  Name$
, grid��-   AutoGenerateColumns- .  $��
30,5,30,35q�$��4��$��18(�.   CanUserReorderColumns. .  /   CanUserSortColumns/ .  0   CanUserResizeRows0 .  1   CanUserAddRows1 .  2   CanUserDeleteRows2 .  #���   3   HorizontalGridLinesBrush3 �	#FF674AB74   VerticalGridLinesBrush4 �	#FF674AB75   Columns5 0  *System.Windows.Controls.DataGridTextColumn    pgtrain.station,  &System.Windows.Controls.DataGridColumn6   Header#6 �  1  +System.Windows.Controls.DataGridBoundColumn7   Binding7 �� *Name+4  .System.Windows.Controls.DataGridTemplateColumn    pgtrain.arrive#6 �  8   CellTemplate8 �� .R�   ACMer.TimeSetter  
9   Day9 �� *	ArriveDay+$  TwoWay=�: �� UpdateSourceTrigger$: PropertyChanged=�;   Hour; �� *
ArriveHour+$  TwoWay=�$: PropertyChanged=�<   Minute< �� *ArriveMinute+$  TwoWay=�$: PropertyChanged=�    pgtrain.start#6 �  8 �� .R�  9 �� *
StartDay+$  TwoWay=�$: PropertyChanged=�; �� *	StartHour+$  TwoWay=�$: PropertyChanged=�< �� *StartMinute+$  TwoWay=�$: PropertyChanged=�  -   col一等座��$6 	一等座��7 �� *
P一等座+  -   col二等座��$6 	二等座��7 �� *
P二等座+  -   col特等座��$6 	特等座��7 �� *
P特等座+  -   col商务座��$6 	商务座��7 �� *
P商务座+  -	   	col软卧��$6 软卧��7 �� *	P软卧+  -
   	col硬卧��$6 硬卧��7 �� *	P硬卧+  -   col高级软卧��$6 高级软卧��7 �� *P高级软卧+  -   	col无座��$6 无座��7 �� *	P无座+  -   	col软座��$6 软座��7 �� *	P软座+  -   	col硬座��$6 硬座��7 �� *	P硬座+�� -   = ��Name$= stack��$��Center=�$) 
Horizontal=�$
��0,10q�$��2��.+�	� $��G��$	��3,0q� 	 PageRadioButton#��� 	 	� $��D��$	��3,0q�#��� 	 	� $��C��$	��3,0q�#��� 	 	� $��Z��$	��3,0q�#��� 	 	� $��T��$	��3,0q�#��� 	 	� $��K��$	��3,0q�#��� 	 	� $��O��$	��3,0q�#��� 	 � -   > �Name$> stack2��$��Center=�? � Orientation$? 
Horizontal=�$��3��.+��� -    
 all#��� 
 $	��5,0q�  PageCheckBoxStyle#��[ $��18(�$��Center=��� -   $��	一等座��$	��2,0q�#��[ $��17(�$��Center=��� -   $��	二等座��$	��2,0q�#��[ $��17(�$��Center=��� -   $��	特等座��$	��2,0q�#��[ $��17(�$��Center=��� -   $��	商务座��$	��2,0q�#��[ $��17(�$��Center=��� -   $��软卧��$	��2,0q�#��[ $��17(�$��Center=��� -   $��硬卧��$	��2,0q�#��[ $��17(�$��Center=��� -   $��高级软卧��$	��2,0q�#��[ $��17(�$��Center=��� -   $��无座��$	��2,0q�#��[ $��17(�$��Center=��� -   $��软座��$	��2,0q�#��[ $��17(�$��Center=��� -   $��硬座��$	��2,0q�#��[ $��17(�$��Center=��� -   @ ��Name$@ title��$��Center=�  pgtrain.title#���  $��Center=�$��36(�$��Light"��� $��5��$) 
Horizontal=�$��	0,0,30,20q�$��Right=�.+��� -   $( 	btnModify��  PageButtonStyle#��[   pgtrain.btnmodify1#���  $
��10,0q�$
��20,8q�$��16(��� -   $( btnSell��#��[   pgtrain.btnsale#���  $
��10,0q�$
��20,8q�$��16(��� -   $( 	btnSubmit��#��[   pgtrain.btnsubmit#���  $
��10,0q�$
��20,8q�$��16(��� -    $( 	btnDelete��#��[   pgtrain.btndelete#���  $
��10,0q�$
��20,8q�$��16(��� $��	30,0,0,20q�$) 
Horizontal=�$��5��$
��Left=�.+��� -!   $( btnAdd��#��[ $��+��$
��Left=�$��Microsoft Sans Serif)�$��24(��� -"   $( 	btnRemove��#��[ $��-��$
��Left=�$��Microsoft Sans Serif)�$��24(�