using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincessLegacyEnchantedRealms.clientDataManager
{
    public class ClientReadData
    {
        private string _fileName;
        private string _playerName;
        private int _playerLevel;
        private string _playerId;
        private string _playerDescribtion;
        private int _playerCurrency;
        public ClientReadData(string filename)
        {
            _fileName = $@"loginInformation\{filename}";
            ReadPlayerData();
        }
        public void ReadPlayerData()
        {
            string playerName = Path.GetFileNameWithoutExtension(_fileName); // Use the file name as the player name
            int playerLevel;
            string playerDescription;
            string playerPersonalFilePath;
            int playerCurrency;
            string[] lines = System.IO.File.ReadAllLines(_fileName);

            // Extract data from the second, third and fourth lines
            // Ingore first line: password
            playerLevel = int.Parse(lines[1]);  // Assumes the second line is the player's level
            playerDescription = lines[2];  // Assumes the third line is the player's description
            playerPersonalFilePath = lines[3]; // Assumes the forth line is the player's file path
            playerCurrency = int.Parse(lines[4]);  // Assumes the fifth line is the player's currency (an integer)

            // Do something with the extracted data
            _playerName = playerName;
            _playerLevel = playerLevel;
            _playerLevel= playerLevel;
            _playerId = playerPersonalFilePath;
            _playerDescribtion = playerDescription;
            _playerCurrency = playerCurrency;
        }
        public Player ReturnPlayer()
        {
            string playerProfilePicture = $@"{_playerId}\gameAvt.jpg";
            string playerProfileCover = $@"{_playerId}\gameCov.png";
            Player player = new Player(_playerDescribtion, _playerName, playerProfilePicture, playerProfileCover, _playerLevel, _playerCurrency);
            return player;
        }
    }
}
