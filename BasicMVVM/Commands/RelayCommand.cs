using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BasicMVVM.Commands
{
    public class RelayCommand: ICommand
    {
        public Predicate<object> CanExecuteDelegate;
        public Action<object> ExecuteDelegate;


        public bool CanExecute(object parameter)
        {
            return CanExecuteDelegate(parameter);
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public void Execute(object parameter)
        {
            ExecuteDelegate(parameter);
        }
    }
}
