using System;
using System.Windows.Input;

namespace WpfApp1.Common {
    public class RelayCommand : ICommand {
        #region Members
        readonly Action<object> execute;
        readonly Predicate<object> canExecute;
        #endregion

        public RelayCommand(Action<object> execute,
           Predicate<object> canExecute = null) {
            this.execute = execute ?? throw new ArgumentNullException(nameof(execute));
            this.canExecute = canExecute;
        }

        public event EventHandler CanExecuteChanged {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }
        public bool CanExecute(object parameter) {
            return this.canExecute?.Invoke(parameter) ?? true;
        }
        public void Execute(object parameter) {
            this.execute.Invoke(parameter);
        }
    }
}
