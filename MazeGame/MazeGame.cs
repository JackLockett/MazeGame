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
    public partial class MazeGame : Form
    {
        public MazeGame()
        {
            InitializeComponent();
            MoveCursorToStart();
            SetupHitboxes();
        }

        private void MazeGame_Move(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void SetupHitboxes()
        {
            HitPanel();
            HitTeleport();
            HitTrap();
            HitGhost();
            HitTreasure();
            HitFinish();
        }

        private void HitPanel()
        {
            foreach (var panel in this.Controls.OfType<Panel>())
            {
                MoveCursorToStart();
                panel.MouseEnter += panel_MouseEnter;
            }
        }

        private void HitTrap()
        {
            MoveCursorToStart();
            trapFinishLabel.MouseEnter += trap_MouseEnter;
            teleportTrapLabel.MouseEnter += trap_MouseEnter;
            teleportTrapLabel2.MouseEnter += trap_MouseEnter;
        }
        private void HitGhost()
        {
            MoveCursorToStart();
            ghostLabel1.MouseEnter += ghost_MouseEnter;
            ghostLabel2.MouseEnter += ghost_MouseEnter;
            ghostLabel3.MouseEnter += ghost_MouseEnter;
        }

        private void HitTeleport()
        {
            MoveCursorToTeleport();
            realTeleportLabel.MouseEnter += teleport_MouseEnter;
        }

        private void HitTreasure()
        {
            treasureLabel.MouseEnter += treasure_MouseEnter;
        }
        private void HitFinish()
        {
            finishLabel.MouseEnter += finish_MouseEnter;
        }

        private void MoveCursorToStart()
        {
            var CursorStart = startLabel.Location;
            Cursor.Position = PointToScreen(CursorStart);
        }
        private void MoveCursorToFinish()
        {
            var CursorFinish = treasureTeleportLabel.Location;
            Cursor.Position = PointToScreen(CursorFinish);
        }
        private void MoveCursorToTeleport()
        {
            var CursorTeleport = teleportLocation.Location;
            Cursor.Position = PointToScreen(CursorTeleport);
        }

        private void finish_MouseEnter(object sender, EventArgs e)
        {
            DialogResult finishDialog = MessageBox.Show("Congratulations, you finished the Maze Game!", "Maze Game", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (finishDialog == DialogResult.OK)
            {
                this.Hide();
                StartMenu StartMenuForm = new StartMenu();
                StartMenuForm.StartPosition = FormStartPosition.Manual;
                StartMenuForm.Location = this.Location;
                StartMenuForm.ShowDialog();
            }

        }
        private void treasure_MouseEnter(object sender, EventArgs e)
        {
            DialogResult treasureDialog = MessageBox.Show("You found the treasure, you will be teleported to the finish!", "Maze Game", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (treasureDialog == DialogResult.OK)
            {
                MoveCursorToFinish();
            }

        }

        private void teleport_MouseEnter(object sender, EventArgs e)
        {
            DialogResult teleportDialog = MessageBox.Show("You found the real teleporter! \n\nYou will be moved further into the maze.", "Maze Game", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (teleportDialog == DialogResult.OK)
            {
                MoveCursorToTeleport();
            }

        }

        private void trap_MouseEnter(object sender, EventArgs e)
        {
            DialogResult trapDialog = MessageBox.Show("You were tricked and fell into a trap!\n\nWould you like to play again?", "Maze Game", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

            if (trapDialog == DialogResult.Yes)
            {
                MoveCursorToStart();
            }
            else if (trapDialog == DialogResult.No)
            {
                this.Hide();
                StartMenu StartMenuForm = new StartMenu();
                StartMenuForm.StartPosition = FormStartPosition.Manual;
                StartMenuForm.Location = this.Location;
                StartMenuForm.ShowDialog();
            }

        }

        private void ghost_MouseEnter(object sender, EventArgs e)
        {
            DialogResult ghostDialog = MessageBox.Show("You were spooked by a ghost!\n\nWould you like to play again?", "Maze Game", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

            if (ghostDialog == DialogResult.Yes)
            {
                MoveCursorToStart();
            }
            else if (ghostDialog == DialogResult.No)
            {
                this.Hide();
                StartMenu StartMenuForm = new StartMenu();
                StartMenuForm.StartPosition = FormStartPosition.Manual;
                StartMenuForm.Location = this.Location;
                StartMenuForm.ShowDialog();
            }

        }

        private void panel_MouseEnter(object sender, EventArgs e)
        {
            DialogResult panelDialog = MessageBox.Show("You hit the wall!\n\nWould you like to play again?", "Maze Game", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (panelDialog == DialogResult.Yes)
            {
                MoveCursorToStart();
            }
            else if (panelDialog == DialogResult.No)
            {
                this.Hide();
                StartMenu StartMenuForm = new StartMenu();
                StartMenuForm.StartPosition = FormStartPosition.Manual;
                StartMenuForm.Location = this.Location;
                StartMenuForm.ShowDialog();
            }

        }
    }
}
