using System;

namespace BobDash
{
    public class SavedPosition
    {
        public SavedPosition()
        {
        }

        public SavedPosition(double pivot, double extend, double wrist, double rollerSpeed)
        {
            PivotPosition = pivot;
            ExtendPosition = extend;
            WristPosition = wrist;
            RollerSpeed = rollerSpeed;
        }

        public SavedPosition(double[] positions)
        {
            if (positions.Length < 3)
            {
                throw new ArgumentException($"Positions array expects 3 elements, but {positions.Length} were passed in.", nameof(positions));
            }

            PivotPosition = positions[0];
            ExtendPosition = positions[1];
            WristPosition = positions[2];
            if (positions.Length > 3)
            {
                RollerSpeed = positions[3];
            }
        }

        public double PivotPosition { get; set; }
        public double ExtendPosition { get; set; }
        public double WristPosition { get; set; }
        public double RollerSpeed { get; set; }

        public double[] ToDoubleArray()
        {
            return new double[] { PivotPosition, ExtendPosition, WristPosition, RollerSpeed };
        }

        public override string ToString()
        {
            return $"({PivotPosition}, {ExtendPosition}, {WristPosition}, {RollerSpeed})";
        }
    }
}
