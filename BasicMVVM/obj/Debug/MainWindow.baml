   M S B A M L   `   `   `  ����D  @BasicMVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:BasicMVVM.ViewModelsBasicMVVM.ViewModels  5   	       BasicMVVM.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   8	viewmodel"clr-namespace:BasicMVVM.ViewModels     5   	   $	��350��5   !   $	��525��6.     � Title  6	   �� *Title+ � DataContext 5      $   BasicMVVM.ViewModels.ViewModel  5   
   .��5	      � .+�5
   
   �� -   5        $��cmdSetTitle��5
   K   $��Change Title��64   $��	0,0,0,270q�6^   ��6   �� *SetTextCommand+6^   �� 5   
   -   5        $��
cmdAddItem��5   G   $��Add Item��64   $��
0,50,0,220q�6Y   ��6   �� *AddItemCommand+6Y   �� 5   
   -   5        $��cmbItems��5   J    �� DisplayMemberPath$
 Name��6   $��0,158,319,108q�6Z    �� SelectedValuePath$ Value��5      ��5   ,   �� *Items+ �� SelectedItem 5      �� *SelectedItem+�� 5   
   -   5        $��
textBlock1��5      $��200,159,0,108q�6I   ��6&   �� *SelectedItem.Name+6I   �� 5   
   $��Show Question��6>   $��0,254,331,0q�6V   ��6   �� *ShowYesNoQuestionCommand+6V   �� 5   
   $��191,254,0,0q�6,   ��6   �� *Answer+6,   5      5      