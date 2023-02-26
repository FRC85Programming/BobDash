using System.Drawing;
using System.Windows.Forms;

namespace BobDashControls
{
    public partial class ToggleButton : UserControl
    {
        public ToggleButton()
        {
            InitializeComponent();
        }

        public Image Image
        {
            get
            {
                return ToggledCheckBox.Image;
            }
            set
            {
                ToggledCheckBox.Image = value;
            }
        }
    }
}
