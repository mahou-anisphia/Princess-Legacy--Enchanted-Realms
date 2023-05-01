using PrincessLegacyEnchantedRealms.clientDataManager;
using PrincessLegacyEnchantedRealms.gameComponents;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection.Emit;

namespace PrincessLegacyEnchantedRealms.clientProfileDrawer
{
    public class ClientDrawer
    {
        private Player _player;
        private TabPage _windowTab;
        private PictureBox _profilePicture;
        private PictureBox _profilePictureBox;
        public ClientDrawer(Player player, TabPage windowTab, PictureBox profilePictureBox)
        {
            _player = player;
            _windowTab = windowTab;
            InitializeComponents();
            _profilePictureBox = profilePictureBox;
        }
        private void InitializeComponents()
        {
            //Page's unique function goes here
            CustomPictureBox banner = new CustomPictureBox(new System.Drawing.Size(224, 449), new System.Drawing.Point(20, 0), "homePageResources\\profile\\profilebanner.png");
            _windowTab.Controls.Add(banner);
            _profilePicture = new CircularPictureBox(new Size(150, 150), new Point(57, 100), _player.GetSetAvatar);
            _windowTab.Controls.Add(_profilePicture);
            _profilePicture.BringToFront();
            _profilePicture.Click += ProfilePicture_Click;
            _profilePicture.MouseEnter += ProfilePicture_MouseEnter;
            _profilePicture.MouseLeave += ProfilePicture_MouseLeave;
            CustomText playerName = new CustomText(_player.Name, 0, 45, Color.White, "Calibri", 24);       
            playerName.BackColor = Color.Transparent;
            playerName.Size = new Size(224, 34);
            playerName.TextAlign = ContentAlignment.MiddleCenter;
            playerName.Parent = banner;
        }

        private void ProfilePicture_Click(object sender, EventArgs e)
        {
            ClientProfileCustomization custom = new ClientProfileCustomization(_player, _profilePictureBox);
            custom.FormClosing += (s, args) =>
            {
                _windowTab.BackgroundImage = Image.FromFile(_player.GetSetCoverImages);
                _profilePicture.Image = Image.FromFile(_player.GetSetAvatar);
            };
            custom.Show();
        }

        //event handler to signify when the mouse enter/leave
        private void ProfilePicture_MouseEnter(object sender, EventArgs e)
        {
            Color lolYellow = Color.FromArgb(50, 255, 236, 0);
            _profilePicture.BackColor = lolYellow;
            //making another layer of the image, display the color over the previous image
            _profilePicture.BackgroundImage = Image.FromFile(_player.GetSetAvatar);
            _profilePicture.Image = CreateSolidColorImage(_profilePicture.Size, lolYellow);
        }

        private void ProfilePicture_MouseLeave(object sender, EventArgs e)
        {
            _profilePicture.BackColor = Color.Transparent;
            _profilePicture.Image = Image.FromFile(_player.GetSetAvatar);
            //optimization
            _profilePicture.BackgroundImage= null;
        }

        //create an image with LoL (League of Legends) signature yellow color
        private Image CreateSolidColorImage(Size size, Color color)
        {
            Bitmap bmp = new Bitmap(size.Width, size.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(color);
            }
            return bmp;
        }

    }
}
