   M S B A M L   `   `   `  ����@  <ACMer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:ACMer.PagesACMer.Pages  5          ACMer.Pages.PgLogin   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:ACMer.Pages     5      $	��500��5   0   $	��400��6?   .��5
      �   � ColumnDefinitions  5   
   �� 5      $
��118* �6   �� 5      $
��251* �6   �� 5      $
��Auto �6   $��81��6,   �� 5      $	��50* �6    � RowDefinitions 5   
   �� 5      $
��111* �6   �� 5      $	��50* �6   �� 5      $	��50* �6   �� 5      $	��86* �6   �� 5      $
��103* �6   .+�5   
   ��    pglog.labid#���   6   $��Center=�68   $��Center=�6U   $��1��6p   $��16(�6}   $��30��6�   �� 5   
     pgreg.labpass#���  6   $��Center=�6:   $��Center=�6W   $��2��6r   $��16(�6   $��30��6�   �� 5   
   -   5         ��Name$ txtID��5   <     PageTextBoxStyle#��[ 6   $��0,5,10,5q�6K   $��1��6]   $��1��6j   $��2��6z    �� 	MaxLength$ 10��6�   G� 5   
   -   5         G�Name$ txtPassword��5   D     PagePasswordBoxStyle#��[ 6   $��0,5,10,5q�6Y   $��2��6k   $��1��6x   $��2��6�    G� 	MaxLength$ 16��6�   6�   �� 5   
     pglog.btnlog#���  6   $��Center=�69   $	��Top=�6V   $��36(�6n   $��Light"�6|   $��1��6�   $��56��6�   �� 5   
   -   5         ��Name$ btnLogin��5   K    �� 	IsDefault .   PageButtonStyle#��[ 6"   #���  6]   $��70,28,40,16q�6�   $��16(�6�   $��3��6�   $��3��6�   �� 5   
   -   5        $ btnRegister��5   ;     PageButtonSimple#��[ 6     pglog.btnreg#���  6P   $
��Left=�6y   $	��Top=�6�   $��4��6�   $��2��6�   $��14(�6�   $
��Bold"�6�   �� 5   
     
pglog.come#���  6   $��1��67   $��Right=�6G   $��0,6,0,0q�6c   $��4��6t   $	��Top=�6�   $��14(�6�   $��28��6�   �� 5    
   -   5         ��Name$ errID��5       $��3��6#   
���  ��$
��Left=�6D   $	��●��6_   $��36(�6h    	 pglog.errid	 � ToolTip#	 � 	 6v   $y�Hidden=�6�   $��1��6�   $��23��6�   �� 5!   
   -   5        $ errPassword��5!      $��3��6)   
���  ��$
��Left=�6J   $��2��6e   $	��●��6r   $��36(�6{   $y�Hidden=�6�    
 pglog.errpass#	 � 
 6�   $��23��6�   5#      5$      