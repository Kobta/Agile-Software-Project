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
    /// <summary>
    /// Interaction logic for ShoppingList.xaml
    /// </summary>
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
            this.NavigationService.Navigate(new Uri("Home.xaml", UriKind.Relative));
        }

        private void FillDataGrid()
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;user id=root;database=applicationproject;sslmode=None");
            connection.Open();
            string Query = "select items, executionDate from shoppinglist";
            MySqlCommand command = new MySqlCommand(Query, connection);
            command.ExecuteNonQuery();

            MySqlDataAdapter dataAdp = new MySqlDataAdapter(command);
            DataTable dt = new DataTable("shoppinglist");
            dataAdp.Fill(dt);
            dgrid.ItemsSource = dt.DefaultView;
            dataAdp.Update(dt);
        }
    }
}
