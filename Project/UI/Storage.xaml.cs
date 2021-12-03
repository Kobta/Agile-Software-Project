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
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Project
{
    public partial class Storage : Page
    {
        public Storage()
        {
            InitializeComponent();
            FillDataGrid();
        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("UI/Home.xaml", UriKind.Relative));
        }


        private void FillDataGrid()
        {
            try
            {
                StorageB s = new StorageB();
                this.dgrid.ItemsSource = s.GetStorage().DefaultView;
            }
            catch
            {
                MessageBox.Show("I'm a Datagnome, pls be patient");
            }
        }

        private void TextBox_TextChanged(Object sender, TextChangedEventArgs e)
        { 
             if(textb1.Text.Trim().Length > 0)
             {
                try
                {
                    StorageB s = new StorageB();
                    this.dgrid.ItemsSource = s.GetStorage(this.textb1.Text).DefaultView;
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

    }
}
