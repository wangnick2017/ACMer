   M S B A M L   `   `   `  ���� @  <ACMer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:ACMer.PagesACMer.Pages      ACMer.Pages.PgProfile   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     +localclr-namespace:ACMer.Pages     $	��500��$	��500��.���   � ColumnDefinitions  �� $
��1.5* ��� $��4* ��� $
��0.5* � � RowDefinitions �� $
��3.5* ��� $��2* ��� $��2* ��� $��2* ��� $��2* ��� $��2* ��� $��2* ��� $��2* ��� $��3* �.+��� -    ��Name$ labID��$��ID��$��1��$��Right=�$��Bottom=�$��	0,0,10,20q�$��16(���    pgreg.labname#���   $��Center=�$��Center=�$��16(�$��1��$
��Wrap=���   pgreg.labpass#���  $��Center=�$��Center=�$��16(�$��2��$
��Wrap=���   pgpro.newpass#���  $��Center=�$��Center=�$��16(�$��3��$
��Wrap=���   pgpro.newpassagain#���  $��Center=�$��Center=�$��16(�$��4��$
��Wrap=���   pgreg.labemail#���  $��Center=�$��Center=�$��16(�$��5��$
��Wrap=���   pgreg.labphone#���  $��Center=�$��Center=�$��16(�$��6��$
��Wrap=���   pgreg.labvalid#���  $��Center=�$��Center=�$��16(�$��7��$
��Wrap=��� -    ��Name$ txtName��  PageTextBoxStyle#��[ $��0,5,10,5q�$��1��$��1�� �� 	MaxLength$ 6��G� -    G�Name$ txtOld��  PagePasswordBoxStyle#��[ $��0,5,10,5q�$��2��$��1�� G� 	MaxLength$ 16��G� -   $ txtPassword��#��[ $��0,5,10,5q�$��3��$��1��$ 16��G� -   $ 
txtConfirm��#��[ $��0,5,10,5q�$��4��$��1��$ 16���� -   $ txtEmail��#��[ $��0,5,10,5q�$��5��$��1��$ 18���� -   $ txtPhone��#��[ $��0,5,10,5q�$��6��$��1��$ 11���� $��1��$��7�� �� Orientation$ 
Horizontal=�.+��� -   $ txtValid�� 	 PageTextBoxValid#��[	 $��0,5,10,5q�$	��130��$ 4��$��Center=��� -	    ��Name$ errValid��
���  ��$	��●��$��36(�$y�Hidden=� 
 pgreg.errvalid	 � ToolTip#	 � 
 �� ���	#FFCDFFD8
 � Cursor$

 Hand��.+��� -
    ��Name$	 img��  pgreg.imgtip#	 �  $	��100��$��50����   pgpro.labmod#���  $��Center=�$��0q�$	��Top=�$��36(�$��Light"�$��3���� -    ��Name$ btnBack��  ButtonBackStyle#��[ $
��Left=�$��	10,10,0,0q�$	��Top=��� -   $ 	btnModify�� �� 	IsDefault .   PageButtonStyle#��[   	pgpro.btn#���  $��70,20,40,10q�$��8��$��2��$��16(�  pgpro.btntip#	 �  �� -   $ errName��$��2��
���  ��$
��Left=�$��1��$	��●��$��36(�$y�Hidden=�  pgreg.errname#	 �  �� -   $ errOld��$��2��
���  ��$
��Left=�$��2��$	��●��$��36(�$y�Hidden=�  pgpro.errold#	 �  �� -   $ 
errConfirm��$��2��
���  ��$
��Left=�$��4��$	��●��$��36(�$y�Hidden=�  pgpro.errnew#	 �  �� -   $ errEmail��$��2��
���  ��$
��Left=�$��5��$	��●��$��36(�$y�Hidden=�  pgreg.erremail#	 �  �� -   $ errPhone��$��2��
���  ��$
��Left=�$��6��$	��●��$��36(�$y�Hidden=�  pgreg.errphone#	 �  