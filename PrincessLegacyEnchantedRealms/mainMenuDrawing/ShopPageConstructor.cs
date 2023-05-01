using PrincessLegacyEnchantedRealms.clientDataManager;
using PrincessLegacyEnchantedRealms.clientDataManager.gameDataManager;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrincessLegacyEnchantedRealms.mainMenuDrawing
{
    public class ShopPageConstructor
    {
        private TabPage _gameShopTab;
        private Player _player;
        private Label _currency;
        public ShopPageConstructor(TabPage tabpage, Label currency, Player player)
        {
            _gameShopTab = tabpage;
            _currency = currency;
            _player = player;
            
        }
        public void ConstructShopPage(){
            GameHomeInfo gameTopUpMenu1 = new GameHomeInfo(new Size(200, 200), new Point(550, 20), @"homePageResources\shop\topup_1.png");
            PictureBox gameTopUpMenu1PictureBox = gameTopUpMenu1.GetPictureBox();
            gameTopUpMenu1PictureBox.Click += TopUp1_Click;
            _gameShopTab.Controls.Add(gameTopUpMenu1PictureBox);
            GameHomeInfo gameTopUpMenu2 = new GameHomeInfo(new Size(200, 200), new Point(550, 250), @"homePageResources\shop\topup_2.png");
            PictureBox gameTopUpMenu2PictureBox = gameTopUpMenu2.GetPictureBox();
            gameTopUpMenu2PictureBox.Click += TopUp2_Click;
            _gameShopTab.Controls.Add(gameTopUpMenu2PictureBox);
            GameHomeInfo gameTopUpMenu3 = new GameHomeInfo(new Size(200, 200), new Point(330, 250), @"homePageResources\shop\topup_3.png");
            PictureBox gameTopUpMenu3PictureBox = gameTopUpMenu3.GetPictureBox();
            gameTopUpMenu3PictureBox.Click += TopUp3_Click;
            _gameShopTab.Controls.Add(gameTopUpMenu3PictureBox);
        }
        // The current design separates saving and loading into separate iterations, which may result in the appearance of an additional method.

        // This design may seem repetitive and unnecessary, and ideally, it would have been avoided from the outset.

        // If time permits, I will endeavor to improve the design to eliminate this issue.
        private void TopUp1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to buy 980 Blue Sky crystals for $50?", "Confirm Purchase", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                _player.AddCurrency(980);
                _currency.Text = _player.GetSetCurrency.ToString();
                string filePath = $"loginInformation\\{_player.Name}.txt";
                gameCurrencyChanges gameCurrencyChanges = new gameCurrencyChanges(filePath);
                gameCurrencyChanges.EditData(980);
            }
        }
        private void TopUp2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to buy 3280 Blue Sky crystals for $100?", "Confirm Purchase", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                _player.AddCurrency(3280);
                _currency.Text = _player.GetSetCurrency.ToString();
                string filePath = $"loginInformation\\{_player.Name}.txt";
                gameCurrencyChanges gameCurrencyChanges = new gameCurrencyChanges(filePath);
                gameCurrencyChanges.EditData(3280);
            }
        }

        private void TopUp3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to buy 12960 Blue Sky crystals for $300?", "Confirm Purchase", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                _player.AddCurrency(12960);
                _currency.Text = _player.GetSetCurrency.ToString();
                string filePath = $"loginInformation\\{_player.Name}.txt";
                gameCurrencyChanges gameCurrencyChanges = new gameCurrencyChanges(filePath);
                gameCurrencyChanges.EditData(12960);
            }
        }
    }
}
