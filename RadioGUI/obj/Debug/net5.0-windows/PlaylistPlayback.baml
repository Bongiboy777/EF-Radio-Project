   M S B A M L   `   `   `  ����C  ?RadioGUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:RadioGUIRadioGUI  5          RadioGUI.PlaylistPlayback   5      \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      (localclr-namespace:RadioGUI     5      b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        N� Title$  PlaylistPlayback��5
      .��5      �  � ColumnDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5       � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5       .+�5#   
   �� -   5         ��Name$ ChannelDisplay��5#      $��3��6,   $��2��6<   $��3��6I   
��� d �$��0,0,0,54q�6t   $��2��6�   d� 5$   
   -   5         d�Name$ TogglePower��5$      $��0��6-   $��1��6=    d� 	IsChecked$ FalseY�6^   $��Power��6p   �� 5&   
   -   5         ��Name$ volumeslider��5&      $��8��6'   $��Center=�67   $��5��6T   $��Bottom=�6a   $	��120��6|    � Maximum$	 100Q�6�    �� TickFrequency$ 1Q�6�   	 �� IsSnapToTickEnabled$
	 True��6�   z�5'      V� 5(      .~�5)      �� �� 5+      
 �� Angle$	
 -90Q�6&   T� 5,      5-      5/      �� 50   
   -   5         ��Name$ volumedisplay��50      $��7��6   $��6��6�   $��0,0,0,56q�6�   $��2��6�   ��6)   �� *Value+ �� ElementName$ volumeslider�� �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 51   
   -   5        $ WelcomeText��51      $��2��6)   $��4��69   �� 53   
   -   5        $ Trackposition��53      $��3��6(   $��3��68   $��3��6E   �� 55   
   -   5        $��0��55      $��Settings��6!   64   �� 57   
   -   5         ��Name$ PreviousTrackButton��57      $��6��6.   $��3��6;   $��15(�6K   .��58      �� $%��/images/previous-track_icon.png��6   59      �� 5;   
   -	   5        $ PauseButton��5;      $��6��6&   $��4��63   $��15(�6C   .��5<      �� $��/images/playpauseicon.png��6   $��35��67   $��35��6C   $��Center=�6N   5=      �� 5?   
   -
   5        $ NextTrackButton��5?      $��5��6*   $��6��6:   $��15(�6G   .��5@      �� $1��+/images/next-track_icon-icons.com_71610.png��6   5A      �� 5D   
   -   5        $ return��5D      $��8��6!   $��Return��61   �� 5F   
   $��Channels��6   $��2��6$   $��2��61   $��Center=�6E   $��20(�6b   �� 5G   
   -   5         ��Name$ Channels��5G      $��0��6$   $��3��64   $��5��6A   $��2��6R   #  MaterialDesignThemes.Wpf.Card  5I   
   $��3��6   $��3��6.   $��3��6;   $��3��6L   .��5J      �� -   5        $ 	Tracklist��5J      5K      5L      5M      