   M S B A M L   `   `   `  ���� @  <ACMer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:ACMer.PagesACMer.Pages      ACMer.Pages.PgQuery   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     +localclr-namespace:ACMer.Pages     $	��514��$	��672��.���   � RowDefinitions  �� $
��Auto ��� $��1* ��� $��2* �.+���    pgquery.labquery#���   $��Center=�$
��0,20q�$��36(�$��Light"�� $��1��$��Center=� � ColumnDefinitions �� $
��0.5* ��� $
��Auto ��� $��1* ��� $
��Auto ��� $��1* ��� $
��Auto ��� $
��0.5* �  �� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto �.+��� -    ��Name$ txtLoc1��  PageTextBoxPlace#��[  �� 	MaxLength$ 10��$��35��$
��10,5q�$��2���� -   $ txtLoc2��#��[ $ 10��$��35��$
��10,5q�$��4��(  "System.Windows.Controls.DatePicker  -     Name$
 date��  DatePickerStyle#��[ $��100,5q�$��1��$��1��$��4���� -    ��Name$ 
chTransfer��  pgquery.chtransfer#���  $	��0,5q�$��3��  PageCheckBoxStyle#��[ $��1��$��4��$��Center=��� -    ��Name$ stack��$��Center=�$	��0,5q� �� Orientation$ 
Horizontal=�$��2��$��1��$��4��.+��� -   $ chAll��  all#���  $	��5,0q�#��[ �� $��G��$	��3,0q�#��[ �� $��D��$	��3,0q�#��[ �� $��C��$	��3,0q�#��[ �� $��Z��$	��3,0q�#��[ �� $��T��$	��3,0q�#��[ �� $��K��$	��3,0q�#��[ �� $��O��$	��3,0q�#��[ �� -    ��Name$ btnQuery��  PageButtonStyle#��[ $��10q�  pgquery.btn#���  $
��40,8q�$��20(�$��2��$��5���� -   	 ��Name$	 btnExchange��$��3��
 � Cursor$

 Hand��$��30��$'��!/ACMer;component/Images/arrow.png���� -	   $ btnMap��  ButtonBackStyle#��[ $��s��$��Right=�$��Center=� 	 pgquery.maptip � ToolTip# � 	 �� -
    ��Name$	 lst�� 
 PageListBox#��[
 $��20,15,20,30q�$��2���� -   $ btnBack��#��[ $
��Left=�$��10,0,0,0q�$��Center=�