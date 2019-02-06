using System;
using System.Diagnostics;

namespace FactoryMethod.Products
{
    public class Pizza : Meal
    {
        public decimal Diameter { get; set; }
        public string Name { get; set; }
        public Pizza()
        {
            ArticleNumber = Guid.NewGuid();
            Debug.Print("Create Pizza");
        }

        public override bool IsValid()
        {
            return base.IsValid() && string.IsNullOrEmpty(Name);
        }
    }
}
