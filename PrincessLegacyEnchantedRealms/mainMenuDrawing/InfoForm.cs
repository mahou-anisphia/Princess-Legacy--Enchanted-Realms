using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrincessLegacyEnchantedRealms.mainMenuDrawing
{
    public class InfoForm
    {
        private string title;
        private string filePath;
        private Size size;

        public InfoForm(string title, string filePath, Size size)
        {
            this.title = title;
            this.filePath = filePath;
            this.size = size;
        }

        public void Show()
        {
            // Initialize components
            Form form = new Form();
            form.Text = title;
            TextBox textBox = new TextBox();
            textBox.Multiline = true;
            textBox.ReadOnly = true;
            textBox.Dock = DockStyle.Fill;
            textBox.Font = new Font("Segoe UI", 12);

            // Read the contents of the file
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                textBox.AppendText(line + Environment.NewLine);
            }

            // Add and show the form
            form.Controls.Add(textBox);
            form.ClientSize = size;
            form.Icon = new Icon(@"homePageResources\gameInfo\collabIcon.ico");
            form.ShowDialog();
        }
    }

}
