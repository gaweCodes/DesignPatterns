using System;
using FactoryMethod.Products;

namespace FactoryMethod.Factory
{
    public abstract class Restaurant
    {
        public abstract Meal CookMeal();

        public void ServeMeal()
        {
            var meal = CookMeal();
            if (!meal.IsValid())
                throw new ArgumentException("The current meal is invalid.");
            Console.Write("This is your meal");
        }

        public virtual bool IsValid(Meal meal)
        {
            return meal.ArticleNumber != Guid.Empty;
        }
    }
}
