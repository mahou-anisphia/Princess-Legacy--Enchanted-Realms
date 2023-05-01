using Microsoft.Win32;
using PrincessLegacyEnchantedRealms.bagDrawing;
using PrincessLegacyEnchantedRealms.clientDataManager;
using PrincessLegacyEnchantedRealms.clientProfileDrawer;
using PrincessLegacyEnchantedRealms.GachaSystem;
using PrincessLegacyEnchantedRealms.gamePlayUI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrincessLegacyEnchantedRealms.mainMenuDrawing
{
    public class MenuConstructor
    {
        private Form _winForm;
        private CustomTabControl _tabControl = new CustomTabControl();
        private List<string> _imagePaths = new List<string>();
        private int _currentIndex = 0;
        private PictureBox _gameSlideShow = new PictureBox();
        private Timer timer1;   
        private List<string> _imageUrls = new List<string>();
        private Player _player;
        private PictureBox profilePic = new PictureBox();
        private Label _playerCurrency;
        public enum UserStatus
        {
            Online,
            Offline
        }
        public MenuConstructor(Form windowForm, Player player){
            _winForm = windowForm;
            _winForm.MaximizeBox = false;
            _player = player;


            //timer for slideshow in home page
            timer1 = new Timer();
            timer1.Interval = 5000 ; // 5 seconds
            timer1.Tick += timer1_Tick; // Set event handler for Timer tick
            timer1.Start();

            //paths for slideshow in home page
            _imagePaths.Add(@"homePageResources\banners\gameEventPage.jpg");
            _imagePaths.Add(@"homePageResources\banners\lycorecoEventResources.png");
            _imageUrls.Add("https://tenten-kakumei.com/index.html");
            _imageUrls.Add("https://lycorisrecoil.com/");
            AddFormCoreComponents();
        }
        private Label userStatus = new Label();
        public void AddFormCoreComponents()
        {
            //League like player status
            userStatus.Location = new Point(900, 40);
            userStatus.Text = "Online";
            userStatus.ForeColor = Color.Green;
            userStatus.Click += userStatus_Click;
            _winForm.Controls.Add(userStatus);

            //Initialize player's profile and player's name
            //This does not refer to Profile tab
            //adding profile icon and name
            profilePic.SizeMode = PictureBoxSizeMode.StretchImage;
            profilePic.Size = new Size(50, 50);
            profilePic.Location = new Point(850, 0);
            profilePic.Image = Image.FromFile(_player.GetSetAvatar);
            _winForm.Controls.Add(profilePic);
            Label playerName = new Label();
            playerName.Location = new Point(900, 0);
            playerName.Text = _player.Name;
            playerName.Font = new Font("Segoe UI", 12);
            _winForm.Controls.Add(playerName);

            //adding current in-game currency status
            PictureBox bs_icon = new PictureBox();
            bs_icon.Image = Image.FromFile("currencySystems\\bs_icon.png");
            bs_icon.Location = new Point(710, 10);
            bs_icon.SizeMode = PictureBoxSizeMode.StretchImage;
            bs_icon.Size = new Size(30, 40);
            _winForm.Controls.Add(bs_icon);
            _playerCurrency = new Label();
            _playerCurrency.Location = new Point(735, 17);
            _playerCurrency.Font = new Font("Segoe UI", 12);
            _playerCurrency.Text = _player.GetSetCurrency.ToString();
            _winForm.Controls.Add(_playerCurrency);
            _playerCurrency.SendToBack();
        }
        //Online-Offline usually found in League clients
        private void userStatus_Click(object sender, EventArgs e)
        {
            if (userStatus.Text == UserStatus.Online.ToString())
            {
                // Change the text and color of the label to indicate offline status
                userStatus.Text = UserStatus.Offline.ToString();
                userStatus.ForeColor = Color.Gray;
            }
            else
            {
                // Change the text and color of the label to indicate online status
                userStatus.Text = UserStatus.Online.ToString();
                userStatus.ForeColor = Color.Green;
            }
        }

        public void AddNavigationBar(){
            //seperate tabs to add each some functions
            //and support readablity


            //------------------------------------TenTenKakumei Icon: Project Reference page----------------------------------------//
            //References of the project (a tab that display the inspiration)
            TentenKakumei tentenIcon = new TentenKakumei(_tabControl, _winForm);
            TabPage tenTenIcon = tentenIcon.AddCustomTabs();
            //note for project: done, do not touch or you'll blew this up; hours wasted: 31


            //------------------------------------Play Tab: choose your gamemode----------------------------------------------------//
            CustomTabs playTab = new CustomTabs(_tabControl, "Play", 200);
            TabPage gamePlayTab = playTab.AddCustomTabs();
            gamePlayTab.BackgroundImage = Image.FromFile(@"homePageResources\play\gamePlayBackground.png");
            _tabControl.SelectedIndexChanged += _tabControl_SelectedIndexChanged;


            //------------------------------------Home Tab: Patch notes, events, etc------------------------------------------------//
            CustomTabs homeTab = new CustomTabs(_tabControl, "Home", 200);
            TabPage gameHomeTab = homeTab.AddCustomTabs();
            _tabControl.SelectedIndex = _tabControl.TabPages.IndexOf(gameHomeTab);
            //make home tab become default
            //most games do that, and so do I
            gameHomeTab.Controls.Add(_gameSlideShow);
            _gameSlideShow.Size = new Size(600, 400);
            //moved paths into constructor for readablity
            //Slideshow is different from other boxes; since it's used for once only, writing it by plain codes is the best for optimize
            _gameSlideShow.Image = Image.FromFile(_imagePaths[_currentIndex]);
            _gameSlideShow.Tag = _imageUrls[_currentIndex];
            _gameSlideShow.Click += gameSlideShow_Click;
            _gameSlideShow.BorderStyle = BorderStyle.FixedSingle;
            //adding home tab constructor
            HomePageConstructor homeTabConstructor = new HomePageConstructor(gameHomeTab, _tabControl, _player, _playerCurrency);
            homeTabConstructor.Construct();


            //------------------------------------Bag tab: check what you have------------------------------------------------------//
            CustomTabs bagTab = new CustomTabs(_tabControl, "Bag", 100);
            TabPage gameBagTab = bagTab.AddCustomTabs();
            BagDrawing bagTabConstructor = new BagDrawing(gameBagTab, _player);


            //------------------------------------Wish Tab: where people get game resources-----------------------------------------//
            CustomTabs wishTab = new CustomTabs(_tabControl, "Wish", 200);
            TabPage gameWishTab = wishTab.AddCustomTabs();
            gameWishTab.BackgroundImage = Image.FromFile(@"homePageResources\wish\wish_cover.jpg");
            WishMenuDrawer constructWishTab = new WishMenuDrawer(_tabControl, _player, _playerCurrency, bagTabConstructor);


            //------------------------------------Profile Tab: customize your profile-----------------------------------------------//
            CustomTabs profileTab = new CustomTabs(_tabControl, "Profile", 100);
            TabPage gameProfileTab = profileTab.AddCustomTabs();
            gameProfileTab.BackgroundImage = Image.FromFile(_player.GetSetCoverImages);
            gameProfileTab.BackgroundImageLayout = ImageLayout.Stretch;
            ClientDrawer profileConstructor = new ClientDrawer(_player, gameProfileTab, profilePic);


            //------------------------------------Shop Tab: Resupply----------------------------------------------------------------//
            CustomTabs shopTab = new CustomTabs(_tabControl, "Shop", 100);
            TabPage gameShopTab = shopTab.AddCustomTabs();
            gameShopTab.BackgroundImage = Image.FromFile(@"homePageResources\shop\shopMenu.jpg");
            ShopPageConstructor constructShopPage = new ShopPageConstructor(gameShopTab, _playerCurrency, _player);
            constructShopPage.ConstructShopPage();
            //------------------------------------End of game tab section-----------------------------------------------------------//


            _tabControl.Alignment = TabAlignment.Top;
            _tabControl.Dock = DockStyle.Left;
            _tabControl.Width = 800;
            //make a bar (maybe adding something to that, if possible?)
            _winForm.Controls.Add(_tabControl);
        }

        private void _tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            TabPage selectedTabPage = _tabControl.SelectedTab;
            if (_tabControl.SelectedIndex == 1)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to launch the external tool?",
                    "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    // Create and show the new form
                    PlayForm toolForm = new PlayForm();
                    toolForm.Text = selectedTabPage.Text + " - External Tool";
                    toolForm.Show();
                }
                else
                {
                    // Select the previous tab page
                    int previousIndex = _tabControl.SelectedIndex == 0 ? 0 : _tabControl.SelectedIndex + 1;
                    _tabControl.SelectedIndex = previousIndex;
                }
            }
        }

        //Event handler for slideshow: timer and clickable images
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Increment index to next image
            _currentIndex++;
            if (_currentIndex >= _imagePaths.Count)
            {
                _currentIndex = 0; // Loop back to first image
            }

            // Load next image and display it in PictureBox
            _gameSlideShow.Image = Image.FromFile(_imagePaths[_currentIndex]);
            _gameSlideShow.Tag = _imageUrls[_currentIndex];
        }
        private void gameSlideShow_Click(object sender, EventArgs e)
        {
            // Open URL associated with current image in default web browser
            string url = _gameSlideShow.Tag.ToString();
            Process.Start(url);
        }
        
    }
}
