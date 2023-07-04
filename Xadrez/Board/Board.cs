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
    }
}
