   M S B A M L   `   `   `  ����Z  VWPF_Infrostruktura_TK_test_task, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:WPF_Infrostruktura_TK_test_taskWPF_Infrostruktura_TK_test_task  5   	   g8clr-namespace:WPF_Infrostruktura_TK_test_task.ViewModels*WPF_Infrostruktura_TK_test_task.ViewModels  5   	   0    *WPF_Infrostruktura_TK_test_task.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ?local-clr-namespace:WPF_Infrostruktura_TK_test_task     5   	   O
viewmodels8clr-namespace:WPF_Infrostruktura_TK_test_task.ViewModels     5   	     � Title$%  Choose necesssary variables ☟��5	   	   $	��450��60   $	��800��6=    � DataContext 5      C  =WPF_Infrostruktura_TK_test_task.ViewModels.VariableViewModels  5   
    � 	Resources 5       �� 
TargetType �� Property �� Value   Group_Name_txt_box��%  '��       &	  n     �� 5   
   " ��6   .�5      ��  � ��$ 16(�6)   �� 5       � ��$
 Bold"�6+   5      �� 5   
   " ��6+   .�5      ��  �@��MaxLines$ 1��6)   �� 5       � ��$	 100��6)   �� 5       � ��$	 200��6)   5      5      .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   $	��300��6*   �� 5      $��* �6   .+�5"   
   � $��0��6    � ColumnDefinitions 5$      �� 5%      $
��auto �6#   �� 5&      $��* �6#   .+�5)      � $��0��6   .+�5*      ��  �� Orientation$ 
Horizontal=�6   $��Center=�66   $	��Top=�6S   $
��auto��6k   .+�5+      �� $��Group��6   �� 5,      #��[  6`   ��6   �� *FilterGroup+	 �� UpdateSourceTrigger$	 PropertyChanged=�6`   �� 5.      $
��Name��6   $��30,0,0,0q�6+   �� 5/      #��[  6_   ��6   �� *
FilterName+$	 PropertyChanged=�6_   50      51      � 53      $��1��6    54      �� 55      $
��auto �6$    57      �� 58      $
��auto �6'   �� 59      $��* �6'   �� 5:      $
��auto �6'   .+�5>      � $��0��6   $��0��6$   .+�5?      �� $��Description��6   5@      � 5B      $��1��6   $��0,0,3,0q�6(   .+�5C      �� $��0,8,0,0q�6f   
 �� TextWrapping$

 Wrap=�6x   $	��200��6�   ��6   �� *FilterDescription+$	 PropertyChanged=�6�   5D      � 5F      $��2��6   .+�5G      �� $ 
Horizontal=�6!   .+�5H      �� $��🔎CaseSensitive?��6    �� 5I      $��center=�6O   $��Right=�6j    d� 	IsChecked 6#   �� *IsSearchCaseSensitive+6j   5J      5K      5L      5N      � 5P   
   $��1��6    5Q      �� 5R      $��* �6#   �� 5S      $
��auto �6#   .+�5U      � $��0��6   .+�5V      &   System.Windows.Controls.DataGrid  ���	#FFE8D28F   SelectionUnit$ FullRow=�62   $��16(�6J      EnableRowVirtualization . ! �� IsDeferredScrollingEnabled .    AutoGenerateColumns .     
IsReadOnly .    CanUserAddRows .     CanUserDeleteRows .     CanUserReorderColumns .     AlternatingRowBackground
 ����� �� AlternationCount$ 2��5Y   <   ��5W      �� *Items+ �� SelectedItem 65   �� *Selected_Variable+   Columns 5Z      0  *System.Windows.Controls.DataGridTextColumn  5[      ,  &System.Windows.Controls.DataGridColumn   Header$ Группа��6-   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6=   �� *Group+ �� IsAsync .  �� Mode$ OneWay=� �� FallbackValue$ 
Loading...��  5\      $ Переменная��6-    6A   �� *Name+ . $ OneWay=�$ 
Loading...��  5]      $ Описание��6-    6?   �� *Description+ . $ OneWay=�$ 
Loading...��5_      5`      � 5b      $��1��6   $	��300��6#   .+�5c      9�  9� ExpandDirection$
 Left=�6    9� 
IsExpanded . $��3q�6E   ��5d      �� 5e      $-��'Выбранные переменные��6    $��Center=�6?   $��Center=�6Z   
�������$��20(�6�   $
��Bold"�6�   
���   � � LayoutTransform 5f      �� 5g   "     �� Angle$  90Q�62   5i      .��5k      �  5l      �� 5m      $
��auto �6,   �� 5n      .+�5q      � $��0��6   $	��150��6,   .+�5r      ]� ��. .+�5s   "   �� $
��Left=�6)   $
��Left=�6D   $��10��5t   )   $��0q�67   
���  ��! � ToolTip$O! IУдалить из списка выбранную переменную ��6a   ��5s   Z   �� *Click_remove_var_from_list+��5u   &   �� 5v   *   $��30��60   $��arrow_left_double.ico��6?   5x   #   �� 5y   "   
�������$��Black"�6d   $��Stretch=�6x   $��40��5z   )   $��0q�68   $H! BОтправить выбранный переменные в БД��6L   ��5y   )   �� *Click_send_vars+��5{   &   �� 5|   *   $��download_database.ico��60   5~   #   5      5�      � 5�      $��1��6   .+�5�      �� 
�������$��0q�6>   ��5�   '   �� *List_selected_vars+" �� SelectedIndex" 6R   �� *Selected_Variable_Index+��5�   "   �� 5�   &   .R�5�   *   �� $ 
Horizontal=�65   .+�5�   .   �� ��64   �� *Group+$ OneWay=��� 5�   .   $	��▶��64   
��� � �6@   �� 5�   .   ��64   �� *Name+$ OneWay=�5�   +   5�   '   5�      5�      5�      5�      5�      5�      5�      5�      