   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:WpfApp1.CommandsWpfApp1.Commands  5      !clr-namespace:WpfApp1WpfApp1  5      -clr-namespace:WpfApp1.ModelWpfApp1.Model  5      A%clr-namespace:WpfApp1.ValidationRulesWpfApp1.ValidationRules  5          WpfApp1.PageEmploye   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2commandclr-namespace:WpfApp1.Commands     5      'localclr-namespace:WpfApp1     5      ,coreclr-namespace:WpfApp1.Model     5      6rule%clr-namespace:WpfApp1.ValidationRules     5      -   5          N� Title$  PageEmploye��5
       � 	Resources 5        WpfApp1.Model.ListTitle   	listTitle  DateTemplate �� StringFormat  EditingDateTemplate(  "System.Windows.Controls.DatePicker   SelectedDate �� Mode �� UpdateSourceTrigger  
errorStyle �� 
TargetType �� Property �� Value	 �� Triggers
 P� Property P� Value �� RelativeSource �� Path��%p  &	        &	      &	 �     &	       5   
   6   �� 5   
   .R�5      �� $��Center=�5      $��Center=�6/   ��5      �� *	BirthDate+$ {0:dd.}{0:MM.}{0:yyyy}��5   /   5      �� 5   
   .R�5         6   �� *	BirthDate+$ TwoWay=�$ PropertyChanged=�5      �� 5   
   " ��6#   .�5      ��  � ��$ -2q�6(   	 5      P� 5       
 �@=�HasError . . �5!      ��  � ��
 �  ��63   �� 5"       � ��$ 1q�68   �� 5#       �@�ToolTip 60   ��  �� *Self+$) #(Validation.Errors)[0].ErrorContent�5%      5'      5(       J� CommandBindings 5*      )  #System.Windows.Input.CommandBinding  5+   
   -   5           Command$
 Undo��5+      6O     5,   
   -   5        $
 Save��5,      6O     5-   
   -   5        $
 Find��5-      6O     5.   
   -   5        $	 New��5.      6M     5/   
   -   5        #  WpfApp1.Commands.DataCommands   Edit# Z 5/      50   @     51   
   -   5           Delete# Z 51      6s     52   
   -   5        $ Refresh��52      6+   .��55      �� $��3q�6     BackGroundWindowResource#��[ 6   .+�56   
   �� .+�57      o� .@�58      m� $��Действие��6   .@�59      m� $��Отменить��6    m� Command$
 Undo��61   6B   �� 5:      6"   m� 5;      $��Создать��6   $	 New��60   6@   m� 5<      $ ��Редактировать��6   $ command:DataCommands.Edit��66   6]   m� 5=      $��Сохранить��6   $
 Save��62   6C   m� 5>      $��
Найти��6   $
 Find��6.   6?   �� 5?      6"   m� 5@      $��Обновить��6   $ Refresh��61   5A      m� 5B      $��
Отчет��6   6,   5C      c� 5D      -	   5        $��TooBar1��5D      $��3q�6%   .@�5E      �� -
   5        $
��Undo��5E      $
��Undo��6%    � ToolTip$D >Отменить редактирование/создание��64   $��5,2,5,2q�6_   .��5F      �� $��24��6   $��24��6(   $��Images/Undo.png��63   5G      �� 5H      -   5        $	��Add��5H      $	��New��6$   $8 2Добавить нового сотрудника��62   $��5,2,5,2q�6W   .��5I      �� $��24��6   $��24��6(   $��Images/Add.png��63   5J      �� 5K      -   5        $
��Edit��5K      $  Редактировать��6%   $��5,2,5,2q�6=   .��5L      �� $��24��6   $��24��6(   $��Images/Edit.png��63   5M      �� 5N      -   5        $
��Find��5N      $
��Find��6%   $ 
Поиск��65   $��5,2,5,2q�6E   .��5O      �� $��24��6   $��24��6(   $��Images/Find.png��63   5P      �� 5Q      -   5        $
��Save��5Q      $
��Save��6%   $ Сохранить��64   $��5,2,5,2q�6H   .��5R      �� $��24��6   $��24��6(   $��Images/Save.png��63   5S      �� 5T      -   5        $��Refresh��5T      $��Refresh��6(   $# Обновить данные��6:   $��5,2,5,2q�6T   .��5U      �� $��24��6   $��24��6(   $��Images/Refresh.png��63   5V      �� 5W      -   5        $��Delete��5W      $!��command:DataCommands.Delete��6'   $ Удалить��6M   $��5,2,5,2q�6_   .��5X      �� $��24��6   $��24��6(   $��Images/Delete.png��63   5Y      5Z      5[      �� 5]   
    �� Orientation$ 
Horizontal=�6   .+�5^      �� .+�5_      &   System.Windows.Controls.DataGrid  -   5          Name$ DataGridEmpoyee��5_         AutoGenerateColumns .  $
��Left=�5b      $
��1000��5c      $	��295��5d         RowBackground �	#FFE6D3EF   AlternatingRowBackground �	#FC96CFD4���	#FF1F33EB$��3q�5h         	RowHeight$ 25Q�5i       � Cursor$
 Hand��5j         CanUserAddRows .     CanUserDeleteRows .  $	��995��5m      ��5`      ��    Columns 5o      0  *System.Windows.Controls.DataGridTextColumn  5p      ,  &System.Windows.Controls.DataGridColumn   Header$ Фамилия��6-   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5q   -   �� *	Surname+$ TwoWay=�$ PropertyChanged=�  5u      $ Имя��6-    5v   -   �� *Name+$ TwoWay=�$ PropertyChanged=�  5z      $ Отчество��6-    5{   -   �� *
Patronymic+$ TwoWay=�$ PropertyChanged=�4	  .System.Windows.Controls.DataGridComboBoxColumn	  5      $ Должность��61     	  DisplayMemberPath$  Title1��5�   1   ! 	  SelectedValuePath$! ID��5�   1   " 	  ItemsSource" 5�   1   �� # �� Source## [  $ 	  SelectedValueBinding$ 5�   1   �� $ TitleID�$ TwoWay=�$ PropertyChanged=�5�   1   4
  .System.Windows.Controls.DataGridTemplateColumn
  5�      $ Дата рождения��61   % 
  CellTemplate#% [ 5�   1   & 
  CellEditingTemplate#& [ 5�   1     5�      $ Телефон��6-    5�   -   �� *	Telephone+$ TwoWay=�$ PropertyChanged=�  5�      $ e-Mail��6-   '   EditingElementStyle#' [ 6=    5�      �� 5�   "   $ Email�6*   $ TwoWay=�67   $ PropertyChanged=�6E   ( �� ValidatesOnExceptions( . ) �� ValidationRules) 5�   &   (   "WpfApp1.ValidationRules.EmailRules  5�   *   5�   #   5�      !*   RowValidationErrorTemplate* 5�      �� 5�      .R�5�      � $��0, -2, 0, -2q�6#    5�   #   ��  �� *FindAncestor++ �� AncestorType)  #System.Windows.Controls.DataGridRow"+  $) #(Validation.Errors)[0].ErrorContent�.+�5�   "   A� $��0��6*   
���  ��#��z��5�   *   #��z��5�   *   �� 5�   "   $��!��6,   #��z��65   $
��Bold"�5�   ,   
�������$��Center=�5�   ,   5�      5�      5�      5�      �� 5�      $��30, 0q�6   .+�5�      � -   5        , �Name$, 
BorderFind��5�      $y�Hidden=�6+   #��[ 6?   - � RowDefinitions- 5�      �� 5�      $��30 �6(   66   �� 5�      $��20 �6(   66   �� 5�      $��20 �6(   66   . � ColumnDefinitions. 5�      �� 5�      $	��100 �6+   69   �� 5�      $	��150 �6+   69   �� 5�      $��30 �6+   68   .+�5�      �� $��1��6    $��0��60   $��20, 0q�6=   $
��Wrap=�6L   $��
Поиск��6`   $��15(�6m   $
��Bold"�6{   �� 5�      -   5        $��TextBlockSurname��5�   =   $��0��6    $��1��60   $��Фамилия��6U   �� 5�      -   5        $��TextBlockTitle��5�   =   $��0��6    $��2��60   $��Должность��6S   �� 5�      -   5        $��TextBoxSurname��5�   <   $��1��6   $��1��6.   6R   �� 5�      -   5        $��ComboBoxTitle��5�   <   $��1��6   $��2��6/   / �� DisplayMemberPath$/ Title1��5�      ��5�   Q   �� ## [  5�   .   �� 5�      -   5        $��ButtonFindSurname��5�   :   $��2��6   $��1��6-   $$ Поиск по фамилии��6S   {�.  .��5�      �� $��Images/Find.png��6    5�      �� 5�      -   5        $��ButtonFindTitle��5�   :   $��2��6   $��2��6-   $( "Поиск по должности��6Q   {�.  0 J� RenderTransformOrigin$0 0,0.043&�6�   .��5�      �� $��Images/Find.png��6    $0 -0.368,-0.263&�69   5�      5�      5�      5�      5�      5�      