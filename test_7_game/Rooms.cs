using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_7_game
{
    internal class Rooms
    {
        public int Id = 0;
        public void Room0(string[,] zone,int i, int j)
        {
            switch (i, j)
            {
                case (4, 2):
                    zone[i, j] = " w";
                    break;
                case (0, >= 0 and <= 4):
                case (1, >= 0 and <= 2):
                case (2, >= 0 and <= 1):
                case ( >= 3 and <= 6, 0):
                case (2, 3):
                case (4, 4):
                case (7, 1):
                case (3, 10):
                case (2, 11):
                case (7, 12):
                case (7, 8):
                    zone[i, j] = " Y";
                    break;
                case ( >= 1 and <= 3, 13):
                case (8, 13):
                    zone[i, j] = " |";
                    break;
                case (0, >= 4 and <= 13):
                case (3, >= 14 and <= 15):
                case (7, >= 14 and <= 15):
                    zone[i, j] = "__";
                    break;
                default:
                    break;
            }
            Console.Write($" {zone[i, j]}");
        }
        public void Room1(string[,] zone, int i, int j)
        {

            switch (i, j)
            {
                case (5, 12):
                    zone[i, j] = "* ";
                    break;
                case (4, 0):
                case (5, 0):
                case (6, 0):
                    zone[i, j] = " #";
                    break;
                case (0, 10):
                case ( >= 2 and <= 8, 15):
                    zone[i, j] = "| ";
                    break;
                case (2, 1):
                case (8, 1):

                case (0, 6):
                    zone[i, j] = " |";
                    break;
                case (8, >= 2 and <= 14):
                case (1, >= 2 and <= 6):
                case (1, >= 10 and <= 14):
                case (7, 0):
                case (7, 1):
                case (3, 0):
                case (3, 1):
                    zone[i, j] = "__";
                    break;
                default:
                    break;
            }
            Console.Write($" {zone[i, j]}");
        }
        public void Room2(string[,] zone, int i, int j)
        {
            switch (i, j)
            {
                case (4, 8):
                    zone[i, j] = " ?";
                    break;
                case ( >= 1 and <= 7, 15):
                case (8, 10):
                    zone[i, j] = "| ";
                    break;
                case (1, 1):
                case (7, 1):
                case (8, 6):
                    zone[i, j] = " |";
                    break;
                case (0, >= 2 and <= 14):
                case (7, >= 2 and <= 6):
                case (7, >= 10 and <= 14):
                case (2, >= 0 and <= 1):
                case (6, >= 0 and <= 1):
                    zone[i, j] = "__";
                    break;
                default:
                    break;
            }
            Console.Write($" {zone[i, j]}");
        }
        public void Room3(string[,] zone, int i, int j)
        {
            switch (i, j)
            {
                case ( >= 1 and <= 7, 0):
                    zone[i, j] = " |";
                    break;
                case ( >= 3 and <= 5, 15):
                    zone[i, j] = " #";
                    break;
                case (1, 14):
                case (8, 14):
                    zone[i, j] = "| ";
                    break;
                case (2, >= 14 and <= 15):
                case (6, >= 14 and <= 15):
                case (0, >= 1 and <= 13):
                case (8, >= 1 and <= 13):
                    zone[i, j] = "__";
                    break;
                case (4, 3):
                    zone[i, j] = "[]";
                    break;
                default:
                    break;
            }
            Console.Write($" {zone[i, j]}");
        }
        public void Room4d(string[,] zone, int i, int j)
        {
            switch (i, j)
            {
                case (4, 4):
                    zone[i, j] = "i ";
                    break;
                default:
                    break;
            }
            Console.Write($" {zone[i, j]}");
        }
        public void Room4(string[,] zone, int i, int j)
        {
            switch (i, j)
            {
                case ( >= 1 and <= 7, 0):
                    zone[i, j] = " |";
                    break;
                case (1, 12):
                case (8, 12):
                    zone[i, j] = "| ";
                    break;
                case (2, >= 12 and <= 15):
                case (6, >= 12 and <= 15):
                case (0, >= 1 and <= 11):
                case (8, >= 1 and <= 11):
                    zone[i, j] = "__";
                    break;
                case (4, 2):
                case (3, 3):
                case (5, 3):
                    zone[i, j] = " X";
                    break;
                case (4, 4):
                    zone[i, j] = "ї`";
                    break;
                default:
                    break;
            }
            Console.Write($" {zone[i, j]}");
        }
        public void Room5(string[,] zone, int i, int j)
        {
            switch (i, j)
            {
                case ( >= 1 and <= 7, 0):
                    zone[i, j] = " |";
                    break;
                case (>= 1 and <= 8, 12):
                    zone[i, j] = "| ";
                    break;
                case (0, >= 1 and <= 11):
                case (8, >= 1 and <= 11):
                    zone[i, j] = "__";
                    break;
                case (4, 8):
                    zone[i, j] = " L";
                    break;
                default:
                    break;
            }
            Console.Write($" {zone[i, j]}");
        }
        public void Room6(string[,] zone, int i, int j)
        {
            switch (i, j)
            {
                case ( >= 1 and <= 7, 0):
                    zone[i, j] = " |";
                    break;
                case (1, 12):
                case (8, 12):
                    zone[i, j] = "| ";
                    break;
                case (2, >= 12 and <= 15):
                case (6, >= 12 and <= 15):
                case (0, >= 1 and <= 11):
                case (8, >= 1 and <= 11):
                    zone[i, j] = "__";
                    break;
                case (4, 4):
                    zone[i, j] = "ї`";
                    break;
                default:
                    break;
            }
            Console.Write($" {zone[i, j]}");
        }
        public void Room7(string[,] zone, int i, int j)
        {
            switch (i, j)
            {
                case ( >= 7 and <= 8, 5):
                    zone[i, j] = " |";
                    break;
                case ( >= 3 and <= 8, 9):
                    zone[i, j] = "| ";
                    break;
                case (2, >= 0 and <= 8):
                case (6, >= 0 and <= 5):
                    zone[i, j] = "__";
                    break;
                default:
                    break;
            }
            Console.Write($" {zone[i, j]}");
        }
        public void Room8(string[,] zone, int i, int j)
        {
            switch (i, j)
            {
                case ( >= 0 and <= 1, 5):
                case ( >= 2 and <= 8, 0):
                    zone[i, j] = " |";
                    break;
                case ( >= 0 and <= 1, 9):
                case ( >= 2 and <= 3, 14):
                    zone[i, j] = "| ";
                    break;
                case (1, >= 1 and <= 4):
                case (1, >= 10 and <= 13):
                case (8, >= 1 and <= 15):
                case (4, >= 14 and <= 15):
                    zone[i, j] = "__";
                    break;
                case (5, 2):
                    zone[i, j] = " Y";
                    break;
                case (6, 5):
                case (4, 5):
                case (4, 7):
                case (6, 7):
                case (4, 9):
                case (6, 9):
                case (4, 11):
                case (6, 11):
                    zone[i, j] = " т";
                    break;
                case (5, 3):
                    zone[i, j] = " g";
                    break;
                default:
                    break;
            }
            Console.Write($" {zone[i, j]}");
        }
        public void Room9(string[,] zone, int i, int j)
        {
            switch (i, j)
            {
                case (8, >= 0 and <= 15):
                case (4, >= 0 and <= 15):
                    zone[i, j] = "__";
                    break;
                default:
                    break;
            }
            Console.Write($" {zone[i, j]}");
        }
        public void Room10(string[,] zone, int i, int j)
        {
            switch (i, j)
            {
                case (>= 1 and <= 4, 0):
                case ( >= 1 and <= 4, 15):
                    zone[i, j] = "| ";
                    break;
                case (8, >= 0 and <= 1):
                case (8, >= 14 and <= 15):
                case (0, >= 1 and <= 6):
                case (0, >= 9 and <= 14):
                    zone[i, j] = "__";
                    break;
                case (4, 9):
                    zone[i, j] = "=|";
                    break;
                default:
                    break;
            }
            Console.Write($" {zone[i, j]}");
        }
        public void Room11(string[,] zone, int i, int j)
        {
            switch (i, j)
            {
                case ( >= 1 and <= 8, 0):
                case ( >= 6 and <= 7, 11):
                case ( >= 6 and <= 7, 5):
                    zone[i, j] = " |";
                    break;
                case ( >= 1 and <= 8, 15):
                case ( >= 6 and <= 7, 10):
                case ( >= 6 and <= 7, 4):
                case (1, 3):
                    zone[i, j] = "| ";
                    break;
                case (1, >= 1 and <= 2):
                    zone[i, j] = "==";
                    break;
                case (6, 12):
                case (4, 10):
                    zone[i, j] = " P";
                    break;
                case (6, 3):
                    zone[i, j] = " W";
                    break;
                case (1, 8):
                    zone[i, j] = " B";
                    break;
                case (8, >= 1 and <= 6):
                case (8, >= 9 and <= 14):
                case (0, >= 1 and <= 2):
                case (2, >= 3 and <= 14):
                case (5, >= 10 and <= 11):
                case (5, >= 4 and <= 5):
                    zone[i, j] = "__";
                    break;
                default:
                    break;
            }
            Console.Write($" {zone[i, j]}");
        }
        public void Room12(string[,] zone, int i, int j)
        {
            switch (i, j)
            {
                case ( >= 1 and <= 8, 0):
                case ( >= 1 and <= 5, 3):
                case ( >= 1 and <= 5, 9):
                    zone[i, j] = " |";
                    break;
                case ( >= 1 and <= 8, 15):
                    zone[i, j] = "| ";
                    break;
                case (1, >= 1 and <= 2):
                    zone[i, j] = "==";
                    break;
                case (8, >= 1 and <= 14):
                case (0, >= 1 and <= 2):
                case (5, >= 4 and <= 6):
                case (5, >= 10 and <= 12):
                    zone[i, j] = "__";
                    break;
                case (5, >= 13 and <= 14):
                    zone[i, j] = " #";
                    break;
                default:
                    break;
            }
            Console.Write($" {zone[i, j]}");
        }
        public void Room13(string[,] zone, int i, int j)
        {
            switch (i, j)
            {

                case ( >= 1 and <= 5, 3):
                case ( >= 1 and <= 5, 9):
                    zone[i, j] = " |";
                    break;
                case ( 1, 5):
                    zone[i, j] = "| ";
                    break;
                case (0, >= 4 and <= 9):
                case (5, >= 4 and <= 6):
                case (1, 4):
                    zone[i, j] = "__";
                    break;
                default:
                    break;
            }
            Console.Write($" {zone[i, j]}");
        }
        public void Room14(string[,] zone, int i, int j)
        {
            switch (i, j)
            {
                case ( >= 1 and <= 8, 0):
                    zone[i, j] = " |";
                    break;
                case ( >= 1 and <= 8, 15):
                    zone[i, j] = "| ";
                    break;
                case (0, 1):
                case (0, 14):
                case (8, >= 1 and <= 6):
                case (8, >= 8 and <= 14):
                    zone[i, j] = "__";
                    break;
                case ( >= 3 and <= 6, 2):
                case ( >= 3 and <= 6, 5):
                case ( >= 3 and <= 6, 9):
                case ( >= 3 and <= 6, 12):
                    zone[i, j] = ".,";
                    break;
                case (8, 7):
                    zone[i, j] = "~~";
                    break;
                default:
                    break;
            }
            Console.Write($" {zone[i, j]}");
        }
    }
}
