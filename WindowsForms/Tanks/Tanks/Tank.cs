using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Tanks
{
    class Tank : IRun, ITurn
    {
        TankImg tankImg = new TankImg();
        Image img;
        int x, y, direct_x, direct_y;

        static Random r;

        public int Direct_y
        {
            get { return direct_y; }
            set { if (value == 0 || value == -1 || value == 1) direct_y = value; else direct_y = 0; }
        }

        public int Direct_x
        {
            get { return direct_x; }
            set { if (value == 0 || value == -1 || value == 1) direct_x = value; else direct_x = 0; }
        }

        public Tank()
        {
            r = new Random();

            img  = tankImg.Img;

            Direct_x = 0;
            Direct_y = 1;
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
            x += direct_x;
            y += direct_y;
        }

        public void Turn()
        {
            if (Math.IEEERemainder(x, 40) == 0 && Math.IEEERemainder(y, 40) == 0)
            {
                if (r.Next(5000) < 2500) // if true moving in vertical direction
                {
                    if (Direct_y != 0)
                        Direct_y = Direct_y;
                    else
                    {
                        direct_x = 0;
                        while (Direct_y == 0)
                            Direct_y = r.Next(-1, 2);
                    }
                }
                else //horisontal direction
                {
                    if (Direct_x != 0)
                        Direct_x = Direct_x;
                    else
                    {
                        direct_y = 0;
                        while (Direct_x == 0)
                            Direct_x = r.Next(-1, 2);
                    }
                }
            }
        }
    }
}
