using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrincessLegacyEnchantedRealms.TextBoxes.loginMenu
{
    public class CustomTextBox : TextBox
    {
        public CustomTextBox(Point position, Size size, Font font, Color foreColor, Color backColor)
        {
            this.Location = position;
            this.Size = size;
            this.Font = font;
            this.ForeColor = foreColor;
            this.BackColor = backColor;
            this.BorderStyle = BorderStyle.None;
            //default: no border
            this.MouseEnter += new EventHandler(MouseEnterHandler);
            this.MouseLeave += new EventHandler(MouseLeaveHandler);
        }

        private void MouseEnterHandler(object sender, EventArgs e)
        {
            this.BorderStyle = BorderStyle.FixedSingle;
            //highlighted when user hover over button
            this.BackColor = Color.FromArgb(255, 192, 203);
        }

        private void MouseLeaveHandler(object sender, EventArgs e)
        {
            this.BorderStyle = BorderStyle.None;
            //return to default
            this.BackColor = Color.FromArgb(36, 36, 36);
        }
    }
}
