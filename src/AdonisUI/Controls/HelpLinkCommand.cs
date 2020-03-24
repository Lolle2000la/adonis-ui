using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AdonisUI.Controls
{
    class HelpLinkCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private readonly Action callback;

        public HelpLinkCommand(Action callback)
        {
            this.callback = callback;
        }

        public bool CanExecute(object parameter) => callback != null;

        public void Execute(object parameter) => callback?.Invoke();
    }
}
