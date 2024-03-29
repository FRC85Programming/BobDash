using System;

namespace BobDash
{
    internal class ShotLogRecord
    {
        public double Height { get; set; }
        public double Angle { get; set; }
        public ShotClassification Classification { get; set; }
        public DateTime? Timestamp { get; set; }
    }
}