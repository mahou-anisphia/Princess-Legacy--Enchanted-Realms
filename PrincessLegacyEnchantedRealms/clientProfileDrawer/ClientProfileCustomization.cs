using PrincessLegacyEnchantedRealms.clientDataManager;
using PrincessLegacyEnchantedRealms.clientDataManager.gameDataManager;
using PrincessLegacyEnchantedRealms.gameComponents;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrincessLegacyEnchantedRealms.clientProfileDrawer
{
    public class ClientProfileCustomization : Form
    {
        private Player _playerAnis;
        private PictureBox _profilePicture;
        private PictureBox _profilePictureBox;
        public ClientProfileCustomization(Player playerAnis, PictureBox profilePictureBox)
        {
            this.Icon = new Icon("anis.ico");
            _playerAnis = playerAnis;
            this.Width = 850;
            this.Height = 600;
            InitializeComponents();
            _profilePictureBox = profilePictureBox;
        }
        private void InitializeComponents()
        {
            //User input can change these
            CustomPictureBox banner = new CustomPictureBox(new System.Drawing.Size(224, 449), new System.Drawing.Point(20, 0), "homePageResources\\profile\\profilebanner.png");
            this.Controls.Add(banner);
            _profilePicture = new CircularPictureBox(new Size(150, 150), new Point(57, 100), _playerAnis.GetSetAvatar);
            this.Controls.Add(_profilePicture);

            //static codes
            this.BackgroundImage = Image.FromFile("homePageResources\\profile\\summonersrift.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            _profilePicture.BringToFront();
            CircularPictureBox avatar1 = new CircularPictureBox(new System.Drawing.Size(150, 150), new System.Drawing.Point(297, 60), "avatarList\\gameAvt1\\gameAvt.jpg");
            this.Controls.Add(avatar1);
            avatar1.Click += Avatar1_Click;
            CircularPictureBox avatar2 = new CircularPictureBox(new System.Drawing.Size(150, 150), new System.Drawing.Point(447, 60), "avatarList\\gameAvt2\\gameAvt.jpg");
            this.Controls.Add(avatar2);
            avatar2.Click += Avatar2_Click;
            CircularPictureBox avatar3 = new CircularPictureBox(new System.Drawing.Size(150, 150), new System.Drawing.Point(597, 60), "avatarList\\gameAvt3\\gameAvt.jpg");
            this.Controls.Add(avatar3);
            avatar3.Click += Avatar3_Click;
            CircularPictureBox avatar4 = new CircularPictureBox(new System.Drawing.Size(150, 150), new System.Drawing.Point(297, 210), "avatarList\\gameAvt4\\gameAvt.jpg");
            this.Controls.Add(avatar4);
            avatar4.Click += Avatar4_Click;
            CircularPictureBox avatar5 = new CircularPictureBox(new System.Drawing.Size(150, 150), new System.Drawing.Point(447, 210), "avatarList\\gameAvt5\\gameAvt.jpg");
            this.Controls.Add(avatar5);
            avatar5.Click += Avatar5_Click;
            CircularPictureBox avatar6 = new CircularPictureBox(new System.Drawing.Size(150, 150), new System.Drawing.Point(597, 210), "avatarList\\gameAvt6\\gameAvt.jpg");
            this.Controls.Add(avatar6);
            avatar6.Click += Avatar6_Click;
            CircularPictureBox avatar7 = new CircularPictureBox(new System.Drawing.Size(150, 150), new System.Drawing.Point(297, 360), "avatarList\\gameAvt7\\gameAvt.jpg");
            this.Controls.Add(avatar7);
            avatar7.Click += Avatar7_Click;
            CircularPictureBox avatar8 = new CircularPictureBox(new System.Drawing.Size(150, 150), new System.Drawing.Point(447, 360), "avatarList\\gameAvt8\\gameAvt.jpg");
            this.Controls.Add(avatar8);
            avatar8.Click += Avatar8_Click;
            CircularPictureBox avatar9 = new CircularPictureBox(new System.Drawing.Size(150, 150), new System.Drawing.Point(597, 360), "avatarList\\gameAvt9\\gameAvt.jpg");
            this.Controls.Add(avatar9);
            avatar9.Click += Avatar9_Click;
        }

        //As the code grow I realize we can update the process by using a class, however I'm running out of time so if possible I'll modify that way
        //this code may be repeative because it was developed by the early stage of the game
        private void Avatar1_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            string updatedAvatar = $"avatarList\\gameAvt1";
            _playerAnis.GetSetAvatar = "avatarList\\gameAvt1\\gameAvt.jpg";
            _playerAnis.GetSetCoverImages = "avatarList\\gameAvt1\\gamecov.png";
            _profilePicture.ImageLocation = "avatarList\\gameAvt1\\gameAvt.jpg";
            _profilePictureBox.Image = pictureBox.Image;
            string filePath = $"loginInformation\\{_playerAnis.Name}.txt";
            AvatarListModifier avaModifier = new AvatarListModifier(filePath);
            avaModifier.ModifyAvatarList(updatedAvatar);
        }

        private void Avatar2_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            string updatedAvatar = $"avatarList\\gameAvt2";
            _playerAnis.GetSetAvatar = "avatarList\\gameAvt2\\gameAvt.jpg";
            _playerAnis.GetSetCoverImages = "avatarList\\gameAvt2\\gamecov.png";
            _profilePicture.ImageLocation = "avatarList\\gameAvt2\\gameAvt.jpg";
            _profilePictureBox.Image = pictureBox.Image;
            string filePath = $"loginInformation\\{_playerAnis.Name}.txt";
            AvatarListModifier avaModifier = new AvatarListModifier(filePath);
            avaModifier.ModifyAvatarList(updatedAvatar);
        }

        private void Avatar3_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            string updatedAvatar = $"avatarList\\gameAvt3";
            _playerAnis.GetSetAvatar = "avatarList\\gameAvt3\\gameAvt.jpg";
            _playerAnis.GetSetCoverImages = "avatarList\\gameAvt3\\gamecov.png";
            _profilePicture.ImageLocation = "avatarList\\gameAvt3\\gameAvt.jpg";
            _profilePictureBox.Image = pictureBox.Image;
            string filePath = $"loginInformation\\{_playerAnis.Name}.txt";
            AvatarListModifier avaModifier = new AvatarListModifier(filePath);
            avaModifier.ModifyAvatarList(updatedAvatar);
        }

        private void Avatar4_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            string updatedAvatar = $"avatarList\\gameAvt4";
            _playerAnis.GetSetAvatar = "avatarList\\gameAvt4\\gameAvt.jpg";
            _playerAnis.GetSetCoverImages = "avatarList\\gameAvt4\\gamecov.png";
            _profilePicture.ImageLocation = "avatarList\\gameAvt4\\gameAvt.jpg";
            _profilePictureBox.Image = pictureBox.Image;
            string filePath = $"loginInformation\\{_playerAnis.Name}.txt";
            AvatarListModifier avaModifier = new AvatarListModifier(filePath);
            avaModifier.ModifyAvatarList(updatedAvatar);
        }

        private void Avatar5_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            string updatedAvatar = $"avatarList\\gameAvt5";
            _playerAnis.GetSetAvatar = "avatarList\\gameAvt5\\gameAvt.jpg";
            _playerAnis.GetSetCoverImages = "avatarList\\gameAvt5\\gamecov.png";
            _profilePicture.ImageLocation = "avatarList\\gameAvt5\\gameAvt.jpg";
            _profilePictureBox.Image = pictureBox.Image;
            string filePath = $"loginInformation\\{_playerAnis.Name}.txt";
            AvatarListModifier avaModifier = new AvatarListModifier(filePath);
            avaModifier.ModifyAvatarList(updatedAvatar);
        }

        private void Avatar6_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            string updatedAvatar = $"avatarList\\gameAvt6";
            _playerAnis.GetSetAvatar = "avatarList\\gameAvt6\\gameAvt.jpg";
            _playerAnis.GetSetCoverImages = "avatarList\\gameAvt6\\gamecov.png";
            _profilePicture.ImageLocation = "avatarList\\gameAvt6\\gameAvt.jpg";
            _profilePictureBox.Image = pictureBox.Image;
            string filePath = $"loginInformation\\{_playerAnis.Name}.txt";
            AvatarListModifier avaModifier = new AvatarListModifier(filePath);
            avaModifier.ModifyAvatarList(updatedAvatar);
        }

        private void Avatar7_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            string updatedAvatar = $"avatarList\\gameAvt7";
            _playerAnis.GetSetAvatar = "avatarList\\gameAvt7\\gameAvt.jpg";
            _playerAnis.GetSetCoverImages = "avatarList\\gameAvt7\\gamecov.png";
            _profilePicture.ImageLocation = "avatarList\\gameAvt7\\gameAvt.jpg";
            _profilePictureBox.Image = pictureBox.Image;
            string filePath = $"loginInformation\\{_playerAnis.Name}.txt";
            AvatarListModifier avaModifier = new AvatarListModifier(filePath);
            avaModifier.ModifyAvatarList(updatedAvatar);
        }


        private void Avatar8_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            string updatedAvatar = $"avatarList\\gameAvt8";
            _playerAnis.GetSetAvatar = "avatarList\\gameAvt8\\gameAvt.jpg";
            _playerAnis.GetSetCoverImages = "avatarList\\gameAvt8\\gamecov.png";
            _profilePicture.ImageLocation = "avatarList\\gameAvt8\\gameAvt.jpg";
            _profilePictureBox.Image = pictureBox.Image;
            string filePath = $"loginInformation\\{_playerAnis.Name}.txt";
            AvatarListModifier avaModifier = new AvatarListModifier(filePath);
            avaModifier.ModifyAvatarList(updatedAvatar);
        }

        private void Avatar9_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            string updatedAvatar = $"avatarList\\gameAvt9";
            _playerAnis.GetSetAvatar = "avatarList\\gameAvt9\\gameAvt.jpg";
            _playerAnis.GetSetCoverImages = "avatarList\\gameAvt9\\gamecov.png";
            _profilePicture.ImageLocation = "avatarList\\gameAvt9\\gameAvt.jpg";
            _profilePictureBox.Image = pictureBox.Image;
            string filePath = $"loginInformation\\{_playerAnis.Name}.txt";
            AvatarListModifier avaModifier = new AvatarListModifier(filePath);
            avaModifier.ModifyAvatarList(updatedAvatar);
        }

    }
}
