   M S B A M L   `   `   `  ����F  BBootcampWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:BootcampWPFBootcampWPF  5   	       BootcampWPF.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:BootcampWPF     5   	   -   5          � Title$  Bootcamp WPF��5   	   $	��422��6   $	��525��6+   .��5
      � .+�5   
   �� -   5         ��Name$ 
tabControl��5      $
��Left=�6)   $	��386��6D   $	��Top=�6Q   $	��512��6i   $��4,4,0,0q�6u   .@�5      �� $��Manage Supplier��6   .��5      � ���	#FFE5E5E5.+�5      �� -   5         ��Name$ 
btn_insert��5      {�.  $��Insert��6C   $
��Left=�6T   $��
211,54,0,0q�6o   $	��Top=�6�   $��75��6�   6�   �� 5      -   5         ��Name$ txt_name��5      {�.  $
��Left=�6o   $��23��6�   $��
298,18,0,0q�6�    �� TextWrapping$
 Wrap=�6�   $�� ��6�   $	��Top=�6�   $	��188��6�   &   System.Windows.Controls.DataGrid  5      -   5          Name$ dataGrid��5         
IsReadOnly .    AutoGenerateColumns .  $
��Left=�6�   $��
16,100,0,0q�6�   $	��Top=�6�   $	��224��6�   $	��467��6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 Id��61   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6=   ��  �� Path$ id�6[     5      $
	 Name��61   
 6?   �� $
 Name�6_     5      $	 	Join Date��61   
 6D   �� $ JoinDate�6h   5      �� 5      -   5         ��Name$ comboBox��5      {�.   �� DisplayMemberPath$
 Name��6C    �� SelectedValuePath$ id��6\   $
��Left=�6s   $��
297,52,0,0q�6�   $	��Top=�6�   $	��185��6�   �� 5      -   5        $ 
btn_Search��5      $��Search��61   $
��Left=�6B   $��
211,19,0,0q�6]   $	��Top=�6q   $��75��6�   6�   �� 5      -   5        $ 	cb_search��5      $
��Left=�62   $��	89,53,0,0q�6M   $	��Top=�6`   $	��113��6x   .@�5      �� $��ID��6'   $
��Left=�64   $	��111��6O   �� 5      $
��Name��6'   $
��Left=�66   $	��111��6Q   �� 5      $��	Join Date��6'   $
��Left=�6;   $	��111��6V   5      �� 5      -	   5         ��Name$ label_category��5      $��
Category :��64   $
��Left=�6I   $��	22,52,0,0q�6d   $	��Top=�6w   �� 5      -
   5        $ 
txt_search��5      $
��Left=�62   $��23��6M   $��	30,18,0,0q�6Y   $
 Wrap=�6l   $�� ��6�   $	��Top=�6�   $	��173��6�   5       5!      5"      5#      5$      