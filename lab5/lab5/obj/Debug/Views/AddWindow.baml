   M S B A M L   `   `   `  ����?  ;lab5, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:lab5.Views
lab5.Views  5          lab5.Views.AddWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      *localclr-namespace:lab5.Views     5      -   5        $��	addWindow��5        � Title$  Add Product��5
      $	��237��6   $	��300��6&    � DataContext 5	      ��    Locator �� Source# [   �� Path$ AddViewModel�.��5      � ���	#FFECEAEA � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��10 �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��30 �6   .+�5   
   �� -   5         ��Name$ label��5      $��Product ID:��6   $��Center=�65   $��Center=�5      $��1��6(   $��0��65   �� 5   
   -   5        $ label1��5      $��Product Name:��6    $��Center=�68   $��Center=�5      $��2��6(   $��0��65   �� 5   
   -   5        $ label2��5      $��	Quantity:��6    $��Center=�64   $��Center=�5      $��3��6(   $��0��65   �� 5   
   -   5         ��Name$ textBox��5      $��Center=�6#   $��23��6@    �� TextWrapping$
 Wrap=�5      $��Center=�6!   $	��120��6X   $��1��5      $��1��6   ��5   <   �� *
EnteredPId+5      �� 5    
   -   5        $ textBox1��5       $��Center=�6$   $��23��6A   $
 Wrap=�5!      $��Center=�6!   $	��120��6Z   $��2��5"      $��1��6   ��5!   <   �� *EnteredPName+5"      �� 5#   
   -   5        $ textBox2��5#      $��Center=�6$   $��23��6A   $
 Wrap=�5$      $��Center=�6!   $	��120��6[   $��3��5%      $��1��6   ��5$   <   �� *EnteredAmount+5%      �� 5&   
   -   5        	 ��Name$	 button��5&      $
��Save��6!   $��Center=�60   $	��Top=�5'      $��75��5(   %   $��4��60   $��0��6=   ��5'   %   �� *SaveCommand+��6E   �� 
 �� ElementName$
 	addWindow��5(   =   �� 5)   
   -	   5        $	 button1��5)      $��Cancel��6"   $��Center=�63   $	��Top=�5*      $��75��5+   %   $��4��60   $��1��6=   ��5*   %   �� *CancelCommand+��6G   �� $
 	addWindow��5+   =   5,      5-      