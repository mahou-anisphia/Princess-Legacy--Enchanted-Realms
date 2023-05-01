namespace PrincessLegacyEnchantedRealms
{
    partial class AnisphiaBraveAdventure
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.scoreCheck = new System.Windows.Forms.Label();
            this.anis = new System.Windows.Forms.PictureBox();
            this.pipeAbove = new System.Windows.Forms.PictureBox();
            this.pipeBottom = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.anis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeAbove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            this.SuspendLayout();
            // 
            // scoreCheck
            // 
            this.scoreCheck.AutoSize = true;
            this.scoreCheck.BackColor = System.Drawing.Color.Transparent;
            this.scoreCheck.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreCheck.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.scoreCheck.Location = new System.Drawing.Point(-2, 0);
            this.scoreCheck.Name = "scoreCheck";
            this.scoreCheck.Size = new System.Drawing.Size(171, 54);
            this.scoreCheck.TabIndex = 4;
            this.scoreCheck.Text = "Score: 0";
            // 
            // anis
            // 
            this.anis.BackColor = System.Drawing.Color.Transparent;
            this.anis.Image = global::PrincessLegacyEnchantedRealms.Properties.Resources.pandoru_removebg_preview1;
            this.anis.Location = new System.Drawing.Point(59, 179);
            this.anis.Name = "anis";
            this.anis.Size = new System.Drawing.Size(83, 97);
            this.anis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.anis.TabIndex = 0;
            this.anis.TabStop = false;
            this.anis.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pipeAbove
            // 
            this.pipeAbove.Image = global::PrincessLegacyEnchantedRealms.Properties.Resources.pipedown;
            this.pipeAbove.Location = new System.Drawing.Point(414, 0);
            this.pipeAbove.Name = "pipeAbove";
            this.pipeAbove.Size = new System.Drawing.Size(66, 142);
            this.pipeAbove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeAbove.TabIndex = 3;
            this.pipeAbove.TabStop = false;
            this.pipeAbove.Click += new System.EventHandler(this.pipeAbove_Click);
            // 
            // pipeBottom
            // 
            this.pipeBottom.Image = global::PrincessLegacyEnchantedRealms.Properties.Resources.pipe;
            this.pipeBottom.Location = new System.Drawing.Point(400, 368);
            this.pipeBottom.Name = "pipeBottom";
            this.pipeBottom.Size = new System.Drawing.Size(80, 188);
            this.pipeBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeBottom.TabIndex = 2;
            this.pipeBottom.TabStop = false;
            // 
            // ground
            // 
            this.ground.Image = global::PrincessLegacyEnchantedRealms.Properties.Resources.ground;
            this.ground.Location = new System.Drawing.Point(-5, 533);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(535, 50);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 1;
            this.ground.TabStop = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // AnisphiaBraveAdventure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(527, 582);
            this.Controls.Add(this.anis);
            this.Controls.Add(this.scoreCheck);
            this.Controls.Add(this.pipeAbove);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.pipeBottom);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AnisphiaBraveAdventure";
            this.Text = "Anisphia\'s Brave Adventure";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gameKeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gameKeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.anis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeAbove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox anis;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox pipeBottom;
        private System.Windows.Forms.PictureBox pipeAbove;
        private System.Windows.Forms.Label scoreCheck;
        private System.Windows.Forms.Timer gameTimer;
    }
}

