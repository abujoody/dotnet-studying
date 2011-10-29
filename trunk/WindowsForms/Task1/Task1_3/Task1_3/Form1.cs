using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Task1_3
{
    public partial class MainForm : Form
    {
        const int xMargin = 30;
        const int yMargin = 30;

        bool isControlButtonPressed = false;
        bool isClickPerformed = false;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics gr = e.Graphics;
            Pen pen = new Pen(Color.Black);
            Rectangle rect = new Rectangle(this.ClientRectangle.Location, this.ClientRectangle.Size);
            rect.Inflate(new Size(-xMargin, -yMargin));
            gr.DrawRectangle(pen, rect);
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void MainForm_MouseClick(object sender, MouseEventArgs e)
        {
            if (isControlButtonPressed)
                this.Close();

            if (e.Button == MouseButtons.Left)
            {
                Point pt = e.Location;
                Point bottomRightMargin = new Point(this.ClientRectangle.Right, this.ClientRectangle.Bottom);

                string message = "";
                if ((pt.X > xMargin) && (pt.Y > yMargin) && (pt.X < bottomRightMargin.X - xMargin) && (pt.Y < bottomRightMargin.Y - yMargin))
                    message = "Inside";
                else if ((pt.X < xMargin) || (pt.Y < yMargin) || (pt.X > bottomRightMargin.X - xMargin) || (pt.Y > bottomRightMargin.Y - yMargin))
                    message = "Outside";
                else
                    message = "On the border";

                MessageBox.Show(message);
            }
            else if (e.Button == MouseButtons.Right)
            {
                this.Text = string.Format("Width = {0}, Height = {1}", this.ClientSize.Width, this.ClientSize.Height);
            }

            isClickPerformed = true;
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
                isControlButtonPressed = true;
        }

        private void MainForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (!e.Control)
                isControlButtonPressed = false;
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isClickPerformed)
                this.Text = string.Format("X = {0}, Y = {1}", e.Location.X, e.Location.Y);
            else
                isClickPerformed = false;
        }
    }
}
