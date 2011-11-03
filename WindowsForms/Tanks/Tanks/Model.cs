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
        List<Apple> apples;

        public Wall wall;

        internal List<Tank> Tanks
        {
            get { return tanks; }
        }

        internal List<Apple> Apples
        {
            get { return apples; }
        }

        public Model(int sizeField, int amountTanks, int amountApples, int speedGame)
        {
            r = new Random();

            tanks = new List<Tank>();
            apples = new List<Apple>();

            this.sizeField = sizeField;
            this.amountTanks = amountTanks;
            this.amountApples = amountApples;
            this.speedGame = speedGame;

            CreateTanks();
            CreateApples();
            wall = new Wall();

            gameStatus = GameStatus.stopping;
        }

        private void CreateApples()
        {
            int x, y;
            while (apples.Count < amountApples)
            {
                x = r.Next(6) * 40;
                y = r.Next(6) * 40;

                bool alreadyExists = false;
                foreach (Apple a in apples)
                {
                    if (a.X == x && a.Y == y)
                    {
                        alreadyExists = true;
                        break;
                    }
                }

                if (alreadyExists == true)
                    continue;

                Apple newApple = new Apple(x, y);
                apples.Add(newApple);
            }
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

                for (int i = 0; i < tanks.Count - 1; i++)
                {
                    for (int j = i + 1; j < tanks.Count; j++)
                    {
                        if (
                            (Math.Abs(tanks[i].X - tanks[j].X) <= 20 && (tanks[i].Y == tanks[j].Y))
                            ||
                            Math.Abs(tanks[j].Y - tanks[j].Y) <= 20 && (tanks[i].X == tanks[j].X)
                            ||
                            (Math.Abs(tanks[i].X - tanks[j].X) <= 20 && Math.Abs(tanks[i].Y - tanks[j].Y) <= 20)

                            )
                        {
                            tanks[i].TurnAround();
                            tanks[j].TurnAround();
                        }
                    }
                }
            }
        }
    }
}
