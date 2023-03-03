namespace BobDash
{
    public class SendableChooser
    {
        internal NetworkTables.Tables.ITable NetworkTable { get; set; }

        public SendableChooser(NetworkTables.Tables.ITable sendableChooserTable)
        {
            NetworkTable = sendableChooserTable;
        }

        public string Default
        {
            get
            {
                return NetworkTable?.GetString("default", null);
            }
        }

        public string[] Options
        {
            get
            {
                return NetworkTable?.GetStringArray("options", null);
            }
        }

        public string Selected
        {
            get
            {
                return NetworkTable?.GetString("selected", null);
            }
            set
            {
                NetworkTable?.PutString("selected", value);
            }
        }
    }
}
