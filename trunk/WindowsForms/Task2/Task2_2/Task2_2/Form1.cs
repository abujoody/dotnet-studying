using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Task2_2
{
    public partial class MainForm : Form
    {
        Random r;

        public MainForm()
        {
            InitializeComponent();

            r = new Random((int)System.DateTime.Now.Ticks);
        }

        private void escapingLabel_MouseMove(object sender, MouseEventArgs e)
        {
            int tryCount = 3;
            int i = 0;
            Rectangle newRect = Rectangle.Empty;
            do
            {
                escape();
                newRect = new Rectangle(escapingLabel.Location, escapingLabel.Size);
                ++i;
            }
            while (i < tryCount && newRect.Contains(e.Location));
        }

        private void escape()
        {
            Rectangle clientRect = this.ClientRectangle;
            int newX = r.Next(clientRect.Left, clientRect.Right - escapingLabel.Size.Width);
            int newY = r.Next(clientRect.Top, clientRect.Bottom - escapingLabel.Size.Height);
            escapingLabel.Location = new Point(newX, newY);
        }
    }
}
