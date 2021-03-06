﻿namespace _12_FallingRocks
{
    using System;
    using System.Collections.Generic;
    using System.Threading;

    public class Startup
    {
        private const int ScoreUpdateTicks = 17;
        private const int RockAddTicks = 10;

        private const int DirectionLeft = -1;
        private const int DirectionRight = 1;

        private static readonly char[] rockSymbols = { '^', '@', '*', '&', '+', '%', '$', '#', '!', '.', ';', '-' };
        private static readonly int[] rockSizes = { 1, 3, 5, 7 };

        private static Random randomGenerator = new Random();
        private static Dwarf dwarf = new Dwarf();
        private static List<Rock> rocks = new List<Rock>();

        private static int timer = 1;
        private static int score = 0;
        private static bool hasCollision = false;

        public static void Main(string[] args)
        {
            SetInitialPosition();

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();

                    if (key.Key == ConsoleKey.Escape)
                    {
                        break;
                    }

                    if (key.Key == ConsoleKey.RightArrow)
                    {
                        MoveDwarf(DirectionRight);
                    }

                    if (key.Key == ConsoleKey.LeftArrow)
                    {
                        MoveDwarf(DirectionLeft);
                    }
                }


                Console.Clear();
                DrawDwarf();

                AddRock();
                DrawRocks();
                MoveRocks();
                CheckCollision();

                if (hasCollision)
                {
                    break;
                }

                UpdateScore();

                Thread.Sleep(150);

                timer++;
            }

            PrintScore();
        }

        private static void PrintScore()
        {
            Console.Clear();
            Console.WriteLine($"Game over! Score: {score}");
        }

        private static void UpdateScore()
        {
            if (timer % ScoreUpdateTicks == 0)
            {
                score++;
            }
        }

        private static void CheckCollision()
        {
            foreach (Rock rock in rocks)
            {
                bool hitsLeft = rock.Y == dwarf.Cy && (dwarf.LeftArm >= rock.LeftEnd && dwarf.LeftArm <= rock.RightEnd);
                bool hitsRight = rock.Y == dwarf.Cy && (dwarf.RightArm >= rock.LeftEnd && dwarf.RightArm <= rock.RightEnd);

                if (hitsLeft || hitsRight)
                {
                    hasCollision = true;
                    return;
                }
            }
        }

        private static void AddRock()
        {
            if (timer % RockAddTicks == 0)
            {
                int symbolIndex = randomGenerator.Next(rockSymbols.Length);
                char symbol = rockSymbols[symbolIndex];

                int sizeIndex = randomGenerator.Next(rockSizes.Length);
                int size = rockSizes[sizeIndex];

                int x = randomGenerator.Next(Console.WindowWidth - size / 2 - 1);
                int y = 0;

                Rock rock = new Rock { X = x, Y = y, Symbol = symbol, Size = size };
                rocks.Add(rock);
            }
        }

        private static void DrawRocks()
        {
            foreach (Rock rock in rocks)
            {
                Console.SetCursorPosition(rock.LeftEnd, rock.Y);
                Console.Write(new string(rock.Symbol, rock.Size));
            }
        }

        private static void MoveRocks()
        {
            foreach (Rock rock in rocks)
            {
                rock.Y++;
            }
        }

        private static void MoveDwarf(int direction)
        {
            if (direction == DirectionRight)
            {
                if (dwarf.RightArm < Console.WindowWidth - 1)
                {
                    dwarf.Cx++;
                }
            }
            else
            {
                if (dwarf.LeftArm > 0)
                {
                    dwarf.Cx--;
                }
            }
        }

        private static void DrawDwarf()
        {
            Console.SetCursorPosition(dwarf.Cx, dwarf.Cy);

            Console.Write(0);

            Console.SetCursorPosition(dwarf.LeftArm, dwarf.Cy);
            Console.Write('(');

            Console.SetCursorPosition(dwarf.RightArm, dwarf.Cy);
            Console.Write(')');
        }

        private static void SetInitialPosition()
        {
            dwarf.Cx = Console.WindowWidth / 2;
            dwarf.Cy = Console.WindowHeight - 2;
        }
    }
}
