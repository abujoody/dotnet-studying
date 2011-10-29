using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Task3_3
{
    public partial class MainForm : Form
    {
        List<Button> buttons;
        Random r;
        TimeSpan gameTime;
        bool isNewGameStarted = false;

        public MainForm()
        {
            InitializeComponent();

            buttons = new List<Button>();
            buttons.Add(button1);
            buttons.Add(button2);
            buttons.Add(button3);
            buttons.Add(button4);
            buttons.Add(button5);
            buttons.Add(button6);
            buttons.Add(button7);
            buttons.Add(button8);
            buttons.Add(button9);
            buttons.Add(button10);
            buttons.Add(button11);
            buttons.Add(button12);
            buttons.Add(button13);
            buttons.Add(button14);
            buttons.Add(button15);
            buttons.Add(button16);

            gameTime = new TimeSpan(0, 0, 0);
        }

        private void OnGameButtonClick(object sender, EventArgs e)
        {
            if (!isNewGameStarted)
            {
                MessageBox.Show("Press \"Start New Game\"\nbutton to start game");
                return;
            }

            Button bt = (Button)sender;
            if (canMoveButton(bt))
            {
                moveButton(bt);

                if (isGameFinished())
                {
                    isNewGameStarted = false;
                    gameTimeTimer.Enabled = false;
                    MessageBox.Show("You win!!!");
                }
            }
        }

        bool canMoveButton(Button bt)
        {
            int index = 0;

            //check if top button is 'empty place' (with tag 16)
            index = tg(bt.Tag) - 4;
            if ((index > 0) && (buttonFromTag(index) == button16))
                return true;

            //check if left button is 'empty place' (with tag 16)
            index = tg(bt.Tag) - 1;
            if ((index > 0) && (index % 4 != 0) && (buttonFromTag(index) == button16))
                return true;

            //check if right button is 'empty place' (with tag 16)
            index = tg(bt.Tag) + 1;
            if ((index <= 16) && ((index - 1) % 4 != 0) && (buttonFromTag(index) == button16))
                return true;

            //check if bottom button is 'empty place' (with tag 16)
            index = tg(bt.Tag) + 4;
            if ((index <= 16) && (buttonFromTag(index) == button16))
                return true;

            //otherwise
            return false;
        }

        int tg(object tag)
        {
            return int.Parse((string)tag);
        }

        Button buttonFromTag(int tag)
        {
            foreach (Button bt in buttons)
            {
                if (tag == tg(bt.Tag))
                    return bt;
            }
            return null;
        }

        void moveButton(Button bt)
        {
            Point oldLocation = bt.Location;
            Size oldSize = bt.Size;
            int oldTag = tg(bt.Tag);

            bt.Location = button16.Location;
            bt.Size = button16.Size;
            bt.Tag = Convert.ToString(tg(button16.Tag));

            button16.Location = oldLocation;
            button16.Size = oldSize;
            button16.Tag = Convert.ToString(oldTag);
        }

        bool isGameFinished()
        {
            foreach (Button bt in buttons)
            {
                if (tg(bt.Tag) != int.Parse(bt.Text))
                    return false;
            }

            return true;
        }

        void shuffle()
        {
            EventArgs tmp = new EventArgs();
            for (int i = 0; i < 500; ++i)
            {
                int randIndex = r.Next(0, buttons.Count);
                while(!canMoveButton(buttons[randIndex]))
                {
                    randIndex = r.Next(0, buttons.Count);
                }
                moveButton(buttons[randIndex]);
            }
        }

        private void startNewGameButton_Click(object sender, EventArgs e)
        {
            isNewGameStarted = true;
            r = new Random((int)DateTime.Now.Ticks);
            shuffle();
            gameTime = new TimeSpan(0, 0, 0);
            TimeValueLabel.Text = gameTime.ToString(@"hh\:mm\:ss");
            gameTimeTimer.Enabled = true;
        }

        private void gameTimeTimer_Tick(object sender, EventArgs e)
        {
            gameTime = gameTime.Add(new TimeSpan(0, 0, 1));
            TimeValueLabel.Text = gameTime.ToString(@"hh\:mm\:ss");
        }
    }
}
