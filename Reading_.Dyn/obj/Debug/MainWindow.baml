   M S B A M L   `   `   `  ����G  CReading_.Dyn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Reading_.DynReading_.Dyn  5   	       Reading_.Dyn.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Reading_.Dyn     5   	   -   5          �Name$
  form��5   	    � Title$ 
MainWindow��5   	   $��461.808��6   $��627.731��6-    � 
ResizeMode$ NoResize=�6=    � SizeToContent$ Width=�6S    � Icon$ dynamoicon.png��6i   .��5	      �  J� RenderTransformOrigin$ 0.606,0.519&�6   $��Right=�6/   $	��622��6K   $	��433��6W   $	��Top=�6d    � RowDefinitions 5
   
   �� 5      $��0* �6   �� 5      $
��196* �6   �� 5      $	��91* �6   �� 5      $
��146* �6    � ColumnDefinitions 5   
   �� 5      $
��298* �6   .+�5   
   �� -   5         ��Name$ btn_open��5      $��	Open File��6#   $
��Left=�67   $��	30,45,0,0q�6R   $	��Top=�6e   $	��161��6}   $��60��6�   $��14(�6�   $
��Bold"�6�   $��1��6�   �� 5   
   -   5        	 ��Name$	 txt_box_Dynamo_Version��5      $��23��62   $��230,59,30,0q�6>   
 �� TextWrapping$

 Wrap=�6S   $��DynamoVersion��6g   $	��Top=�6|   $��14(�6�   {�.  $��1��6�   �� 5   
   -   5         ��Name$ lbl_Dynamo_Version��5      $��Dynamo Version:��6,   $
��Left=�6F   $��
227,33,0,0q�6a   $	��Top=�6u   $��3��6�   $	��168��6�   $��26��6�   $��1��6�   �� 5   
   -   5        $ lbl_Packages��5      $��	Packages:��6&   $
��Left=�6:   $��
26,154,0,0q�6U   $	��Top=�6i   $	��168��6�   $��26��6�   $��1��6�   �� 5   
   -   5         ��Name$ listViewPackages��5      $y�Visible=�6.   $��
30,0,30,30q�6C   $��1��6W   $��3��6d   $	��221��6u   $��Bottom=�6�   {�.   �� View 5      �� 5      .P�5      �� $
��Name��6%    �� Width$	 260��63    �� DisplayMemberBinding 6?   �� *Name+�� 5      $��Version��6%   $	 260��66    6B   �� *	Version+5       5"      �� 5#   
   -   5        $"	 txt_box_Dynamo_Compatibility��5#      $��23��68   $��230,123,30,0q�6D   $

 Wrap=�6Z   $��Compatibility��6n   $	��Top=�6�   $��14(�6�   $��1��6�   {�.  6�   �� 5$   
   -   5        $ lbl_Dynamo_Version_Copy��5$      $"��Revit Version Compatibility:��61   $
��Left=�6X   $��
227,98,0,0q�6s   $	��Top=�6�   $��3��6�   $	��168��6�   $��26��6�   $��1��6�   �� 5%   
   -	   5        $ noAvailable��5%      $��Information not available��6%   $y�Hidden=�6I   $��1��6]   $��24(�6j   $��25,187,25,25q�6x   $��3��6�   $ 0.506,0.487&�6�   $
��Bold"�6�   $��Center=�6�   $��Center=�6�   5'      5(      