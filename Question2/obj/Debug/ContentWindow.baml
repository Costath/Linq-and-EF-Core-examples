   M S B A M L   `   `   `  ����D  @Question2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Question2	Question2  5   	   O KBaseballClassLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullgGclr-namespace:BaseballClassLibrary.Models;assembly=BaseballClassLibraryBaseballClassLibrary.Models 5   	       Question2.ContentWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Question2     5   	   ZModelsGclr-namespace:BaseballClassLibrary.Models;assembly=BaseballClassLibrary     5   	   -   5          � Title$  All Players��5	   	   $	��231��6   $	��520��6*    � WindowStartupLocation$ CenterScreen=�6M    � 	Resources 5
         baseballContextViewSource $  baseballContextPlayersViewSource �� Source �� Source��%X   &	        &	      7   �� 5   
   6   �� 5   
    6H   �� *	Players+8   5      .��5      �  � DataContext# [ 6   .+�5   
   �� -   5         ��Name$ BackBtn��5      $
��Back��6"   $
��Left=�61   $��214,153,0,0q�6L   $	��Top=�6a   $��75��6y   6�   � 5   
   -   5         �Name$ grid1��5      # [  6   $
��Left=�6W   $��	10,10,0,0q�6r   $	��Top=�6�    � ColumnDefinitions 5      �� 5      $
��Auto �6#   �� 5      $
��Auto �6#   	 � RowDefinitions	 5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    .+�5      �� $��Batting Average:��6   $��0��6/   $
��Left=�6?   $��3q�6Z   $��0��6e   $��Center=�6r   �� 5      -   5        
 ��Name$
 battingAverageTextBox��5      $��1��65   $
��Left=�6E   $��23��6`   $��3q�6l   $��0��6w   $��Center=�6�   $	��120��6  ��6�   �� *BattingAverage+ �� Mode$ TwoWay=� �� NotifyOnValidationError .  �� ValidatesOnExceptions . 6  �� 5      $��First Name:��6   $��0��6*   $
��Left=�6:   $��3q�6U   $��1��6`   $��Center=�6m   �� 5      -   5        $
 firstNameTextBox��5      $��1��60   $
��Left=�6@   $��23��6[   $��3q�6g   $��1��6r   $��Center=�6�   $	��120��6�   ��6   �� *	FirstName+$ TwoWay=� .  . 6�   �� 5      $��
Last Name:��6   $��0��6)   $
��Left=�69   $��3q�6T   $��2��6_   $��Center=�6l   �� 5       -   5        $
 lastNameTextBox��5       $��1��6/   $
��Left=�6?   $��23��6Z   $��3q�6f   $��2��6q   $��Center=�6�   $	��120��6�   ��6~   �� *
LastName+$ TwoWay=� .  . 6�   �� 5!      $��
Player Id:��6   $��0��6)   $
��Left=�69   $��3q�6T   $��3��6_   $��Center=�6l   �� 5"      -   5        $
 playerIdTextBox��5"      $��1��6/   $
��Left=�6?   $��23��6Z   $��3q�6f   $��3��6q   $��Center=�6�   $	��120��6�   ��6~   �� *
PlayerId+$ TwoWay=� .  . 6�   5#      &   System.Windows.Controls.DataGrid  5$   
   -   5          Name$ playersDataGrid��5$         AutoGenerateColumns .     EnableRowVirtualization . $��255,10,10,62q�6�      RowDetailsVisibilityMode$ VisibleWhenSelected=�6�   ��6g   �� # [     Columns 5%      0  *System.Windows.Controls.DataGridTextColumn  5&      -	   5        firstNameColumn��,  &System.Windows.Controls.DataGridColumn   Header$ 
First Name��5&   \      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6p   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6>   �� *	FirstName+6p     5'      -
   5        lastNameColumn��$ 	Last Name��5'   Z   $ * 6m    6=   �� *
LastName+6m   5)      5*      5+      