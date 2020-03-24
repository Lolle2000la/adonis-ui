using System;

namespace AdonisUI.Controls
{
    /// <summary>
    /// Exposes properties used to configure the appearance and behavior of a help link on a <see cref="MessageBoxWindow"/>.
    /// </summary>
    public interface IMessageBoxHelpLink
    {
        /// <summary>
        /// A <see cref="String"/> that specifies which caption to use for the help link.
        /// </summary>
        string Caption { get; }

        /// <summary>
        /// A <see cref="Action"/> callback that will be called when the link is pressed.
        /// </summary>
        /// 
        Action Callback { get; }
    }
}