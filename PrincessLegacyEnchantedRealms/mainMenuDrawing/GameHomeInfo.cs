using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrincessLegacyEnchantedRealms.mainMenuDrawing
{
    public class GameHomeInfo
    {
        private readonly PictureBox _pictureBox;

        public GameHomeInfo(Size size, Point location, string imagePath)
        {
            _pictureBox = new PictureBox();
            _pictureBox.Size = size;
            _pictureBox.Location = location;
            _pictureBox.Image = Image.FromFile(imagePath);
            _pictureBox.BorderStyle = BorderStyle.FixedSingle;
        }

        public PictureBox GetPictureBox()
        {
            return _pictureBox;
        }
    }
}
