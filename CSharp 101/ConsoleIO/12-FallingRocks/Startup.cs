namespace _12_FallingRocks
{
    using System;
    using System.Collections.Generic;
    using System.Threading;

    public class Startup
    {
        private const int DirectionLeft = -1;
        private const int DirectionRight = 1;

        private static readonly char[] rockSymbols = { '^', '@', '*', '&', '+', '%', '$', '#', '!', '.', ';', '-' };
        private static readonly int[] rockWidths = { 1, 3, 5, 7 };

        private static Random randomGenerator = new Random();
        private static Dwarf dwarf = new Dwarf();
        private static Queue<Rock> rocks = new Queue<Rock>();

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
            if (timer % 17 == 0)
            {
                score++;
            }
        }

        private static void CheckCollision()
        {
            foreach (Rock rock in rocks)
            {
                bool hitsLeft = rock.Y == dwarf.Cy && rock.X == dwarf.LeftArm;
                bool hitsCenter = rock.Y == dwarf.Cy && rock.X == dwarf.Cx;
                bool hitsRight = rock.Y == dwarf.Cy && rock.X == dwarf.RightArm;

                if (hitsLeft || hitsCenter || hitsRight)
                {
                    hasCollision = true;
                    return;
                }
            }
        }

        private static void AddRock()
        {
            if (timer % 3 == 0)
            {
                int symbolIndex = randomGenerator.Next(rockSymbols.Length);
                char symbol = rockSymbols[symbolIndex];

                int x = randomGenerator.Next(Console.WindowWidth - 1);
                int y = 0;

                Rock rock = new Rock { X = x, Y = y, Symbol = symbol };
                rocks.Enqueue(rock);
           k}
           k}
        }

        private static void DrawRocks()
        {
            foreach (Rock rock in rocks)
            {
                Console.SetCursorPosition(rock.X, rock.Y);
                Console.Write(rock.Symbol);
            }
        }

        private static void MoveRocks()
        {
            foreach (Rock rock in rocks)
            {
                rock.Y++;
            }

            while (rocks.Count > 0 && rocks.Peek().Y == Console.WindowWidth - 1)
            {
                rocks.Dequeue();
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
