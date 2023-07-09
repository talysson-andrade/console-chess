using board;

namespace chess
{
    class Horse : Piece
    {
        public Horse(Board board, Color color) : base(board, color)
        {

        }
        public override bool[,] PossibleMovements()
        {
            bool[,] mat = new bool[boardgame.rows, boardgame.columns];
            Position pos = new Position(0, 0);

            //up
            pos.DefineValue(position.row - 1, position.column);
            if (boardgame.ValidPosition(pos) && CanMoveTo(pos))
            {
                mat[pos.row, pos.column] = true;
            }
            return mat;
        }
        public override string ToString()
        {
            return "H";
        }
    }
}
