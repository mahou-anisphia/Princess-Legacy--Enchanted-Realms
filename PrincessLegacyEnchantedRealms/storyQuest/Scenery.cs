using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;


namespace PrincessLegacyEnchantedRealms.storyQuest
{
    public class Scenery : Interaction
    {
        private Form _windowForm;
        public Scenery(string imageFilePath, Form windowForm) : base(imageFilePath)
        {
            _imageFilePath= imageFilePath;
            _windowForm= windowForm;
        }
        //change picture box's background to an image
        public void DrawImage(PictureBox pix)
        {
            pix.BackgroundImage = Image.FromFile(_imageFilePath);
        }
    }
}
