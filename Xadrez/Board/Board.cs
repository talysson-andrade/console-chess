namespace board
{
    class Board
    {
        public int rows { get; set; }
        public int columns { get; set; }
        public Piece[,] pieces;

        public Board(int row, int column)
        {
            this.rows = row;
            this.columns = column;
            pieces = new Piece[row, column];
        }

        public Piece GetPiece(int row, int column)
        {
            return pieces[row, column];
        }
        public Piece GetPiece(Position position)
        {
            return pieces[position.row, position.column];
        }

        public bool HasPiece(Position position)
        {
            CheckPosition(position);
            return GetPiece(position) != null;
        }

        public bool ValidPosition(Position position)
        {
            if (position.row < 0 || position.row >= rows || position.column < 0 || position.column >= columns)
            {
                return false;
            }
            return true; 
        }

        public void CheckPosition(Position position)
        {
            if (!ValidPosition(position))
            {
                throw new BoardException("Invalid Position!");
            }
        }

        public void InsertPiece(Piece piece, Position pstn)
        {
            if (HasPiece(pstn))
            {
                throw new BoardException("This position already has a piece");
            }
            pieces[pstn.row, pstn.column] = piece;
            piece.position = pstn;
        }
        public Piece RemovePiece(Position position)
        {
            if(GetPiece(position)== null)
            {
                return null;
            }
            Piece ast = GetPiece(position);
            ast.position = null;
            pieces[position.row, position.column] = null;
            return ast;
        }
    }
}
