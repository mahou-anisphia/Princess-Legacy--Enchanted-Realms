using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PrincessLegacyEnchantedRealms.clientDataManager.gameDataManager
{
    public class gameGachaModification
    {
        private string _filePath;

        public gameGachaModification(string filePath)
        {
            _filePath = filePath;
        }

        public void EditFile(List<string> newInventoryItems)
        {
            List<string> fileLines = File.ReadAllLines(_filePath).ToList();

            // Subtract 1600 from the line containing "1600"
            fileLines[4] = (int.Parse(fileLines[4]) - 1600).ToString();

            // Append new inventory items to the InventoryStarts section
            int inventoryStartsIndex = fileLines.FindIndex(line => line == "InventoryStarts");
            fileLines.InsertRange(inventoryStartsIndex + 1, newInventoryItems);

            // Save the updated file
            File.WriteAllLines(_filePath, fileLines);
        }
    }
}
