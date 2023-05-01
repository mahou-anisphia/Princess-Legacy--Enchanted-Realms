using PrincessLegacyEnchantedRealms.TextBoxes.loginMenu;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace PrincessLegacyEnchantedRealms.loginMenu
{
    public class Login
    {
        protected Form _windowForm;
        protected readonly CustomTextBox _usernameTextBox;
        protected readonly CustomTextBox _passwordTextBox;
        protected CustomButton _loginButton;
        protected bool _loggedin = false;
        private string _logincredentals;
        public Login(Form windowForm)
        {
            //I realized that there are ways better to implement this, however I don't have time to fix the old iterations. 
            _windowForm = windowForm;
            _windowForm.BackgroundImage = Image.FromFile("loginMenu/resources/login_screen.png");
            _windowForm.BackgroundImageLayout = ImageLayout.Stretch;

            _usernameTextBox = new CustomTextBox(new Point(600, 395), new Size(360, 70), new Font("Segoe UI", 24, FontStyle.Regular), Color.FromArgb(244, 233, 239), Color.FromArgb(74, 65, 62));
            _usernameTextBox.Name = "usernameTextBox";
            _usernameTextBox.Text = "Username";
            _usernameTextBox.ReadOnly = false;

            _passwordTextBox = new CustomTextBox(new Point(600, 475), new Size(360, 70), new Font("Segoe UI", 24, FontStyle.Regular), Color.FromArgb(244, 233, 239), Color.FromArgb(74, 65, 62));
            _passwordTextBox.Name = "passwordTextBox";
            _passwordTextBox.Text = "Password";
            _passwordTextBox.ReadOnly = false;
            _passwordTextBox.PasswordChar = '*';
            //Since these two won't change by any means, so it will be defined once in this constructor

        }

        public virtual void AddControlsToForm()
        {
            _windowForm.Controls.Add(_usernameTextBox);
            _windowForm.Controls.Add(_passwordTextBox);
            //add stuffs to the current form
            _loginButton = new CustomButton(new Point(600, 575), new Size(360, 45), "Log in", new Font("Segoe UI", 14, FontStyle.Regular), Color.FromArgb(255, 255, 255), Color.FromArgb(26, 26, 26), Color.FromArgb(67, 67, 67), Color.FromArgb(37, 37, 37));
            _loginButton.Click += LoginButton_Click;
            _loginButton.KeyDown += new KeyEventHandler(PasswordTextBox_KeyDown);
            _windowForm.Controls.Add(_loginButton);
            ClickableText clickableText = new ClickableText(_windowForm, new Point(710, 630), "New account?", NewAccountLabel_Click);
        }
        //somehow did not work
        private void PasswordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                LoginButton_Click(sender, e);
            }
        }

        private void NewAccountLabel_Click(object sender, EventArgs e)
        {
            for (int i = _windowForm.Controls.Count - 1; i >= 0; i--)
            {
                Control control = _windowForm.Controls[i];
                _windowForm.Controls.Remove(control);
                control.Dispose();
            }
            _logincredentals = "Error";
            CreateAccount loginMenu = new CreateAccount(_windowForm);
            loginMenu.AddControlsToForm();
        }
        protected virtual void LoginButton_Click(object sender, EventArgs e)
        {
            bool _loggedin = this.AuthenticateUser();
            if (_loggedin)
            {
                MessageBox.Show("hello there", "Authentication successful!", MessageBoxButtons.OK);
                _windowForm.Dispose();
            }
            else
            {
                MessageBox.Show("Please try again or click Create Account to create a new one", "Account or Password Error");
            }
        }

        private bool AuthenticateUser()
            //Encapsulation
        {
            string username = _usernameTextBox.Text;
            string password = _passwordTextBox.Text;
            string userpass;
            string folderPath = "loginInformation";
            foreach (string filePath in Directory.GetFiles(folderPath))
            {
                // Extract the filename (without extension) from the full file path
                string filename = Path.GetFileNameWithoutExtension(filePath);

                // Check if the filename matches the username entered by the user
                if (filename == username)
                {
                    // Read the first line of the file (in this case, the password)
                    userpass = File.ReadLines(filePath).First();
                    if (password == userpass) {
                        _logincredentals = $@"{username}.txt";
                        return true;
                    }
                    return false;

                    // Exit the loop since we have found the file we were looking for
                }
            }
            // Code to valid user login, otherwise returns false
            return false;
        }
        public bool GetLoginState { get => _loggedin; }
        public string GetUserLoggedIn { get => _logincredentals; }
    }
}
