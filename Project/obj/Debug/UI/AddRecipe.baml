   M S B A M L   `   `   `  ����  Project    Project.AddRecipe   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5        N� Title$  	AddRecipe��5      .��5
      � .+�5   
   �� -   5        $
��Back��5      $
��Left=�6    $��	10,10,0,0q�6;   $	��Top=�6N   $��81��6f   $��36��6q   ���	#FF2749E2
�������$��20(�6�   �� 5   
   -   5        $��
Add Recipe��5      $
��Left=�6&   $��1103,625,0,0q�6A   $	��Top=�6W   $	��117��6o   $��45��6{   ���	#FF2749E2
�������$��20(�6�   �� 5   
   -   5        $��rname��5      $��Center=�6   $��30��6<   $��450,190,699,0q�6H    �� TextWrapping$
 Wrap=�6_   $��Recipe Name��6s   $	��Top=�6�   $	��131��6�   $��20(�6�   �� 5   
   -   5        $��	rcategory��5      $��Center=�6#   $��30��6@   $��655,190,464,0q�6L   $
 Wrap=�6c   $��Recipe Category��6w   $	��Top=�6�   $	��161��6�   $��20(�6�   �� 5   
   -   5        $��portions��5      $��Center=�6"   $��30��6?   $��878,243,307,0q�6K   $
 Wrap=�6b   $��Portions��6v   $	��Top=�6�   $��95��6�   $��20(�6�    J� RenderTransformOrigin$ 3.165,8.537&�6�   �� 5   
   -   5        $
��Inst��5      $��Center=�6   $	��325��6;   $��137,345,762,0q�6H   $
 Wrap=�6_   $��Instructions��6s   $	��Top=�6�   $	��381��6�   $��20(�6�   �� 5   
   $��
Add Recipe��6   $��Center=�6%   $��541,32,561,0q�6B   $	��Top=�6X   $��30(�6p   $	��178��6~   ���	#FF240EFF6�   �� 5   
   $(��"First add the name of your recipe:��6   $
��Left=�6=   $��137,183,0,0q�6X   $	��Top=�6m   $��20(�6�   �� 5   
   $	��and��6   $
��Left=�6   $��598,187,0,0q�69   $	��Top=�6N   $��33��6f   $��20(�6r   �� 5   
   $V��PNow add the portions of the recipe (How many plates of food this recipe creates)��6   $
��Left=�6k   $��137,236,0,0q�6�   $	��Top=�6�   $��20(�6�   �� 5   
   $H��BNow list the ingredients of the recipe and write the instructions.��6   $
��Left=�6]   $��137,303,0,0q�6x   $	��Top=�6�   $��20(�6�   &   System.Windows.Controls.DataGrid  5   
   -   5        $��Ingredients��5      $
��Left=�6&   $	��325��6A   $��541,345,0,0q�6N   $	��Top=�6c   $	��503��6{      AutoGenerateColumns .     CanUserAddRows .    CanUserDeleteRows . ��5   "   �� *GridIngredients+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 
Ingredient��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 69   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6C   �� *
Ingredient+  5       $ Amount��6%   $ * 66   	 6@   �� *Amount+  5!      $ Weight unit��6%   $ * 6W   	 6:   �� *
UnitName+6W   5$      5%      5&      