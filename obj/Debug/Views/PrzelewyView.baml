   M S B A M L   `   `   `  ����?  ;Bank, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Bank.ViewModelsBank.ViewModels  5          Bank.Views.PrzelewyView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      >d2http://schemas.microsoft.com/expression/blend/2008    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      4
viewmodelsclr-namespace:Bank.ViewModels     5      .��5      � $��Center=�6   $��Center=�6(   $	��240��6C   $	��500��6P     � ColumnDefinitions  5   
   �� 5      $��15 �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $��15 �6    � RowDefinitions 5   
   �� 5      $��15 �6   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��* �6   �� 5      $��15 �6   .+�5   
   �� $��17(�6   $��Wybierz konto: ��6"   $��1��69   $��1��6I   $
��Left=�6V   $��Center=�6q   �� 5   
   $��10 0 0 0q�6   $��2��6%   $��1��65   $��2��6B   $��30��6V   $	��250��6b   $
��Left=�6n   $��Center=�6�   ��5      �� *	KontoList+ �� SelectedValue 5      �� *SelectedKontoZ+ �� SelectedItem 5       �� *SelectedKontoZItem+��5!      �� 5"      .R�5#      ��  �� Orientation$ 
Horizontal=�6!   .+�5$      �� $��17(�6$   ��62   �� *nazwa+5%      5&      5(      �� 5*   
   $��17(�6   $��Wybierz konto docelowe: ��6"   $��1��6B   $��2��6R   $
��Left=�6_   $��Center=�6z   �� 5+   
   $��10 0 0 0q�6   $��2��6%   $��2��65   $��2��6B   $��30��6V   $	��250��6b   $
��Left=�6n   $��Center=�6�   ��5,      �� *	KontoList+ 5-      �� *SelectedKontoDo+ 5.      �� *SelectedKontoDoItem+��5/      �� 50      .R�51      �� $ 
Horizontal=�6!   .+�52      �� $��17(�6$   ��62   �� *nazwa+53      54      56      �� 58   
   $��17(�6   $��Podaj kwotę przelewu: ��6"   $��1��6@   $��3��6P   $
��Left=�6]   $��Center=�6x   �� 59   
   $��10 0 0 0q�6[   $��17(�6m   $��2��6{   $��3��6�   $
��Left=�6�   $��Center=�6�   $��30��6�   $	��250��6�   ��6   �� *Kwota+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5;   
   $��1��6   $��4��6%   $��2��62   $ 
Horizontal=�6F   $��Center=�6`   .+�5<      �� $��30��68   $	��110��6D   $��Przelej��6P   $��Center=�6b   $��17(�6   $��10 0 0 0q�6�   ��6   �� *WykonajPrzelew+6�   �� 5=      $
��Home��64   $��30��6L   $	��110��6X   $��Anuluj��6d   $
��Left=�6u   $��17(�6�   $��20 0 0 0q�6�   ��6   �� *
UpdateView+6�   5>      5A      5B      