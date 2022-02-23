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
using System.Windows.Shapes;

namespace SarabiaSantiago_PRG_III_A__Practica2
{
    /// <summary>
    /// Interaction logic for FilteredDishes.xaml
    /// </summary>
    public partial class FilteredDishes : Window
    {
        List<Dish> dishes;
        public FilteredDishes(List<Dish> _dishes)
        {
            InitializeComponent();
            dishes = _dishes;
            filteredGrid.ItemsSource = dishes;
        }

        private void buyBtn_Click(object sender, RoutedEventArgs e)
        {
            new BuyDishes(dishes).Show();
        }
    }
}
