   M S B A M L   `   `   `  ���� @  <ACMer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:ACMer.PagesACMer.Pages      ACMer.Pages.PgMyTicket   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     +localclr-namespace:ACMer.Pages     $	��514��$	��672��.���   � RowDefinitions  �� $
��Auto ��� $��1* ��� $��5* �.+���    pgmy.lab#���   $��Center=�$
��0,20q�$��36(�$��Light"�� $��1��$��Center=� � ColumnDefinitions �� $
��0.5* ��� $
��Auto ��� $��1* ��� $
��Auto ��� $��1* ��� $
��Auto ��� $
��0.5* �  �� $
��Auto ��� $
��Auto �.+�(  "System.Windows.Controls.DatePicker  -     Name$ date1��  DatePickerStyle#��[ $
��10,5q�$��2��  -   $ date2��#��[ $
��10,5q�$��4���� -    ��Name$ stack��$��Center=�$	��0,5q� �� Orientation$ 
Horizontal=�$��1��$��1��$��4��.+��� -     all#���  $	��5,0q�  PageCheckBoxStyle#��[ �� $��G��$	��3,0q�#��[ �� $��D��$	��3,0q�#��[ �� $��C��$	��3,0q�#��[ �� $��Z��$	��3,0q�#��[ �� $��T��$	��3,0q�#��[ �� $��K��$	��3,0q�#��[ �� $��O��$	��3,0q�#��[ �� -    ��Name$ btnQuery��  PageButtonStyle#��[ $��10q�  pgquery.btn#���  $
��40,8q�$��16(�$��2��$��5���� $��Right=�$��20,0,0,0q�  from#���  $��Center=�$��16(�$��1���� $��3��  to#���  $��Center=�$��16(�$
��0,11q��� -    ��Name$	 lst��  PageListBox#��[ $��20,15,20,30q�$��2���� -   $ btnBack�� 	 ButtonBackStyle#��[	 $
��Left=�$��10,0,0,0q�$��Center=�