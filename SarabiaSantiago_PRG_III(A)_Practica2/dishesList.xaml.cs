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
    /// Interaction logic for dishesList.xaml
    /// </summary>
    public partial class dishesList : Window
    {

        Restaurant miBistro = new Restaurant();

        public dishesList()
        {
            string line = @"======================================================================================";
            InitializeComponent();
            foreach (Dish dish in miBistro.Dishes)
            {
                dishListView.Items.Add(line);
                dishListView.Items.Add("Nombre: " + dish.Name + "\t Precio: " + dish.Price + "\t Categoria: " + dish.Category);
                dishListView.Items.Add(line);
                dishListView.Items.Add("*           Ingredientes           *");
                foreach(Ingredient ingredient in dish.Ingredients) dishListView.Items.Add(" -> " + ingredient.Name);
            }
        }
    }
}
