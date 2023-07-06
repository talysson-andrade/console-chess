using System;
using board;
using chess;

namespace Xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            Board b = new Board(8, 8);
            b.InsertPiece(new Pawn(b, Color.Black), new Position(1, 0));
            b.InsertPiece(new Pawn(b, Color.Black), new Position(1, 1));
            b.InsertPiece(new Pawn(b, Color.Black), new Position(1, 2));
            b.InsertPiece(new Queen(b, Color.Black), new Position(1, 3));


            Screen.PrintBoard(b);
        }
    }
}
