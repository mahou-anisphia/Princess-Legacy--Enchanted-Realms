using PrincessLegacyEnchantedRealms.clientDataManager;
using PrincessLegacyEnchantedRealms.storyQuest;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrincessLegacyEnchantedRealms
{
    public partial class AnisphiaBraveAdventure : Form
    {
        //I can't find any Anisphia's picture so I'll use a pandoru to represent the character
        //main form of the winform, created automatically by window
        private int _speed = 10;
        private int _gravity = 5;
        private int _score = 0;
        private Player _player;
        //private Label _currencyStatus;
        public AnisphiaBraveAdventure(Player player)
        {
            _player = player;
            InitializeComponent();
            this.Icon = new Icon("anis.ico");
        }
        //overload method for testing the event page
        public AnisphiaBraveAdventure()
        {
            InitializeComponent();
            this.Icon = new Icon("anis.ico");
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pipeAbove_Click(object sender, EventArgs e)
        {

        }

        //game event handler
        private void gameTimerEvent(object sender, EventArgs e)
        {
            anis.Top += _gravity;
            pipeAbove.Left -= _speed;
            pipeBottom.Left -= _speed;
            scoreCheck.Text = "Score: " + _score;
            Random random = new Random();
            if (pipeBottom.Right < 0)
            {
                // Reset the bottom pipe to a random location between 800 and 900
                pipeBottom.Left = random.Next(800, 901);
                _score++;
            }
            if (pipeAbove.Right < 0)
            {
                // Reset the top pipe to a random location between 950 and 1050
                pipeAbove.Left = random.Next(950, 1051);
                _score++;
            }
            if (anis.Bounds.IntersectsWith(pipeBottom.Bounds) ||
                anis.Bounds.IntersectsWith(pipeAbove.Bounds) ||
                anis.Bounds.IntersectsWith(ground.Bounds) || anis.Top < -25
                )
            {
                endGame();
            }
            if (_score > 5 && _score % 5 == 0)
            {
                _speed += 2; // increase the pipe speed by 2 every time the score is divisible by 5
            }

        }

        private void gameKeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                _gravity = -12;
            }
        }
        private void endGame()
        {
            gameTimer.Stop();
            scoreCheck.Text += " Game over!!!";
            _player.AddCurrency(_score * 1000);
        }
        private void gameKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                _gravity = 12;
            }
        }
    }
}
