using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace PrincessLegacyEnchantedRealms.mainMenuDrawing
{
    public class CustomTabs
    {
        private TabControl _tabControl;
        private string _label;
        private int _width;
        public CustomTabs(TabControl tabControl, string text, int width)
        {
            _tabControl = tabControl;
            _label = text;
            _width = width;
        }
        public TabPage AddCustomTabs()
        {
            TabPage tabPage = new TabPage();
            tabPage.Text = _label;
            _tabControl.TabPages.Add(tabPage);
            tabPage.Width = _width;
            _tabControl.SizeMode = TabSizeMode.Fixed;
            _tabControl.ItemSize = new Size(_width, 50); // Change the width and height of the tab header
            //This code is used to render the tabs colors and style
            _tabControl.SelectedTab.ForeColor = Color.FromArgb(0xFF, 0x8B, 0x8B);

            return tabPage;
        }
    }
}
