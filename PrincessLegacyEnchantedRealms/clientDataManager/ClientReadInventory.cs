using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.LinkLabel;

namespace PrincessLegacyEnchantedRealms.clientDataManager
{
    // This code is written to read inventory
    // although it would be waste of hardware power when re-looping the process, however since the player data is small, I've used this way so it
    // would be the best way to reuse and mantainance codes.
    public class ClientReadInventory
    {
        private Player _player;
        private string _fileName;
        private List<string> _characters = new List<string>();
        private List<string> _weapons = new List<string>();
        public ClientReadInventory(Player player) {
            _player = player;
            _fileName = $@"loginInformation\{player.Name}.txt";
            ReadInventory();
        }
        public void ReadInventory()
        {
            bool isParsingInventory = false;
            string[] lines = File.ReadAllLines(_fileName);
            foreach (string line in lines)
            {
                if (line == "InventoryStarts")
                {
                    isParsingInventory = true;
                }
                else if (isParsingInventory)
                {
                    string[] parts = line.Split(':');
                    string type = parts[0].Trim();
                    string value = parts[1].Trim();
                    if (type == "character")
                    {
                        _characters.Add(value);
                    }
                    else if (type == "weapon")
                    {
                        _weapons.Add(value);
                    }

                }
            }
        }
        public List<string> GetCurrentCharacters
        {
            get => _characters;
        }
        public List<string> GetCurrentWeapons
        {
            get => _weapons;
        }

    }
}
