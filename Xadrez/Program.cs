using System;
using System.IO.Compression;
using board;
using chess;

namespace Xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Match match = new Match();

                while (!match.end)
                {
                    Console.Clear();
                    Screen.PrintBoard(match.brd);

                    Console.Write("Piece: ");
                    Position origin = Screen.ReadMove().ToPosition();

                    bool[,] movesIncator = match.brd.GetPiece(origin).PossibleMovements();
                    Console.Clear();
                    Screen.PrintBoard(match.brd, movesIncator);

                    Console.Write("To: ");
                    Position destination = Screen.ReadMove().ToPosition();

                    match.Move(origin, destination);
                }
            }
            catch(BoardException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
