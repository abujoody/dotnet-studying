using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Collections;
using System.Media;

namespace CrazyButtons
{
    public partial class MainForm : Form
    {
        const int startX = 12;
        delegate bool ChangeXCoordinateDelegate(Button bt, int deltaX);
        delegate void ShowResultsDelegate(Button bt);
        ArrayList movingButtons = new ArrayList();
        bool gameEnd = false;
        string resultInfo = "";
        int finishedThreadsCount = 4;
        Thread[] threads = new Thread[4];

        SoundPlayer sp;

        public MainForm()
        {
            InitializeComponent();

            movingButtons.Add(button1);
            movingButtons.Add(button2);
            movingButtons.Add(button3);
            movingButtons.Add(button4);

            sp = new SoundPlayer(Properties.Resources.movingSound);
        }

        /// <summary>
        /// Is called on button press. Starts thread for buttons moving
        /// </summary>
        /// <param name="sender">Object Button</param>
        /// <param name="e">Event arguments</param>
        private void StartButton_Click(object sender, EventArgs e)
        {
            if (finishedThreadsCount == 4)
            {
                sp.Load();
                sp.PlayLooping();
                gameEnd = false;
                resultInfo = "";
                finishedThreadsCount = 0;
                int i = 0;
                foreach (Button bt in movingButtons)
                {
                    threads[i] = new Thread(new ParameterizedThreadStart(moveButton));
                    threads[i].IsBackground = true;
                    threads[i].Start(bt);
                    ++i;
                }
            }
        }

        private void showResults(Button bt)
        {
            lock (this)
            {
                ++finishedThreadsCount;

                resultInfo += "\n";
                resultInfo += bt.Text;

                if (finishedThreadsCount == 4)
                {
                    sp.Stop();

                    MessageBox.Show(resultInfo);

                    Invoke(new MethodInvoker(moveButtonsToStart));
                }
            }
        }

        private void moveButtonsToStart()
        {
            foreach (Button button in movingButtons)
            {
                button.Location = new Point(startX, button.Location.Y);
                button.BackColor = SystemColors.Control;
            }
        }

        private bool changeCoord(Button bt, int deltaX)
        {
            lock (this)
            {
                bt.Location = new Point(bt.Location.X + deltaX, bt.Location.Y);

                if (bt.Right >= finishPictureBox.Location.X)
                {
                    if (!gameEnd)
                    {
                        gameEnd = true;
                        for (int i = 0; i < movingButtons.Count; ++i)
                        {
                            ((Button)movingButtons[i]).BackColor = SystemColors.Control;
                        }
                        bt.BackColor = Color.Yellow;
                    }
                    return true;
                }

                int maxXIndex = 0;
                for (int i = 0; i < movingButtons.Count; ++i)
                {
                    if (((Button)movingButtons[maxXIndex]).Location.X < ((Button)movingButtons[i]).Location.X)
                        maxXIndex = i;
                }
                for (int i = 0; i < movingButtons.Count; ++i)
                {
                    if (i == maxXIndex)
                    {
                        ((Button)movingButtons[i]).BackColor = Color.Yellow;
                    }
                    else
                    {
                        ((Button)movingButtons[i]).BackColor = SystemColors.Control;
                    }
                }

                return false;
            }
        }

        private void moveButton(object obj)
        {
            if (obj is Button)
            {
                Button bt = (Button)obj;
                ChangeXCoordinateDelegate del = new ChangeXCoordinateDelegate(changeCoord);
                bool finish = false;
                Random delta = new Random(DateTime.UtcNow.Millisecond);
                Random sleepInterval = new Random(DateTime.UtcNow.Millisecond);
                object[] args = new object[] { bt, delta.Next(1, 5) };
                do
                {
                    if (InvokeRequired)
                    {
                        finish = (bool)Invoke(del, args);
                    }
                    else
                    {
                        finish = changeCoord(bt, delta.Next(5, 10));
                    }
                    Thread.Sleep(sleepInterval.Next(10, 20));
                }
                while (!finish);
                showResults(bt);
                Console.WriteLine("Thread for Button '" + bt.Text + "' is finished");
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopButton_Click(sender, new EventArgs());
        }

        /// <summary>
        /// Susspends button moving
        /// </summary>
        /// <param name="sender">bbbbbbbbbb</param>
        /// <param name="e">eeeeeeeeeeee</param>
        private void SuspendButton_Click(object sender, EventArgs e)
        {
            if (threads[0] != null)
            {
                sp.Stop();
                foreach (Thread th in threads)
                {
                    if (th.IsAlive)
                    {
                        th.Suspend();
                    }
                }
            }
        }

        private void ResumeButton_Click(object sender, EventArgs e)
        {
            sp.PlayLooping();
            foreach (Thread th in threads)
            {
                if (th.IsAlive)
                {
                    th.Resume();
                }
            }
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            sp.Stop();
            SuspendButton_Click(sender, e);
            finishedThreadsCount = 4;
            moveButtonsToStart();
        }
    }
}
