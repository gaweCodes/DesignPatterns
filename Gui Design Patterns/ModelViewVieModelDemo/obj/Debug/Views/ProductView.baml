   M S B A M L   `   `   `  ����  ModelViewVieModelDemo-    'ModelViewVieModelDemo.Views.ProductView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .��5	      � 
�������  J� RenderTransformOrigin$  0.453, 0.51&�5
       � DataContext 5	      �� *CurrentProduct+ � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   �� $��Productnumber:��6   $��Right=�6*   $��5q�5      $
��Bold"�6   $��0��61   $��0��6>   �� 5   
   $
��Left=�63   $��5q�5      $��0��6   $��1��6,   ��5      �� *ProductNumber+5   ,   �� 5   
   $��Producttext:��6   $��Right=�6(   $��5q�5      $
��Bold"�6   $��1��61   $��0��6>   �� 5   
   $
��Left=�61   $��5q�5      $��1��6   $��1��6,   ��5      �� *ProductText+5   ,   �� 5    
   $��Price:��6   $��Right=�6"   $��5q�5!      $
��Bold"�6   $��2��61   $��0��6>   �� 5"   
   $
��Left=�63   $��5q�5#      $��2��6   $��1��6,   ��5"      �� *PricePerPiece+5#   ,   �� 5%   
   -   5         ��Name$ IncrementPriceButton��5%      $
��+100��6/   $
��Left=�5&      $��107, 0, 0, 0q�6,   $	��Top=�5'      $��43��6)   $��25��64   $��2��5)      $��1��6   ��5(      �� *IncrementPriceCommand+5)      �� 5+   
   -   5        $ PreviousButton��5+      $��Previous��6)   $��3��5-      $��0��6   ��5,      �� *PreviousCommand+5-      �� 5/   
   -   5        $ 
NextButton��5/      $
��Next��6%   $��3��51      $��1��6   ��50      �� *NextCommand+51      54      55      