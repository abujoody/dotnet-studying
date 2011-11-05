using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace Task2_1
{
    public partial class MainForm : Form
    {
        Point firstPoint;
        int currentLabelIndex;
        ArrayList labels;

        public MainForm()
        {
            InitializeComponent();

            labels = new ArrayList();
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ArrayList labelsUnderClick = new ArrayList();
                foreach (Label lb in labels)
                {
                    if (lb.Bounds.Contains(e.Location))
                        labelsUnderClick.Add(lb);
                }
                if (labelsUnderClick.Count != 0)
                {
                    Label resultLabel = (Label)labelsUnderClick[0];
                    int temp = int.Parse(resultLabel.Text);
                    foreach (Label lb in labelsUnderClick)
                    {
                        int labelNumber = int.Parse(lb.Text);
                        if (temp < labelNumber)
                        {
                            temp = labelNumber;
                            resultLabel = lb;
                        }
                    }
                    this.Text = string.Format("Square of Label '" + resultLabel.Text + "' is {0} x {1} = {2}",
                        resultLabel.Size.Width, resultLabel.Size.Height, resultLabel.Size.Width * resultLabel.Size.Height);
                }
            }
            else if (e.Button == MouseButtons.Left)
            {
                firstPoint = e.Location;
            }
        }

        private void MainForm_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != System.Windows.Forms.MouseButtons.Left)
                return;

            Point lastPoint = e.Location;

            int left = Math.Min(firstPoint.X, lastPoint.X);
            int top = Math.Min(firstPoint.Y, lastPoint.Y);
            int width = Math.Abs(firstPoint.X - lastPoint.X);
            int height = Math.Abs(firstPoint.Y - lastPoint.Y);

            if ((width < 20) || (height < 20))
            {
                this.Text = "Warning: min size is 20 x 20";
            }
            else
            {
                this.Text = "Draw Rect";
                Label nextLabel = new Label();
                nextLabel.Text = Convert.ToString(++currentLabelIndex);
                nextLabel.BackColor = Color.Aqua;
                nextLabel.Location = new Point(left, top);
                nextLabel.Size = new Size(width, height);
                nextLabel.BorderStyle = BorderStyle.FixedSingle;
                nextLabel.Font = new Font(System.Drawing.FontFamily.GenericSerif,
                                            Math.Min(width, height) / 2);
                nextLabel.TextAlign = ContentAlignment.MiddleCenter;
                nextLabel.Enabled = false;

                labels.Add(nextLabel);
                this.Controls.Add(nextLabel);
            }
        }

        private void MainForm_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button != System.Windows.Forms.MouseButtons.Left)
                return;

            ArrayList labelsUnderClick = new ArrayList();
            foreach (Label lb in labels)
            {
                if (lb.Bounds.Contains(e.Location))
                    labelsUnderClick.Add(lb);
            }
            if (labelsUnderClick.Count != 0)
            {
                Label resultLabel = (Label)labelsUnderClick[0];
                int temp = int.Parse(resultLabel.Text);
                foreach (Label lb in labelsUnderClick)
                {
                    int labelNumber = int.Parse(lb.Text);
                    if (temp > labelNumber)
                    {
                        temp = labelNumber;
                        resultLabel = lb;
                    }
                }
                labels.Remove(resultLabel);
                this.Controls.Remove(resultLabel);
            }
        }
    }
}
