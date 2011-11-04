using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Tanks
{
    class FireTank
    {
        FireTankImg ftImg = new FireTankImg();
        Image currentImage;

        public Image CurrentImage
        {
            get { return currentImage; }
        }

        Image[] img;

        int x, y;

        public int X
        {
            get { return x; }
            set { x = value; }
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public FireTank(int x, int y)
        {
            this.x = x;
            this.y = y;
            img = ftImg.Img;
            PutCurrentImage();
        }

        public void Fire()
        {
            PutCurrentImage();
        }

        int k;
        private void PutCurrentImage()
        {
            currentImage = img[k];
            k++;
            if (k == 6)
                k = 0;
        }
    }
}
