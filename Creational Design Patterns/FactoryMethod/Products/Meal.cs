using System;

namespace FactoryMethod.Products
{
    public abstract class Meal
    {
        public decimal Price { get; set; }
        public  Guid ArticleNumber { get; set; }
        public int NumberOfOrders { get; set; }
        public virtual bool IsValid()
        {
            return ArticleNumber != Guid.Empty;
        }
    }
}
