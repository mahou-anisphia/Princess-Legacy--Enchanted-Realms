using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincessLegacyEnchantedRealms.storyQuest
{
    public abstract class Interaction
    {
        protected string _imageFilePath;
        public Interaction(string imageFilePath)
        {
            _imageFilePath = imageFilePath;
        }
    }
}
