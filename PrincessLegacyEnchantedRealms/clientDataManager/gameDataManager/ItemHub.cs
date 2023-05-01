using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincessLegacyEnchantedRealms.clientDataManager.gameDataManager
{
    public abstract class ItemHub
    {
        protected string _directory;
        protected List<Item> _systemItems;
        protected List<string> _playerItems;
        protected List<Item> _obtainedItems;

        protected void SystemLoadItems()
        {
            foreach (string subDirectory in Directory.GetDirectories(_directory))
            {
                string[] textfile = Directory.GetFiles(subDirectory, "*txt");
                string description = Path.GetFileNameWithoutExtension(textfile[0]);

                //note: Image is FULL PATH, no need modification
                string[] imagefile = Directory.GetFiles(subDirectory, "*png");
                string itemImage = Path.GetFullPath(imagefile[0]);

                //note: name will be stored into player's account files
                string itemName = Path.GetFileName(subDirectory);
                Item gameItem = new Item(description, itemName, itemImage);
                _systemItems.Add(gameItem);
            }
        }

        public List<Item> InitializePlayerInventory()
        {
            foreach (Item systemItem in _systemItems)
            {
                string itemID = systemItem.Name;
                foreach (string itemName in _playerItems)
                {
                    if (itemID == itemName)
                    {
                        _obtainedItems.Add(systemItem);
                    }
                }
            }
            return _obtainedItems;
        }
        public List<Item> SystemLoadItem()
        {
            return _systemItems;
        }
    }
}
