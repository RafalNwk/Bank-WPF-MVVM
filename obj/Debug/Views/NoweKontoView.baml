   M S B A M L   `   `   `  ����?  ;Bank, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Bank.ViewModelsBank.ViewModels  5          Bank.Views.NoweKontoView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      >d2http://schemas.microsoft.com/expression/blend/2008    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      4
viewmodelsclr-namespace:Bank.ViewModels     5      .��5      � $��Center=�6   $��Center=�6(   $	��240��6C   $	��500��6P     � ColumnDefinitions  5   
   �� 5      $��15 �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $��15 �6    � RowDefinitions 5   
   �� 5      $��15 �6   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��* �6   �� 5      $��15 �6   .+�5   
   �� $��17(�6   $��Podaj nazwę konta: ��6"   $��1��6=   $��1��6M   $
��Left=�6Z   $��Center=�6u   �� 5   
   $��10 0 0 0q�6[   $��17(�6m   $��2��6{   $��1��6�   $
��Left=�6�   $��Center=�6�   $��30��6�   $	��250��6�   ��6   �� *Nazwa+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5   
   $��17(�6   $��Wybierz rodzaj konta: ��6"   $��1��6@   $��2��6P   $
��Left=�6]   $��Center=�6x   �� 5   
   $��10 0 0 0q�6   $��2��6%   $��2��65   $��2��6B   $��30��6V   $	��250��6b   $
��Left=�6n   $��Center=�6�   ��5       �� *rodzajKontaList+ �� SelectedValue 5!      �� *SelectedRodzajKonta+ �� SelectedItem 5"      �� *SelectedRodzajItem+��5#      �� 5$      .R�5%      ��  �� Orientation$ 
Horizontal=�6!   .+�5&      �� $��17(�6$   ��62   �� *Nazwa+5'      5(      5*      �� 5+   
   $��1��6   $��3��6%   $��2��62   $ 
Horizontal=�6F   $��Center=�6`   .+�5,      �� $��30��64   $	��110��6@   $��Utwórz konto��6L   $��Center=�6c   $��17(�6�   $��10 0 0 0q�6�   ��6   �� *
DodajKonto+6�   �� 5-      $
��Home��64   $��30��6L   $	��110��6X   $��Anuluj��6d   $
��Left=�6u   $��17(�6�   $��20 0 0 0q�6�   ��6   �� *
UpdateView+6�   5.      51      52      