using PrincessLegacyEnchantedRealms.clientDataManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincessLegacyEnchantedRealms.GachaSystem
{
    public class _5StarsGachaSystem : _4StarsGachaSystem
    {
        public _5StarsGachaSystem(Player player) : base(player)
        {
        }
        protected override void ExecuteWish()
        {
            _wishResults = new List<Item>();
            Random random = new Random();

            // Always add a 5-star item to the wish results
            int fiveStarIndex = random.Next(_5starsItems.Count);
            Item fiveStarItem = _5starsItems[fiveStarIndex];
            _wishResults.Add(fiveStarItem);

            // Always add a 4-star item to the wish results, since every wish always have a 4 stars
            int fourStarIndex = random.Next(_4starsItems.Count);
            Item fourStarItem = _4starsItems[fourStarIndex];
            _wishResults.Add(fourStarItem);

            for (int i = 0; i < 8; i++)
            {
                // Add a 5-star item with a 1.2% chance, otherwise add a 4-star or 3-star item
                if (random.NextDouble() < 0.012)
                {
                    int additionalFiveStarIndex = random.Next(_5starsItems.Count);
                    Item additionalFiveStarItem = _5starsItems[additionalFiveStarIndex];
                    _wishResults.Add(additionalFiveStarItem);
                }
                else
                {
                    Item additionalItem = random.NextDouble() < 0.1 ? _4starsItems[random.Next(_4starsItems.Count)] : _3starsItems[random.Next(_3starsItems.Count)];
                    _wishResults.Add(additionalItem);
                }
            }
        }
    }
}
