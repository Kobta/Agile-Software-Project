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
    public partial class AddRecipe : Page
    {
        public ObservableCollection<IngredientsListItem> GridIngredients { get; set; }
        public AddRecipe()
        {
            InitializeComponent();

            //this containes all ingredients
            GridIngredients = new ObservableCollection<IngredientsListItem>();
            DataContext = this;

        }
     

        //back
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("UI/Home.xaml", UriKind.Relative));
        }


        //Add recipe to database
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //get textbox inputs
            string name = this.rname.Text.ToString();
            string ctg = this.rcategory.Text.ToString();
            int aop = Convert.ToInt32(this.portions.Text);
            string inst = this.Inst.Text.ToString();

            //create object
            AddRecipeB ad = new AddRecipeB();

            //send textboxes forward and get result
            int result = ad.AddRecipes(name, ctg, aop, inst);

            //send datagrid ingredients forward and get result
            int result2 = ad.AddRecipes(GridIngredients);

            //test if succesful
            if (result > 0 && result2 > 0)
            {
                MessageBox.Show("Recipe Added");
            }
            else
            {
                MessageBox.Show("Something went wrong.");
            }


        }
    }

    


}
