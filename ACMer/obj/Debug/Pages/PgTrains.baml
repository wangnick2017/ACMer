   M S B A M L   `   `   `  ����@  <ACMer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:ACMer.PagesACMer.Pages  5          ACMer.Pages.PgTrains   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:ACMer.Pages     5      $	��558��5      $	��872��6   .��5
      �   � ColumnDefinitions  5   
   �� 5      $��1* �6   �� 5      $��1* �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      .+�5   
   �� -   5           ButtonBackStyle#��[  5      $
��Left=�6:   $��20q�6U   6a   �� 5   
   $��40q�6   $��1��6   ���	#FF7B82C9$��5q�6B    �� CornerRadius$ 5��6V    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         Color$ 	#FFC4C7E8��6#      
BlurRadius$ 5Q�65      ShadowDepth$ 10Q�6D   ._�5      � ���	#FF8188CE 5      �� 5      $��2* �6$   �� 5      $
��Auto �6$   �� 5      $
��Auto �6$   �� 5      $��1* �6$   .+�5      �� $��Center=�6   $	��260��68    �� Orientation$ 
Horizontal=�6D   $��2��6]   .+�5       ��   pgtrains.txtid#���  6    $��Center=�6H   $��Center=�6c   $��20(�6�   
�������6�   �� 5!      -   5         ��Name$ txtID��5!        PageTextBoxStyle#��[ 6-   	 �� TextWrapping$
	 Wrap=�6W   $��Center=�6k   $��Center=�6�   
 �� 	MaxLength$
 10��6�   $��20(�6�   $��37��6�   $	��180��6�   ���	#FF8188CE6�   5"      �� 5#      -   5         ��Name$ btnQuery��5#        PageButtonSimpleBig#��[ 6+     pgtrains.btnquery#���  6X   $��Center=�6�   $��Center=�6�   $��44(�6�   $��3��6�   
������� 5$        5%      $ 	#FFAEAEAE��6+   5'      �� 5(      $%��/ACMer;component/Images/big.png��6   $	��150��6A    5)      -  'System.Windows.Media.Effects.BlurEffect  5*         Radius$ 2Q�6%   5,      5-      5.      �� 5/   
   $��40q�6   $��1��6   $��1��6*   ���	#FF7B82C9$��5q�6R   $ 5��6f    50        51      $ 	#FFC4C7E8��6#   $ 5Q�65   $ 10Q�6D   ._�53      � ���	#FF8188CE 54      �� 55      $	��12* �6$   �� 56      $	��27* �6$   .+�58      �� -   5        $ btnNew��58      #��[ 6)     pgtrains.btnnew#���  6V   $��Center=�6�   $��Center=�6�   $��44(�6�   
������� 59        5:      $ 	#FFAEAEAE��6+   $ 10Q�6=   5<      �� 5=      $��1��6   $$��/ACMer;component/Images/cc.png��6%   $	��170��6M    5>        5?      $ 1Q�6%   5A      5C      5D      �� 5E   
     pgtrains.labmanage#���  6   $��2��6?   $��36(�6S   $��Light"�6a   $��Center=�6t   $��Center=�6�   5G      5H      