   M S B A M L   `   `   `  ���� Z  VWPF_Infrostruktura_TK_test_task, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:WPF_Infrostruktura_TK_test_taskWPF_Infrostruktura_TK_test_task  g8clr-namespace:WPF_Infrostruktura_TK_test_task.ViewModels*WPF_Infrostruktura_TK_test_task.ViewModels  0    *WPF_Infrostruktura_TK_test_task.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     ?local-clr-namespace:WPF_Infrostruktura_TK_test_task     O
viewmodels8clr-namespace:WPF_Infrostruktura_TK_test_task.ViewModels       � Title$%  Choose necesssary variables ☟��$	��450��$	��800�� � DataContext C  =WPF_Infrostruktura_TK_test_task.ViewModels.VariableViewModels   � 	Resources  �� 
TargetType �� Property �� Value   Group_Name_txt_box��%�   '��       &	  ;     �� " ��.���  � ��$ 16(���  � ��$
 Bold"��� " ��.���  �@��MaxLines$ 1����  � ��$	 100����  � ��$	 200��.���  � RowDefinitions �� $
��auto �$	��300���� $��* �.+�� $��0�� � ColumnDefinitions �� $
��auto ��� $��* �.+�� $��0��.+���  �� Orientation$ 
Horizontal=�$��Center=�$	��Top=�$
��auto��.+��� $��Group���� #��[  ���� *FilterGroup+	 �� UpdateSourceTrigger$	 PropertyChanged=��� $
��Name��$��30,0,0,0q��� #��[  ���� *
FilterName+$	 PropertyChanged=�� $��1�� �� $
��auto � �� $
��auto ��� $��* ��� $
��auto �.+�� $��0��$��0��.+��� $��Description��� $��1��$��0,0,3,0q�.+��� $��0,8,0,0q�
 �� TextWrapping$

 Wrap=�$	��200������ *FilterDescription+$	 PropertyChanged=�� $��2��.+��� $��3q�
��� ���._��� $ 
Horizontal=�.+��� $��🔎CaseSensitive?���� $��center=�$��Right=� d� 	IsChecked �� *IsSearchCaseSensitive+� $��1�� �� $��* ��� $
��auto �.+�� $��0��.+�&   System.Windows.Controls.DataGrid  ���	#FFE8D28F   SelectionUnit$ FullRow=�$��16(�   EnableRowVirtualization . ! �� IsDeferredScrollingEnabled .    AutoGenerateColumns .     
IsReadOnly .    CanUserAddRows .     CanUserDeleteRows .     CanUserReorderColumns .     AlternatingRowBackground
 ����� �� AlternationCount$ 2������ *Items+ �� SelectedItem �� *Selected_Variable+   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ Группа��1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *Group+ �� IsAsync .  �� Mode$ OneWay=� �� FallbackValue$ 
Loading...��  $ Переменная�� �� *Name+ . $ OneWay=�$ 
Loading...��  $ Описание�� �� *Description+ . $ OneWay=�$ 
Loading...��� $��1��$	��300��.+�9�  9� ExpandDirection$
 Left=� 9� 
IsExpanded . $��3q����� $-��'Выбранные переменные��$��Center=�$��Center=�
�������$��20(�$
��Bold"�
���   � � LayoutTransform ��   �� Angle$  90Q�.���  �� $
��auto ��� .+�� $��0��$	��150��.+�]� ��. .+��� $
��Left=�$
��Left=�$��10��$��0q�
���  ��! � ToolTip$O! IУдалить из списка выбранную переменную ������ *Click_remove_var_from_list+���� $��30��$��arrow_left_double.ico���� 
�������$��Black"�$��Stretch=�$��40��$��0q�$H! BОтправить выбранный переменные в БД������ *Click_send_vars+���� $��download_database.ico��� $��1��.+��� 
�������$��0q����� *List_selected_vars+" �� SelectedIndex" �� *Selected_Variable_Index+���� .R��� $ 
Horizontal=�.+��� ���� *Group+$ OneWay=��� $	��▶��
��� � ��� ���� *Name+$ OneWay=�