using System;
using FactoryMethod.Products;

namespace FactoryMethod.Factory
{
    public class Spaghetteria : Restaurant
    {
        public override Meal CookMeal()
        {
            return new Spaghetti();
        }

        public Spaghetti CookSpaghetti(SpaghettiType spaghettiType)
        {
            switch (spaghettiType)
            {
                case SpaghettiType.Bolognese:
                    return new Bolognese();
                case SpaghettiType.Napoli:
                    return new Napoli();
                case SpaghettiType.Pesto:
                    return new Pesto();
                default:
                    throw new NullReferenceException("The requested type is not available.");
            }
        }
        
        public override bool IsValid(Meal meal)
        {
            return base.IsValid(meal) && ((Spaghetti) meal).Weight > 0;
        }
    }
}
