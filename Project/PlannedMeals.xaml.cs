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
    /// <summary>
    /// Interaction logic for PlannedMeals.xaml
    /// </summary>
    public partial class PlannedMeals : Page
    {
        public PlannedMeals()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Home.xaml", UriKind.Relative));
        }


        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // sql
        }


    }
}
