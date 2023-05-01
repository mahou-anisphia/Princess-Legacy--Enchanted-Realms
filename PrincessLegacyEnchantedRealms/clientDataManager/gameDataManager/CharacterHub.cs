using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PrincessLegacyEnchantedRealms.clientDataManager.gameDataManager
{
    public class CharacterHub : ItemHub
    {

        public CharacterHub(List<string> playerCharacters)
        {
            _playerItems = playerCharacters;
            _directory = @"gameAsserts\characters";
            _systemItems = new List<Item>();
            _obtainedItems = new List<Item>();
            SystemLoadItems();
        }
        public CharacterHub()
        {
            _playerItems = new List<string>();
            _directory = @"gameAsserts\characters";
            _systemItems = new List<Item>();
            _obtainedItems = new List<Item>();
            SystemLoadItems();
        }
    }
}
