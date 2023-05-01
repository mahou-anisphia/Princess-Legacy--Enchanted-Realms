using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PrincessLegacyEnchantedRealms.clientDataManager.gameDataManager
{
    public class gameCurrencyChanges
    {
        private string filename;

        public gameCurrencyChanges(string filename)
        {
            this.filename = filename;
        }

        public void EditData(int numberToAdd)
        {
            // Read the data from the file
            string[] lines = File.ReadAllLines(filename);

            // Modify the 5th line
            int index = 4; // 5th line has index 4 (since arrays are 0-indexed)
            int value = int.Parse(lines[index]);
            value += numberToAdd;
            lines[index] = value.ToString();

            // Save the updated data back to the file
            File.WriteAllLines(filename, lines);
        }
    }
}
