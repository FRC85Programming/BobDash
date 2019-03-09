using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BobDash
{
    public class SmartDashboardVariable
    {
        public string Name
        {
            get;
            private set;
        }

        public NetworkTables.Value Value
        {
            get;
            private set;
        }

        public NetworkTables.NtType Type
        {
            get
            {
                return Value?.Type ?? NetworkTables.NtType.Unassigned;
            }
        }

        public SmartDashboardVariable(string name, NetworkTables.Value value)
        {
            Name = name;
            Value = value;
        }
    }
}
