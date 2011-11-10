﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Media;

[assembly: CLSCompliant(true)]
namespace Tanks
{
    public partial class ControllerMainForm : Form
    {
        const int defSizeField = 260;
        const int defAmountTanks = 5;
        const int defAmountApples = 5;
        const int defSpeedGame = 40;

        View view;
        Model model;

        Thread modelPlay;

        bool isSound;

        SoundPlayer sp;

        public ControllerMainForm() : this(defSizeField) {}
        public ControllerMainForm(int sizeField) : this(sizeField, defAmountTanks) {}
        public ControllerMainForm(int sizeField, int amountTanks) : this(sizeField, amountTanks, defAmountApples) {}
        public ControllerMainForm(int sizeField, int amountTanks, int amountApples) : this(sizeField, amountTanks, amountApples, defSpeedGame) {}
        public ControllerMainForm(int sizeField, int amountTanks, int amountApples, int speedGame)
        {
            InitializeComponent();
            model = new Model(sizeField, amountTanks, amountApples, speedGame);

            model.changeStreep += new Streep(ChangerStatusStripLbl);

            view = new View(model);
            this.Controls.Add(view);

            isSound = true;

            sp = new SoundPlayer(Properties.Resources.TankMov);
        }

        private void StartStopButton_Click(object sender, EventArgs e)
        {
            if (model.gameStatus == GameStatus.playing)
            {
                modelPlay.Abort();
                model.gameStatus = GameStatus.stopping;
                StartStopButton.Image = Properties.Resources.PlayButton;
                ChangerStatusStripLbl();
            }
            else
            {
                StartStopButton.Focus();
                modelPlay = new Thread(model.Play);
                modelPlay.Start();
                model.gameStatus = GameStatus.playing;
                StartStopButton.Image = Properties.Resources.PauseButton;
                ChangerStatusStripLbl();

                view.Invalidate();
            }
        }

        private void Controller_MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            sp.Stop();

            if (modelPlay != null)
            {
                model.gameStatus = GameStatus.stopping;
                modelPlay.Abort();
            }

            DialogResult dr = MessageBox.Show("Are you sure you want close application?", this.Text, MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button2, MessageBoxOptions.DefaultDesktopOnly);
            if (dr == DialogResult.Yes)
                e.Cancel = false;
            else
            {
                e.Cancel = true;
            }
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

        private void NewGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            model.NewGame();
            StartStopButton.Image = Properties.Resources.PlayButton;
            view.Refresh();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Game Tanks (Packman) v1.0\nUse W, S, A, D to move and L to shoot.\nGather 5 apples to win.", "Tanks", MessageBoxButtons.OK,
                MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button2, MessageBoxOptions.DefaultDesktopOnly);
        }

        private void SoundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isSound = !isSound;
            if (isSound)
            {
                if (model.gameStatus == GameStatus.playing)
                    sp.PlayLooping();
                soundToolStripMenuItem.Image = Properties.Resources.SoundOn;
            }
            else
            {
                sp.Stop();
                soundToolStripMenuItem.Image = Properties.Resources.NoSound;
            }
        }

        void ChangerStatusStripLbl()
        {
            Invoke(new MethodInvoker(SafeChangerStatusStripLbl));
        }

        void SafeChangerStatusStripLbl()
        {
            GameStatus_lbl_ststr.Text = model.gameStatus.ToString();
            if (isSound)
            {
                if (model.gameStatus == GameStatus.playing)
                {
                    sp.PlayLooping();
                }
                else
                {
                    sp.Stop();
                }
            }
        }
    }
}