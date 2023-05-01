using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PrincessLegacyEnchantedRealms.bagDrawing;
using PrincessLegacyEnchantedRealms.clientDataManager;
using PrincessLegacyEnchantedRealms.GachaSystem;
using PrincessLegacyEnchantedRealms.loginMenu;


namespace PrincessLegacyEnchantedRealms.mainMenuDrawing
{
    public class WishMenuDrawer
    {
        private TabControl _tabControl;
        private Player _player;
        private Label _playerCurrency;
        private BagDrawing _bagConstruct;
        public WishMenuDrawer(TabControl tabpage, Player player, Label playerCurrency, BagDrawing bagTabConstructor) {
            _playerCurrency= playerCurrency;
            _tabControl = tabpage;
            _tabControl.SelectedIndexChanged += new EventHandler(tabControl_SelectedIndexChanged);
            _player = player;
            _bagConstruct = bagTabConstructor;
        }
        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
        // Get the currently selected tab page
        TabPage selectedTabPage = _tabControl.SelectedTab;

        // Show a message box to warn the user
            if (_tabControl.SelectedIndex == 4){
                DialogResult result = MessageBox.Show("Are you sure you want to launch the external tool?",
                    "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    // Create and show the new form
                    WishWindow toolForm = new WishWindow(_player, _playerCurrency);
                    toolForm.Text = selectedTabPage.Text + " - External Tool";
                    toolForm.Disposed += ToolForm_Disposed;
                    toolForm.Show();
                }
                else
                {
                    // Select the previous tab page
                    int previousIndex = _tabControl.SelectedIndex == 0 ? 0 : _tabControl.SelectedIndex - 1;
                    _tabControl.SelectedIndex = previousIndex;
                }
            }
        }

        private void ToolForm_Disposed(object sender, EventArgs e)
        {
            _bagConstruct.Update();
        }
    }
}
