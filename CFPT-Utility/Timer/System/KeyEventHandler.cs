using System.Windows.Forms;

namespace System
{
    internal class KeyEventHandler
    {
        private Action<object, KeyEventArgs> messageText_KeyPress;
        private Action<object, KeyEventHandler> messageText_KeyPress1;

        public KeyEventHandler(Action<object, KeyEventHandler> messageText_KeyPress1)
        {
            this.messageText_KeyPress1 = messageText_KeyPress1;
        }

        public KeyEventHandler(Action<object, KeyEventArgs> messageText_KeyPress)
        {
            this.messageText_KeyPress = messageText_KeyPress;
        }
    }
}