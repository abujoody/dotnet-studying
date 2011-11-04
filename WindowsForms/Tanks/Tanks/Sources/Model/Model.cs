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
        Projectile projectile;

        List<Tank> tanks;
        List<FireTank> fireTanks;
        List<Apple> apples;

        public Wall wall;

        internal List<Tank> Tanks
        {
            get { return tanks; }
        }

        internal List<FireTank> FireTanks
        {
            get { return fireTanks; }
            set { fireTanks = value; }
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

        internal Projectile Projectile
        {
            get { return projectile; }
            set { projectile = value; }
        }

        public Model(int sizeField, int amountTanks, int amountApples, int speedGame)
        {
            r = new Random();

            this.sizeField = sizeField;
            this.amountTanks = amountTanks;
            this.amountApples = amountApples;
            this.speedGame = speedGame;

            NewGame();
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
            while (tanks.Count < amountTanks + 1)
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

                Tank newTank;
                if (tanks.Count != 0)
                    newTank = new Tank(sizeField, x, y);
                else
                    newTank = new Hunter(sizeField, x, y);

                tanks.Add(newTank);
            }
        }

        public void Play()
        {
            while (gameStatus == GameStatus.playing && collectedApples < 5)
            {
                Thread.Sleep(speedGame);

                projectile.Run();
                packman.Run();
                ((Hunter)tanks[0]).Run(packman.X, packman.Y);
                for (int i = 1; i < tanks.Count; i++)
                {
                    tanks[i].Run();
                }

                foreach (FireTank ft in fireTanks)
                {
                    ft.Fire();
                }

                for (int i = 1; i < tanks.Count; i++)
                    if ((projectile.X - tanks[i].X) < 13 && (projectile.Y - tanks[i].Y) < 13 &&
                        (projectile.X - tanks[i].X) > 7 && (projectile.Y - tanks[i].Y) > 7)
                    {
                        fireTanks.Add(new FireTank(tanks[i].X, tanks[i].Y));
                        tanks.RemoveAt(i);
                        projectile.DefaultSettings();
                    }

                    for (int i = 0; i < tanks.Count - 1; i++)
                    {
                        for (int j = i + 1; j < tanks.Count; j++)
                        {
                            if (
                                (Math.Abs(tanks[i].X - tanks[j].X) <= 20 && (tanks[i].Y == tanks[j].Y))
                                ||
                                Math.Abs(tanks[i].Y - tanks[j].Y) <= 20 && (tanks[i].X == tanks[j].X)
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

        internal void NewGame()
        {
            collectedApples = 0;

            tanks = new List<Tank>();
            fireTanks = new List<FireTank>();
            apples = new List<Apple>();

            CreateTanks();
            CreateApples();
            wall = new Wall();
            packman = new Packman(sizeField);
            projectile = new Projectile();

            gameStatus = GameStatus.stopping;
        }
    }
}
