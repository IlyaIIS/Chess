using System;

namespace Chess
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] board = new char[8,8];
        }

        public static void Horse(int x, int y, int x1, int y1)
        {
            if (((Math.Abs(x1 - x) == 2) && (Math.Abs(y1 - y) == 1)) || ((Math.Abs(x1 - x) == 1) && (Math.Abs(y1 - y) == 2)))
                Console.WriteLine("Все ок");
            else
                Console.WriteLine("Такого хода не существует");
        }

        public static void King(int x, int y, int x1, int y1)
        {
            if (((Math.Abs(x1 - x) == 1) || (Math.Abs(x1 - x) == 0)) && ((Math.Abs(y1 - y) == 1) || (Math.Abs(y1 - y) == 0)))
                Console.WriteLine("Все ок");
            else
                Console.WriteLine("Такого хода не существует");
        }

        public static void Rook(int x, int y, int x1, int y1)
        {
            if ((Math.Abs(x1 - x) == 0) || (Math.Abs(y1 - y) == 0))
                Console.WriteLine("Все ок");
            else
                Console.WriteLine("Такого хода не существует");
        }

        public static void Bishop(int x, int y, int x1, int y1)
        {
            if (Math.Abs(x1 - x) == Math.Abs(y1 - y))
                Console.WriteLine("Все ок");
            else
                Console.WriteLine("Такого хода не существует");
        }

        public static void Queen(int x, int y, int x1, int y1)
        {
            if ((Math.Abs(x1 - x) == Math.Abs(y1 - y)) ||
               ((Math.Abs(x1 - x) == 0) || (Math.Abs(y1 - y) == 0)))
                Console.WriteLine("Все ок");
            else
                Console.WriteLine("Такого хода не существует");
        }

        public static void Pawn(int x, int y, int x1, int y1)
        {
            if (Math.Abs(x1 - x) == 1 && Math.Abs(y1 - y) == 0)
                Console.WriteLine("Все ок");
            else
                Console.WriteLine("Такого хода не существует");
        }

        static void CheckPosition()
        {

        }
    }
}
