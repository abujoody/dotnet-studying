using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Tanks
{
    class Packman : IRun, ITurn, ITransparent, ICurrentPicture
    {
        PackmanImg packmanImg = new PackmanImg();
        Image[] img;
        Image currentImg;
        int x, y, direct_x, direct_y;
        int sizeField;

        public Image CurrentImg
        {
            get { return currentImg; }
        }

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

        public int Y
        {
            get { return y; }
        }

        public int X
        {
            get { return x; }
        }

        public Packman(int sizeField)
        {
            this.sizeField = sizeField;

            this.x = 120;
            this.y = 240;
            this.Direct_x = 0;
            this.Direct_y = -1;

            PutImg();

            PutCurrentImage();            
        }

        public void Run()
        {
            x += direct_x;
            y += direct_y;

            if (Math.IEEERemainder(x, 40) == 0 && Math.IEEERemainder(y, 40) == 0)
                Turn();

            PutCurrentImage();

            Transparent();
        }

        void PutImg()
        {
            if (direct_x == 1)
                img = packmanImg.Right;
            else if (direct_x == -1)
                img = packmanImg.Left;

            if (direct_y == 1)
                img = packmanImg.Down;
            else if (direct_y == -1)
                img = packmanImg.Up;
        }

        int k;
        private void PutCurrentImage()
        {
            currentImg = img[k];
            k++;
            if (k == 5)
                k = 0;
        }

        public void Turn()
        {
            //Implement!!!
            //.............
            //

            PutImg();
        }

        public void Transparent()
        {
            if (x == -1)
                x = sizeField - 21;
            if (x == sizeField - 19)
                x = 1;

            if (y == -1)
                y = sizeField - 21;
            if (y == sizeField - 19)
                y = 1;
        }
    }
}
