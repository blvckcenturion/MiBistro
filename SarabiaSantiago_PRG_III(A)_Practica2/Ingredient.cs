using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SarabiaSantiago_PRG_III_A__Practica2
{
    public class Ingredient
    {
        public int Id { get; }
        public string Name { get; }
        public int Price { get; }

        public IngredientCategory Category { get; set; }

        public Ingredient(string _name, int _price, IngredientCategory _category, int _id)
        {
            Id = _id;
            Name = _name;
            Price = _price;
            Category = _category;
        }
    }
}
