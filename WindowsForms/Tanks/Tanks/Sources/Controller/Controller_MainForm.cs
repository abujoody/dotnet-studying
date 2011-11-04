using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Tanks
{
    public partial class Controller_MainForm : Form
    {
        const int defSizeField = 260;
        const int defAmountTanks = 2;
        const int defAmountApples = 5;
        const int defSpeedGame = 40;

        View view;
        Model model;

        Thread modelPlay;

        public Controller_MainForm() : this(defSizeField) {}
        public Controller_MainForm(int sizeField) : this(sizeField, defAmountTanks) {}
        public Controller_MainForm(int sizeField, int amountTanks) : this(sizeField, amountTanks, defAmountApples) {}
        public Controller_MainForm(int sizeField, int amountTanks, int amountApples) : this(sizeField, amountTanks, amountApples, defSpeedGame) {}
        public Controller_MainForm(int sizeField, int amountTanks, int amountApples, int speedGame)
        {
            InitializeComponent();

            model = new Model(sizeField, amountTanks, amountApples, speedGame);

            view = new View(model);
            this.Controls.Add(view);
        }

        private void StartStopButton_Click(object sender, EventArgs e)
        {
            if (model.gameStatus == GameStatus.playing)
            {
                modelPlay.Abort();
                model.gameStatus = GameStatus.stopping;
                StartStopButton.Image = Properties.Resources.PlayButton;
            }
            else
            {
                StartStopButton.Focus();
                modelPlay = new Thread(model.Play);
                modelPlay.Start();
                model.gameStatus = GameStatus.playing;
                StartStopButton.Image = Properties.Resources.PauseButton;

                view.Invalidate();
            }
        }

        private void Controller_MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (modelPlay != null)
            {
                model.gameStatus = GameStatus.stopping;
                modelPlay.Abort();
            }

            DialogResult dr = MessageBox.Show("Are you sure you want close application?", this.Text, MessageBoxButtons.YesNoCancel);
            if (dr == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;
        }

        private void StartStopButton_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyData.ToString())
            {
                case "A":
                    model.Packman.NextDirect_x = -1;
                    model.Packman.NextDirect_y = 0;
                    break;

                case "D":
                    model.Packman.NextDirect_x = 1;
                    model.Packman.NextDirect_y = 0;
                    break;

                case "W":
                    model.Packman.NextDirect_x = 0;
                    model.Packman.NextDirect_y = -1;
                    break;

                case "S":
                    model.Packman.NextDirect_x = 0;
                    model.Packman.NextDirect_y = 1;
                    break;

                case "L":
                    model.Projectile.Direct_x = model.Packman.Direct_x;
                    model.Projectile.Direct_y = model.Packman.Direct_y;

                    if (model.Packman.Direct_y == -1)
                    {
                        model.Projectile.X = model.Packman.X + 10;
                        model.Projectile.Y = model.Packman.Y;
                    }
                    if (model.Packman.Direct_y == 1)
                    {
                        model.Projectile.X = model.Packman.X + 10;
                        model.Projectile.Y = model.Packman.Y + 20;
                    }
                    if (model.Packman.Direct_x == -1)
                    {
                        model.Projectile.X = model.Packman.X;
                        model.Projectile.Y = model.Packman.Y + 10;
                    }
                    if (model.Packman.Direct_x == 1)
                    {
                        model.Projectile.X = model.Packman.X + 20;
                        model.Projectile.Y = model.Packman.Y + 10;
                    }
                    break;
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
