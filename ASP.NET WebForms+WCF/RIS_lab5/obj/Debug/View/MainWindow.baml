   M S B A M L   `   `   `  ����  RIS_lab5    RIS_lab5.View.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  
MainWindow��5   	   $	��360��6   $	��670��6)   .��5      � .+�5   
   �� $
��Left=�6   $	��375��6+   $	��Top=�68   $	��670��6P   $��..\Image\main.jpg��6\   $��	0,0,0,-31q�6w   �� 5   
   -   5        $1��+Зарегистрировать карту��5      $
��Left=�62   $��
491,15,0,0q�6M   $	��Top=�6a   $	��146��6y   $��45��6�   �� 5   
   -   5        $'��!Совершить покупку��5      $
��Left=�6-   $��
491,65,0,0q�6H   $	��Top=�6\   $	��146��6t   $��45��6�    J� RenderTransformOrigin$ 3.405,1.367&�6�   �� 5	   
   -   5        $%��Проверить баланс��5	      $
��Left=�6,   $��491,115,0,0q�6G   $	��Top=�6\   $	��146��6t   $��45��6�   &   System.Windows.Controls.DataGrid  5
   
   -   5        $��dgSaleCards��5
         CanUserResizeColumns .    AutoGenerateColumns .  $
��Left=�6�   $	��245��6�   $��	16,15,0,0q�6�   $	��Top=�6�   $	��437��6  ��6&   �� *	SaleCards+ �� SelectedItem 6H   �� *ChoosedCard+ �� Mode$ OneWayToSource=�   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$! Номер карточки��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6=   �� *Number+  5      $ Процент��6%    66   �� *
Discount+  5      $ Имя владельца��6%    6<   �� *	Surname+  5      $' !Фамилия владельца��6%    6@   �� *Name+  5      $ Баланс��6%    65   �� *	Balance+5      �� 5   
   -   5        $%��Слияние карточек��5      $
��Left=�6,   $��491,165,0,0q�6G   $	��Top=�6\   $	��146��6t   $��45��6�   �� 5   
   -   5        $��
Отчет��5      $
��Left=�6!   $��491,215,0,0q�6<   $	��Top=�6Q   $	��146��6i   $��45��6�   �� 5   
   $��Обновить��6   $
��Left=�6$   $��
16,274,0,0q�6?   $	��Top=�6S   $	��437��6k   $��27��6w   ��6�   �� *UpdateWindow+5      5      