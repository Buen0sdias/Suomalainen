   M S B A M L   `   `   `  ����I  Eoliolopputyö3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:oliolopputyö3oliolopputyö3  5   	       oliolopputyö3.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:oliolopputyö3     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � $��0,0,0,-6q�6   ��5
   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$
 Pink��6   � 5      $ Purple��6    � Offset$ 1Q�6.   5       � RowDefinitions 5   
   �� 5      $
��184* �6   �� 5      $
��147* �6   .+�5   
   �� -   5         ��Name$ tbTuote��5      $
��Left=�6#   $��23��6>   $��
314,87,0,0q�6J    �� TextWrapping$
 Wrap=�6^   $	��Top=�6r   $	��120��6�    J� RenderTransformOrigin$ 	2.53,1.04&�6�   	� 5   
   -   5        	 	�Name$	 cbJuoma��5      $��Juoma��6'   $
��Left=�67   $��	534,0,0,0q�6R   $��Center=�6e   $��19��6�   6�   	� 5   
   -   5        $	 cbKarkki��5      $��Karkki��6(   $
��Left=�69   $��534,150,0,0q�6T   $	��Top=�6i   $��18��6�   6�   �� 5   
   -   5        $ 
tbOstokset��5      $
��Left=�6&   $	��144��6A   $��157,198,0,0q�6N   $
 Wrap=�6c   $	��Top=�6w   $	��104��6�   ���	#FFD42B2B$��2��6�   �� 5   
   -   5        
 ��Name$
 	btnSelect��5      $'��!Siirry maksamaan                 ��6$   $
��Left=�5      $��
534,20,0,0q�6.   $	��Top=�6B   $	��160��6Z   $��25��6~   $��1��6�   �� 5   
   -   5        $
 	btnTotext��5      $��Maksa ostokset��6$   $
��Left=�6=   $��148,149,0,0q�6X   $	��Top=�6m   $	��122��6�   6�   �� 5   
   -   5         ��Name$ tbSuccessful��5      $
��Left=�6*   $��
419,20,0,0q�6E   $
��Wrap=�6Y   $	��Top=�6m   $	��169��6�   $��1��6�   �� 5   
   $
��Left=�6   $��
314,49,0,0q�6/   $
��Wrap=�6C   $	��Top=�6W   
���   ��� 6�    � Language$ fi-fi�6�   $�Tuote jonka ostat:��6�   6�   	� 5   
   -   5        $	 cbSipsi��5      $��Sipsi��6'   $
��Left=�67   $��534,186,0,0q�6R   $	��Top=�6g   6   	� 5   
   -	   5        $	 cbVaate��5      $��Vaate��6'   $
��Left=�67   $��532,220,0,0q�6R   $	��Top=�6g   6   �� 5   
   -
   5        $ tbGenreinfo��5      $
��Left=�6)   $��250,1,0,-28q�6D   $
��Wrap=�6Y   $	��Top=�6m   $	��153��6�   $	��174��6�   $��1��6�   �� 5    
   $
��Left=�6   $��
543,79,0,0q�6/   $
��Wrap=�6C   $	��Top=�6W   $��Tuotteen kategoria:��6o   
����  �6�   �� 5!   
   $
��Left=�6   $
��Wrap=�6/   $��Kauppa lista��6C   $	��Top=�6W   $��26��6o   $��63��6{   �� 5"   
   -   5        $
 BTN_Pois��5"      $��Sammuta��6#   $��681,8,10,180q�65   6K   5&      5'      