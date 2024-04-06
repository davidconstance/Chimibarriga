using System;
using System.Collections.Generic;
using System.Linq;

namespace ChimiMiBarriga
{
    public class Hamburger
    {
        public string BreadType { get; }
        public string Meat { get; }
        public double BasePrice { get; }
        public List<Ingredient> AdditionalIngredients { get; }

        public Hamburger(string breadType, string meat, double basePrice)
        {
            BreadType = breadType;
            Meat = meat;
            BasePrice = basePrice;
            AdditionalIngredients = new List<Ingredient>();
        }

        public void AddIngredient(Ingredient ingredient)
        {
            if (AdditionalIngredients.Count < 4)
            {
                AdditionalIngredients.Add(ingredient);
            }
            else
            {
                Console.WriteLine("Maximum number of additional ingredients reached.");
            }
        }

        public double CalculateTotalPrice()
        {
            double totalPrice = BasePrice + AdditionalIngredients.Sum(ingredient => ingredient.Price);
            return totalPrice;
        }

        public void DisplayPriceDetails()
        {
            Console.WriteLine($"Hamburger Details:");
            Console.WriteLine($"Bread Type: {BreadType}");
            Console.WriteLine($"Meat: {Meat}");
            Console.WriteLine($"Base Price: ${BasePrice}");
            Console.WriteLine($"Additional Ingredients:");
            foreach (var ingredient in AdditionalIngredients)
            {
                Console.WriteLine($"- {ingredient.Name}: ${ingredient.Price}");
            }
            Console.WriteLine($"Total Price: ${CalculateTotalPrice()}");
        }
    }
}
