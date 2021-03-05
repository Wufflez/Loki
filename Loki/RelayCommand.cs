using System;
using System.Windows.Input;

namespace Loki
{
    public class RelayCommand : ICommand
    {
        private readonly Action<object> _execute;
        private readonly Func<object, bool> _canExecute;

        public RelayCommand(Action<object> execute, Func<object, bool> canExecute = null)
        {
            _execute = execute;
            _canExecute = canExecute;
        }

        public bool CanExecute(object param) => _canExecute?.Invoke(param) ?? true;
        public void Execute(object param) => _execute(param);
        public event EventHandler CanExecuteChanged;
    }
}
