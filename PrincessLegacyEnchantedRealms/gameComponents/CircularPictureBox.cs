using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrincessLegacyEnchantedRealms.gameComponents
{
    public class CircularPictureBox : PictureBox
    {
        public CircularPictureBox(Size size, Point location, string imagePath)
        {
            this.BackColor = Color.Transparent;
            this.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Size = size;
            this.Location = location;
            this.Image = Image.FromFile(imagePath);
        }

        protected override void OnPaint(PaintEventArgs pe)
            //Overriding the old method
            //This allows the picture appears circular, which fits the profile
        {
            base.OnPaint(pe);

            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddEllipse(new Rectangle(0, 0, this.Width, this.Height));
                this.Region = new Region(path);

                pe.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                using (Brush brush = new TextureBrush(this.Image))
                {
                    pe.Graphics.FillEllipse(brush, new Rectangle(0, 0, this.Width, this.Height));
                }
            }
        }
    }

}
