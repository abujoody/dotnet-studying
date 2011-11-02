using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Tanks
{
    class Wall
    {
        WallImg wallImg = new WallImg();
        Image img;

        public Image Img
        {
            get { return img; }
            set { img = value; }
        }

        public Wall()
        {
            img = wallImg.Img;
        }
    }
}
