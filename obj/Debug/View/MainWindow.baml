   M S B A M L   `   `   `  ����D  @Namordnik, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Namordnik.ViewNamordnik.View  5   	       Namordnik.View.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   	   (localclr-namespace:Namordnik.View  5   	   $	��850��5   	   $	��750��6   $	��950��6'   $	��850��67     � Icon$&   /Resurses/Намордник.png��5	   	    � Title$ 	Namordnik��5
   	   $	��475��6   $	��800��6(    � 	Resources 5       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $% /Resurses/ElementsListView.xaml?�6%   6P   �� 5      $" /Resurses/ComboBoxStyle.xaml?�6%   6M   �� 5      $! /Resurses/ButttonStyle.xaml?�6%   6L   %    5      .��5      � .+�5   
   �� $��Disabled=�6      ListProduct#��[  6�     ku#��[ 6�   $��	0,99,0,43q�6�    �� SelectedItem 6I   �� *SelectedProduct+��6r   �� *FilterProduct+��5      �� 5       �� 
TargetType" ��6   .�5      ��  �� Property � �� �� Value$
 Left=�6C   6R   5      .  (System.Windows.Interactivity.Interaction	   Triggers	 5      /  )System.Windows.Interactivity.EventTrigger  5      
   	EventName$
 MouseDoubleClick��6!   .  (System.Windows.Interactivity.TriggerBase   Actions. 5      6  0System.Windows.Interactivity.InvokeCommandAction     Command 5      �� *EditCommand+   CommandParameter 5       �� *SelectedProduct+5!      5#      �� 5$   
   $
��Left=�6O   $��23��6j   $��	10,71,0,0q�6v    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��135��6�   ��6   �� *Search+ �� UpdateSourceTrigger$ PropertyChanged=�.��6�   ��5%      O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5&   -   �� 6   0sys&clr-namespace:System;assembly=mscorlib  6-   " ��6    �� 	Resources 5'        Brushes j� 
AlignmentX j� 
AlignmentY j� Stretch !� Visual��%�   &	       !� 5(      $
 Left=�66   $ Center=�6H   $
 None=�6\    5)      �� 5*   "   $��Search��6(   ���#B0E5FD6P   5,      5-       �� Triggers 5.      P� 5/       P� Property � �� �� Empty P� Value# Z 62   . �50      ��  � ��# [ 6;   51      P� 52       � �� 62   Z� . �53      ��  � ��# [ 6;   54      P� 55       �@J�IsKeyboardFocused . . �56      ��  � �� �#FDBD406;   57      59      .��5;      5=      �� 5>   
   $&�� /Resurses/Намордник.png��6   $
��Left=�61   $��52��6L   $��	10,10,0,0q�6X   $	��Top=�6k   $��52��6�   �� 5?   
   $��14(�6   $
��Left=�6#   $��	67,24,0,0q�6>   $
��Wrap=�6Q   $#��ООО ''Намордник''��6e   $	��Top=�6~   $��	Tw Cen MT)�6�   5A      �� 5B   
    �� SelectedIndex$ 0��6     ComboBoxTest#��[ 6&   $
��Left=�6L   $��
231,71,0,0q�6g   $	��Top=�6{   $	��120��6�   .@�5C      �� .��5D      �� $��Все типы��6   6.   5E      �� 5F      .��5G      �� $��Держатели��6   6/   5H      �� 5I      .��5J      �� $!��Запасные части��6   64   5K      �� 5L      .��5M      �� $��Сменные части��6   63   5N      �� 5P      .��5Q      �� $��Полумаски��6   6/   5R      �� 5T      .��5U      �� $��
Маски��6   6+   5V      �� 5X      .��5Y      �� $��Повязки��6   6-   5Z      �� 5\      .��5]      �� $��Респираторы��6   61   5^      �� 5`      .��5a      �� $��Предфильтры��6   61   5b      �� 5c      .��5d      �� $��Полнолецевые��6   62   5e      5f      �� 5g   
   $ 0��6   #��[ 6�   $
��Left=�6�   $��
408,71,0,0q�6�   $	��Top=�6�   $	��120��6  ��6%   �� *SortingParams+ 6K   �� *SelectedOrderBy+$ PropertyChanged=�5i      �� 5j   
     TransparentStyle#��[ 62   $��>>��6^   $
��Left=�6k   $��
466,0,0,11q�6�   $��75��6�    J� RenderTransformOrigin$ 0.5,0.5&�6�   $��28��6�   $��Bottom=�6�   ��6   �� *PreviousPage+z�5k      V� 5l      .~�5m      �� �� 5n      �� 5o       �� Angle$ -180.087Q�6&   T� 5p      5q      5t      �� 5u   
   #��[ 6.   $��>>��6Z   $
��Left=�6g   $��
624,0,0,11q�6�   $��75��6�   $��28��6�   $��Bottom=�6�   ��6   �� *
NextPage+6�   �� 5v   
   $
��Left=�61   $��591,783,0,0q�6L   $
��Wrap=�6a   $	��Top=�6u   ��6   �� *PageDisplay+6u   �� 5w   
   #��[ 60   $#��Добавить данные��6Z   $
��Left=�6t   $��	97,0,0,11q�6�   $	��138��6�   $��27��6�   $��Bottom=�6�   ��6   �� *
AddCommand+6�   �� 5x   
   #��[ 63   $!��Удалить данные��6]   $
��Left=�6v   $��
246,0,0,11q�6�   $	��138��6�   $��27��6�   $��Bottom=�6�   ��6   �� *RemoveProduct+6�   �� 5y   
   $2��,Сортировать по убыванию��65   $
��Left=�6W   $��
533,71,0,0q�6r   $	��Top=�6�    d� 	IsChecked 6   �� *OrderByDesc+6�   5{      5|      