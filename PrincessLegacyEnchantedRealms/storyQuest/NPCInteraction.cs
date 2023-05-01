using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PrincessLegacyEnchantedRealms.storyQuest
{
    public class NPCInteraction : Interaction
    {
        public NPCInteraction(string imageFilePath) : base(imageFilePath)
        {
            _imageFilePath= imageFilePath;
        }
        public string[] GetImageResources()
        {
            string folderPath = $@"{_imageFilePath}";
            string[] files = Directory.GetFiles(folderPath, "*.png");
            string[] fileNames = new string[files.Length];
            //read all image files in the passed folder
            for (int i = 0; i < files.Length; i++)
            {
                string fileName = $"{_imageFilePath}{Path.GetFileNameWithoutExtension(files[i])}.png";
                fileNames[i] = fileName;
            }
            return fileNames;
        }
    }
}
