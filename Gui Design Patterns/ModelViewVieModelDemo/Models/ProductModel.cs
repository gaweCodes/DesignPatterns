using System.ComponentModel;
using System.Runtime.CompilerServices;
using ModelViewVieModelDemo.Annotations;

namespace ModelViewVieModelDemo.Models
{
    internal class ProductModel : INotifyPropertyChanged
    {
        private int _productNumber;
        private string _productText;
        private decimal _pricePerPiece;
        public event PropertyChangedEventHandler PropertyChanged;
        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        public int ProductNumber
        {
            get => _productNumber;
            set
            {
                _productNumber = value;
                OnPropertyChanged(nameof(ProductNumber));
            }
        }
        public string ProductText
        {
            get => _productText;
            set
            {
                _productText = value;
                OnPropertyChanged(nameof(_productText));
            }
        }
        public decimal PricePerPiece
        {
            get => _pricePerPiece;
            set
            {
                _pricePerPiece = value;
                OnPropertyChanged(nameof(PricePerPiece));
            }
        }
    }
}
