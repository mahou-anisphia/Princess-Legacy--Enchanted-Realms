using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincessLegacyEnchantedRealms.clientDataManager
{
    public class Player : GameObjects
    {
        private string _coverImages;
        private int _level;
        private int _currency;
        public Player(string describtion, string name, string profileImages, string coverImages, int level, int currency) : base(describtion, name, profileImages)
        {
            _coverImages = coverImages;
            _level = level;
            _currency = currency;
        }
        public string GetSetCoverImages
        {
            get => _coverImages;
            set => _coverImages = value;
        }
        public int GetLevel
        {
            get => _level;
        }
        public int GetSetCurrency
        {
            get => _currency;
            set => _currency = value;
        }
        public void AddCurrency(int currency)
        {
            _currency += currency;
        }
    }
}
