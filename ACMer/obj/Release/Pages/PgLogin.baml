   M S B A M L   `   `   `  ���� @  <ACMer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:ACMer.PagesACMer.Pages      ACMer.Pages.PgLogin   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     +localclr-namespace:ACMer.Pages     $	��500��$	��400��.���   � ColumnDefinitions  �� $
��118* ��� $
��251* ��� $
��Auto �$��81���� $	��50* � � RowDefinitions �� $
��111* ��� $	��50* ��� $	��50* ��� $	��86* ��� $
��103* �.+���    pglog.labid#���   $��Center=�$��Center=�$��1��$��16(�$��30����   pgreg.labpass#���  $��Center=�$��Center=�$��2��$��16(�$��30���� -    ��Name$ txtID��  PageTextBoxStyle#��[ $��0,5,10,5q�$��1��$��1��$��2�� �� 	MaxLength$ 10��G� -    G�Name$ txtPassword��  PagePasswordBoxStyle#��[ $��0,5,10,5q�$��2��$��1��$��2�� G� 	MaxLength$ 16����   pglog.btnlog#���  $��Center=�$	��Top=�$��36(�$��Light"�$��1��$��56���� -    ��Name$ btnLogin�� �� 	IsDefault .   PageButtonStyle#��[ #���  $��70,28,40,16q�$��16(�$��3��$��3���� -   $ btnRegister��  PageButtonSimple#��[   pglog.btnreg#���  $
��Left=�$	��Top=�$��4��$��2��$��14(�$
��Bold"���   
pglog.come#���  $��1��$��Right=�$��0,6,0,0q�$��4��$	��Top=�$��14(�$��28���� -    ��Name$ errID��$��3��
���  ��$
��Left=�$	��●��$��36(� 	 pglog.errid	 � ToolTip#	 � 	 $y�Hidden=�$��1��$��23���� -   $ errPassword��$��3��
���  ��$
��Left=�$��2��$	��●��$��36(�$y�Hidden=� 
 pglog.errpass#	 � 
 $��23��