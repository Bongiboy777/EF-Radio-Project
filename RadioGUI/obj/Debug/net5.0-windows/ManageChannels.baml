   M S B A M L   `   `   `  ����C  ?RadioGUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:RadioGUIRadioGUI  5          RadioGUI.ManageChannels   5      \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      "localclr-namespace:RadioGUI  5        N� Title$  ManageChannels��5
      .��5      �  � ColumnDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      $��10 �6   �� 5      �� 5      �� 5      $��10 �6   �� 5      �� 5       � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5       �� 5!      �� 5"      .+�5%   
   �� -   5         ��Name$ NameChannel��5%      $��NameChannel��6'   $��2��6:   $��3��6J   $��Center=�6W   6t   ]� 5&   
   $��2��6   $��6��6%   $��2��62   $��2��6F   .+�5'      �� -   5         ��Name$ PlaylistInfoName��5'      $	��Top=�62   �� 5(      -   5        $ playlistInfo��5(      $��Bottom=�6.   5*      ]� 5,   
   $��5��6   $��2��6%   $��3��69   .+�5-      �� -   5        $ Songinforname��5-      $	��Top=�6/   $��Center=�6D   �� 5.      -   5        $ Songinfo��5.      $��Bottom=�6*   50      �� 52   
   -   5         ��Name$ 
NewChannel��52      $��2��6%   $��4��65   $��
AddChannel��6B   
�������6�   �� 53   
   -   5        $ RemoveChannel��53      $��2��6(   $��5��68   $��DeleteChannel��6E   
�������6�   �� 54   
   -   5        $ BackToSettings��54      $��Return��6)   
�������6S   #  MaterialDesignThemes.Wpf.Card  57   
   $��8��6   $��2��6.   $��2��6;   $��6��6O   .��58      ]� .+�59      �� $��All Music Files��6   $��Center=�63   $��20(�6P   $
��Bold"�6^   $	��Top=�6p   �� 5:      -	   5         ��Name$ 
MusicFiles��5:      $��Bottom=�6R   5<      5>        5@   
   $��2��6   $��2��6+   $��6��6?   .��5A      ]� .+�5B      �� $��	Playlists��6   $��Center=�6-   $��20(�6J   $
��Bold"�6X   $	��Top=�6j   �� 5C      -
   5        $ Channels��5C      $��Bottom=�6,   5E      5G        5I   
   $��5��6   $��3��6.   $��2��6;   $��5��6O   .��5J      ]� .+�5K      �� $��	Tracklist��6   $��Center=�6-   $��20(�6J   $
��Bold"�6X   $	��Top=�6j   �� 5L      -   5        $ ChannelPlaylist��5L      $��Bottom=�63   5N      5P      � 5S   
   $��2��6   $��3��6   $��3��63   $��Center=�6D    5T      �� 5U      �� 5V      �� 5W       5Z      �� 5[      �� 5\      �� 5]      .+�5a      �� -   5        $ volumedisplay��5a      $��Bottom=�6.   $��0��6�   $��3��6�   $��0��6�   ��6F   ��  �� ElementName$ volumeslider�� �� Path$ Value�	 �� UpdateSourceTrigger$	 PropertyChanged=�6�   �� 5b      -   5        
 ��Name$
 volumeslider��5b      $��Bottom=�6,   $��3��6D   $��0��6X   $	��289��6f    � Maximum$	 100Q�6r    �� TickFrequency$ 1Q�6�    �� IsSnapToTickEnabled$
 True��6�   $��24��6�   $��0��6�   �� 5d      -   5        $ PreviousTrackButton��5d      $��1��62   $��0��6?   $��15(�6O   .��5e      �� $%��/images/previous-track_icon.png��6   5f      �� 5h      -   5        $ PauseButton��5h      $��1��6*   $��1��67   $��15(�6G   .��5i      �� $��/images/playpauseicon.png��6   $��35��6;   $��35��6G   $��Center=�6R   5j      �� 5l      -   5        $ NextTrackButton��5l      $��2��6.   $��1��6>   $��15(�6K   .��5m      �� $1��+/images/next-track_icon-icons.com_71610.png��6   5n      5p      5t      5u      