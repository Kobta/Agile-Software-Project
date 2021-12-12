using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
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

    public partial class ShoppingList : Page
    {
        public ShoppingList()
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
                SListB s = new SListB();
                this.dgrid.ItemsSource = s.GetSList().DefaultView;
            }
            catch
            {
                MessageBox.Show("Something went wrong");
            }
        }
    }
}
