   M S B A M L   `   `   `  ����J  FNextLogInWindow, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:NextLogInWindowNextLogInWindow  5   	        NextLogInWindow.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:NextLogInWindow     5   	   V RMaterialDesignThemes.Wpf, Version=2.4.0.1044, Culture=neutral, PublicKeyToken=null@material1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  
MainWindow��5	   	   $	��450��6   $	��800��6)    � WindowStartupLocation$ CenterScreen=�65   .��5
      �  � RowDefinitions 5      �� 5      $
��0.3* �6   �� 5      $	��100��6   �� 5      $
��0.1* �6   �� 5      $	��100��6   .+�5      � $��0��6	    � ColumnDefinitions 5      �� 5      $
��0.5* �6   �� 5      �� 5      $
��0.1* �6   .+�5      �� -   5        $��0��5      $��10q�6   6)   '  !MaterialDesignThemes.Wpf.PopupBox  5      $��2��6      PlacementMode$ BottomAndAlignRightEdges=�6'      	StaysOpen .     PopupContent. 5      �� .+�5      �� $��Name Surname��6   �� 5      �� 5      $��Settings��6   �� 5       $��Profile��6   �� 5!      $��Log Out��6   5"      5#      5%      � 5'      $��1��6	    5(      �� 5)      �� 5*      $
��0.1* �6   .+�5-      �� -   5        $��lbWatchedFilms��5-      $��2��6#      lbItemsPanelWrap#��[  6[     lbItemTemplateGrid#��[ 6�   ��67   �� *WatchedFilm+��5/      �� 50       �� 
TargetType" ��6   .�51      ��  �� Property �@�ContextMenu	 �� Value	 52   	   �� 53   
   .@�55      m� $��Delete��6   ��56      �� 57      " m�6   58      5:      5<      5>   	   5?      5B      � 5D      $��1��6
    5E      �� 5F      �� 5G      �� 5H      .+�5K      '  !MaterialDesignThemes.Wpf.PackIcon  -   5        $��piIcon��5K   %   $��0��6   �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.4.0.1044, Culture=neutral, PublicKeyToken=null]]
   Kind$
 ViewGrid=�63   $
��Auto��6C   $
��Auto��6P   $��Center=�6^    � Cursor$
 Hand��6{   6�   �� 5M      -   5        $��tbMoreWatched��5M      $��2��6%   $��0 0 0 5q�62   $��Bottom=�6C   $��more...��6^   
����  �$
 Hand��6�   $��Center=�6�   6�   5O      5Q      �� 5S      $��2��6   $��0q�6   $��Stretch=�63   $��8��6Q   � 5U      $��3��6	    5V      �� 5W      �� 5X      $
��0.1* �6   .+�5[      �� $��2��6   �� 5]      -   5        $��
tbMoreLook��5]      $��1��6!   $��0 0 0 5q�61   $��Bottom=�6B   $��more...��6]   
����  �$
 Hand��6   $��Center=�6�   6�   5_      5a      5b      