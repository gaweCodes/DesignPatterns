using System;
using System.Windows.Input;

namespace ModelViewVieModelDemo
{
    internal class Command : ICommand
    {
        private readonly Action<object> _codeToExecute;
        private readonly Predicate<object> _canExecute;
        public Command(Action<object> codeToExecute, Predicate<object> canExecute)
        {
            _codeToExecute = codeToExecute;
            _canExecute = canExecute;
        }
        public bool CanExecute(object parameter) => _canExecute?.Invoke(parameter) ?? true;
        public void Execute(object parameter) => _codeToExecute(parameter);
        public event EventHandler CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }
    }
}
