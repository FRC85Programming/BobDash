using System;

namespace BobDash
{
    internal class ToggleButtonClickedEventArgs : EventArgs
    {
        public string PositionName { get; set; }
        public string GroupName { get; set; }
    }
}
