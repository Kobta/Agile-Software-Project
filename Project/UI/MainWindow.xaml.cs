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
    public partial class MainWindow : Window
    {
        //Same window, different pages
        public MainWindow()
        {
            InitializeComponent();
            Main.NavigationService.Navigate(new Uri("UI/Home.xaml", UriKind.Relative));
        }

    }
}
