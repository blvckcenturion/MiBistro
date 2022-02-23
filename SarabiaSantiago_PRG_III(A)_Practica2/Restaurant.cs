using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SarabiaSantiago_PRG_III_A__Practica2
{
    public enum IngredientCategory
    {
        Frutas,
        Carnes,
        Hierbas,
        Vegetales,
        Derivados,
        Otros
    }

    public enum DishCategory
    {
        Ensalada,
        Sopa,
        Entrada,
        PlatoPrincipal,
        Postre
    }


    internal class Restaurant
    {
        private List<Dish> dishes = new List<Dish>();
        public List<Dish> Dishes { get { return dishes; } }
        
        private List<Ingredient> availableIngredients = new List<Ingredient>(); 
        public List<Ingredient> AvailableIngredients { get { return availableIngredients;} }

        private string basePath = @"C:\Users\blvck\source\repos\SarabiaSantiago_PRG_III(A)_Practica2\storage\";

        public Restaurant()
        {
            string ingredientsPath = basePath + "Ingredients.txt";
            string dishesPath = basePath + "Dishes.txt";

            foreach (string line in File.ReadLines(ingredientsPath))
            {
                string[] parts = line.Split(';');
                availableIngredients.Add(new Ingredient(parts[1], int.Parse(parts[2]), (IngredientCategory) int.Parse(parts[3]), int.Parse(parts[0])));
            }

            foreach(string line in File.ReadLines(dishesPath))
            {
                string[] parts = line.Split(';');
                string[] ingredients = parts[1].Split(',');
                List<Ingredient> ingredientList = new List<Ingredient>();
                int price = 0;
                foreach (string ing in ingredients) ingredientList.Add(availableIngredients[int.Parse(ing)]);
                foreach (Ingredient ingredient in ingredientList) price += ingredient.Price;
                dishes.Add(new Dish(parts[0], price, (DishCategory)int.Parse(parts[2]), ingredientList));
            }
        }

        public List<Dish> filterByAbsent(List<Ingredient> ingredients)
        {
            List<Dish> dishResult = new List<Dish>();
            foreach (Dish dish in dishes)
            {
                bool validDish = true;
                foreach (Ingredient ingredient in ingredients)
                {
                    if(dish.Ingredients.Contains(ingredient) == true)
                    {
                        validDish  = false;
                        break;
                    }
                }
                if (validDish) dishResult.Add(dish);
            }
            return dishResult;
        }

        public List<Dish> filterByPresent(List<Ingredient> ingredients)
        {
            List<Dish> dishResult = new List<Dish>();
            foreach (Dish dish in dishes)
            {
                // seleccion de ingredientes de tipo OR por lo que si se encuentra uno de los ingredientes presentes directamente es agregado a la lista
                foreach (Ingredient ingredient in ingredients)
                {
                    if (dish.Ingredients.Contains(ingredient) == true && dishResult.Contains(dish) == false)
                    {
                        dishResult.Add(dish);
                    }
                }

                // seleccion de ingredientes de tipo AND que solamente agrega un platillo si cuenta con todos los elementos presentes
                //bool isValid = true;
                //foreach (Ingredient ingredient in ingredients)
                //{
                //    if (dish.Ingredients.Contains(ingredient) != true)
                //    {
                //        isValid = false;
                //        break;
                //    }
                //}
                //if (isValid) dishResult.Add(dish);
            }
            return dishResult;
        }

        public List<Dish> filterByBoth(List<Ingredient> absentIngredients, List<Ingredient> presentIngredients)
        {
            List<Dish> presentDishes = filterByPresent(presentIngredients);
            List<Dish> absentDishes = filterByAbsent(absentIngredients);
            List<Dish> both = presentDishes.Intersect(absentDishes).ToList();
            return both;
        }
    }
}
