using System;
using System.Windows.Input;

namespace eu.satam.som.ui.Common
{
    public class Command<T> : ICommand
    {
        public Command(Action<object> action)
        {
            if (action == null)
            {
                throw new ArgumentException("action");
            }
            ExecuteAction = action;
        }

        public Action<object> ExecuteAction { get; private set; }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            T convertedObject;
            if (parameter is T) { convertedObject = (T)parameter; }
            else { convertedObject = (T)Convert.ChangeType(parameter, typeof(T)); }

            ExecuteAction(convertedObject);
        }

        public event EventHandler CanExecuteChanged;
    }
}