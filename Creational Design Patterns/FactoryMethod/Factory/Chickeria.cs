using FactoryMethod.Products;

namespace FactoryMethod.Factory
{
    public class Chickeria : Restaurant
    {
        public override Meal CookMeal()
        {
            return new ChickenNuggets();
        }
        
        public override bool IsValid(Meal meal)
        {
            return base.IsValid(meal) && ((ChickenNuggets) meal).NumberPerPack > 0;
        }
    }
}
