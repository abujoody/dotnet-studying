using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Tanks
{
    class Model
    {
        int sizeField;
        int amountTanks;
        int amountApples;
        public int speedGame;

        public GameStatus gameStatus;

        static Random r;

        List<Tank> tanks;
        public Wall wall;

        internal List<Tank> Tanks
        {
            get { return tanks; }
            set { tanks = value; }
        }

        public Model(int sizeField, int amountTanks, int amountApples, int speedGame)
        {
            r = new Random();

            tanks = new List<Tank>();

            this.sizeField = sizeField;
            this.amountTanks = amountTanks;
            this.amountApples = amountApples;
            this.speedGame = speedGame;

            CreateTanks();
            wall = new Wall();

            gameStatus = GameStatus.stopping;
        }

        private void CreateTanks()
        {
            int x, y;
            while (tanks.Count < amountTanks)
            {
                x = r.Next(6) * 40;
                y = r.Next(6) * 40;

                bool alreadyExists = false;
                foreach (Tank t in tanks)
                {
                    if (t.X == x && t.Y == y)
                    {
                        alreadyExists = true;
                        break;
                    }
                }

                if (alreadyExists == true)
                    continue;

                Tank newTank = new Tank(sizeField, x, y);
                tanks.Add(newTank);
            }
        }

        public void Play()
        {
            while (gameStatus == GameStatus.playing)
            {
                Thread.Sleep(speedGame);
                foreach (Tank t in tanks)
                    t.Run();
            }
        }
    }
}
