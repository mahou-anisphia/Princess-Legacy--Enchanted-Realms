using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrincessLegacyEnchantedRealms.gamePlayUI
{
    public class PlayForm : Form
    {
        private TabControl storyQuest;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private PictureBox scene1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label3;
        private Label label2;
        private Label label1;
        private TabPage tabPage3;
        public PlayForm()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.storyQuest = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.scene1 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.storyQuest.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scene1)).BeginInit();
            this.SuspendLayout();
            // 
            // storyQuest
            // 
            this.storyQuest.AccessibleName = "StoryQuest";
            this.storyQuest.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.storyQuest.Controls.Add(this.tabPage1);
            this.storyQuest.Controls.Add(this.tabPage2);
            this.storyQuest.Controls.Add(this.tabPage3);
            this.storyQuest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.storyQuest.Location = new System.Drawing.Point(0, 0);
            this.storyQuest.Multiline = true;
            this.storyQuest.Name = "storyQuest";
            this.storyQuest.SelectedIndex = 0;
            this.storyQuest.Size = new System.Drawing.Size(1000, 549);
            this.storyQuest.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = global::PrincessLegacyEnchantedRealms.Properties.Resources.sceen2TheBirthOfEnchantedDuels;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.pictureBox2);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.scene1);
            this.tabPage1.Location = new System.Drawing.Point(25, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(971, 541);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Chapter 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(726, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Scene3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(457, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Scene2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(109, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Scene1";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::PrincessLegacyEnchantedRealms.Properties.Resources.scene3;
            this.pictureBox2.Location = new System.Drawing.Point(680, 135);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(157, 88);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::PrincessLegacyEnchantedRealms.Properties.Resources.scene2;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(378, 343);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 75);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // scene1
            // 
            this.scene1.BackgroundImage = global::PrincessLegacyEnchantedRealms.Properties.Resources.scene1;
            this.scene1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.scene1.Location = new System.Drawing.Point(46, 92);
            this.scene1.Name = "scene1";
            this.scene1.Size = new System.Drawing.Size(163, 72);
            this.scene1.TabIndex = 0;
            this.scene1.TabStop = false;
            this.scene1.Click += new System.EventHandler(this.scene1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = global::PrincessLegacyEnchantedRealms.Properties.Resources.sceen3EuphylliaPast;
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Location = new System.Drawing.Point(25, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(971, 541);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Chapter 2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.BackgroundImage = global::PrincessLegacyEnchantedRealms.Properties.Resources.sceen4TheGameInvented;
            this.tabPage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage3.Location = new System.Drawing.Point(25, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(971, 541);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Chapter 3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // PlayForm
            // 
            this.ClientSize = new System.Drawing.Size(1000, 549);
            this.Controls.Add(this.storyQuest);
            this.Name = "PlayForm";
            this.storyQuest.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scene1)).EndInit();
            this.ResumeLayout(false);

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void scene1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is currently under development and is not yet fully functional. However, it is expected to perform similarly to the tutorial you've seen in the game. Please note that the app is still in beta, and we appreciate your patience as we work to improve and enhance its features. Thank you for your understanding.\r\n", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is currently under development and is not yet fully functional. However, it is expected to perform similarly to the tutorial you've seen in the game. Please note that the app is still in beta, and we appreciate your patience as we work to improve and enhance its features. Thank you for your understanding.\r\n", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is currently under development and is not yet fully functional. However, it is expected to perform similarly to the tutorial you've seen in the game. Please note that the app is still in beta, and we appreciate your patience as we work to improve and enhance its features. Thank you for your understanding.\r\n", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
    }
}
