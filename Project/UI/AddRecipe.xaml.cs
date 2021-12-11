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

            //Nämä luovat muokattavan datagridin sisällön
            //kaikki datagridin inputit menee yhteen collectioniin josta voi sitten poimia mitä haluaa tietokantaan
            GridIngredients = new ObservableCollection<IngredientsListItem>();
            DataContext = this;

        }
     

        //back
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("UI/Home.xaml", UriKind.Relative));
        }


        //lisää tiedot tietokantaan
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //ota kaikkien textboxien inputit
            string name = this.rname.Text.ToString();
            string ctg = this.rcategory.Text.ToString();
            int aop = Convert.ToInt32(this.portions.Text);
            string inst = this.Inst.Text.ToString();

            //luodaan objekti
            AddRecipeB ad = new AddRecipeB();

            //lähetetään textbox eteenpäin
            int result = ad.AddRecipes(name, ctg, aop, inst);

            //datagrid
            int result2 = ad.AddRecipes(GridIngredients);

            //testataan onnistuiko
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
