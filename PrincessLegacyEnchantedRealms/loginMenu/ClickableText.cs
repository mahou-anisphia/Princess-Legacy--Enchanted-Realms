using System;
using System.Drawing;
using System.Windows.Forms;
namespace PrincessLegacyEnchantedRealms.loginMenu
{
    public class ClickableText
    {
        private Label _textLabel;
        //make a clear and no background clickable text found in many games
        public ClickableText(Form form, Point location, string text, EventHandler clickHandler)
        {
            // create a new label control with the specified text and font
            _textLabel = new Label();
            _textLabel.Font = new Font("Segoe UI", 14, FontStyle.Regular);
            _textLabel.Text = text;

            // set the label's location and size
            _textLabel.Location = new Point(location.X, location.Y + 50); //try to make it stay at the middle of the thing
            _textLabel.AutoSize = true;

            // set the label's color, underline style, and background color, it should look like a link
            _textLabel.ForeColor = Color.Blue;
            _textLabel.Cursor = Cursors.Hand;
            _textLabel.Font = new Font(_textLabel.Font, FontStyle.Underline);
            _textLabel.BackColor = Color.Transparent;

            // add the click handler to the label's Click event
            _textLabel.Click += clickHandler;

            // add the label to the form
            form.Controls.Add(_textLabel);
        }
    }
}
