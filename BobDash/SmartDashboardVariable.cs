using NetworkTables;
using System.ComponentModel;

namespace BobDash
{
    public class SmartDashboardVariable : INotifyPropertyChanged
    {
        readonly int _listener;

        public event PropertyChangedEventHandler PropertyChanged;

        public string Name
        {
            get;
            private set;
        }

        public Value Value
        {
            get;
            private set;
        }

        public NtType Type
        {
            get
            {
                return Value?.Type ?? NtType.Unassigned;
            }
        }

        public SmartDashboardVariable(string name, Value value)
        {
            Name = name;
            Value = value;
            
            _listener = NtCore.AddEntryListener($"/SmartDashboard/{name}", (uid, key, newValue, flags) => {
                Value = newValue;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Value"));
            }, NotifyFlags.NotifyUpdate | NotifyFlags.NotifyImmediate);           
        }
    }
}
