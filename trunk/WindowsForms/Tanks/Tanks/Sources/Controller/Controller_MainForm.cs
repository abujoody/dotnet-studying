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
        const int defAmountTanks = 5;
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (model.gameStatus == GameStatus.playing)
            {
                modelPlay.Abort();
                model.gameStatus = GameStatus.stopping;
            }
            else
            {
                modelPlay = new Thread(model.Play);
                modelPlay.Start();
                model.gameStatus = GameStatus.playing;

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
    }
}
