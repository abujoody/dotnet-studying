using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Tanks
{
    partial class View : UserControl
    {
        Model model;

        public View(Model model)
        {
            InitializeComponent();

            this.model = model;
        }

        void Draw(PaintEventArgs e)
        {
            Graphics gr = e.Graphics;

            DrawWall(gr);
            DrawTank(gr);
            
            if (model.gameStatus != GameStatus.playing)
                return;

            Thread.Sleep(model.speedGame);
            Invalidate();
        }

        private void DrawTank(Graphics gr)
        {
            foreach (Tank t in model.Tanks)
            {
                gr.DrawImage(t.CurrentImg, new Point(t.X, t.Y));
            }
        }

        private void DrawWall(Graphics gr)
        {
            for (int y = 20; y < 260; y += 40)
            {
                for (int x = 20; x < 260; x += 40)
                {
                    gr.DrawImage(model.wall.Img, new Point(x, y));
                }
            }
            
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Draw(e);
        }
    }
}
