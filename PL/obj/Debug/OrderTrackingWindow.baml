   M S B A M L   `   `   `  ����=  9PL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:PLPL  5   	       PL.OrderTrackingWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   "localclr-namespace:PL     5   	     � Title$  OrderTrackingWindow��5   	   $	��450��6%   $	��800��62   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��192* �6   �� 5      $	��25* �6   .+�5   
   �� -   5         ��Name$ OredrDetailsBtn��5       
  button#��[  6*   $��Oredr Details��6J   $
��Left=�6b   $��624,361,0,0q�6}   $	��Top=�6�   $��36��6�   $	��134��6�   $��2��6�   �� 5   
   $
��Left=�66   $��
198,13,0,0q�6Q   $	��Top=�6e   ��6   ��  �� Path$ Item1.Status�6e   �� 5   
   -   5         ��Name$ OrderTrackingListview��5        ListView#��[ 6b   $��35,87,400,0q�5      $��Normal"�6)   $��Adobe Gothic Std B)�6`   $	��287��6�   $	��Top=�6�   
���   ����	#FFEDCDBD��6=   �� $ Item2� �� View 5      �� 5      .P�5      �� $
��Date��6Q    �� Width$	 200��6_    �� DisplayMemberBinding 6%   �� $ Item1�6_   �� 5      $��Status��6Q   $	 100��6a    6%   �� $ Item2�6a   5      5      �� 5   
   $��	Status---��6   $
��Left=�6$   $��
122,10,0,0q�6?   $	��Top=�6S    J� RenderTransformOrigin$ 0.468,0.128&�6k   �� 5   
   $��order tracking��6   $
��Left=�6)   $��
166,56,0,0q�6D   $	��Top=�6X   $ 0.389,0.332&�6p   �� 5   
   -   5        $��Back-��5      $
��Left=�6!   $��	35,18,0,0q�6<   $	��Top=�6O   #��[  6|   5      5      