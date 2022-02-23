using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SarabiaSantiago_PRG_III_A__Practica2
{
    public class Dish
    {
        public string Name { get; }
        public int Price { get; }
        public DishCategory Category { get; }

        private List<Ingredient> ingredients;

        public List<Ingredient> Ingredients { get { return ingredients; }}

        public Dish(string _name, int _price,DishCategory _dishCategory, List<Ingredient> _ingredients)
        {
            Name = _name;
            Price = _price;
            Category = _dishCategory;
            ingredients = _ingredients;
        }

    }
}
