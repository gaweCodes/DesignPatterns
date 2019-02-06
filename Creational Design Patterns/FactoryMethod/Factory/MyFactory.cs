using FactoryMethod.Products;

namespace FactoryMethod.Factory
{
    public class MyFactory
    {
        private readonly string _defaultAttribute;

        public MyFactory()
        {

        }
        public MyFactory(string defaultAttribute)
        {
            _defaultAttribute = defaultAttribute;
        }
        public MyObject Create(string defaultAttribute)
        {
            return new MyObject(defaultAttribute);
        }

        public MyObject Create()
        {
            return  new MyObject(_defaultAttribute);
        }
    }
}
