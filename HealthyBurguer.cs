namespace ChimiMiBarriga
{
    public class HealthyBurger : Hamburger
    {
        private const int MaxAdditionalIngredients = 6;

        public HealthyBurger(string meat, double basePrice) : base("Integral", meat, basePrice)
        {
        }

        public override void AddIngredient(Ingredient ingredient)
        {
            if (AdditionalIngredients.Count < MaxAdditionalIngredients)
            {
                AdditionalIngredients.Add(ingredient);
            }
            else
            {
                Console.WriteLine("Maximum number of additional ingredients reached.");
            }
        }
    }
}
