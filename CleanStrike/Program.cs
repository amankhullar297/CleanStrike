using System;
using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;

namespace CleanStrike
{
    class Program
    {
        static int redCoin = 1, blackCoins = 9;
        static int pointsA = 0, pointsB = 0;
        static int foulA = 0, foulB = 0;
        static int noneCountA = 0, noneCountB = 0;
        static bool isPlayer1Chance = true;

        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            list.Add("Defunct coin");
            list.Add("Defunct coin");
            list.Add("Defunct coin");
            list.Add("Defunct coin");
            list.Add("Defunct coin");
            list.Add("Defunct coin");
            list.Add("Defunct coin");
            list.Add("Defunct coin");
            list.Add("Defunct coin");
            list.Add("Defunct coin");
            list.Add("Defunct coin");
            list.Add("Defunct coin");

            foreach (string value in list)
            {
                switch (value)
                {
                    case "Strike":
                        {
                            UpdateStrike();
                            break;
                        }

                    case "Multi-strike":
                        {
                            UpdateMultiStrike(2);
                            break;
                        }
                    case "Red strike":
                        {
                            UpdateRedStrike();
                            break;
                        }
                    case "Striker strike":
                        {
                            UpdateStrikerStrike();
                            break;
                        }
                    case "Defunct coin":
                        {
                            UpdateDefunctCoin();
                            break;
                        }
                    case "None":
                        {
                            UpdateNoneChance();
                            break;
                        }
                }
            }

            Console.WriteLine(pointsA);
            Console.ReadKey();
        }

        private static void UpdateStrike()
        {
            int value = 1;
            if (IsCoinLess(value))
            {
                DeclareWinner();
                return;
            }
            if (isPlayer1Chance)
            {
                pointsA += value; ;
                isPlayer1Chance = false;
            }

            else
            {
                pointsB += value; ;
                isPlayer1Chance = true;
            }
            blackCoins -= value;
        }

        private static void UpdateMultiStrike(int coins)
        {
            int value = 2;
            if (IsCoinLess(value))
            {
                DeclareWinner();
                return;
            }
            blackCoins += coins;
            blackCoins -= value;

            if (isPlayer1Chance)
            {
                pointsA++;
                isPlayer1Chance = false;
            }

            else
            {
                pointsB++;
                isPlayer1Chance = true;
            }
        }

        private static void UpdateRedStrike()
        {
            if (redCoin == 1)
            {
                if (isPlayer1Chance)
                {
                    pointsA += 3;
                    isPlayer1Chance = false;
                }

                else
                {
                    pointsB += 3;
                    isPlayer1Chance = true;
                }
            }
            redCoin = 0;
        }


        private static void UpdateStrikerStrike()
        {
            if (isPlayer1Chance)
            {
                pointsA--;
                foulA++;
                if (foulA == 3)
                {
                    pointsA--;
                    foulA = 0;
                }
                isPlayer1Chance = false;
            }

            else
            {
                pointsB--;
                foulB++;
                if (foulB == 3)
                {
                    pointsB--;
                    foulB = 0;
                }
                isPlayer1Chance = true;
            }
        }

        private static void UpdateDefunctCoin()
        {
            int value = 1;
            if (IsCoinLess(1))
            {
                DeclareWinner();
                return;
            }

            blackCoins -= value;

            if (isPlayer1Chance)
            {
                pointsA -= 2;
                isPlayer1Chance = false;
            }
            else
            {
                pointsB -= 2;
                isPlayer1Chance = true;
            }
        }

        private static void UpdateNoneChance()
        {
            if (isPlayer1Chance)
            {
                noneCountA++;
                if (noneCountA == 3)
                {
                    pointsA--;
                    noneCountA = 0;
                }
                isPlayer1Chance = false;
            }

            else
            {
                noneCountB++;
                if (noneCountB == 3)
                {
                    pointsB--;
                    noneCountB = 0;
                }
                isPlayer1Chance = true; ;
            }
        }

        private static bool IsCoinLess(int coins)
        {
            if (blackCoins - coins <= 0)
                return true;

            return false;
        }

        public static void DeclareWinner()
        {
            if (pointsB >= 5 || pointsA >= 5)
            {
                int value = pointsA - pointsB;
                if (Math.Abs(value) >= 3 && value > 0)
                    Console.WriteLine("Player A is Winner!");

                else if (Math.Abs(value) >= 3 && value < 0)
                    Console.WriteLine("Player B is Winner!");

            }
            Console.WriteLine("Match is Draw");
        }
    }
}
