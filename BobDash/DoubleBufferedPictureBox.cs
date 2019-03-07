using System.Windows.Forms;

namespace BobDashControls
{
    public class DoubleBufferedPictureBox : PictureBox
    {
        public DoubleBufferedPictureBox() : base()
        {
            DoubleBuffered = true;
        }
    }
}
