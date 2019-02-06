using FactoryMethod.Factory;

namespace FactoryMethod.Products
{
    public class MyObject
    {
        private static MyFactory _factory = new MyFactory();
        private string _anAttribute;
        public MyObject(string anAttribute)
        {
            _factory = new MyFactory();
            this._anAttribute = anAttribute;
        }
        public static MyFactory GetFactory()
        {
            return _factory;
        }

        public override string ToString()
        {
            return _anAttribute;
        }
    }
}
