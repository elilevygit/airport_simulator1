   M S B A M L   `   `   `  ����=  9UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:UIUI  5   	       UI.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   "localclr-namespace:UI     5   	     � Title$  
MainWindow��5   	   $	��585��6   $	��888��6)   ��5	      �� 5
   
    �� ImageSource$ pic/airport2.jpg��6    � 	Resources 5         buttonTemplate �� 
TargetType �� CornerRadius � Cursor �� Orientation  Img��%/  &	        �� 5   
   " ��61   .R�5      �� $ 5��6   $��15q�6'   $
 Hand��63   ._�5      �� $ 
Horizontal=�6   
��� ���.+�5      �� #���  6   $	��100��6G   $	��100��6T   $��5q�6`   6m   �� 5      #��z��6   
������ $��2q�6Y   6f   5      5      5      5      .��5      � $��	0,0,-8,-5q�6   .+�5   
   �� -   5         ��Name$ listplanes1��5       �� Left$	 857��6(   
	 �� Top$		 204��6:   $	��210��6K   $	��276��6X   
�������$��10,10,602,339q�6~   
 �� View
 5      �� 5      .P�5      �� $��Airplane Name��6%    �� Width$	 120��6<    �� DisplayMemberBinding 6H   �� *Plane.PlaneId+�� 5      $��StationName��6%   $	 150��6:    6F   �� *StationName+5      5!      �� 5"   
   -   5        $ 
DCAhistory��5"      $	 857��6'   $		 204��69   $	��210��6J   $	��276��6W   
�������$��291,10,321,339q�6}   
 5#      �� 5$      .P�5%      �� $��Airplane Id��6%   $	 120��6:    6F   �� *plane.PlaneId+�� 5&      $��StationName��6%   $	 150��6:    6F   �� *station.StationName+�� 5'      $��StationName��6%   $	 150��6:    6F   �� *DCAhistoryId+�� 5(      $��StationName��6%   $	 150��6:    6F   �� *
Departures+�� 5)      $��StationName��6%   $	 150��6:    6F   �� *
Landings+5*      5,      5�      5�      