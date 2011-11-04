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
            DrawApple(gr);
            DrawTank(gr);
            DrawPackman(gr);
            DrawProjectile(gr);

            if (model.gameStatus != GameStatus.playing)
                return;

            Thread.Sleep(model.speedGame);
            Invalidate();
        }

        private void DrawProjectile(Graphics gr)
        {
            gr.DrawImage(model.Projectile.Img, new Point(model.Projectile.X, model.Projectile.Y));
        }

        private void DrawPackman(Graphics gr)
        {
            gr.DrawImage(model.Packman.CurrentImg, new Point(model.Packman.X, model.Packman.Y));
        }

        private void DrawApple(Graphics gr)
        {
            for (int i = 0; i < model.Apples.Count; i++)
            {
                gr.DrawImage(model.Apples[i].Img, new Point(model.Apples[i].X, model.Apples[i].Y));
            }
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
