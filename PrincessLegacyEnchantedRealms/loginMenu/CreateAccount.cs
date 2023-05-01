using PrincessLegacyEnchantedRealms.storyQuest;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrincessLegacyEnchantedRealms.loginMenu
{
    public class CreateAccount : Login
    {
        public CreateAccount(Form windowForm) : base(windowForm)
        {
        }
        public override void AddControlsToForm()
        {
            _windowForm.Controls.Add(_usernameTextBox);
            _windowForm.Controls.Add(_passwordTextBox);
            //add stuffs to the current form
            _loginButton = new CustomButton(new Point(600, 575), new Size(360, 45), "Create new Account!", new Font("Segoe UI", 14, FontStyle.Regular), Color.FromArgb(255, 255, 255), Color.FromArgb(26, 26, 26), Color.FromArgb(67, 67, 67), Color.FromArgb(37, 37, 37));
            _loginButton.Click += LoginButton_Click;
            _windowForm.Controls.Add(_loginButton);
        }
        protected override async void LoginButton_Click(object sender, EventArgs e)
        {
            bool _loggedin = this.CheckForValidAccount();
            if (_loggedin)
            {
                string folderPath = @"loginInformation\"; // Replace with your folder path; the @ means this is plain string, no escaper allowed
                string fileName = $"{_usernameTextBox.Text}.txt"; 

                // Combine folder path and file name to get full file path
                string filePath = Path.Combine(folderPath, fileName);

                // Create a new text file
                using (StreamWriter writer = File.CreateText(filePath))
                {
                    writer.WriteLine(_passwordTextBox.Text);
                    writer.WriteLine(1);
                    writer.WriteLine("New Player");
                    writer.WriteLine(@"avatarList\gameAvt9");
                    writer.WriteLine(1600);
                    writer.WriteLine("InventoryStarts");
                }
                MessageBox.Show("create account sucessfully", "Authentication successful!", MessageBoxButtons.OK);
                for (int i = _windowForm.Controls.Count - 1; i >= 0; i--)
                {
                    Control control = _windowForm.Controls[i];
                    _windowForm.Controls.Remove(control);
                    control.Dispose();
                }
                Scene cutscreen = new Scene(@"gameStoryScript\gameIntro\", _windowForm);
                await cutscreen.PlayStoryAsync();
                MessageBox.Show("For your security reason, please log in again!", "Warning!", MessageBoxButtons.OK);
                _windowForm.Dispose();
            }
            else
            {
                MessageBox.Show("Username's already taken, or password was blank", "Account or Password Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool CheckForValidAccount()
        //Encapsulation
        {
            string username = _usernameTextBox.Text;
            string password = _passwordTextBox.Text;
            string folderPath = "loginInformation";
            foreach (string filePath in Directory.GetFiles(folderPath))
            {
                // Extract the filename (without extension) from the full file path
                string filename = Path.GetFileNameWithoutExtension(filePath);

                // Check if the filename matches the username entered by the user
                if (filename == username || string.IsNullOrEmpty(password))
                {
                    return false;
                }
            }
            // Code to valid user login, otherwise returns false
            return true;
        }
    }
}
