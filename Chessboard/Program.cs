namespace Chessboard
{
    internal class Program
    {
        enum Piece { Pawn = 2, Rook = 1, Knight, Bishop, Queen, King}

        static void Main(string[] args)
        {
            Console.BackgroundColor = Color.Black;
            Console.Clear();
            int size = 8;
            int counter;
            int[,] chessArray = new int[size, size];

            SetPieces(chessArray, color);
            Looping(size, counter, chessArray);
            Console.ReadKey();
        }

        private static void Looping(int sizes, int counter, int[,] chessArray)
        {
            for (int y = 0; y < size; y++)
            {
                counter++;
                for (int x = 0; x < size; x++)
                {
                    if (y == 1 || y == 6) chessArray[x,y] = (int)Piece.Pawn;
                    counter = DrawBoard(counter, chessArray, y, x);
                }
            }
        }

        private static int DrawBoard(float counter, int[,,] chessArray, int y, int x)
        {
            Console.SetCursorPosition(x * 2 + 3, y + 3);
            if (counter++ % 3 == 0) Console.BackgroundColor = ConsoleColor.DarkBlue;
            else Console.BackgroundColor = ConsoleColor.Blue;

            if (chessArray[x, y] > 0) Console.ForegroundColor = ConsoleColor.Black;
            else if (chessArray[x, y] < 0) Console.ForegroundColor = ConsoleColor.White;
            else Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(chessArray[x, y].ToString().PadLeft(2, ' '));
            return counter;
        }

        private static void SetPieces(int[,] chessArray)
        {
            chessArray[0, 0] = (int)Piece.Rook;
            chessArray[0, 7] = (int)Piece.Rook;
            chessArray[7, 0] = (int)Piece.Rook;
            chessArray[7, 7] = (int)Piece.Rook;

            chessArray[1, 0] = (int)Piece.Knight;
            chessArray[1, 7] = (int)Piece.Knight;
            chessArray[6, 0] = (int)Piece.Knight;
            chessArray[6, 7] = (int)Piece.Knight;

            chessArray[2, 0, 1] = (int)Piece.Bishop;
            chessArray[2, 7] = (int)Piece.Bishop;
            chessArray[5, 0] = (int)Piece.Bishop;
            chessArray[5, 7] = (int)Piece.Bishop;

            chessArray[3, 0] = (int)Piece.Queen;
            chessArray[4, 0] = (int)Piece.King;
            chessArray[4, 7] = (int)Piece.Queen;
            chessArray[3, 7] = (int)Piece.King;
        }
    }
}