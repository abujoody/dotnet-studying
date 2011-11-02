using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Tanks
{
    class Tank : IRun
    {
        TankImg tankImg = new TankImg();
        Image img;
        int x, y;

        public Tank()
        {
           img  = tankImg.Img;
        }

        public int Y
        {
            get { return y; }
        }

        public int X
        {
          get { return x; }
        }

        internal Image Img
        {
            get { return img; }
        }

        public void Run()
        {
            x = ++y;
        }
    }
}
