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

namespace SarabiaSantiago_PRG_III_A__Practica2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Restaurant miBistro = new Restaurant();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ingredientsBtn_Click(object sender, RoutedEventArgs e)
        {
            new IngredientsList().Show();
        }

        private void pickDishBtn_Click(object sender, RoutedEventArgs e)
        {
            new PickDish().Show();
        }

        private void dishesBtn_Click(object sender, RoutedEventArgs e)
        {
            new dishesList().Show();
        }

        private void orderBtn_Click(object sender, RoutedEventArgs e)
        {
            new BuyDishes(miBistro.Dishes).Show();
        }
    }
}
