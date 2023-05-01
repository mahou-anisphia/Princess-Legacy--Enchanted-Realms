using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrincessLegacyEnchantedRealms.storyQuest
{
    public class Scene
    {
        private string _filepath;
        private Form _windowForm;
        private PictureBox _pictureBox;
        public Scene(string filepath, Form windowForm)
        {
        _filepath= filepath;
        _windowForm= windowForm;
        }
        private TaskCompletionSource<bool> _clickTaskSource;
        public async Task PlayStoryAsync()
        //execute the background without colliding with user interface because story quest does not required UI
        //I've tried other implementation but with low experience in cleaning the RAM and almost blew up my pc, I've decided to implement async
        {
            foreach (string filePath in Directory.GetFiles(_filepath))
            {
                string[] lines = File.ReadAllLines(filePath);
                string folderpath = lines[0];
                string backgroundpath = lines[1];
                Scenery setBackgroundScenery = new Scenery(backgroundpath, _windowForm);
                NPCInteraction imgPathReader = new NPCInteraction(folderpath);
                string[] imagesPath = imgPathReader.GetImageResources();
                _pictureBox = new PictureBox();
                // Set the location and size of the picture box
                _pictureBox.Location = new Point(0, 0);
                _pictureBox.Dock = DockStyle.Fill;
                _pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                _windowForm.Controls.Add(_pictureBox);
                setBackgroundScenery.DrawImage(_pictureBox);
                foreach (string filename in imagesPath)
                {
                    Dialogue talk = new Dialogue(filename, _windowForm);
                    talk.DrawImage(_pictureBox);

                    _clickTaskSource = new TaskCompletionSource<bool>();

                    // Attach the click event handler to the PictureBox
                    _pictureBox.Click += PictureBox_Click;

                    // Wait for the click event to occur asynchronously
                    await _clickTaskSource.Task;

                    // Detach the click event handler from the PictureBox
                    _pictureBox.Click -= PictureBox_Click;
                }
                _windowForm.Controls.Remove(_pictureBox);
            }
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            // Signal the click event
            _clickTaskSource.SetResult(true);
        }

    }

}
