using System;
using System.Diagnostics;

namespace FactoryMethod.Products
{
    public class ChickenNuggets : Meal
    {
        public int NumberPerPack { get; set; }
        public ChickenNuggets()
        {
            ArticleNumber = Guid.NewGuid();
            Debug.Print("Create Chicken Nuggets");
        }

        public override bool IsValid()
        {
            return base.IsValid() && NumberPerPack > 0;
        }
    }
}
