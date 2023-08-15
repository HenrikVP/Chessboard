namespace Chessboard
{
    internal class Program
    {
        enum Piece { Pawns = 1, Rook, Knight, Bishop, Queen, King}
        static int counter = 0;
        static int[,] chessArray;

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            int size = 8;
            chessArray = new int[size, size];
            SetPieces();
            CountY(size);
            Console.ReadKey();
        }

        static void DrawX(int sizeOfX, int y)
        {
            for (int x = 0; x < sizeOfX; x++)
            {
                Console.SetCursorPosition(x*2 + 3, y+ 3);
                if (counter++ % 2 == 0) Console.BackgroundColor = ConsoleColor.DarkBlue;
                else Console.BackgroundColor = ConsoleColor.Blue;

                if (chessArray[x, y] > 0) Console.ForegroundColor = ConsoleColor.Black;
                else if (chessArray[x, y] < 0) Console.ForegroundColor = ConsoleColor.White;
                else Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write(chessArray[x, y].ToString().PadLeft(2, ' '));
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

        static void SetPieces()
        {
            chessArray[0, 0] = (int)Piece.Rook;
            chessArray[3, 7] = -(int)Piece.Queen;
        }
    }
}