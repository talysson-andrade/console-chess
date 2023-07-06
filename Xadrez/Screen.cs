using System;
using board;

namespace Xadrez
{
    class Screen
    {
        public static void PrintBoard(Board brd)
        {
            for (int i = 0; i < brd.rows; i++)
            {
                for (int j = 0; j < brd.columns; j++)
                {
                    if (brd.GetPiece(i, j) == null)
                    {
                        Console.Write("| ");
                    }
                    else
                    {
                        Console.Write("|" + brd.GetPiece(i, j));
                    }
                    if (j == 7)
                    {
                        Console.Write("|");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
