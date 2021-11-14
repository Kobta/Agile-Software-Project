﻿using System;
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
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Project
{
    /// <summary>
    /// Interaction logic for Storage.xaml
    /// </summary>
    public partial class Storage : Page
    {
        public Storage()
        {
            InitializeComponent();
            FillDataGrid();
        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Home.xaml", UriKind.Relative));
        }

        private void TextBox_TextChanged(Object sender, TextChangedEventArgs e)
        {
            var tb = sender as TextBox;
            if(tb.Text != "")
            {
               // lisää sql setit
            }
        }

        private void FillDataGrid()
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;user id=root;database=applicationproject;sslmode=None");
            connection.Open();

            string Query = "select name, category, baseUnit from foodstuff";
            MySqlCommand command = new MySqlCommand(Query, connection);
            command.ExecuteNonQuery();

            MySqlDataAdapter dataAdp = new MySqlDataAdapter(command);
            DataTable dt = new DataTable("foodstuff");
            dataAdp.Fill(dt);
            dgrid.ItemsSource = dt.DefaultView;
            dataAdp.Update(dt);
        }

    }
}