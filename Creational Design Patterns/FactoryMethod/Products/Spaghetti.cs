using System;
using System.Diagnostics;

namespace FactoryMethod.Products
{
    public class Spaghetti : Meal
    {
        public decimal Weight { get; set; }
        public Spaghetti()
        {
            ArticleNumber = Guid.NewGuid();
            Debug.Print("Create Spaghetti");
        }
        public override bool IsValid()
        {
            return base.IsValid() && Weight > 0;
        }
    }
}
