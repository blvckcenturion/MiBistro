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
    /// Interaction logic for BuyDishes.xaml
    /// </summary>
    public partial class BuyDishes : Window
    {
        List<Dish> availableDishes;
        List<OrderItem> items = new List<OrderItem>();

        public BuyDishes(List<Dish> _availableDishes)
        {
            InitializeComponent();
            availableDishes = _availableDishes;
            dishListGrid.ItemsSource = availableDishes;   
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (items.Count != 0)
            {
                int total = 0;
                foreach (OrderItem item in items) total += item.SubTotal;
                MessageBox.Show("El total de su orden es: " + total);
            }
        }

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            if (dishBox.Text != "")
            {
                foreach(Dish dish in availableDishes)
                {
                    if(dish.Name.ToLower() == dishBox.Text.ToLower())
                    {
                        bool alreadyInItems = false;
                        foreach (OrderItem item in items)
                        {
                            if (dish.Name == item.Name)
                            {
                                alreadyInItems = true;
                                item.Quantity += 1;
                                item.SubTotal = item.Quantity * item.dish.Price;
                            }
                        }
                        if (!alreadyInItems) items.Add(new OrderItem(dish));
                        orderItemGrid.ItemsSource = null;
                        orderItemGrid.ItemsSource = items;
                    }
                }
            }
        }
    }
}
