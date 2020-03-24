using AdonisUI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdonisUI.Controls
{
    /// <inheritdoc/>
    public class MessageBoxHelpLink
        : PropertyChangedBase
        , IMessageBoxHelpLink

    {
        private string _caption = "Learn more";

        /// <inheritdoc/>
        public string Caption
        {
            get => _caption;
            private set => SetProperty(ref _caption, value);
        }

        private Action _callback;

        /// <inheritdoc/>
        public Action Callback
        {
            get => _callback;
            private set => SetProperty(ref _callback, value);
        }
    }
}
