   M S B A M L   `   `   `  ����H  DSteganography, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:Steganography.MVVM.ViewSteganography.MVVM.View  5      +    %Steganography.MVVM.View.EmbedTextView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      7local%clr-namespace:Steganography.MVVM.View     5      
������ .��5
      �   J� RenderTransformOrigin$	  0,0&�6   .+�5   
   �� -   5         ��Name$ pictureBoxInput��5      $
��Left=�6)   $	��171��6D   $��
400,30,0,0q�6Q   $	��Top=�6e   $	��341��6}   5      �� 5   
   -   5        $ pictureBoxStega��5      $
��Left=�6)   $	��160��6D   $��400,252,0,0q�6Q   $	��Top=�6f   $	��341��6~    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5      5      �� 5   
   $��Original Image��6   $
��Left=�5      $��	424,6,0,0q�5      $	��Top=�5      ���#BB86FC6(   �� 5   
   $��Stega Image��6   $
��Left=�5      $��424,226,0,0q�5      $	��Top=�5      ���#BB86FC6%   �� 5   
   -   5         ��Name$ routeBox��5      $
��Left=�6$   $��	52,44,0,0q�5       �� TextWrapping$
 Wrap=�5      $	��Top=�5      $	��246��5      ���	#FF1F1E1F
���������6X   Z� 6o   �� 5    
   -   5        $ stegabox��5       $
��Left=�6$   $��
52,393,0,0q�5!      $
 Wrap=�5"      $	��Top=�5#      $	��246��5$      ���	#FF1F1E1F
���������65   Z� 6L   �� 5%   
   $��Original Image route��6   $
��Left=�5&      $��	47,13,0,0q�5'      $	��Top=�5(      ���#BB86FC6%   �� 5)   
   $��Stega Image route��6   $
��Left=�5*      $��
47,365,0,0q�5+      $	��Top=�5,      ���#BB86FC6%   �� 5-   
   -   5         ��Name$ 
openButton��5-      $��Open...��6%   $
��Left=�67   $��	52,73,0,0q�5.      $	��Top=�6$   $  0.404,0.601&�6<   ���	#FFA287C5
����������	#FF1F1B24 � 	Resources 5/       �� 
TargetType �� Property	 �� Value��%^   '��       �� 50      " ��6   .�51      ��  �@��CornerRadius$	 2��65   52      53      54      �� 55   
   -   5        $ saveStegaButton��55      $��Save...��6*   $
��Left=�6<   $��
52,428,0,0q�56      $	��Top=�6!   $  0.404,0.601&�69   $��60��6]   ���	#FFA287C5
����������	#FF1F1B24 57      ��%^   '��       �� 58      " ��6   .�59      ��  �@��CornerRadius$	 2��65   5:      5;      5<      	� 5=   
   -   5        
 	�Name$

 lsb1��5=      $��LSB 1��6$   $
��Left=�64   $��
52,341,0,0q�6O   $	��Top=�6c   
�������6{   	� 5>   
   -   5        $

 lsb2��5>      $��LSB 2��6$   $
��Left=�64   $��107,341,0,0q�6O   $	��Top=�6d   
�������6|   	� 5?   
   -	   5        $

 lsb3��5?      $��LSB 3��6$   $
��Left=�64   $��163,341,0,0q�6O   $	��Top=�6d   
�������6|   	� 5@   
   -
   5        $

 lsb4��5@      $��LSB 4��6$   $
��Left=�64   $��216,341,0,0q�6O   $	��Top=�6d   
�������6|   �� 5A   
   -   5        $ textToEmbed��5A      $
��Left=�6'   $��
52,111,0,0q�6B   $
 Wrap=�6V   $��Text to embed here...��6j   $	��Top=�6�   $	��269��6�   $	��222��6�   $ �� HorizontalScrollBarVisibility$ Visible=�6�    � UseLayoutRounding . " �� VerticalScrollBarVisibility$
 Auto=�6�   ���	#FF1F1B24���	#FFBBB2CA �� SelectionBrush �	#FFBB86F9 �� AcceptsReturn .  �� 
AcceptsTab . ��6Y  Z� .��6�   5B      ��%^   '��       �� 5C      " ��6   .�5D      ��  �@��CornerRadius$	 5��65   5E      5F      .��6!   5G      � 5H      -   5         �Name$ pBar1��5H      $
��Left=�6)   $��18��6D   $��424,208,0,0q�6P   $	��Top=�6e   $	��351��6}   �� 5I   
   -   5        $ embedButton��5I      $��Embed��6&   $
��Left=�66   $��280,339,0,0q�6Q   $	��Top=�6f   
���������5J      
� 5K      .��5L      �  � Color$ 	#FF9E86C3��6#   � 5M      $ 	#FF7012FF��6#    � Offset$ 0.637Q�65   5N      5P      5Q      5R      