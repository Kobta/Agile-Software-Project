using System;
using System.Collections.Generic;
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
    public partial class Home : Page
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Category_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("UI/Recipe.xaml", UriKind.Relative));
        }

        private void Category_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            //testailen jossain vaiheessa, jos saan ennakoivan tekstin toimimaan
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //storage
           this.NavigationService.Navigate(new Uri("UI/Storage.xaml", UriKind.Relative));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //planned meals
            this.NavigationService.Navigate(new Uri("UI/PlannedMeals.xaml", UriKind.Relative));
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //addrecipe
            this.NavigationService.Navigate(new Uri("UI/AddRecipe.xaml", UriKind.Relative));
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            //shoppinglist
            this.NavigationService.Navigate(new Uri("UI/ShoppingList.xaml", UriKind.Relative));
        }
    }
}
