using System.Windows;
using ModelViewVieModelDemo.ViewModels;

namespace ModelViewVieModelDemo
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var vm = new ProductViewModel();
            ProductView.DataContext = vm;
            ProductView.IncrementPriceButton.DataContext = vm;
            ProductView.NextButton.DataContext = vm;
            ProductView.PreviousButton.DataContext = vm;

        }
    }
}
