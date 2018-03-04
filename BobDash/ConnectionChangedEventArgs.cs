using System;

namespace BobDash
{
    public class ConnectionChangedEventArgs : EventArgs
    {
        public bool Connected { get; set; }
    }
}
