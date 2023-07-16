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
                    Screen.PrintBoard(match);

                    match.TurnPlay();
                }
            }
            catch(BoardException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
