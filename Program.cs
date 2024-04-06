using System;

namespace ChimiMiBarriga
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ejemplo de uso
            Hamburger classicBurger = new Hamburger("Regular", "Beef", 5.00);
            classicBurger.AddIngredient(new Ingredient("Lettuce", 0.50));
            classicBurger.AddIngredient(new Ingredient("Tomato", 0.75));
            classicBurger.DisplayPriceDetails();

            Console.WriteLine();

            HealthyBurger healthyBurger = new HealthyBurger("Turkey", 6.50);
            healthyBurger.AddIngredient(new Ingredient("Avocado", 1.00));
            healthyBurger.AddIngredient(new Ingredient("Spinach", 0.75));
            healthyBurger.DisplayPriceDetails();

            Console.WriteLine();

            PremiumBurger premiumBurger = new PremiumBurger("Chicken", 8.50);
            premiumBurger.DisplayPriceDetails();

            Console.ReadLine();
        }
    }
}
