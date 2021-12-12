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
                RecipeListB m = new RecipeListB();
                this.recipe.ItemsSource = m.GetRecipeList().DefaultView;
            }
            catch
            {
                MessageBox.Show("I'm a Datagnome, pls be patient");
            }
        }
        //search
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (textS.Text.Trim().Length > 0)
            {
                try
                {
                    RecipeListB r = new RecipeListB();
                    this.recipe.ItemsSource = r.GetRecipeList(this.textS.Text).DefaultView;
                }
                catch
                {
                    MessageBox.Show("I'm a Datagnome, pls be patient");
                }
            }
            else
            {
                FillDataGrid();
            }

        }

        public List<string> RecipeNames = new List<string>();

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //avaa reseptin tarkemmat tiedot textboxisssa ( ei toimim vieläm)
            try
            {
                //get the row value for the sql query
                DataGrid recipe = sender as DataGrid;
                DataGridRow row = (DataGridRow)recipe.ItemContainerGenerator.ContainerFromIndex(recipe.SelectedIndex);
                DataGridCell RowColumn = recipe.Columns[3].GetCellContent(row).Parent as DataGridCell;
                int CellValue = Convert.ToInt32(((TextBlock)RowColumn.Content).Text);

                RecipeListB i = new RecipeListB();
                this.textR.Text = i.GetRecipeLists(CellValue);
            }
            catch
            {
                MessageBox.Show("I'm a Datagnome, pls be patient");
            }

            
        }
            private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //tää siirtää valitun reseptin mealsiin.
            //datagrid selection objektina ja siitä tiedot tietokantaan tai
            //sit samanalailla kuin add recipe että siellä on observablecollection, entiedä vielä kumpi on parempi.
        }
    }
}
