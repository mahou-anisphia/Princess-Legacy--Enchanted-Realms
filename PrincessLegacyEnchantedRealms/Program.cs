using PrincessLegacyEnchantedRealms.clientDataManager;
using PrincessLegacyEnchantedRealms.clientDataManager.gameDataManager;
using PrincessLegacyEnchantedRealms.loginMenu;
using PrincessLegacyEnchantedRealms.mainMenuDrawing;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrincessLegacyEnchantedRealms
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// This application using Window Form library. As the program grows, the implement may change a little bit
        [STAThread]
        static void Main()
        {
            //test code
            /*Form form = new AnisphiaAdventure();
            Application.Run(form);*/
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form form = new Form();
            form.Icon = new Icon("Euphy_icon.ico");
            form.Text = "Princess Legacy: Enchanted Realms - Login";

            //format the log in window

            Login loginMenu = new Login(form);
            loginMenu.AddControlsToForm();

            //Add the login to the form

            form.WindowState = FormWindowState.Maximized;
            Application.Run(form);

            string playerData = loginMenu.GetUserLoggedIn;
            if (playerData == "Error")
            {
                Form formForFirstTimeLogin = new Form();
                formForFirstTimeLogin.Icon = new Icon("Euphy_icon.ico");
                formForFirstTimeLogin.Text = "Princess Legacy: Enchanted Realms - Login";
                Login firstTime = new Login(formForFirstTimeLogin);
                firstTime.AddControlsToForm();
                formForFirstTimeLogin.WindowState = FormWindowState.Maximized;
                Application.Run(formForFirstTimeLogin);
                playerData = firstTime.GetUserLoggedIn;
                //if the user create account, this one prompt
            }
            //for testing
            //can this form be replaced by splashkit...? no, splashkit currently using language version 8
            //I tried to modify but can't
            ClientReadData readLoginData = new ClientReadData(playerData);
            Player player = readLoginData.ReturnPlayer(); //Take player's account

            Form client = new Form();
            client.ClientSize = new Size(1000, 600);
            client.Icon = new Icon("anis.ico");
            client.Text = "Princess Legacy: Enchanted Realms client";
            MenuConstructor menu = new MenuConstructor(client, player);
            menu.AddNavigationBar();
            Application.Run(client);
        }
    }
}
