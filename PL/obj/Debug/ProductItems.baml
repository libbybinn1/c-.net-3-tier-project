   M S B A M L   `   `   `  ����=  9PL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:PLPL  5   	       PL.ProductItems   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   "localclr-namespace:PL     5   	     � Title$  ProductItems��5   	   $	��450��6   $	��800��6+   .��5	      � .+�5
   
   � -   5        $��UpGrid��5
      $��Stretch=�6   $
��auto��6;   $��0��6I   $��Stretch=�5      $
��auto��6+   
������� � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $��* �6#   .+�5      �� $��	Category:��6   $��0��6)   $
��Left=�69   $��
253,12,0,0q�6U   $	��Top=�5      $��24(�6(   $
��Bold"�66   $��AdamGorry-Inline)�6H   �� 5      -   5         ��Name$ CategorySelector��5   '   $��1��6   $
��Left=�6A   $��	26,23,0,0q�6\   $	��Top=�6o   $	��150��6�   $��32��5   9   ��6   ��  �� Path$ Item2�6E   �� 5      -   5        $
��Back��5      $
��Left=�6$   $��	23,18,0,0q�6?   $	��Top=�6R   $��32��6j   $��38��6v    
  button#��[  6�   5      �� 5   
   -   5         ��Name$ ProductItemListview��5        ListView#��[ 6W   $��0,69,0,0q�5      $��Normal"�6&   $��Adobe Gothic Std B)�6:   $	��311��6Z   $	��Top=�6�   
���   ���6g   �� $ Item1� �� View 5      �� 5      .P�5      �� $��ID��6N    �� Width$	 100��6Z    �� DisplayMemberBinding 6%   �� $ ID�6Z   �� 5      $
��Name��6P   $	 100��6^    6%   �� $
 Name�6^   �� 5      $��Price��6Q   $	 100��6`    6%   �� $ Price�6`   �� 5      $��category��6T   $	 100��6f    6%   �� $ Category�6f   �� 5      $��Amount��6R   $	 100��6b    6%   �� $ Amount�6b   �� 5      $��InStock��6S   $	 100��6d    6%   �� $ InStock�6d   5       5"      �� 5#   
   -   5        $��CartBtn��5#      $
��🛒��6    $
��Left=�6-   $��	72,18,0,0q�6H   $	��Top=�6[   $��32��6s   $��40��6    J� RenderTransformOrigin$ 
0.597,2.71&�5$      #��[  64   5%      5&      