using System;
using board;

namespace Xadrez
{
    class Screen
    {
        public static void PrintBoard(Board brd)
        {
            for (int i = 0; i < brd.row; i++)
            {
                for (int j = 0; j < brd.column; j++)
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
