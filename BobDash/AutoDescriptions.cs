using System.ComponentModel;

namespace BobDash
{
    public enum AutoDescriptions : int
    {
        None = 0,
        Center = 1,
        [Description("Left long")]
        LeftLong = 2,
        [Description("Right long")]
        RightLong = 3,
        [Description("Left short")]
        LeftShort = 4,
        [Description("Right short")]
        RightShort = 5,
        [Description("Shoot red")]
        ShootRed = 6,
        [Description("Shoot blue")]
        ShootBlue = 7,
    }
}
