using System;
using board;
using chess;

namespace Xadrez
{
    class Screen
    {
        public static void PrintBoard(Board brd)
        {
            Console.WriteLine();
            Console.WriteLine("   a b c d e f g h");
            for (int i = 0; i < brd.rows; i++)
            {
                Console.Write(8 - i + " ");
                for (int j = 0; j < brd.columns; j++)
                {
                    if (brd.GetPiece(i, j) == null)
                    {
                        Console.Write("| ");
                    }
                    else
                    {
                        Console.Write("|");
                        PrintPiece(brd.GetPiece(i, j));
                    }
                    if (j == 7)
                    {
                        Console.Write("|");
                    }
                }
                Console.Write(" {0}",8-i);
                Console.WriteLine();
            }
            Console.WriteLine("   a b c d e f g h");
        }
        public static ChessPosition ReadMove()
        {
            string move = Console.ReadLine();
            char column = move[0];
            int row = int.Parse(move[1] + "");
            return new ChessPosition(column, row);
        }
        public static void PrintPiece(Piece piece)
        {
            if(piece.color == Color.White)
            {
                Console.Write(piece);
            }
            else
            {
                ConsoleColor ccolor = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write(piece);
                Console.ForegroundColor = ccolor;
            }
        }
    }
}
