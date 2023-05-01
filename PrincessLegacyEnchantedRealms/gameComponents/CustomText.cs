using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
namespace PrincessLegacyEnchantedRealms.gameComponents
{
    public class CustomText : Label
    {
        public CustomText(string text, int x, int y, Color color, string fontName, float fontSize)
        {
            Text = text;
            Location = new Point(x, y);
            ForeColor = color;
            Font = new Font(fontName, fontSize);
        }
    }
}
