   M S B A M L   `   `   `  ����R  NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R8clr-namespace:System.ComponentModel;assembly=WindowsBaseSystem.ComponentModel  5      ? ;lab5, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:lab5.ViewModellab5.ViewModel 5      clr-namespace:lab5lab5 5	      c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35qPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.InteractivitySystem.Windows.Interactivity 5
      R8clr-namespace:System.ComponentModel;assembly=WindowsBaseSystem.ComponentModel  6`      lab5.Views.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml      5      @d2http://schemas.microsoft.com/expression/blend/2008      5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006      5      Hscm8clr-namespace:System.ComponentModel;assembly=WindowsBase      5      +vmclr-namespace:lab5.ViewModel      5      $localclr-namespace:lab5      5	      ^iPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.Interactivity      5
      Iscm18clr-namespace:System.ComponentModel;assembly=WindowsBase      6`   Ci1:http://schemas.microsoft.com/expression/2010/interactivity  6�   -   5        $��
mainWindow��5        � Title$  Inventory Control System��5      $	��350��6&   $	��525��63    � DataContext 5      ��    Locator �� Source# [   �� Path$
 Main�.��5      � ���	#FFECEAEA � 	Resources 5   
     SortedItems �� Source �� SortDescriptions+   %System.ComponentModel.SortDescription   PropertyName��%n   &	       �� 5       67   �� *
MemberList+ 5        5      $ 	ProductId��6+   5      5      .+�5   
   �� -   5         ��Name$ button��5      $	��Add��6!   $��1��6/   $��1��6=   $
��Left=�5   ,   $	��Top=�6G   $��75��5      $��0,50,0,0q�6   ��5      �� *
AddCommand+5      �� 5   
   -   5        $ button2��5      $
��Exit��6"   $��1��61   $��1��6?   $
��Left=�5      $��Bottom=�6(   $��75��6C   $��0,0,0,50q�6N   ��5      �� *ExitCommand+��6-   �� 	 �� ElementName$	 
mainWindow��5   N   �� 5   
   -   5        
 ��Name$
 listBox��5      $��1��5      $��0��6    $��Center=�61   $��Center=�6N   $	��220��6i   $	��322��6v   ��5   #   �� # [  �� SelectedItem 6_   �� *SelectedMember+.  (System.Windows.Interactivity.Interaction   Triggers 5      /  )System.Windows.Interactivity.EventTrigger  5         	EventName$ MouseUp��6"   .  (System.Windows.Interactivity.TriggerBase   Actions. 5       6  0System.Windows.Interactivity.InvokeCommandAction     Command 6-   �� *ChangeCommand+5!      5#      �� 5$   
   -   5         ��Name$ label��5$      $��	Products:��6   $��0��63   $��0��6A   $
��Left=�5%      $��Bottom=�6(    � ColumnDefinitions 5&   
   �� 5'      $	��380 �6   �� 5(       � RowDefinitions 5*   
   �� 5+      $��* �6   �� 5,      $	��250 �6   �� 5-      $��* �6   5/      50      