using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrincessLegacyEnchantedRealms.loginMenu
{
    public class CustomButton : Button
    {
        public CustomButton(Point position, Size size, string text, Font font, Color foreColor, Color backColor, Color mouseOverBackColor, Color mouseDownBackColor)
        {
            this.Location = position;
            this.Size = size;
            this.Text = text;
            this.Font = font;
            this.ForeColor = foreColor;
            this.BackColor = backColor;
            this.FlatStyle = FlatStyle.Flat;
            //2D apperance only, no 3d bevel or raised edge
            this.FlatAppearance.BorderSize = 0;
            this.FlatAppearance.MouseOverBackColor = mouseOverBackColor;
            this.FlatAppearance.MouseDownBackColor = mouseDownBackColor;
        }
    }
}
