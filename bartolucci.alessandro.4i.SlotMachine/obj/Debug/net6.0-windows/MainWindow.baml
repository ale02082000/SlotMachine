   M S B A M L   `   `   `  ����_  [bartolucci.alessandro.4i.SlotMachine, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:bartolucci.alessandro._4i.SMbartolucci.alessandro._4i.SM  5   	   -    'bartolucci.alessandro._4i.SM.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   <local*clr-namespace:bartolucci.alessandro._4i.SM     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� -   5         ��Name$ textBoxWelcome��5      $��0��6*   $��Stretch=�67   $��60��6U   $��20,10q�6a   ���#4CAF50
�������$;��5Benvenuto, se vuoi giocare clicca sul pulsante "Spin"��6�   $	��Top=�6�   $	��456��6�   $��18(�6  � 5   
   -   5         �Name$
 Slot��5      $��1��6   $	��100��6*    � ColumnDefinitions 5      �� 5      $
��Auto �6#   �� 5      $
��Auto �6#   �� 5      $
��Auto �6#   �� 5      $
��Auto �6#   .+�5      �� -   5        $ textBoxLett1��5      $��0��6,   $	��180��6<   $��Stretch=�6H   $��20,10,20,20q�6f   $��36(�6{   �� 5      -   5        $ textBoxLett2��5      $��1��6,   $	��180��6<   $��Stretch=�6H   $��20,10,20,20q�6f   $��36(�6{   �� 5      -   5        $ textBoxLett3��5      $��2��6,   $	��180��6<   $��Stretch=�6H   $��20,10,20,20q�6f   $��36(�6{   �� 5      -   5        $
��Spin��5   4   $
��Spin��6   $��3��6$   $��4��6@   $��Stretch=�6M   $��20,10q�6k   $
��auto��6z   $
��auto��6�   
���   �$��24(�6�   6�   �� 5      -   5         ��Name$ checkBoxStopSimb1��5      $��Stop Simbolo 1��62   $��0��6K   $	��180��6[   $��Stretch=�6g   $
��20,5q�6�   $��Bottom=�6�   6�   �� 5      -   5        $ checkBoxStopSimb2��5      $��Stop Simbolo 2��62   $��1��6K   $	��180��6[   $��Stretch=�6g   $
��20,5q�6�   $��Bottom=�6�   6�   �� 5       -	   5        $ checkBoxStopSimb3��5       $��Stop Simbolo 3��62   $��2��6K   $	��180��6[   $��Stretch=�6g   $
��20,5q�6�   $��Bottom=�6�   6�   5"      �� 5$   
   -
   5        $ textBoxResult��5$      $��2��6)   $��Right=�66   $��20,10q�6R   
��� ���
�������$�� ��6�   $	��Top=�6�   $	��300��6�   $��60��6�   $��18(�6�   �� 5%   
   -   5        $ textBoxCredits��5%      $��2��6*   $
��Left=�67   $��20,10q�6R   $�� ��6a   $	��Top=�6i   $	��300��6�   $��60��6�   $��18(�6�   5(      5)      