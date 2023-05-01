using PrincessLegacyEnchantedRealms.clientDataManager;
using PrincessLegacyEnchantedRealms.clientDataManager.gameDataManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrincessLegacyEnchantedRealms.bagDrawing
{
    public class BagDrawing
    {
        private TabPage _bagTab;
        private Player _player;
        private CharacterArchieveDrawing _charaDraw;
        private InventoryDrawing _wepInvent;
        public BagDrawing (TabPage bagTab, Player player)
        {
            _bagTab = bagTab;
            _player = player;
            Initialize();
        }
        private void Initialize()
        {
            TabControl tab1 = new TabControl();
            tab1.Dock = DockStyle.Fill;
            TabPage charaArchieve = new TabPage("Character Archieve");
            charaArchieve.Width = 300;
            TabPage inventory = new TabPage("Inventory");
            tab1.Controls.Add(charaArchieve);
            tab1.Controls.Add(inventory);
            _bagTab.Controls.Add(tab1);
            _charaDraw = new CharacterArchieveDrawing(charaArchieve, _player);
            _wepInvent = new InventoryDrawing(inventory, _player);
        }
        public void Update()
        {
            _charaDraw.Update();
            _wepInvent.Update();
        }
    }
}
