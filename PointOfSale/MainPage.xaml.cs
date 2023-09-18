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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Window
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void DashboardButton_Click(object sender, RoutedEventArgs e)
        {
            //dashboardUserControl.Visibility = Visibility.Visible;
            // Hide other UserControls if necessary
            contentControl.Content = new Dashboard();
        }

        private void EmployeesButton_Click(object sender, RoutedEventArgs e)
        {
            // Show Employees UserControl, hide others
        }

        private void ProductsButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
    }
