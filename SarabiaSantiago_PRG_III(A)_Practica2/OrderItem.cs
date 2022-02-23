using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SarabiaSantiago_PRG_III_A__Practica2
{
    internal class OrderItem
    {
        public string Name { get; }
        public int Quantity { get; set; }

        public int SubTotal { get; set; }

        public Dish dish { get; }

        public OrderItem(Dish _dish)
        {
            Quantity = 1;
            dish = _dish;
            Name = _dish.Name;
            SubTotal = _dish.Price;
        }


    }
}
