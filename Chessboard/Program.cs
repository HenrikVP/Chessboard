using System.Drawing;

namespace Chessboard
{
    internal class Program
    {
        static int counter = 0;

        static void Main(string[] args)
        {
            Console.Clear();
            int size = 8;
            CountY(size);

        }

        static void DrawX(int sizeOfX, int y)
        {
            for (int x = 0; x < sizeOfX; x++)
            {
                Console.SetCursorPosition(x*2 + 3, y+ 3);
                if (counter++ % 2 == 0) Console.BackgroundColor = ConsoleColor.DarkGray;
                else Console.BackgroundColor = ConsoleColor.White;
                Console.WriteLine("  ");
            }
        }

        static void CountY(int sizeOfY) 
        {
            for (int y = 0; y < sizeOfY; y++)
            {
                counter++;
                DrawX(sizeOfY, y);
            }
        }
    }
}