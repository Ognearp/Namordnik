   M S B A M L   `   `   `  ����D  @Namordnik, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Namordnik.ViewNamordnik.View  5   	   ;"clr-namespace:Namordnik.OtherClassNamordnik.OtherClass  5   	       Namordnik.View.AddProduct   5   
   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:Namordnik.View     5   	   1xc"clr-namespace:Namordnik.OtherClass     5   	   $	��450��5   
   $	��850��6   $	��850��6)     � Title$+  %Добавление продукта��5
   	   $	��450��6%   $	��800��62   '   !Namordnik.OtherClass.DialogCloser   DialogResult 5   	   �� *DialogResult+ � 	Resources 5       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $! /Resurses/ButttonStyle.xaml?�6%   6L   %    5      .��5      � .+�5   
   �� $
��Left=�6,   $��23��6G   $��
59,102,0,0q�6S    �� TextWrapping$
 Wrap=�6g   $	��Top=�6|   $	��169��6�   ��6   �� *
Nameprod+6�   �� 5   
   $'��!Название продукта��6   $
��Left=�6.   $��244,104,0,0q�6I   $
��Wrap=�6^   $	��Top=�6r    J� RenderTransformOrigin$ 0.265,-0.375&�6�   $��	Tw Cen MT)�6�   �� 5   
   $
��Left=�6+   $��23��6F   $��
59,143,0,0q�6R   $
 Wrap=�6f   $	��Top=�6{   $	��169��6�   ��6   �� *	Articul+6�   �� 5   
   $��	Tw Cen MT)�6   $��Артикуль��6,   $
��Left=�6<   $��244,145,0,0q�6W   $
��Wrap=�6l   $	��Top=�6�   $ 0.265,-0.375&�6�   �� 5   
   $
��Left=�61   $��23��6L   $��
59,183,0,0q�6X   $
 Wrap=�6l   $	��Top=�6�   $	��169��6�   ��6   �� *Costforagent+6�   �� 5   
   $��	Tw Cen MT)�6   $9��3Минимальная цена для агента��6,   $
��Left=�6O   $��243,185,0,0q�6j   $
��Wrap=�6   $	��Top=�6�   $ 0.265,-0.375&�6�   �� 5   
   $
��Left=�6.   $��23��6I   $��
59,220,0,0q�6U   $
 Wrap=�6i   $	��Top=�6~   $	��169��6�   ��6   �� *
Tipproduct+6�   �� 5   
   $��	Tw Cen MT)�6   $��Тип продукта��6-   $
��Left=�6A   $��244,222,0,0q�6\   $
��Wrap=�6q   $	��Top=�6�   $ 0.265,-0.375&�6�   �� 5   
   $
��Left=�60   $��23��6K   $��
59,256,0,0q�6W   $
 Wrap=�6k   $	��Top=�6�   $	��169��6�   ��6   �� *Matforproizv+6�   �� 5   
   $��	Tw Cen MT)�6   $M��GКоличесиво материала для производства��6,   $
��Left=�6Y   $��242,259,0,0q�6t   $
��Wrap=�6�   $	��Top=�6�   $ 0.265,-0.375&�6�   �� 5   
   $
��Left=�60   $��23��6K   $��
59,292,0,0q�6W   $
 Wrap=�6k   $	��Top=�6�   $	��169��6�   ��6   �� *Numberproizv+6�   �� 5   
   $��	Tw Cen MT)�6   $<��6Номер производственного цеха��6,   $
��Left=�6P   $��241,295,0,0q�6k   $
��Wrap=�6�   $	��Top=�6�   $ 0.265,-0.375&�6�   �� 5   
   $&�� /Resurses/Намордник.png��6   $
��Left=�61   $��87��6L   $��	17,10,0,0q�6X   $	��Top=�6k   $��80��6�   �� 5    
   $��14(�6   $
��Left=�6#   $��
113,41,0,0q�6>   $
��Wrap=�6R   $#��ООО ''Намордник''��6f   $	��Top=�6   $��	Tw Cen MT)�6�   �� 5!   
   $��14(�6   $
��Left=�6#   $��
629,10,0,0q�6>   $-��'Добавление продукции��6S   $	��Top=�6o   $��	Tw Cen MT)�6�   $ 0.105,0.984&�6�   �� 5"   
      TransparentStyle#��[  6   $%��Добать продукцию��6Z   $
��Left=�6u   $��
75,332,0,0q�6�   $	��Top=�6�   $	��140��6�   ��6;   �� *
AddCommand+6�   �� 5#   
   $
��Left=�6H   $	��133��6c   $��576,110,0,0q�6p   $	��Top=�6�   $	��143��6�   ��6   �� *Image+  Con �� 	Converter# [ 6�   �� 5$   
   #��[  62   $)��#Загрузить картинку��6\   $
��Left=�6y   $��582,278,0,0q�6�   $	��Top=�6�   $	��143��6�   ��6   �� *LoadKartinka+6�   5&      5'      