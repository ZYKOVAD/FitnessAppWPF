   M S B A M L   `   `   `  ����E  AFitnessApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:FitnessApp
FitnessApp  5          FitnessApp.Page1   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:FitnessApp     5        N� Title$  Page1��5	      .��5      � 
�������$��0 0 0 0q�6   $	��Top=�6/   .+�5   
   �  � RowDefinitions 5      �� 5      $��50 �6    .+�5      �� -   5         ��Name$ But_Add_Client��5      $��0��6J   $��10q�6W   $	��170��6c   $
��Left=�6o   ���	#FF3B533C
���������6�   Z� .��6�   !Добавить клиента6�   �� 5      -   5        $ But_ArchiveClients��5      $��0��6R   $��10q�6_   $	��170��6k   $��Right=�6w   ���	#FF3B533C
���������6�   Z� .��6�   Архив клиентов6�   5      � 5   
   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ 	dgClients��5      $	��Top=�6*   $	��400��6B   $��	0 50 0 0 q�6O      AutoGenerateColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   
IsReadOnly .    Header$ ID��6Y      Width5  /System.Windows.Controls.DataGridLengthConverter$ 50 6e   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6)   �� 
 �� Path$
 ID�6e     5       . $ Имя��6[   $	 150 6h   	 6)   �� $

 Name�6h     5       . $ Фамилия��6_   $	 150 6p   	 6)   �� $
 Surname�6p     5       . $ Отчество��6b   $	 150 6t   	 6)   �� $
 
SecondName�6t   5      5      5       5!      