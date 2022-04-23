using System;
using System.Windows.Input;

namespace Bank.Commands
{
    public abstract class CommandBase : ICommand
    {
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public virtual bool CanExecute(object parameter)
        {
            return true;
        }

        public abstract void Execute(object parameter);

        protected void OnCanExecutedChanged()
        {
            //CanExecuteChanged?.Invoke(this, new EventArgs());
            CommandManager.InvalidateRequerySuggested();
        }
    }
}
