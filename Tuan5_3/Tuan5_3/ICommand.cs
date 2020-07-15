using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan5_3
{
    interface ICommand
    {
        // Occurs when changes occur that affect whether
        // or not the command should execute.
        event EventHandler CanExecuteChanged;
        // Defines the method that determines whether the command
        // can execute in its current state.
        bool CanExecute(object parameter);
        // Defines the method to be called when the command is invoked.
        void Execute(object parameter);
    }
}
