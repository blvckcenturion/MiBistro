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
    /// Interaction logic for IngredientsList.xaml
    /// </summary>
    public partial class IngredientsList : Window
    {

        Restaurant miBistro = new Restaurant();

        public IngredientsList()
        {
            InitializeComponent();
            ingredientsGrid.ItemsSource = miBistro.AvailableIngredients;
        }
    }
}
