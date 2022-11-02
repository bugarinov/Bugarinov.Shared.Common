using System;
using System.Windows.Input;

namespace Bugarinov.Shared.Common.Core
{
    public class DelegateCommand : ICommand
    {
        private readonly Action _action;
        private readonly Action<object> _action_obj;

        public DelegateCommand(Action action)
        {
            _action = action;
        }

        public DelegateCommand(Action<object> action)
        {
            _action_obj = action;
        }

        public void Execute(object parameter)
        {
            if (_action != null)
            {
                _action();
            }
            else
            {
                _action_obj?.Invoke(parameter);
            }

        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

#pragma warning disable 67
        public event EventHandler CanExecuteChanged { add { } remove { } }
#pragma warning restore 67
    }
}
