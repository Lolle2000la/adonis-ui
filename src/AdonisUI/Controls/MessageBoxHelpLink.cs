using AdonisUI.ViewModels;
using System;
using System.Windows.Input;

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

        /// <inheritdoc/>
        public ICommand Command { get; }

        private MessageBoxHelpLink(string caption, Action callback) 
        {
            Caption = caption ?? Caption;
            Callback = callback ?? throw new ArgumentNullException(nameof(callback));

            Command = new HelpLinkCommand(callback);
        }

        /// <summary>
        /// Creates a new instance of <see cref="MessageBoxHelpLink"/> with the default caption "Learn more". Can be used to add and configure a help link on a message box.
        /// </summary>
        /// <param name="callback">Specifies a callback that should be called when the help link is called</param>
        /// <returns>A <see cref="MessageBoxHelpLink"/> that when assigned to a <see cref="MessageBoxModel"/> adds a help link.</returns>
        public MessageBoxHelpLink Create(Action callback) => new MessageBoxHelpLink(null, callback);

        /// <summary>
        /// Creates a new instance of <see cref="MessageBoxHelpLink"/>. Can be used to add and configure a help link on a message box.
        /// </summary>
        /// <param name="caption">Specifies the caption that the help link should have.</param>
        /// <param name="callback">Specifies a callback that should be called when the help link is called</param>
        /// <returns>A <see cref="MessageBoxHelpLink"/> that when assigned to a <see cref="MessageBoxModel"/> adds a help link.</returns>
        public MessageBoxHelpLink Create(string caption, Action callback) => new MessageBoxHelpLink(caption, callback);
    }
}
