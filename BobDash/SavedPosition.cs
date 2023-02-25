using AForge;
using System;
using System.Threading;

namespace BobDash
{
    public class SavedPosition
    {
        public SavedPosition(double pivot, double extend, double wrist)
        {
            PivotPosition = pivot;
            ExtendPosition = extend;
            WristPosition = wrist;
        }

        public SavedPosition(double[] positions)
        {
            if (positions.Length != 3)
            {
                throw new ArgumentException($"Positions array expects 3 elements, but {positions.Length} were passed in.", nameof(positions));
            }

            PivotPosition = positions[0];
            ExtendPosition = positions[1];
            WristPosition = positions[2];
        }

        public double PivotPosition { get; set; }
        public double ExtendPosition { get; set; }
        public double WristPosition { get; set; }

        public double[] ToDoubleArray()
        {
            return new double[] { PivotPosition, ExtendPosition, WristPosition };
        }
    }
}
