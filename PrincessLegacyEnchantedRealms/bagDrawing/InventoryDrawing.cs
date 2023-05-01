using PrincessLegacyEnchantedRealms.clientDataManager;
using PrincessLegacyEnchantedRealms.clientDataManager.gameDataManager;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrincessLegacyEnchantedRealms.bagDrawing
{
    public class InventoryDrawing : CharacterArchieveDrawing
    {
        public InventoryDrawing(TabPage bagTab, Player player) : base(bagTab, player)
        {
            _player= player;
            _flowLayoutPanel.Location = new System.Drawing.Point(0, 0);
        }
        protected override void GenerateLocalFields()
        {
            _filePaths = new List<string>();
            ClientReadInventory clientReadInventory = new ClientReadInventory(_player);
            List<string> weaponIDs = clientReadInventory.GetCurrentWeapons;
            WeaponInventory clientReadWeaponData = new WeaponInventory(weaponIDs);
            List<Item> _items = clientReadWeaponData.InitializePlayerInventory();
            foreach (Item a in _items)
            {
                //store all image files inside the filepaths
                _filePaths.Add(a.GetSetAvatar);
                _fileName.Add(a.Name);
            }
        }
        protected override void DrawCircleCover() { }
        protected override void InitializeComponents()
        {
            base.InitializeComponents();
            foreach (Control control in _flowLayoutPanel.Controls)
            {
                if (control is PictureBox pictureBox)
                {
                    pictureBox.Size = new Size(60, 60);
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }

        protected override void PictureBox_Click(object sender, EventArgs e)
        {
            // Handle user clicking on a picture box
            PictureBox pb = (PictureBox)sender;
            // Do something with the selected image
            MessageBox.Show("I did something, cool?");
        }
    }
}
