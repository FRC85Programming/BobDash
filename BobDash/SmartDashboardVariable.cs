using NetworkTables;
using System;
using System.ComponentModel;

namespace BobDash
{
    public class SmartDashboardVariable : INotifyPropertyChanged, IDisposable
    {
        readonly int _listener;
        private bool disposedValue;

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
            }, NotifyFlags.NotifyNew | NotifyFlags.NotifyUpdate | NotifyFlags.NotifyImmediate);           
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    if (_listener > 0)
                    {
                        NtCore.RemoveEntryListener(_listener);
                    }
                }

                disposedValue = true;
            }
        }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
