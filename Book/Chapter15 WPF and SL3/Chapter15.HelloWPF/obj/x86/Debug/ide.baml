   M S B A M L   `   `   `  ����M  IChapter15.HelloWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Chapter15.HelloWPFChapter15.HelloWPF  5          Chapter15.HelloWPF.ide   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /my clr-namespace:Chapter15.HelloWPF     5        N� Title$	  ide��6    � 	Resources 5	      )   #Chapter15.HelloWPF.Chapter15Dataset   Chapter15Dataset  filmViewSource �� Source �� Path �� Source��%W   &	        &	      7     5
   
   6   �� 5   
    66   �� $
 Film�8   5      .��5      � -   5        $��grid1��5   T    � DataContext# [ 6   $
��Left=�69   $	��Top=�6a    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� $��Film ID:��6   $��0��6#   $��0��63   $
��Left=�6@   $��3q�6[   $��Center=�6f   �� 5   
   -   5        $��filmIDTextBox��5   a   $��1��6   $��0��6"   $��23��6/   $
��Left=�6;   $��3q�6V   $��Center=�6�   $	��120��6�   ��6v   �� $ FilmID� �� Mode$ OneWay=�6�   �� 5   
   $��Title:��6   $��0��6!   $��1��61   $
��Left=�6>   $��3q�6Y   $��Center=�6d   �� 5   
   -   5        $��titleTextBox��5   a   $��1��6   $��1��6"   $��23��6/   $
��Left=�6;   $��3q�6V   $��Center=�6�   $	��120��6�   ��6u   �� $ Title�6�   �� 5   
   $��Description:��6   $��0��6'   $��2��67   $
��Left=�6D   $��3q�6_   $��Center=�6j   �� 5   
   -   5        $��descriptionTextBox��5   a   $��1��6   $��2��6"   $��23��6/   $
��Left=�6;   $��3q�6V   $��Center=�6�   $	��120��6�   ��6{   �� $ Description�6�   �� 5   
   $��Length:��6   $��0��6"   $��3��62   $
��Left=�6?   $��3q�6Z   $��Center=�6e   �� 5   
   -   5        $��lengthTextBox��5   a   $��1��6   $��3��6"   $��23��6/   $
��Left=�6;   $��3q�6V   $��Center=�6�   $	��120��6�   ��6v   �� $ Length�6�   5       5!      