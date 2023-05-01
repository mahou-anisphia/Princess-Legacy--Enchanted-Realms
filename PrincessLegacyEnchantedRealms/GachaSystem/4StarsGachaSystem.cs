using PrincessLegacyEnchantedRealms.clientDataManager;
using PrincessLegacyEnchantedRealms.clientDataManager.gameDataManager;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrincessLegacyEnchantedRealms.GachaSystem
{
    public class _4StarsGachaSystem
    {
        protected Player _player;
        private List<Item> _systemItems;
        protected List<Item> _3starsItems; 
        protected List<Item> _4starsItems;
        protected List<Item> _5starsItems;
        protected List<Item> _wishResults;
        public _4StarsGachaSystem(Player player)
        {
            _player = player;
            InitializeWishSystem();
            ExecuteWish();
        }
        private void InitializeWishSystem()
        {
            CharacterHub systemChara = new CharacterHub();
            _systemItems = new List<Item>();
            _systemItems = systemChara.SystemLoadItem();
            WeaponInventory systemWep = new WeaponInventory();
            _systemItems.AddRange(systemWep.SystemLoadItem());
            _4starsItems= new List<Item>();
            _3starsItems= new List<Item>();
            _5starsItems= new List<Item>();
            foreach (Item item in _systemItems)
            {
                //using if, avoiding unexpected data flow in
                if (item.ShortDescribtion == "4stars")
                {
                    _4starsItems.Add(item);
                }
                if (item.ShortDescribtion == "3stars")
                {
                    _3starsItems.Add(item);
                }
                if (item.ShortDescribtion == "5stars")
                {
                    _5starsItems.Add(item);
                }
            }
        }
        protected virtual void ExecuteWish()
        {
            _wishResults = new List<Item>();
            Random random = new Random();

            // Always add a 4-star item to the wish results
            int fourStarIndex = random.Next(_4starsItems.Count);
            Item fourStarItem = _4starsItems[fourStarIndex];
            _wishResults.Add(fourStarItem);

            for (int i = 0; i < 9; i++)
            {
                // Add another 4-star item with a 10% chance, otherwise add a 3-star item
                Item additionalItem = random.NextDouble() < 0.1 ? _4starsItems[random.Next(_4starsItems.Count)] : _3starsItems[random.Next(_3starsItems.Count)];
                _wishResults.Add(additionalItem);
            }
        }
        public void UpdateInventory()
        {
            gameGachaModification gameGachaModification = new gameGachaModification($@"loginInformation\{_player.Name}.txt");
            List<string> resultFormatted = new List<string>();
            foreach (Item gacha in _wishResults)
            {
                if (gacha.ShortDescribtion == "3stars")
                {
                    resultFormatted.Add($"weapon:{gacha.Name}");
                }
                resultFormatted.Add($"character:{gacha.Name}");
            }
            gameGachaModification.EditFile( resultFormatted );
            Form results = new Form();
            TabPage tab = new TabPage();
            results.ClientSize = new Size(1000, 600);
            TabControl tabcontrol = new TabControl();
            tabcontrol.Dock= DockStyle.Fill;
            ShowWishResults showWishResult = new ShowWishResults(_wishResults, tab);
            tabcontrol.Controls.Add(tab);
            results.Controls.Add(tabcontrol);
            //results.Controls.Add(tab);
            results.Text = "Wish Result:";
            results.Show();
        }
    }
}
