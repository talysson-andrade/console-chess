using board;
namespace chess
{
    class Match
    {
        public Board brd { get; private set; }
        private int turn;
        private Color player;
        public bool end { get; private set; }

        public Match()
        {
            this.brd = new Board(8,8);
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

    }
}
