using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PrincessLegacyEnchantedRealms.clientDataManager.gameDataManager
{
    public class AvatarListModifier
    {
        private string _filePath;

        public AvatarListModifier(string filePath)
        {
            _filePath = filePath;
        }

        public void ModifyAvatarList(string newAvatarListPath)
        {
            List<string> fileLines = File.ReadAllLines(_filePath).ToList();

            // Replace the avatarList\gameavt line
            for (int i = 0; i < fileLines.Count; i++)
            {
                if (fileLines[i].StartsWith("avatarList\\"))
                {
                    fileLines[i] = newAvatarListPath;
                    break;
                }
            }

            // Save the updated file
            File.WriteAllLines(_filePath, fileLines);
        }
    }
}
