using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PrincessLegacyEnchantedRealms.clientDataManager.gameDataManager
{
    public class WeaponInventory : ItemHub
    {
        public WeaponInventory(List<string> playerWeapons)
        {
            _playerItems = playerWeapons;
            _directory = @"gameAsserts\weapons\";
            _systemItems = new List<Item>();
            _obtainedItems = new List<Item>();
            SystemLoadItems();
        }
        public WeaponInventory()
        {
            _playerItems = new List<string>();
            _directory = @"gameAsserts\weapons\";
            _systemItems = new List<Item>();
            _obtainedItems = new List<Item>();
            SystemLoadItems();
        }
    }
}
