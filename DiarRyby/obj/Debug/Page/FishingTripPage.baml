   M S B A M L   `   `   `  ����C  ?DiarRyby, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:DiarRybyDiarRyby  5      O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5          DiarRyby.FishingTripPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      (localclr-namespace:DiarRyby     5      6sys&clr-namespace:System;assembly=mscorlib     5        N� Title$  DochazkaPage��5
      .��5      �  � ColumnDefinitions 5   
   �� 5      $��20 �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��50 �6    � RowDefinitions 5   
   �� 5      $��30 �6   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��20 �6   �� 5      $��50 �6   �� 5      $��20 �6   �� 5      $��* �6   �� 5      $��50 �6   .+�5   
   �� $��Zápis o lovu��6   $��Center=�6(   $��Center=�6C   $��1��6`   $��0��6p   $��2��6}   �� 5!   
   $��1��6   $��1��6%   $
��Left=�62   $��Center=�6M    �� Orientation$ 
Horizontal=�6h   .+�5"      �� -   5        $��
datumLabel��5"      $��Datum��6&   $��80��66   (  "System.Windows.Controls.DatePicker  5#      -   5        $��tripDateDataPicker��5#      
 �� Now   SelectedDate# Z 63   5$      �� 5'   
   $��1��6   $��2��6%   $
��Left=�62   $��Center=�6M   $ 
Horizontal=�6h   .+�5(      �� -   5        $��areaNameLabel��5(      $��Revír��6)   $��70��6i    �� Target 69   ��  �� ElementName$ areaNameComboBox��6i   �� 5)      -   5        $��areaNameComboBox��5)      $	��250��6/    �� 
IsEditable . 	 �� Text$	  ��6e   $��10,0,0,0q�6m   ��6M   �� 5*      5,      �� 5.   
   $��2��6   $��2��6%   $
��Left=�62   $��Center=�6M   $ 
Horizontal=�6h   .+�5/      �� -   5        $��areaNumberLabel��5/      $��Číslo revíru��6+   $��70��6s    6B   �� $ areaNumberTextBox��6s   �� 50      -   5        $��areaNumberTextBox��50      $	��100��61   $��10,0,0,0q�6=   51      �� 53   
   $��1��6   $��3��6&   $
��Left=�63   $��Center=�6N   $ 
Horizontal=�6i   .+�54      �� -   5        $��	baitLabel��54      $��Krmení��6%   $��70��6b    66   �� $ baitComboBox��6b   �� 55      -   5        $��baitComboBox��55      $	  ��6+   $	��250��63    . $��10,0,0,0q�6j   ��6Q   �� 6j   56      �� 58   
   $��2��6   $��3��6&   $
��Left=�63   $��Center=�6N   $ 
Horizontal=�6i   .+�59      �� -	   5        $��	lureLabel��59      $��	Nástraha��6%   $��70��6d    68   �� $ lureComboBox��6d   �� 5:      -
   5        $��lureComboBox��5:      $	  ��6+   $	��200��63    . $��10,0,0,0q�6k   ��6R   �� 6k   5;      �� 5=   
   $��Zápis ulovených ryb��6   $��Center=�6/   $��Center=�6J   $��1��6g   $��4��6w   $��2��6�   �� 5?   
   $��1��6   $��2��6%   $��5��69   $
��Left=�6F   $��Center=�6a   $ 
Horizontal=�6|   .+�5@      �� -   5        $��fishSpeciesLabel��5@      $��
Druh ryby:��6,   $��70��6t    6A   �� $ fishSpeciesComboBox��6t   �� 5A      -   5        $��fishSpeciesComboBox��5A      $	��100��62    . $	  ��6h   ��6P   �� 5B      �� 5C      -   5        $��fishCountLabel��5C      $��Počet ulovených ryb: ��6*    6J   �� $ fishCountTextBox���� 5D      -   5        $��fishCountTextBox��5D      $�� ��6.   $��50��66   $��	10,0,10,0q�6B   �� 5E      -   5        $��fishLengthLabel��5E      $��Délka ryby:��6+    6A   �� $ fishLengthTextBox���� 5F      -   5        $��fishLengthTextBox��5F      $�� ��6/   $��50��67   $��	10,0,10,0q�6C   �� 5G      -   5        $��fishKepLabel��5G      $��Ponecháno?��6(    6=   �� $ fishKeptCombobox���� 5H      -   5        $��fishKeptCombobox��5H      $��50��6/    . .@�5I      �� 
 �� 
IsSelected
 . $��0��61   �� 5J      $��1��6   5K      �� 5L      -   5        $��addFishButton��5L      $��Přidej úlovek��6*   $��80��6B   $��20,0,0,0q�6M   6_   5M      �� 5O   
   $��Přidané úlovky��6   $��Center=�6*   $��Center=�6E   $��1��6b   $��6��6r   $��2��6   �� 5Q   
   -   5        $��previewDataGrid��5Q      $��1��6)   $��1��69   $��7��6M   ��6Z   �� *FishingRecords+�� 5R   
   -   5        $��testDataGrid��5R      $��2��6&   $��7��66   ��6C   �� �� 5T   
   -   5        $��saveFishingRecord��5T      $"��Ulož zápis lovu do deníku��6*   $��Center=�6N   $��Center=�6k   $��2��6�   $��8��6�   6�   5V      5W      