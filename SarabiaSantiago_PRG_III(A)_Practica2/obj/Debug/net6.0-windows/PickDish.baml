   M S B A M L   `   `   `  ����_  [SarabiaSantiago_PRG_III(A)_Practica2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null[2clr-namespace:SarabiaSantiago_PRG_III_A__Practica2$SarabiaSantiago_PRG_III_A__Practica2  5   	   3    -SarabiaSantiago_PRG_III_A__Practica2.PickDish   5   	   W SPresentationCore, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Dlocal2clr-namespace:SarabiaSantiago_PRG_III_A__Practica2     5   	     � Title$  PickDish��5   	   $	��850��6   $
��1000��6'   .��5	      � ���	#FFD9DEE2.+�5
   
   �� $��Center=�6   $��0,29,0,0q�61   $
��Wrap=�6C   $��Filtrar platillos��6W   $	��Top=�6p   $��40��6�   $	��327��6�   $��30(�6�   ���	#FF336BC5 �� TextAlignment$ Center=�6�   �� 5   
   $
��Left=�6   $��
51,134,0,0q�6/   $
��Wrap=�6C   $��Ingrediente presente:��6W   $	��Top=�6t   $��31��6�   $	��223��6�   $��20(�6�   ���	#FF336BC5$ Center=�6�   �� 5   
   $
��Left=�6   $��
51,213,0,0q�6/   $
��Wrap=�6C   $��Ingrediente ausente:��6W   $	��Top=�6s   $��31��6�   $	��223��6�   $��20(�6�   ���	#FF336BC5$ Center=�6�   �� 5   
   -   5         ��Name$ absentBlock��5      $��Center=�6'   $��	0,214,0,0q�6D    �� TextWrapping$
 Wrap=�6W   $�� ��6k   $	��Top=�6s   $	��206��6�   $��31��6�   $��14(�6�   �� 5   
   -   5        $ presentBlock��5      $��Center=�6(   $��	0,134,0,0q�6E   $
 Wrap=�6X   $�� ��6l   $	��Top=�6t   $	��208��6�   $��32��6�   $��14(�6�   �� 5   
   -   5         ��Name$ 
presentBtn��5      $��Agregar presente��6%   $
��Left=�6@   $��743,135,0,0q�6[   $	��Top=�6p   $��31��6�   $	��168��6�    J� RenderTransformOrigin$ -0.286,0.778&�6�   ���	#FFD9DEE2���	#FF336BC56�   �� 5   
   -   5        $ 	absentBtn��5      $��Agregar ausente��6$   $
��Left=�6>   $��743,214,0,0q�6Y   $	��Top=�6n   $��31��6�   $	��168��6�   $ -0.286,0.778&�6�   ���	#FFD9DEE2���	#FF336BC56�   �� 5   
   -   5         ��Name$ errorTxt��5      $��Center=�6&   $��0,74,0,0q�6C   $
��Wrap=�6U   $��Filtrar platillos��6i   $	��Top=�6�   $��40��6�   $	��525��6�   $��15(�6�   ���	#FFFF4A15$ Center=�6�   $y�Hidden=�6�   �� 5   
   -   5        $ cleanBtn��5      $��Limpiar��6#   $
��Left=�65   $��	51,36,0,0q�6P   $	��Top=�6c   $��40��6{   $	��178��6�   $ -0.286,0.778&�6�   ���	#FFF7F7F7���	#FFFF96156�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ presentGrid��5      $��51,371,592,235q�6(     5   
   -   5        $ 
absentGrid��5      $��584,371,59,235q�6'   �� 5   
   $
��Left=�6   $��118,318,0,0q�6/   $
��Wrap=�6D   $��Ingredientes presentes��6X   $	��Top=�6v   $��31��6�   $	��223��6�   $��20(�6�   ���	#FF336BC5$ Center=�6�   �� 5   
   $
��Left=�6   $��651,318,0,0q�6/   $
��Wrap=�6D   $��Ingredientes ausentes��6X   $	��Top=�6u   $��31��6�   $	��223��6�   $��20(�6�   ���	#FF336BC5$ Center=�6�   �� 5   
   ���	#FF336BC5$��1q�6)   $��124,284,124,0q�6=   $��1��6T   $	��Top=�6_   $ 0.5,0.5&�6w   z�5      V� 5      .~�5      ��  �� ScaleY$ -1Q�6%   �� 5      �� 5      T� 5      5       5"      �� 5#   
   ���	#FF336BC5$��1q�6)   $��124,645,124,0q�6=   $��1��6T   $	��Top=�6_   $ 0.5,0.5&�6w   z�5$      V� 5%      .~�5&      �� $ -1Q�6%   �� 5'      �� 5(      T� 5)      5*      5,      �� 5-   
   -	   5        $ 	filterBtn��5-      $��Filtrar��6$   $
��Left=�66   $��584,713,0,0q�6Q   $	��Top=�6f   $��63��6~   $	��357��6�   $ -0.286,0.778&�6�   ���	#FFF7F7F7���	#FFFF96156�   �� 5.   
   -
   5        	 ��Name$	 absentCheck��5.      $��Filtrar por Ausentes��6(   $
��Left=�6G   $��134,705,0,0q�6b   $	��Top=�6w   $��30��6�   $	��190��6�   $��15(�6�   �� 5/   
   -   5        $	 presentCheck��5/      $��Filtrar por Presentes��6)   $
��Left=�6I   $��134,753,0,0q�6d   $	��Top=�6y   $��28��6�   $	��190��6�   $��15(�6�   53      54      