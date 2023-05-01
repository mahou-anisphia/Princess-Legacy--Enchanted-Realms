using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
namespace PrincessLegacyEnchantedRealms.storyQuest
{
    public class Dialogue : Interaction
    {
        private Form _windowForm;
        public Dialogue(string imageFilePath, Form windowForm) : base(imageFilePath)
        {
            _imageFilePath= imageFilePath;
            _windowForm= windowForm;
        }
        
        public void DrawImage(PictureBox pictureBox)
        {
            Image image = Image.FromFile(_imageFilePath);
            // Set the picture box's Image property to the loaded image
            pictureBox.Image = image;
        }
        public void RemoveImageFromForm(PictureBox pictureBox)
        {
            // Set the picture box's Image property to null to remove the image
            pictureBox.Image = null;
        }
    }
}
