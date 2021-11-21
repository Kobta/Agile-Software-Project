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
    /// <summary>
    /// Interaction logic for AddRecipe.xaml
    /// </summary>
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
            this.NavigationService.Navigate(new Uri("Home.xaml", UriKind.Relative));
        }

        private void Ingredients_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        //lisää tiedot tietokantaan
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //ota kaikkien textboxien ja datagridin inputit ja lisää ne tietokantaan

        }

        private void Ingredients_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }
    }

    


}
