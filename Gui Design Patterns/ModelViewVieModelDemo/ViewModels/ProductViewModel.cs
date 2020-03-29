using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using ModelViewVieModelDemo.Annotations;
using ModelViewVieModelDemo.Models;

namespace ModelViewVieModelDemo.ViewModels
{
    internal class ProductViewModel : INotifyPropertyChanged
    {
        private ProductModel _currentProduct;
        private ICommand _incrementPriceCommand;
        private ICommand _previousCommand;
        private ICommand _nextCommand;
        public event PropertyChangedEventHandler PropertyChanged;
        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        private ObservableCollection<ProductModel> _products;
        public ProductViewModel() => LoadProducts();
        public ObservableCollection<ProductModel> Products { get; private set; }
        public ProductModel CurrentProduct
        {
            get => _currentProduct;
            set
            {
                _currentProduct = value;
                OnPropertyChanged(nameof(CurrentProduct));
            }
        }
        public bool CanDelete => _currentProduct != null;
        public ICommand IncrementPriceCommand => _incrementPriceCommand ?? (_incrementPriceCommand = new Command(
            x => CurrentProduct.PricePerPiece += 100,
            x => CurrentProduct != null));
        public ICommand NextCommand =>
            _nextCommand ?? (_nextCommand =
                new Command(x => CurrentProduct = _products[_products.IndexOf(CurrentProduct) + 1],
                    x => CurrentProduct != _products[_products.Count - 1]));
        public ICommand PreviousCommand => _previousCommand ?? (_previousCommand = new Command(
            x => CurrentProduct = _products[_products.IndexOf(CurrentProduct) - 1],
            x => CurrentProduct != _products[0]));
        private void LoadProducts()
        {
            _products = new ObservableCollection<ProductModel>
            {
                new ProductModel {ProductNumber = 1000, ProductText = "Smartphone", PricePerPiece = 499},
                new ProductModel {ProductNumber = 2000, ProductText = "Tablet", PricePerPiece = 669}
            };
            Products = _products;
            _currentProduct = _products[0];
        }
    }
}
