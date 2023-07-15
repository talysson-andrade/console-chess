using board;
using System.Text.RegularExpressions;
using Xadrez;

namespace chess
{
    class Match
    {
        public Board brd { get; private set; }
        public int turn { get; private set; }
        public Color player { get; private set; }
        public bool end { get; private set; }

        public Match()
        {
            this.brd = new Board(8, 8);
            PlacePieces();
            this.turn = 1;
            this.player = Color.White;
            end = false;

        }

        private void PlacePieces()
        {
            brd.InsertPiece(new Pawn(brd, Color.Black), new ChessPosition('a', 7).ToPosition());
            brd.InsertPiece(new Pawn(brd, Color.Black), new ChessPosition('b', 7).ToPosition());
            brd.InsertPiece(new Pawn(brd, Color.Black), new ChessPosition('c', 7).ToPosition());
            brd.InsertPiece(new Pawn(brd, Color.Black), new ChessPosition('d', 7).ToPosition());
            brd.InsertPiece(new Pawn(brd, Color.Black), new ChessPosition('e', 7).ToPosition());
            brd.InsertPiece(new Pawn(brd, Color.Black), new ChessPosition('f', 7).ToPosition());
            brd.InsertPiece(new Pawn(brd, Color.Black), new ChessPosition('g', 7).ToPosition());
            brd.InsertPiece(new Pawn(brd, Color.Black), new ChessPosition('h', 7).ToPosition());
            brd.InsertPiece(new Pawn(brd, Color.White), new ChessPosition('a', 2).ToPosition());
            brd.InsertPiece(new Pawn(brd, Color.White), new ChessPosition('b', 2).ToPosition());
            brd.InsertPiece(new Pawn(brd, Color.White), new ChessPosition('c', 2).ToPosition());
            brd.InsertPiece(new Pawn(brd, Color.White), new ChessPosition('d', 2).ToPosition());
            brd.InsertPiece(new Pawn(brd, Color.White), new ChessPosition('e', 2).ToPosition());
            brd.InsertPiece(new Pawn(brd, Color.White), new ChessPosition('f', 2).ToPosition());
            brd.InsertPiece(new Pawn(brd, Color.White), new ChessPosition('g', 2).ToPosition());
            brd.InsertPiece(new Pawn(brd, Color.White), new ChessPosition('h', 2).ToPosition());
            brd.InsertPiece(new Tower(brd, Color.Black), new ChessPosition('a', 8).ToPosition());
            brd.InsertPiece(new Tower(brd, Color.Black), new ChessPosition('h', 8).ToPosition());
            brd.InsertPiece(new Tower(brd, Color.White), new ChessPosition('a', 1).ToPosition());
            brd.InsertPiece(new Tower(brd, Color.White), new ChessPosition('h', 1).ToPosition());
            brd.InsertPiece(new Horse(brd, Color.White), new ChessPosition('b', 1).ToPosition());
            brd.InsertPiece(new Horse(brd, Color.White), new ChessPosition('g', 1).ToPosition());
            brd.InsertPiece(new Horse(brd, Color.Black), new ChessPosition('b', 8).ToPosition());
            brd.InsertPiece(new Horse(brd, Color.Black), new ChessPosition('g', 8).ToPosition());
            brd.InsertPiece(new Bishop(brd, Color.White), new ChessPosition('c', 1).ToPosition());
            brd.InsertPiece(new Bishop(brd, Color.White), new ChessPosition('f', 1).ToPosition());
            brd.InsertPiece(new Bishop(brd, Color.Black), new ChessPosition('c', 8).ToPosition());
            brd.InsertPiece(new Bishop(brd, Color.Black), new ChessPosition('f', 8).ToPosition());
            brd.InsertPiece(new Queen(brd, Color.White), new ChessPosition('d', 1).ToPosition());
            brd.InsertPiece(new Queen(brd, Color.Black), new ChessPosition('d', 8).ToPosition());
            brd.InsertPiece(new King(brd, Color.White), new ChessPosition('e', 1).ToPosition());
            brd.InsertPiece(new King(brd, Color.Black), new ChessPosition('e', 8).ToPosition());


        }

        public void Move(Position origin, Position destination)
        {
            Piece piece = brd.RemovePiece(origin);
            piece.MovedPiece();
            Piece capturedPiece = brd.RemovePiece(destination);
            brd.InsertPiece(piece, destination);

        }

        public void TurnPlay()
        {
            try
            {
                PlayerTurn(Color.White);
                PlayerTurn(Color.Black);
                turn++;
              
            }
            catch (BoardException e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }
            

        }
        public void PlayerTurn(Color color)
        {

            player = color;
            Console.Clear();
            Screen.PrintBoard(this);

            Console.Write("Piece: ");
            Position origin = Screen.ReadMove().ToPosition();
            OriginPositionIsValid(origin);

            bool[,] movesIncator = brd.GetPiece(origin).PossibleMovements();
            Console.Clear();
            Screen.PrintBoard(this, movesIncator);

            Console.Write("To: ");
            Position destination = Screen.ReadMove().ToPosition();
            DestinationPositionIsValid(destination,origin);

            Move(origin, destination);

            Console.Clear();
            Screen.PrintBoard(this);



        }

        public void OriginPositionIsValid(Position origin)
        {
            if (brd.GetPiece(origin) == null)
            {
                throw new BoardException("There are no pieces in this position");
            }
            if (player != brd.GetPiece(origin).color)
            {
                throw new BoardException("Is not your turn");
            }
            if (!brd.GetPiece(origin).ExistPossibleMoves())
            {
                throw new BoardException("This piece does'nt have any possible moves");
            }
        }
        public void DestinationPositionIsValid(Position destination, Position origin)
        {
            if (!brd.GetPiece(origin).PossibleMovements()[destination.row, destination.column])
            {
                throw new BoardException("This piece cannot go to that position");
            }
        }
    }
}
