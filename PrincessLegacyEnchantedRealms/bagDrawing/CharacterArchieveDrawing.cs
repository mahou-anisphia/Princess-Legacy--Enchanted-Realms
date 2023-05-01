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
    public class CharacterArchieveDrawing
    {
        protected TabPage _bagTab;
        protected List<string> _filePaths;
        protected Player _player;
        protected FlowLayoutPanel _flowLayoutPanel = new FlowLayoutPanel();
        protected List<string> _fileName;
        private Form _winform;

        //Initialize Character Archieve's parameters drawing for the gamme
        public CharacterArchieveDrawing(TabPage bagTab, Player player)
        {
            //set the variables equal to the parameter
            _bagTab = bagTab;
            _player = player;
            _fileName = new List<string>();
            InitializeComponents();
        }
        public CharacterArchieveDrawing(){
            //this overload is created for inheritance
        }

        private TextBox _textBox; // add TextBox control to display file paths

        protected virtual void GenerateLocalFields()
        {
            _filePaths = new List<string>();
            ClientReadInventory clientReadInventory = new ClientReadInventory(_player);
            List<string> characterIDs = clientReadInventory.GetCurrentCharacters;
            CharacterHub clientReadCharacterData = new CharacterHub(characterIDs);
            List<Item> _items = clientReadCharacterData.InitializePlayerInventory();
            foreach (Item a in _items)
            {
                //store all image files inside the filepaths
                _filePaths.Add(a.GetSetAvatar);
                _fileName.Add(a.Name);
            }
        }
        public void Update()
        {
            InitializeComponents();
        }
        protected virtual void InitializeComponents()
        {
            GenerateLocalFields();

            // Create a new FlowLayoutPanel control and add it to the tab page
            //This implementation provide a better approach than the one used in the profile customization section
            //however due to limited time, I cannot change the profile customization's implementation

            _flowLayoutPanel.Location = new Point(200, 0); // set X-coordinate to 200
            _flowLayoutPanel.Size = new Size(600, 550);
            //_flowLayoutPanel.Dock = DockStyle.Right;
            _flowLayoutPanel.AutoScroll = true;
            _bagTab.Controls.Add(_flowLayoutPanel);
            int count = 0;

            // Add a PictureBox control for each image
            try
            {
                // Add a PictureBox control for each image
                foreach (string filePath in _filePaths)
                {
                    PictureBox pb = new PictureBox();
                    pb.Image = Image.FromFile(filePath);
                    pb.SizeMode = PictureBoxSizeMode.Zoom;
                    pb.Size = new Size(280, 280);
                    pb.Click += PictureBox_Click;
                    pb.Cursor = Cursors.Hand;
                    pb.Name = _fileName[count];
                    count++;
                    _flowLayoutPanel.Controls.Add(pb);
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                string errorMessage = $"An ArgumentOutOfRangeException occurred.\nMessage: {ex.Message}\n" +
                                      $"Count: {count}\n_filePaths.Count: {_filePaths.Count}\n_fileName.Count: {_fileName.Count}";
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            DrawCircleCover();
            // Add a TextBox control to display file paths
            //This code block is used to print the directory link on the window form,
            //and is necessary for development. Although it may impact the code's readablity
            // it should be kept in place until the feature is fully developed.
            //This block may be used again in the future, so it should not be deleted but can
            //be commented out if needed. This does not take any effect on user's experience
            /*_textBox = new TextBox();
            _textBox.Dock = DockStyle.Bottom;
            _textBox.Multiline = true;
            _textBox.ScrollBars = ScrollBars.Vertical;
            _textBox.Height = 100;
            _textBox.ReadOnly = true;
            _textBox.Text = string.Join(Environment.NewLine, _filePaths);
            _bagTab.Controls.Add(_textBox);*/
        }
        protected virtual void DrawCircleCover()
        {
            PictureBox frame = new PictureBox();
            frame.Image = Image.FromFile("homePageResources\\gameInventory\\profilecover.png");
            frame.SizeMode = PictureBoxSizeMode.Zoom;
            frame.Size = new Size(200, 200);
            frame.Location = new Point(20, 0);
            _bagTab.Controls.Add(frame);

            // Draw the number in the middle of the PictureBox
            Label numberLabel = new Label();

            //fix
            /*
             1. Bug discovered
             2. I acknowledges bug and says I'll fix it
             3. I resubmit a fix, but it doesn't work or causes new bugs
             4. I found out about the new bugs
             5. I acknowledges the complaints and says I'll fix everything in the next resubmit
             6. Repeat from step 1
             */


            //This one should stay inside the box
            //I've followed the cycle above for a while so I've decided to keep the old implementation

            numberLabel.Text = _filePaths.Count.ToString();
            numberLabel.Font = new Font("Segoe UI", 24, FontStyle.Bold);
            numberLabel.TextAlign = ContentAlignment.MiddleCenter;
            numberLabel.AutoSize = false;
            numberLabel.Size = new Size(50, 50);
            numberLabel.Location = new Point(frame.Location.X + (frame.Width / 2) - (numberLabel.Width / 2),
                                             frame.Location.Y + (frame.Height / 2) - (numberLabel.Height / 2));
            numberLabel.BackColor = Color.Transparent;
            numberLabel.ForeColor = Color.Black;
            _bagTab.Controls.Add(numberLabel);
            numberLabel.BringToFront();

            // Add the text "Character Owned" below the PictureBox
            Label textLabel = new Label();
            textLabel.Text = "Character Owned";
            textLabel.Font = new Font("Segoe UI", 14, FontStyle.Regular);
            textLabel.TextAlign = ContentAlignment.MiddleCenter;
            textLabel.Size = new Size(180, 25);
            textLabel.Location = new Point(frame.Location.X, frame.Location.Y + frame.Height + 5);
            textLabel.BackColor = Color.Transparent;
            textLabel.ForeColor = Color.Black;
            _bagTab.Controls.Add(textLabel);
            textLabel.BringToFront();
        }
        protected virtual void PictureBox_Click(object sender, EventArgs e)
        {
            // Handle user clicking on a picture box
            PictureBox pb = (PictureBox)sender;
            // Do something with the selected image (maybe opeing character's profile; under development)
            MessageBox.Show("You clicked on " + pb.Name);
        }
    }
}
