   M S B A M L   `   `   `  ����C  ?DiarRyby, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:DiarRybyDiarRyby  5      O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5          DiarRyby.DochazkaPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      (localclr-namespace:DiarRyby     5      6sys&clr-namespace:System;assembly=mscorlib     5        N� Title$  DochazkaPage��5
      .��5      �  � ColumnDefinitions 5   
   �� 5      $��20 �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��50 �6    � RowDefinitions 5   
   �� 5      $��30 �6   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��20 �6   �� 5      $��50 �6   �� 5      $��20 �6   �� 5      $��* �6   �� 5      $��50 �6   .+�5   
   �� $��Zápis o lovu��6   $��Center=�6(   $��Center=�6C   $��1��6`   $��0��6p   $��2��6}   �� 5!   
   $��1��6   $��1��6%   $
��Left=�62   $��Center=�6M    �� Orientation$ 
Horizontal=�6h   .+�5"      �� -   5        $��
datumLabel��5"      $��Datum��6&   $��80��66   (  "System.Windows.Controls.DatePicker  5#      -   5        $��datumLovuDataPicker��5#      
 �� Now   SelectedDate# Z 64   5$      �� 5'   
   $��1��6   $��2��6%   $
��Left=�62   $��Center=�6M   $ 
Horizontal=�6h   .+�5(      �� -   5        $��
revirLabel��5(      $��Revír��6&   $��70��6c    �� Target 66   ��  �� ElementName$ revirComboBox��6c   �� 5)      -   5        $��revirComboBox��5)      $	��250��6,    �� 
IsEditable . 	 �� Text$	  ��6b   $��10,0,0,0q�6j   ��6J   �� 5*      5,      �� 5.   
   $��2��6   $��2��6%   $
��Left=�62   $��Center=�6M   $ 
Horizontal=�6h   .+�5/      �� -   5        $��cisloReviruLabel��5/      $��Číslo revíru��6,   $��70��6u    6C   �� $ cisloReviruTextBox��6u   �� 50      -   5        $��cisloReviruTextBox��50      $	��100��62   $��10,0,0,0q�6>   51      �� 53   
   $��1��6   $��3��6&   $
��Left=�63   $��Center=�6N   $ 
Horizontal=�6i   .+�54      �� -   5        $��krmeniLabel��54      $��Krmení��6'   $��70��6e    68   �� $ krmeniTextBox��6e   �� 55      -   5        $��krmeniComboBox��55      $	  ��6-   $	��250��65    . $��10,0,0,0q�6l   ��6S   �� 6l   56      �� 58   
   $��2��6   $��3��6&   $
��Left=�63   $��Center=�6N   $ 
Horizontal=�6i   .+�59      �� -	   5        $��nastrahaLabel��59      $��	Nástraha��6)   $��70��6k    6<   �� $ nastrahaTextBox��6k   �� 5:      -
   5        $��nastrahaComboBox��5:      $	  ��6/   $	��200��67    . $��10,0,0,0q�6o   ��6V   �� 6o   5;      �� 5=   
   $��Zápis ulovených ryb��6   $��Center=�6/   $��Center=�6J   $��1��6g   $��4��6w   $��2��6�   �� 5?   
   $��1��6   $��2��6%   $��5��69   $
��Left=�6F   $��Center=�6a   $ 
Horizontal=�6|   .+�5@      �� -   5        $��	druhLabel��5@      $��
Druh ryby:��6%   $��70��6i    6:   �� $ druhRybComboBox��6i   �� 5A      -   5        $��druhRybComboBox��5A      $	��100��6.    . $	  ��6d   ��6L   �� 5B      �� 5C      -   5        $��pocetKusuLabel��5C      $��Počet ulovených ryb: ��6*    6J   �� $ pocetKusuTextBox���� 5D      -   5        $��pocetKusuTextBox��5D      $�� ��6.   $��50��66   $��	10,0,10,0q�6B   �� 5E      -   5        $��delkaRybLabel��5E      $��Délka ryby:��6)    6?   �� $ delkaRybTextBox���� 5F      -   5        $��delkaRybTextBox��5F      $�� ��6-   $��50��65   $��	10,0,10,0q�6A   �� 5G      -   5        $��ponechanaRybaLabel��5G      $��Ponecháno?��6.    6C   �� $ ponechanaLabel���� 5H      -   5        $��ponechanaRybaCombobox��5H      $��50��64    . .@�5I      �� 
 �� 
IsSelected
 . $��0��61   �� 5J      $��1��6   5K      �� 5L      -   5        $��pridejRybuButton��5L      $��Přidej úlovek��6-   $��80��6E   $��20,0,0,0q�6P   6b   5M      �� 5O   
   $��Přidané úlovky��6   $��Center=�6*   $��Center=�6E   $��1��6b   $��6��6r   $��2��6   �� 5Q   
   -   5        $��prehledZapisDataGrid��5Q      $��1��6.   $��1��6>   $��7��6R   ��6_   �� *Lovi+�� 5R   
   -   5        $��pokusDataGrid��5R      $��2��6'   $��7��67   ��6D   �� �� 5T   
   -   5        $��ulozZapisLov��5T      $"��Ulož zápis lovu do deníku��6%   $��Center=�6I   $��Center=�6f   $��2��6�   $��8��6�   6�   5V      5W      