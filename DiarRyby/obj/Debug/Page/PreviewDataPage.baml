   M S B A M L   `   `   `  ����C  ?DiarRyby, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:DiarRybyDiarRyby  5          DiarRyby.PreviewDataPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      (localclr-namespace:DiarRyby     5        N� 
Background
  ����  N� Title$ 
NahledPage��5
      .��5      �  � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      .+�5   
   �� -   5         ��Name$ loadDataButon��5      $��Načti data��6(   $��Center=�6=   $��Center=�6Z   6u   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ TripDataGrid��5      $��1��6)   $��0��66      
IsReadOnly .    AutoGenerateColumns .  ��6X   ��    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Datum��6%   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 64   �� *
TripDate+
 �� StringFormat$
 
dd.MM.yyyy��  5      $ Revír��6%   	 64   �� *
AreaName+  5      $ Číslo revíru��6%   	 6;   �� *
AreaNumber+  5      $ Krmení��6%   	 65   �� *Bait+  5      $ 	Nástraha��6%   	 67   �� *Lure+  5      $
 Ryby��6%   	 63   �� *FishSpecies+  5      $ Počet��6%   	 64   �� *	FishCount+  5      $ Průměrná délka��6%   	 6=   �� *
FishLength+  5      $ Ponecháno ryb��6%   	 6<   �� *
FishKept+5       5#      5$      