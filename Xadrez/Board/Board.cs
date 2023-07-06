namespace board
{
    class Board
    {
        public int row { get; set; }
        public int column { get; set; }
        public Piece[,] pieces;

        public Board(int row, int column)
        {
            this.row = row;
            this.column = column;
            pieces = new Piece[row, column];
        }

        public Piece GetPiece(int row, int column)
        {
            return pieces[row, column];
        }

        public void InsertPiece(Piece piece, Position pstn)
        {
            pieces[pstn.row, pstn.column] = piece;
            piece.position = pstn;
        }
    }
}
