using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MazeGame
{
    public partial class StartMenu : Form
    {

        public StartMenu()
        {
            InitializeComponent();
        }
        private void StartMenu_Move(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void instructionButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Navigate your way through the the entire maze.\n\nAvoid hitting the walls, traps and ghosts or you will be sent back to the start!\n\nFinding the correct teleporter will send you further into the maze, the treasure will take you near the finish.\n\nOnce you reach the finish, you have successfully completed the maze game!", "Maze Game - Instructions", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void creditButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created By: Jack Lockett", "Maze Game - Credits", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MazeGame MazeGameForm = new MazeGame();
            MazeGameForm.StartPosition = FormStartPosition.Manual;
            MazeGameForm.Location = this.Location;
            MazeGameForm.ShowDialog();
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
