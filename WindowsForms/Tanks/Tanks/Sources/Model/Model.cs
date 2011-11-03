﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Tanks
{
    class Model
    {
        int collectedApples;
        int sizeField;
        int amountTanks;
        int amountApples;
        public int speedGame;

        public GameStatus gameStatus;

        static Random r;

        Packman packman;

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

        internal Packman Packman
        {
            get { return packman; }
            set { packman = value; }
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
            packman = new Packman(sizeField);

            gameStatus = GameStatus.stopping;
        }

        private void CreateApples()
        {
            CreateApples(0);
        }

        private void CreateApples(int newApples)
        {
            int x, y;
            while (apples.Count < amountApples + newApples)
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
            while (gameStatus == GameStatus.playing && collectedApples < 5)
            {
                Thread.Sleep(speedGame);

                packman.Run();
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

                for (int i = 0; i < tanks.Count; i++)
                {
                    if (
                        (Math.Abs(tanks[i].X - packman.X) <= 19 && (tanks[i].Y == packman.Y))
                        ||
                        Math.Abs(tanks[i].Y - packman.Y) <= 19 && (tanks[i].X == packman.X)
                        ||
                        (Math.Abs(tanks[i].X - packman.X) <= 19 && Math.Abs(tanks[i].Y - packman.Y) <= 19)
                        )
                    {
                        gameStatus = GameStatus.looser;
                    }
                }

                for (int i = 0; i < apples.Count; i++)
                {
                    if (Math.Abs(packman.X - apples[i].X) <= 1 && Math.Abs(packman.Y - apples[i].Y) <= 1)
                    {
                        apples[i] = new Apple(step += 30, 270);
                        collectedApples++;
                        CreateApples(collectedApples);
                    }
                }

                if (collectedApples > 4)
                    gameStatus = GameStatus.winner;
            }
        }

        int step = -30;
    }
}
