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

        //Browse recipes
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("UI/Recipe.xaml", UriKind.Relative));
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
