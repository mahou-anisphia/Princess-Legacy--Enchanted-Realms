using PrincessLegacyEnchantedRealms.clientDataManager;
using PrincessLegacyEnchantedRealms.clientDataManager.gameDataManager;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrincessLegacyEnchantedRealms.mainMenuDrawing
{
    public class HomePageConstructor
    {
        private TabPage _gameHomeTab;
        private TabControl _tabControl;
        private Player _player;
        private Label _playerCurrency;
        private int _playerBeginCurrency;
        public HomePageConstructor(TabPage tabpage, TabControl tabControl, Player player, Label playerCurrency)
        {
            _gameHomeTab = tabpage;
            _tabControl = tabControl;
            _player = player;
            _playerCurrency = playerCurrency;
        }
        public void Construct()
        {
            // Define each UI box element for displaying game data
            // This code currently uses artifacts to represent the data, but they can be easily replaced
            // by accessing the game's data structures, which are stored in a local database
            // Using the game's data structures supports future development by allowing the game to be updated
            // with new features and data without changing the code


            // Define a box for displaying game update information
            GameHomeInfo gameUpdateInfo = new GameHomeInfo(new Size(300, 150), new Point(0, 400), @"homePageResources\banners\gameUpdateInfo.png");
            PictureBox gameUpdateInfoPictureBox = gameUpdateInfo.GetPictureBox();
            _gameHomeTab.Controls.Add(gameUpdateInfoPictureBox);
            gameUpdateInfoPictureBox.Click += gameUpdateInfo_Click;

            // Separate boxes for better readability

            // Define a box for displaying game events
            GameHomeInfo gameEventInfo = new GameHomeInfo(new Size(300, 150), new Point(300, 400), @"homePageResources\banners\gameMainEvent.png");
            PictureBox gameEventInfoPictureBox = gameEventInfo.GetPictureBox();
            _gameHomeTab.Controls.Add(gameEventInfoPictureBox);
            gameEventInfoPictureBox.Click += gameEventInfo_Click;

            // Separate boxes for better readability

            // Define a box for displaying new episode information
            GameHomeInfo newEpisodeInfo = new GameHomeInfo(new Size(200, 200), new Point(600, 0), @"homePageResources\banners\newEPCommercal.png");
            PictureBox newEpisodeInfoPictureBox = newEpisodeInfo.GetPictureBox();
            _gameHomeTab.Controls.Add(newEpisodeInfoPictureBox);
            newEpisodeInfoPictureBox.Click += gameEpisodeInfo_Click;

            // Separate boxes for better readability

            // Define a box for displaying game mode updates
            GameHomeInfo gameModeUpd = new GameHomeInfo(new Size(200, 200), new Point(600, 200), @"homePageResources\banners\gameModeUpd.png");
            PictureBox gameModeUpdPictureBox = gameModeUpd.GetPictureBox();
            _gameHomeTab.Controls.Add(gameModeUpdPictureBox);
            gameModeUpdPictureBox.Click += AnisphiaAdventure_Click;

            // Separate boxes for better readability

            // Define a box for displaying the top-up menu
            GameHomeInfo topUpMenu = new GameHomeInfo(new Size(200, 150), new Point(600, 400), @"homePageResources\banners\topUpMenu.png");
            PictureBox topUpMenuPictureBox = topUpMenu.GetPictureBox();
            _gameHomeTab.Controls.Add(topUpMenuPictureBox);
            topUpMenuPictureBox.Click += topUpMenu_Click;

        }
        private void gameUpdateInfo_Click(object sender, EventArgs e)
        {
            InfoForm gameUpdateInfo = new InfoForm("Game Update Information", @"homePageResources\gameInfo\gameUpdatePatchNotes.txt", new Size(600, 400));
            gameUpdateInfo.Show();
        }

        private void gameEventInfo_Click(object sender, EventArgs e)
        {
            InfoForm gameEventInfo = new InfoForm("LycoReco Event Info", @"homePageResources\gameInfo\lycoRecoEvent.txt", new Size(800, 500));
            gameEventInfo.Show();
        }
        private void gameEpisodeInfo_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/watch?v=_R44IknzVpc");
        }
        private void AnisphiaAdventure_Click(object sender, EventArgs e)
        {
            //previous game event tab
            //edited to appears as real event, not scam announcement
            /*InfoForm gameModeInfo = new InfoForm("LycoReco Event Info", @"homePageResources\gameInfo\anisphiaBraveAdventure.txt", new Size(800, 500));
            gameModeInfo.Show();*/
            _playerBeginCurrency = _player.GetSetCurrency;
            AnisphiaBraveAdventure anisAdventure = new AnisphiaBraveAdventure(_player);
            anisAdventure.FormClosing += AnisphiaAdventure_FormClosing;
            anisAdventure.Show();
        }
        private void AnisphiaAdventure_FormClosing(object sender, FormClosingEventArgs e)
        {
            int changes;
            changes = _player.GetSetCurrency - _playerBeginCurrency;
            MessageBox.Show($"Congratulations! You got {changes} blue sky crystals");
            _playerCurrency.Text = _player.GetSetCurrency.ToString();
            string filePath = $"loginInformation\\{_player.Name}.txt";
            gameCurrencyChanges gameCurrencyChanges = new gameCurrencyChanges(filePath);
            gameCurrencyChanges.EditData(changes);
        }

        private void topUpMenu_Click(object sender, EventArgs e)
        {
            _tabControl.SelectedIndex = 6;
        }
    }
}
