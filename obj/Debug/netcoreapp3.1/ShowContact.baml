   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.ShowContact   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	     � Title$  ShowContact��5   	   $	��450��6   $	��800��6*   .��5	      �  � RowDefinitions 5
   
   �� 5      $��3* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��2��5      5      �� 5   
   $��Nom : ��6   $��1��5      $��0��5      $��Center=�5      $��Center=�5      $��20(�5       �� 5!   
   -   5         ��Name$ LastName��5!      $��1��5"      $��1��5#      $��Center=�5$      $��Center=�5%      $��20(�5&      �� 5(   
   $��
Prénom : ��6   $��2��5)      $��0��5*      $��Center=�5+      $��Center=�5,      $��20(�5-      �� 5.   
   -   5        $ 	FirstName��5.      $��2��5/      $��1��50      $��Center=�51      $��Center=�52      $��20(�53      �� 55   
   $��Téléphone : ��6   $��3��56      $��0��57      $��Center=�58      $��Center=�59      $��20(�5:      �� 5;   
   -   5        $ phone��5;      $��3��5<      $��1��5=      $��Center=�5>      $��Center=�5?      $��20(�5@      �� 5B   
   $��Date de naissance : ��6   $��4��5C      $��0��5D      $��Center=�5E      $��Center=�5F      $��20(�5G      �� 5H   
   -   5        $ 	BirthDate��5H      $��4��5I      $��1��5J      $��Center=�5K      $��Center=�5L      $��20(�5M      �� 5O   
   -   5         ��Name$ btnExit��5O      $��Quitter��5Q      $��5��5R      $��10q�5S      �� 5T   
   -   5        $ 	btnModify��5T      $��Modifier��5V      $��5��5W      $��2��5X      $��10q�5Y      5[      5\      