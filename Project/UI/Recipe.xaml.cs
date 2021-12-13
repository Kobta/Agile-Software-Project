using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Project
{
    public partial class Recipe : Page
    {
        //This string saves the chosen recipe name
        public string CellValue;
        public int CellID;

        public Recipe()
        {
            InitializeComponent();
            FillDataGrid();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //back
            this.NavigationService.Navigate(new Uri("UI/Home.xaml", UriKind.Relative));
        }

        //fill
        private void FillDataGrid()
        {
            try
            {
                //create object and get list of recipes
                RecipeListB m = new RecipeListB();
                this.recipe.ItemsSource = m.GetRecipeList().DefaultView;
            }
            catch
            {
                MessageBox.Show("Something went wrong");
            }
        }
        //search
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            //see if there is any text
            if (textS.Text.Trim().Length > 0)
            {
                try
                {
                    //create object and get result
                    RecipeListB r = new RecipeListB();
                    this.recipe.ItemsSource = r.GetRecipeList(this.textS.Text).DefaultView;
                }
                catch
                {
                    MessageBox.Show("Something went wrong");
                }
            }
            else
            {
                FillDataGrid();
            }

        }
        //get user selection
        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                //get the row value
                DataGrid recipe = sender as DataGrid;
                DataGridRow row = (DataGridRow)recipe.ItemContainerGenerator.ContainerFromIndex(recipe.SelectedIndex);
                DataGridCell RowColumn = recipe.Columns[0].GetCellContent(row).Parent as DataGridCell;
                CellValue = Convert.ToString(((TextBlock)RowColumn.Content).Text);

                DataGridCell RowColumn1 = recipe.Columns[3].GetCellContent(row).Parent as DataGridCell;
                CellID = Convert.ToInt32(((TextBlock)RowColumn1.Content).Text);

                //create object and get result
                RecipeListB i = new RecipeListB();
                this.textR.Text = i.ShowInstructions(CellValue);
                this.r_ing.ItemsSource = i.ShowIngredients(CellID).DefaultView;
            }
            catch
            {
                MessageBox.Show("Something went wrong");
            }

            
        }

            //send recipe to planned meals
            private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            int result = 0;

            //test that date and recipe have been selected
            if (this.DtP.SelectedDate != null && CellValue != "")
            {
                DateTime dt = (DateTime)DtP.SelectedDate;

                //format the date to database format
                string ddt = dt.ToString("yyyy-MM-dd HH:mm:ss");

                //create object and get result
                RecipeListB i = new RecipeListB();
                result = i.AddToMeal(CellValue, ddt, CellID);

                if (result > 0)
                {
                    MessageBox.Show("Recipe added to Planned Meals");
                }
                else
                {
                    MessageBox.Show("Something went wrong.");
                }
            }
            else
            {
                MessageBox.Show("Select date and recipe");
            }


        }

    }
}
