   M S B A M L   `   `   `  ����I  EMaterialDesign, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:MaterialDesignMaterialDesign  5   	   E ADragablz, Version=0.0.3.203, Culture=neutral, PublicKeyToken=null5(clr-namespace:Dragablz;assembly=DragablzDragablz 5	   	       MaterialDesign.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:MaterialDesign     5   	   V RMaterialDesignThemes.Wpf, Version=2.4.0.1044, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   7dragablz(clr-namespace:Dragablz;assembly=Dragablz  5	   	   -   5        $��Regular"�5
   	   $��13(�5   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	    � Title$ 
MainWindow��5   	   $	��300��6   $	��250��6)    � WindowStyle$
 None=�65    � AllowsTransparency . 
������  � WindowStartupLocation$ CenterScreen=�6�   .��5      � -   5        $	��Grd��5       � ColumnDefinitions 5      �� 5      �� 5      $
��0.1* �6    � 	Resources 5       �� 
TargetType	 �� Property
 �� Value��%�   ' �       �� 5      "  �6   .�5      �� 	 �@ �NavigationUIVisibility$
 Hidden=�6/   �� 5      	 � ��

 �����6#   5      5      .+�5       � -   5        $
��Main��5      $��0��6
   6    � 5      -   5        $��AddReg��5      $��0��6
   $��	500 0 0 0q�6(   � 5!      $��1��6	   
������  � RowDefinitions 5"      �� 5#      $
��0.5* �6   �� 5$      �� 5%      .+�5(      �� -   5        $��0��5(      ���#EDA639$��0,28,0,0q�6.   $��20��6@   $	��Top=�6a   $��1q�6y    � Triggers 5)      :� 5*       :� RoutedEvent$ Button.Click��6   .[�5+      �� .��5,   	   ��  �� 
TargetName$ AddReg��6    �� TargetProperty$ Margin�63   .��5-   
   t�  g� Duration$ 0:0:0.3D�6E   	 t� To 6   �� *To+ t� From 6/   �� *From+6E   5.   
   5/   	   50      .��53      �� $��add.png��6   54      56      57      59      