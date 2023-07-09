
namespace MazeGame
{
    partial class StartMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartMenu));
            this.startButton = new System.Windows.Forms.Button();
            this.instructionButton = new System.Windows.Forms.Button();
            this.creditButton = new System.Windows.Forms.Button();
            this.versionLabel = new System.Windows.Forms.Label();
            this.logoPicture = new System.Windows.Forms.PictureBox();
            this.borderPicture = new System.Windows.Forms.PictureBox();
            this.quitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borderPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.startButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startButton.FlatAppearance.BorderSize = 0;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = System.Drawing.Color.MidnightBlue;
            this.startButton.Location = new System.Drawing.Point(182, 199);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(179, 55);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start Game";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // instructionButton
            // 
            this.instructionButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.instructionButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.instructionButton.FlatAppearance.BorderSize = 0;
            this.instructionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.instructionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionButton.ForeColor = System.Drawing.Color.MidnightBlue;
            this.instructionButton.Location = new System.Drawing.Point(427, 199);
            this.instructionButton.Name = "instructionButton";
            this.instructionButton.Size = new System.Drawing.Size(179, 55);
            this.instructionButton.TabIndex = 1;
            this.instructionButton.Text = "Instructions";
            this.instructionButton.UseVisualStyleBackColor = false;
            this.instructionButton.Click += new System.EventHandler(this.instructionButton_Click);
            // 
            // creditButton
            // 
            this.creditButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.creditButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.creditButton.FlatAppearance.BorderSize = 0;
            this.creditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.creditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditButton.ForeColor = System.Drawing.Color.MidnightBlue;
            this.creditButton.Location = new System.Drawing.Point(182, 282);
            this.creditButton.Name = "creditButton";
            this.creditButton.Size = new System.Drawing.Size(179, 55);
            this.creditButton.TabIndex = 2;
            this.creditButton.Text = "Credits";
            this.creditButton.UseVisualStyleBackColor = false;
            this.creditButton.Click += new System.EventHandler(this.creditButton_Click);
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versionLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.versionLabel.Location = new System.Drawing.Point(21, 408);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(98, 18);
            this.versionLabel.TabIndex = 3;
            this.versionLabel.Text = "Version: 1.0";
            // 
            // logoPicture
            // 
            this.logoPicture.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.logoPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.logoPicture.Image = global::MazeGame.Properties.Resources.Logo;
            this.logoPicture.Location = new System.Drawing.Point(182, 52);
            this.logoPicture.Name = "logoPicture";
            this.logoPicture.Size = new System.Drawing.Size(424, 102);
            this.logoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPicture.TabIndex = 4;
            this.logoPicture.TabStop = false;
            // 
            // borderPicture
            // 
            this.borderPicture.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.borderPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.borderPicture.Image = global::MazeGame.Properties.Resources.Border;
            this.borderPicture.Location = new System.Drawing.Point(-1, -2);
            this.borderPicture.Name = "borderPicture";
            this.borderPicture.Size = new System.Drawing.Size(803, 454);
            this.borderPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.borderPicture.TabIndex = 5;
            this.borderPicture.TabStop = false;
            // 
            // quitButton
            // 
            this.quitButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.quitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.quitButton.FlatAppearance.BorderSize = 0;
            this.quitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitButton.ForeColor = System.Drawing.Color.MidnightBlue;
            this.quitButton.Location = new System.Drawing.Point(427, 282);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(179, 55);
            this.quitButton.TabIndex = 6;
            this.quitButton.Text = "Quit Game";
            this.quitButton.UseVisualStyleBackColor = false;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // StartMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.logoPicture);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.creditButton);
            this.Controls.Add(this.instructionButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.borderPicture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "StartMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maze Game - Start Menu";
            this.Move += new System.EventHandler(this.StartMenu_Move);
            ((System.ComponentModel.ISupportInitialize)(this.logoPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borderPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button instructionButton;
        private System.Windows.Forms.Button creditButton;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.PictureBox logoPicture;
        private System.Windows.Forms.PictureBox borderPicture;
        private System.Windows.Forms.Button quitButton;
    }
}

