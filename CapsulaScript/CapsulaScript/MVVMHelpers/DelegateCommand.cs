using System;
using System.Diagnostics;
using System.Windows.Input;

namespace MVVMUtils
{
    /// <summary>
    /// A command whose sole purpose is to relay its functionality to other
    /// objects by invoking delegates. The default return value for the
    /// CanExecute method is 'true'.
    /// </summary>
    public class DelegateCommand : ICommand
    {
        /// <summary>
        /// implementation of the canExecuteChanged event for ICommand interface
        /// </summary>
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        private readonly Action<object> _execute;
        private readonly Action _executeSP;
        private readonly Func<bool> _canExecute;
        /// <summary>
        /// Creates a new command.
        /// </summary>
        /// <param name="execute">The execution logic.</param>
        /// <param name="canExecute">The execution status logic.</param>
        public DelegateCommand(Action<object> execute, Func<bool> canExecute = null)
        {
            _execute = execute ?? throw new ArgumentNullException(nameof(execute));
            _canExecute = canExecute;
        }

        public DelegateCommand(Action execute, Func<bool> canExecute = null)
        {
            _executeSP = execute ?? throw new ArgumentNullException(nameof(execute));
            _canExecute = canExecute;
        }

        /// <summary>
        /// parameterless implementation for canExecute, ignores parameter
        /// </summary>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public bool CanExecute(object parameters)
        {
            return _canExecute?.Invoke() ?? true;
        }

        /// <summary>
        /// explicit implementation of execute method for a void type of method
        /// </summary>
        /// <param name="parameters"></param>
        public void Execute(object parameters)
        {
            if (_executeSP == null)
            {
                _execute(parameters);
            }
            else
            {
                _executeSP();
            }
            CommandManager.InvalidateRequerySuggested();
        }
    }
}
