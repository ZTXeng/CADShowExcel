   M S B A M L   `   `   `  ����B  >CadMvvm, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:CadMvvm.ViewCadMvvm.View  5           CadMvvm.View.ShowExcelView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:CadMvvm.View     5      $	��450��5      $	��600��6     � Title$  表格展示��6'   .��5	      �  � RowDefinitions 5
   
   �� 5      $��36 �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $
��Left=�6"    �� Orientation$ 
Horizontal=�6=   .+�5      �� 
���   �$	��0.5q�6)   $��32��6?   ._�5      �� $	��420��6   $��Center=�6(   ��6C   �� *Model.FilePath+5      �� 5      $��34��6   $��32��6!   ��6,   �� *
FileSelect+5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 	ExcelData��5      $��1��6&   ��63   �� *Model.CurrentDataTable+5      5      