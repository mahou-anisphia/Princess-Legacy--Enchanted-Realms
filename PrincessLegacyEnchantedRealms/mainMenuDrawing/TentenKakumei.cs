using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrincessLegacyEnchantedRealms.mainMenuDrawing
{
    public class TentenKakumei
    {
        private CustomTabControl _tabControl;
        private Form _windowForm;
        public TentenKakumei(CustomTabControl tabControl, Form windowForm)
        {
            _tabControl = tabControl;
            _windowForm = windowForm;
        }


        public TabPage AddCustomTabs()
        {
            TabPage imageTab = new TabPage();

            // Add the tab page to the tab control
            _tabControl.TabPages.Add(imageTab);
            // Create a new PictureBox
            PictureBox pictureBox = new PictureBox();

            // Set the PictureBox properties
            pictureBox.Size = new Size(100, 50);
            pictureBox.Location = new Point(0, 0);
            pictureBox.Image = Image.FromFile(@"gameBarResources\kakumeiIcon.png");
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Enabled = false;
            // Add the PictureBox to the form's controls collection
            WebBrowser webBrowser = new WebBrowser();   
            webBrowser.ScriptErrorsSuppressed = true;
            //since the browser does not support JavaScript (I've tried to make it support), so I have to supress the error. 
            webBrowser.Dock = DockStyle.Fill;
            imageTab.Controls.Add(webBrowser);
            webBrowser.Navigate("https://tenten-kakumei.com/index.html");

            //add the picture box into the page's controls, not the tabpage
            _windowForm.Controls.Add(pictureBox);
            return imageTab;
        }
    }
}
