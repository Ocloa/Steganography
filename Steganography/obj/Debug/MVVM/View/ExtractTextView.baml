   M S B A M L   `   `   `  ����H  DSteganography, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:Steganography.MVVM.ViewSteganography.MVVM.View  5      -    'Steganography.MVVM.View.ExtractTextView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      7local%clr-namespace:Steganography.MVVM.View     5      
������ .��5      � .+�5   
   �� -   5          ��Name$  pictureBoxStega��5      $
��Left=�6)   $	��353��6D   $��400,135,0,0q�6Q   $	��Top=�6f   $	��372��6~   �� 5   
   $��Stega Image��6   $
��Left=�5      $��400,104,0,0q�5      $	��Top=�5      ���#BB86FC6%   �� 5   
   -   5         ��Name$ decodedText��5      $
��Left=�6'   $��
29,288,0,0q�6B    �� TextWrapping$
 Wrap=�6V   $.��(Extracted text will be displayed here...��6j   $	��Top=�6�   $	��269��6�   $	��222��6�   $ �� HorizontalScrollBarVisibility$ Visible=�6�    � UseLayoutRounding . " �� VerticalScrollBarVisibility$
 Auto=�6  ���	#FF1F1B24���	#FFBBB2CA �� SelectionBrush �	#FFBB86F9 �� IsReadOnlyCaretVisible .  �� 
IsReadOnly . ��6l  Z� .��6�  	 � 	Resources	 5      
 �� 
TargetType �� Property �� Value��%^   '��       �� 5      "
 ��6   .�5      ��  �@��CornerRadius$ 5��65   5      5      .��6!   5      	� 5   
   -   5         	�Name$
 lsb1��5      $��LSB 1��6$   $
��Left=�64   $��
34,204,0,0q�6O   $	��Top=�6c   
�������6{   	� 5   
   -   5        $
 lsb2��5      $��LSB 2��6$   $
��Left=�64   $��
89,204,0,0q�6O   $	��Top=�6c   
�������6{   	� 5   
   -   5        $
 lsb3��5      $��LSB 3��6$   $
��Left=�64   $��145,204,0,0q�6O   $	��Top=�6d   
�������6|   	� 5   
   -   5        $
 lsb4��5      $��LSB 4��6$   $
��Left=�64   $��198,204,0,0q�6O   $	��Top=�6d   
�������6|   �� 5   
   -   5        $��Extract��5      $
��Left=�6#   $��
34,238,0,0q�6>   $	��Top=�6R   $��23��6j   $��48��6v   ���	#FFA287C5
���������6�   Z� 	 5      ��%^   '��       �� 5      "
 ��6   .�5      ��  �@��CornerRadius$ 2��65   5       5!      5"      �� 5#   
   $��Stega Image route��6   $
��Left=�5$      $��	29,35,0,0q�5%      $	��Top=�5&      ���#BB86FC6%   �� 5'   
   -   5        $ stegabox��5'      $
��Left=�6$   $��	34,66,0,0q�5(      $
 Wrap=�5)      $	��Top=�5*      $	��246��5+      ���	#FF1F1E1F
���������6S   Z� 6j   �� 5,   
   -	   5         ��Name$ 
openButton��5,      $��Open...��6%   $
��Left=�67   $��	34,97,0,0q�5-      $	��Top=�6     J� RenderTransformOrigin$ 0.404,0.601&�68   ���	#FFA287C5
���������6�   Z� 	 5.      ��%^   '��       �� 5/      "
 ��6   .�50      ��  �@��CornerRadius$ 2��65   51      52      53      55      56      