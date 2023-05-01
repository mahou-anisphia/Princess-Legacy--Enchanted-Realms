using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace PrincessLegacyEnchantedRealms.mainMenuDrawing
{
    public class CustomTabControl : TabControl
    {
        public CustomTabControl()
        {
            this.DrawMode = TabDrawMode.OwnerDrawFixed;
            //set the draw responsiblity for tab control
            this.DrawItem += CustomTabControl_DrawItem;
        }
        //custom render for indexed value - I know it may looks like 1980, but to simulate the behaviour of the source TenTen Kamuei 
        //webpage is challenging
        private void CustomTabControl_DrawItem(object sender, DrawItemEventArgs e)
        {
            TabControl tabControl = sender as TabControl;
            TabPage tabPage = tabControl.TabPages[e.Index];
            Rectangle tabRect = tabControl.GetTabRect(e.Index);

            //if selected tab switch color pink, else the vanilla
            Color fillColor = (e.Index == tabControl.SelectedIndex) ? Color.FromArgb(255, 139, 139) : Color.FromArgb(222, 218, 208);

            using (Brush brush = new SolidBrush(fillColor))
            {
                e.Graphics.FillRectangle(brush, tabRect);
            }

            //normal brown, else black
            Color textColor = (e.Index == tabControl.SelectedIndex) ? Color.Black : Color.FromArgb(207, 159, 73);
            TextRenderer.DrawText(e.Graphics, tabPage.Text, new Font("Calibri", 14, FontStyle.Bold), tabRect, textColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }
    }
}
