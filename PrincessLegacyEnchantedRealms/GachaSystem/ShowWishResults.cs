using PrincessLegacyEnchantedRealms.bagDrawing;
using PrincessLegacyEnchantedRealms.clientDataManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrincessLegacyEnchantedRealms.GachaSystem
{
    public class ShowWishResults : CharacterArchieveDrawing
    {
        private List<Item> _wishResults= new List<Item>();
        public ShowWishResults(List<Item> results, TabPage bagTab) {
            _wishResults = results;
            _bagTab = bagTab;
            InitializeComponents();
        }
        protected override void GenerateLocalFields()
        {
            _fileName = new List<string>();
            _filePaths= new List<string>();
            foreach (Item a in _wishResults)
            {
                //store all image files inside the filepaths
                _filePaths.Add(a.GetSetAvatar);
                _fileName.Add(a.Name);
            }
        }
        protected override void DrawCircleCover(){}
    }
}
