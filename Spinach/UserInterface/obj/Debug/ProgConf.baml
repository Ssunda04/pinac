   M S B A M L   `   `   `  ����  Spinach    Spinach.ProgConf   5   	   \ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      8x,http://schemas.microsoft.com/winfx/2006/xaml    5      -   5        $��frmProgConf��5   v     � Title$%  SPINACH - Program Configuration��6   $	��466��6-   $	��675��6:    � AllowsTransparency .   � WindowState$ Normal=�6a    � WindowStyle$ ThreeDBorderWindow=�6�    � WindowStartupLocation$ CenterScreen=�6�    � Icon$! /Spinach;component/Icon.JPG��6�   $��1��6  .��5      � 
������� � ColumnDefinitions 5   
   �� 5      $
��299* �6   �� 5      $
��327* �6   .+�5
   
   o� -   5        $��mnuProg��5
      $��22��6   $	��Top=�6*   }�.  J� Opacity$	 100Q�6V   $y�Hidden=�6d   $��4��6x   .@�5      m� -   5        $��mnuFile��5   &   $��_File��6   .@�5      m� -   5        $��	submnuNew��5   ,   $��_New...��6   6=   m� 5      -   5        $��
submnuLoad��5   *   $��_Load��6   6<   �� 5      m� 5      -   5        $��submnuDisconnect��5   0   $��_Disconnect��6   6H   m� 5      -   5        $��
submnuExit��5   *   $��E_xit��6   6<   5      m� 5      -   5        $��mnuHelp��5   &   $��_Help��6   6&   5      �� 5   
   -	   5        $��lstUserList��5   +   $��15,63,17.104,20q�6    � ToolTip$. (The list of users connected in the swarm��6>   $��1��6q   	 � ContextMenu	 5      �� 5      5      �� 5   
   -
   5        $��lblSwarmList��5   5   $��28��6   $��15,32,150.733,0q�6   $	��Top=�6I   $��1��6a   .��6q   Swarm User List6�   �� 5   
   -   5        $��rtbChat��5   /   $��27.267,180,9,61q�6   
 �� IsUndoEnabled
 .   �� 
IsReadOnly . " �� VerticalScrollBarVisibility$
 Auto=�6f    � 	Resources 5   
    �� 
TargetType �� Property �� Value��%X   'J�       �� 5      " J�6   .�5      ��  �@��Margin$ 0q�6+   5      5      5       �� 5!   
   -   5        $��
txtMessage��5!   .   $��27.267,0,56,11.139q�6   $��37��6@   $��Bottom=�6L   $��1��6g    �� TextWrapping$
 Wrap=�6t   $
 Auto=�6�   �� 5"   
   -   5        $��cmdSend��5"   O   $��37��6   $��Right=�6   $��0,0,9,11.139q�69   $��Bottom=�6^   $��39��6y    �� 	IsDefault . .��6�   _Send6�   �� 5#   
   -   5        $��image1��5#   3   $��90��6   $��27.267,32,0,0q�6   $
��Fill=�6A   $	��Top=�6P   $)��#/Spinach;component/SPINACH_logo.jpg��6h   $
��Left=�6�   $��156.629��6�    J� BitmapEffect 5$      F� 5%       F� Color$ DarkGray��6)   5'      �� 5(      -   5        $��lblChat��5(   5   $��28��6   $��27.267,149,75.892,0q�6   $	��Top=�6D   .��6\   Chat6b   5)      5*      