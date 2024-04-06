namespace ChimiMiBarriga
{
    public class PremiumBurger : Hamburger
    {
        public PremiumBurger(string meat, double basePrice) : base("Brioche", meat, basePrice)
        {
            AddIngredient(new Ingredient("Papitas", 2.50));
            AddIngredient(new Ingredient("Bebida", 1.50));
        }

        public override void AddIngredient(Ingredient ingredient)
        {
            Console.WriteLine("Cannot add additional ingredients to Premium Burger.");
        }
    }
}
