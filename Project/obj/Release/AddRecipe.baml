   M S B A M L   `   `   `  ����   Project    Project.AddRecipe   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008       N� Title$  	AddRecipe��.��� .+��� -   $
��Back��$
��Left=�$��	10,10,0,0q�$	��Top=�$��81��$��36�����	#FF2749E2
�������$��20(��� -   $��
Add Recipe��$
��Left=�$��1103,625,0,0q�$	��Top=�$	��117��$��45�����	#FF2749E2
�������$��20(��� $��Center=�$��30��$��450,190,699,0q� �� TextWrapping$
 Wrap=�$��Recipe Name��$	��Top=�$	��131��$��20(��� $��Center=�$��30��$��655,190,496,0q�$
 Wrap=�$��Recipe type��$	��Top=�$	��129��$��20(��� $��Center=�$��30��$��878,243,307,0q�$
 Wrap=�$��Portions��$	��Top=�$��95��$��20(� J� RenderTransformOrigin$ 3.165,8.537&��� $��Center=�$	��325��$��137,345,762,0q�$
 Wrap=�$��Instructions��$	��Top=�$	��381��$��20(��� $��
Add Recipe��$��Center=�$��541,32,561,0q�$	��Top=�$��30(�$	��178�����	#FF240EFF�� $(��"First add the name of your recipe:��$
��Left=�$��137,183,0,0q�$	��Top=�$��20(��� $	��and��$
��Left=�$��598,187,0,0q�$	��Top=�$��33��$��20(��� $V��PNow add the portions of the recipe (How many plates of food this recipe creates)��$
��Left=�$��137,236,0,0q�$	��Top=�$��20(��� $H��BNow list the ingredients of the recipe and write the instructions.��$
��Left=�$��137,303,0,0q�$	��Top=�$��20(�&   System.Windows.Controls.DataGrid  -   $��Ingredients��$
��Left=�$	��325��$��541,345,0,0q�$	��Top=�$	��503��   AutoGenerateColumns .     CanUserAddRows .    CanUserDeleteRows . ���� *GridIngredients+   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ 
Ingredient��   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 �� *
Ingredient+  $ Amount��$ * 	 �� *Amount+  $ Weight unit��$ * 	 �� *
UnitName+