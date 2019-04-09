using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace REPO
{
    public class ClassCommand : ICommand
    {
        private Action action;
        private bool canExecute;

        public event EventHandler CanExecuteChanged;

        public ClassCommand(Action inAction, bool inCanExecute)
        {
            action = inAction;
            canExecute = inCanExecute;
        }

        public bool CanExecute(object parameter)
        {
            return canExecute;
        }

        public void Execute(object parameter)
        {
            action();
        }
    }
}
