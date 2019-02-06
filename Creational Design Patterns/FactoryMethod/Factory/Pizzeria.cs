using FactoryMethod.Products;

namespace FactoryMethod.Factory
{
    public class Pizzeria : Restaurant
    {
        public override Meal CookMeal()
        {
            return new Pizza();
        }
        
        public override bool IsValid(Meal meal)
        {
            return base.IsValid(meal) && ((Pizza) meal).Diameter > 0;
        }
    }
}
