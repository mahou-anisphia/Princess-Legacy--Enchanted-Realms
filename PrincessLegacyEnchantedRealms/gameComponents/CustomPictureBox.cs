using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrincessLegacyEnchantedRealms.gameComponents
{
    public class CustomPictureBox : PictureBox
    {
        public CustomPictureBox(Size size, Point location, string imagePath)
        {
            this.Size = size;
            this.Location = location;
            this.BackColor = Color.Transparent;
            this.SizeMode = PictureBoxSizeMode.Zoom;
            this.Image = Image.FromFile(imagePath);
        }
    }
}
