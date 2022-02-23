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
    /// Interaction logic for PickDish.xaml
    /// </summary>
    public partial class PickDish : Window
    {
        Restaurant miBistro = new Restaurant();
        List<Ingredient> presentIngredients = new List<Ingredient>();
        List<Ingredient> absentIngredients = new List<Ingredient>();
        public PickDish()
        {
            InitializeComponent();
        }

        private void cleanBtn_Click(object sender, RoutedEventArgs e)
        {
            presentIngredients.Clear();
            presentGrid.ItemsSource = null;
            absentIngredients.Clear();
            absentGrid.ItemsSource = null;
        }

        private void absentBtn_Click(object sender, RoutedEventArgs e)
        {
            if (validate(absentBlock.Text, presentIngredients, absentIngredients))
            {
                List<Ingredient> ing = miBistro.AvailableIngredients;
                for (int i = 0; i < ing.Count; i++)
                {
                    if (absentBlock.Text.ToLower() == ing[i].Name.ToLower())
                    {
                        absentIngredients.Add(ing[i]);
                    }
                }
                absentGrid.ItemsSource = null;
                absentGrid.ItemsSource = absentIngredients;
            }
        }

        private void presentBtn_Click(object sender, RoutedEventArgs e)
        {
            if (validate(presentBlock.Text, absentIngredients, presentIngredients))
            {
                List<Ingredient> ing = miBistro.AvailableIngredients;
                for (int i = 0; i < ing.Count; i++)
                {
                    if (presentBlock.Text.ToLower() == ing[i].Name.ToLower())
                    {
                        presentIngredients.Add(ing[i]);
                    }
                }
                presentGrid.ItemsSource = null;
                presentGrid.ItemsSource = presentIngredients;
            }
        }

        public bool validate(string value, List<Ingredient> other, List<Ingredient> main)
        {
            errorTxt.Visibility = Visibility.Hidden;
            bool returnValue = false;
            if(value != "")
            {
                foreach(Ingredient ing in miBistro.AvailableIngredients)
                {
                    if (ing.Name.ToLower() == value.ToLower()) returnValue = true;
                }   

                if(returnValue)
                {
                    foreach (Ingredient ing in other)
                    {
                        if (ing.Name.ToLower().Equals(value.ToLower())) {
                            errorTxt.Visibility = Visibility.Visible;
                            errorTxt.Text = "el producto ingresado se encuentra en otra lista.";
                            returnValue = false;
                        } 
                    }

                    foreach (Ingredient ing in main)
                    {
                        if (ing.Name.ToLower().Equals(value.ToLower()))
                        {
                            errorTxt.Visibility = Visibility.Visible;
                            errorTxt.Text = "el producto ingresado ya esta en la lista.";
                            returnValue = false;
                        }
                    }
                } else
                {
                    errorTxt.Visibility = Visibility.Visible;
                    errorTxt.Text = "el producto ingresado no esta en la lista de ingredientes.";
                }


            }
            return returnValue;
        }


        public void addToList(string element, List<Ingredient> ingList)
        {
            List<Ingredient> ing = miBistro.AvailableIngredients;
            for (int i =0; i < ing.Count; i++)
            {
                if(element.ToLower() == ing[i].Name.ToLower())
                {
                    ingList.Add(ing[i]);
                }
            }
        }

        private void filterBtn_Click(object sender, RoutedEventArgs e)
        {
            errorTxt.Visibility = Visibility.Hidden;

            if (absentCheck.IsChecked == false && presentCheck.IsChecked == false)
            {
                errorTxt.Visibility = Visibility.Visible;
                errorTxt.Text = "Ninguno de los filtros fue seleccionado";
                return;
            } else if(presentCheck.IsChecked == true && absentCheck.IsChecked == true)
            {
                if (presentIngredients.Count == 0 && absentIngredients.Count == 0)
                {
                    errorTxt.Visibility = Visibility.Visible;
                    errorTxt.Text = "No existe ningun elemento seleccionado";
                    return;
                }
                showFiltered(miBistro.filterByBoth(absentIngredients, presentIngredients));
            } else if(presentCheck.IsChecked == true)
            {
                if (presentIngredients.Count == 0)
                {
                    errorTxt.Visibility = Visibility.Visible;
                    errorTxt.Text = "No existe ningun elemento seleccionado";
                    return;
                }
                showFiltered(miBistro.filterByPresent(presentIngredients));
            } else
            {
                if (absentIngredients.Count == 0)
                {
                    errorTxt.Visibility = Visibility.Visible;
                    errorTxt.Text = "No existe ningun elemento seleccionado";
                    return;
                }
                showFiltered(miBistro.filterByAbsent(absentIngredients));
            }
        }


        public void showFiltered(List<Dish> dishes)
        {
            if (dishes.Count <= 0)
            {
                errorTxt.Visibility = Visibility.Visible;
                errorTxt.Text = "No se encontro ningun elemento con estas caracteristicas";
                return;
            }
            new FilteredDishes(dishes).Show();
        }
    }
}
