   M S B A M L   `   `   `  ����@  <ACMer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:ACMerACMer  5          ACMer.Pages.PgTrain   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      &parentclr-namespace:ACMer     5      $	��558��5      $	��872��6     � 	Resources  5	         DataGridStyle �� 
TargetType&   System.Windows.Controls.DataGrid �� Property �� Value �� 
TargetType �� CornerRadius �� Padding J� SnapsToDevicePixels ��Name	 � ColumnDefinitions
 � RowDefinitions   SelectAllCommand �� 
ResourceId �� TypeInTargetAssembly7  1System.Windows.Controls.DataGridHeadersVisibility
   All �� ConverterParameter!   HeadersVisibilityConverter �� 	Converter �� RelativeSource �� AncestorTypeG  ASystem.Windows.Controls.Primitives.DataGridColumnHeadersPresenter  Name   Column ��Name �� CanContentScroll ��Name  SimpleScrollBar �� ScrollableHeight � Maximum �� Orientation* �� #ComputedVerticalScrollBarVisibility �� ViewportHeight �� ViewportSize � Value  �� Mode! �� ScrollableWidth," �� %ComputedHorizontalScrollBarVisibility# �� ViewportWidth$ �� Triggers% ]� 
Conditions& �� Property' �� Value��%�  &	        7  7  �� 5
   
   "  6&   .�5      ��  � ��
 �����6+   �� 5       � ��# � ��6+   �� 5       � �� �	#FF674AB76,   �� 5       � ��$ 2q�60   �� 5        �@ RowDetailsVisibilityMode$ VisibleWhenSelected=�69   �� 5       � �� . 6>   �� 5       �@��PanningMode$
 Both=�69   �� 5       �@��IsFlicksEnabled .  67   �� 5       � �� 5      �� 5      "  6&   .R�5      �� $ 8��6!   #��z��62   #��z��6^   #��z��6�   # z��6�    . ._�5      �� $ DG_ScrollViewer��66   $��4q�6+   |�.  ��5   "   �� 5   &   " ��66   .R�5   *   � 	 5   .   �� 5   2   $
��Auto �6C   �� 5   2   $��* �6C   �� 5   2   $
��Auto �6C   
 5    .   �� 5!   2   $
��Auto �6@   �� 5"   2   $��* �6@   �� 5#   2   $
��Auto �6@   .+�5%   .   �� #��Z 65   |�.  ��6v   C� *�� $" DataGridSelectAllButtonStyle��"  +y�6�   �� *HeadersVisibility+# Z # Z  �� "  ��6�  �� *CellsPanelHorizontalOffset+ �� "    5&   .   $! PART_ColumnHeadersPresenter��6M   $��1��6r   y�6�   �� *HeadersVisibility+# Z # Z  �� "  �� 5'   .   $! PART_ScrollContentPresenter��6E   # z��6j   $��2��6�   $��1��6�   �� 5(   .   $ PART_VerticalScrollBar��6a   8��  $��2��6�   # z 6�   $ Vertical=�6�   $��1��6�   #y�z 6�   # z 6�   6%  �� *VerticalOffset+$  OneWay=� �� *TemplatedParent+6�  � 5)   .   $��1��63   $��2��6C   	 5*   2   �� 5+   6   ��6G   �� **(NonFrozenColumnsViewportHorizontalOffset+ �� "  �� 5,   6   $��* �6G   .+�5.   2   �� $ PART_HorizontalScrollBar��6e   8�� $��1��6�   # z! 6�   $ 
Horizontal=�6�   #y�z" 6�   # z# 6�   6!  �� *HorizontalOffset+$  OneWay=� �� *TemplatedParent+6�  5/   /   50   +   51   '   .��53   "   �� # z 61   54      55      56      58      $ 59      ]� 5:      % 5;      �� 5<      & �@��
IsGrouping' . 6:   �� 5=      "& �@%�IsVirtualizingWhenGrouping' .  6\   ./�5?      ��  � �� .  6F   5@      5B      5C      .��5E      � 
 5F   
   �� 5G      $
��Auto �6   �� 5H      $
��Auto �6   �� 5I      $
��Auto �6   �� 5J      $
��Auto �6   �� 5K      �� 5L      $
��Auto �6   .+�5N   
   �� -   5        ( ��Name$( btnBack��5N   :     ButtonBackStyle#��[ 6   $
��Left=�6K   $��
20,20,0,20q�6f   $��Center=�6z   6�   �� 5O   
   ) �� Orientation$) 
Horizontal=�6   $��1��6.   $
��0,10q�6;   $��Center=�6I   .+�5P      ��   pgtrain.labid#���  6   $��20(�6>   $��Light"�6L   $
��10,0q�6_   �� 5Q      -   5        * ��Name$* txtID��5Q   @     PageTextBoxStyle#��[ 6   + �� 	MaxLength$+ 10��6O   $	��120��6^   $��35��6j   $��16(�6v   �� 5R        pgtrain.labname#���  6   $��20(�6@   $��Light"�6N   $��	20,0,10,0q�6a   �� 5S      -   5        $* txtName��5S   @   #��[ 6   $+ 10��6Q   $	��120��6`   $��35��6l   $��16(�6x   5T        5U   
   -   5        ,  Name$
, grid��5U      -   AutoGenerateColumns- .  $��
30,5,30,35q�6=   $��4��6Q   $��18(�6^   .   CanUserReorderColumns. .  /   CanUserSortColumns/ .  0   CanUserResizeRows0 .  1   CanUserAddRows1 .  2   CanUserDeleteRows2 .  #���   6�   3   HorizontalGridLinesBrush3 �	#FF674AB74   VerticalGridLinesBrush4 �	#FF674AB75   Columns5 5V      0  *System.Windows.Controls.DataGridTextColumn  5W        pgtrain.station,  &System.Windows.Controls.DataGridColumn6   Header#6 �  6%   1  +System.Windows.Controls.DataGridBoundColumn7   Binding7 6P   �� *Name+4  .System.Windows.Controls.DataGridTemplateColumn  5X        pgtrain.arrive#6 �  6)   8   CellTemplate8 5Y      �� 5Z      .R�5[         ACMer.TimeSetter  
9   Day9 5\   !   �� *	ArriveDay+$  TwoWay=�: �� UpdateSourceTrigger$: PropertyChanged=�;   Hour; 5]   !   �� *
ArriveHour+$  TwoWay=�$: PropertyChanged=�<   Minute< 5^   !   �� *ArriveMinute+$  TwoWay=�$: PropertyChanged=�5_      5a        5b        pgtrain.start#6 �  6)   8 5c      �� 5d      .R�5e        9 5f   !   �� *
StartDay+$  TwoWay=�$: PropertyChanged=�; 5g   !   �� *	StartHour+$  TwoWay=�$: PropertyChanged=�< 5h   !   �� *StartMinute+$  TwoWay=�$: PropertyChanged=�5i      5k        5l      -   5        col一等座��$6 	一等座��5l   5   7 6B   �� *
P一等座+  5m      -   5        col二等座��$6 	二等座��5m   5   7 6B   �� *
P二等座+  5n      -   5        col特等座��$6 	特等座��5n   5   7 6B   �� *
P特等座+  5o      -   5        col商务座��$6 	商务座��5o   5   7 6B   �� *
P商务座+  5p      -	   5        	col软卧��$6 软卧��5p   4   7 6@   �� *	P软卧+  5q      -
   5        	col硬卧��$6 硬卧��5q   4   7 6@   �� *	P硬卧+  5r      -   5        col高级软卧��$6 高级软卧��5r   6   7 6D   �� *P高级软卧+  5s      -   5        	col无座��$6 无座��5s   4   7 6@   �� *	P无座+  5t      -   5        	col软座��$6 软座��5t   4   7 6@   �� *	P软座+  5u      -   5        	col硬座��$6 硬座��5u   4   7 6@   �� *	P硬座+5x      �� 5y   
   -   5        = ��Name$= stack��5y      $��Center=�6$   $) 
Horizontal=�6A   $
��0,10q�6Z   $��2��6h   .+�5z      	� $��G��6   $	��3,0q�6&    	 PageRadioButton#��� 	 63   	� 5{      $��D��6   $	��3,0q�6&   #��� 	 63   	� 5|      $��C��6   $	��3,0q�6&   #��� 	 63   	� 5}      $��Z��6   $	��3,0q�6&   #��� 	 63   	� 5~      $��T��6   $	��3,0q�6&   #��� 	 63   	� 5      $��K��6   $	��3,0q�6&   #��� 	 63   	� 5�      $��O��6   $	��3,0q�6&   #��� 	 63   5�      � 5�   
   -   5        > �Name$> stack2��5�      $��Center=�6$   ? � Orientation$? 
Horizontal=�6A   $��3��6Z   .+�5�      �� -   5         
 all#��� 
 5�      $	��5,0q�67     PageCheckBoxStyle#��[ 6D   $��18(�6�   $��Center=�6�   �� 5�      -   5        $��	一等座��5�      $	��2,0q�6%   #��[ 62   $��17(�6�   $��Center=�6�   �� 5�      -   5        $��	二等座��5�      $	��2,0q�6%   #��[ 62   $��17(�6�   $��Center=�6�   �� 5�      -   5        $��	特等座��5�      $	��2,0q�6%   #��[ 62   $��17(�6�   $��Center=�6�   �� 5�      -   5        $��	商务座��5�      $	��2,0q�6%   #��[ 62   $��17(�6�   $��Center=�6�   �� 5�      -   5        $��软卧��5�      $	��2,0q�6$   #��[ 61   $��17(�6�   $��Center=�6�   �� 5�      -   5        $��硬卧��5�      $	��2,0q�6$   #��[ 61   $��17(�6�   $��Center=�6�   �� 5�      -   5        $��高级软卧��5�      $	��2,0q�6&   #��[ 63   $��17(�6�   $��Center=�6�   �� 5�      -   5        $��无座��5�      $	��2,0q�6$   #��[ 61   $��17(�6�   $��Center=�6�   �� 5�      -   5        $��软座��5�      $	��2,0q�6$   #��[ 61   $��17(�6�   $��Center=�6�   �� 5�      -   5        $��硬座��5�      $	��2,0q�6$   #��[ 61   $��17(�6�   $��Center=�6�   5�      �� 5�   
   -   5        @ ��Name$@ title��5�      $��Center=�6     pgtrain.title#���  6<   $��Center=�6f   $��36(�6�   $��Light"�6�   �� 5�   
   $��5��6   $) 
Horizontal=�6"   $��	0,0,30,20q�6;   $��Right=�6N   .+�5�      �� -   5        $( 	btnModify��5�        PageButtonStyle#��[ 6(     pgtrain.btnmodify1#���  6Q   $
��10,0q�6�   $
��20,8q�6�   $��16(�6�   6�   �� 5�      -   5        $( btnSell��5�      #��[ 6&     pgtrain.btnsale#���  6O   $
��10,0q�6{   $
��20,8q�6�   $��16(�6�   6�   �� 5�      -   5        $( 	btnSubmit��5�      #��[ 6(     pgtrain.btnsubmit#���  6Q   $
��10,0q�6   $
��20,8q�6�   $��16(�6�   6�   �� 5�      -    5        $( 	btnDelete��5�      #��[ 6(     pgtrain.btndelete#���  6Q   $
��10,0q�6   $
��20,8q�6�   $��16(�6�   6�   5�      �� 5�   
   $��	30,0,0,20q�6   $) 
Horizontal=�6(   $��5��6A   $
��Left=�6N   .+�5�      �� -!   5        $( btnAdd��5�      #��[ 6%   $��+��6Z   $
��Left=�6f   $��Microsoft Sans Serif)�6�   $��24(�6�   �� 5�      -"   5        $( 	btnRemove��5�      #��[ 6(   $��-��6]   $
��Left=�6j   $��Microsoft Sans Serif)�6�   $��24(�6�   5�      5�      5�      