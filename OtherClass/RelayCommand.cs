using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Namordnik.OtherClass
{
  public  class RelayCommand : ICommand
  {
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
        private Action<object> execute;
        private Func<object, bool> canExecute;

        public RelayCommand(Action<object> execute, Func<object, bool> canExecute = null)
        {
            this.execute = execute;
            this.canExecute = canExecute;
        }
        public bool CanExecute(object paramter)
        {
            return this.execute == null || this.canExecute == null;
        }

        public void Execute(object parameter)
        {
            this.execute(parameter);
        }
  }
}
