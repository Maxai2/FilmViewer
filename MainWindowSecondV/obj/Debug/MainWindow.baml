   M S B A M L   `   `   `  ����L  HMainWindowSecondV, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:MainWindowSecondVMainWindowSecondV  5   	   "    MainWindowSecondV.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:MainWindowSecondV     5   	   V RMaterialDesignThemes.Wpf, Version=2.4.0.1044, Culture=neutral, PublicKeyToken=null@material1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   $	��600��5	   	   $
��1080��6     � WindowStyle$
  None=�6#    � 
ResizeMode$ NoResize=�66    � 	Resources 5         MenuOpen �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value  	MenuClose��%�  &	        &	 �     �� 5      .��5      U� $ (FrameworkElement.Width)�6#   $ GridMenu��6X   .\�5        $ 0��6   $ 60Q�6'     5      $ 0:0:0.5��6   $	 200Q�6-   5      5      �� 5      .��5      U� $ (FrameworkElement.Width)�6#   $ GridMenu��6X   .\�5        $ 0��6   $	 200Q�6'     5      $ 0:0:0.5��6   $ 60Q�6-   5      5      5       � Triggers 5      :� 5       :� RoutedEvent$ ButtonBase.Click��6   	 :� 
SourceName$	 bOpen��60   .[�5      �� #��[  6   5      :� 5      $ ButtonBase.Click��6   $	 bClose��60   .[�5      �� #��[ 6   5       .��5#      � 
�������.+�5%      � $��70��6	   $	��Top=�6   ���	#FF1859C9.+�5&      �� $��Film Viewer��6   $��Center=�6!   
������ 
�������$��40(�6h   $��Center=�6v   '  !MaterialDesignThemes.Wpf.PopupBox  5'      $��Right=�6   
�������$��10q�6F   
   PlacementMode$
 BottomAndAlignLeftEdges=�6R      	StaysOpen .     PopupContent. 5(      �� $	��150��6   .+�5)      �� $��Log Out��6   �� 5*      $
��Exit��6   5+      5,      5-      � 5/      -   5         �Name$ GridMenu��5/   	   $��60��6   $
��Left=�6&   ���	#FF1B3861.+�50      �� .+�51      � 
�������$	��150��6   .+�53      �� -   5         ��Name$ bClose��53      $	��Top=�6   $��Right=�6K   $��60��6g   $��60��6s   
������ 
������ $y�	Collapsed=�6�   .��54      '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.4.0.1044, Culture=neutral, PublicKeyToken=null]]   Kind$ 	ArrowLeft=�6   ���	#FF1B3861$��25��6B   $��25��6M   55      �� 57      -   5        $ bOpen��57      $	��Top=�6   $��Right=�6I   $��60��6e   $��60��6q   
������ 
������ .��58        $
 Menu=�6   ���	#FF1B3861$��25��6=   $��25��6H   59      5;      �� 5=      $��Disabled=�6   .@�5?      �� $��60��6   .��5@      ��  �� Orientation$ 
Horizontal=�6   .+�5A   	     $ ViewDashboard=�6   $��25��60   $��25��6;   ���	#FF1859C9$��Center=�6^   �� 5B   	   $
��Home��6   
������ $��Center=�68   $��20 10q�6S   $��Center=�6b   ���	#FF1859C96   5C   	   5D      �� 5F      $��60��6   .��5G      �� $ 
Horizontal=�6   .+�5H   	     $ 	Timelapse=�6   $��25��6,   $��25��67   ���	#FF1859C9$��Center=�6Z   �� 5I   	   $��Whatch Later��6   
������ $��Center=�6@   $��20 10q�6[   $��Center=�6j   ���	#FF1859C96�   5J   	   5K      �� 5M      $��60��6   .��5N      �� $ 
Horizontal=�6   .+�5O   	     $	 Eye=�6   $��25��6&   $��25��61   ���	#FF1859C9$��Center=�6T   �� 5P   	   $��Whatched Film��6   
������ $��Center=�6B   $��20 10q�6]   $��Center=�6l   ���	#FF1859C96�   5Q   	   5R      �� 5T      $��60��6   .��5U      �� $ 
Horizontal=�6   .+�5V   	     $ Settings=�6   $��25��6+   $��25��66   ���	#FF1859C9$��Center=�6Y   �� 5W   	   $��Settings/Profile��6   
������ $��Center=�6D   $��20 10q�6_   $��Center=�6n   ���	#FF1859C96�   5X   	   5Y      5[      5]      5^      5_      5`      