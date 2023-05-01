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
    public class DrawCoverBox
    {
        private Point position;
        private Size size;
        private Color color;
        private Control control;

        public DrawCoverBox(Point position, Size size, Color color, Control control)
        {
            this.position = position;
            this.size = size;
            this.color = color;
            this.control = control;

            this.control.Paint += Control_Paint;
            this.control.Invalidate();
        }

        private void Control_Paint(object sender, PaintEventArgs e)
        {
            Draw(e.Graphics);
        }

        public void Draw(Graphics graphics)
        {
            // Create a new GraphicsPath object and add a rounded rectangle to it
            GraphicsPath roundedRectPath = new GraphicsPath();
            int cornerRadius = 20; // Change this value to adjust the roundness of the corners
            roundedRectPath.AddArc(position.X, position.Y, cornerRadius * 2, cornerRadius * 2, 180, 90);
            roundedRectPath.AddArc(position.X + size.Width - cornerRadius * 2, position.Y, cornerRadius * 2, cornerRadius * 2, 270, 90);
            roundedRectPath.AddArc(position.X + size.Width - cornerRadius * 2, position.Y + size.Height - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 0, 90);
            roundedRectPath.AddArc(position.X, position.Y + size.Height - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 90, 90);
            roundedRectPath.CloseAllFigures();
            //This code was written with some help from chatGPT
            // Fill the rounded rectangle with the specified color
            using (SolidBrush brush = new SolidBrush(color))
            {
                graphics.FillPath(brush, roundedRectPath);
            }
        }
    }
}
