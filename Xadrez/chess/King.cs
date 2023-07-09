using board;

namespace chess
{
    class King:Piece
    {
        public King(Board board, Color color) : base(board, color)
        {
             
        }
        public override string ToString()
        {
            return "K";
        }

        public override bool[,] PossibleMovements()
        {
            bool[,] mat = new bool[boardgame.rows, boardgame.columns];
            Position pos = new Position(0, 0);

            //up
            pos.DefineValue(position.row - 1, position.column);
            if(boardgame.ValidPosition(pos) && CanMoveTo(pos))
            {
                mat[pos.row, pos.column] = true;
            }

            //up-right
            pos.DefineValue(position.row - 1, position.column + 1);
            if (boardgame.ValidPosition(pos) && CanMoveTo(pos))
            {
                mat[pos.row, pos.column] = true;
            }

            //up-left
            pos.DefineValue(position.row - 1, position.column - 1);
            if (boardgame.ValidPosition(pos) && CanMoveTo(pos))
            {
                mat[pos.row, pos.column] = true;
            }

            //right
            pos.DefineValue(position.row, position.column + 1);
            if (boardgame.ValidPosition(pos) && CanMoveTo(pos))
            {
                mat[pos.row, pos.column] = true;
            }

            //left
            pos.DefineValue(position.row, position.column - 1);
            if (boardgame.ValidPosition(pos) && CanMoveTo(pos))
            {
                mat[pos.row, pos.column] = true;
            }

            //down 
            pos.DefineValue(position.row + 1, position.column);
            if (boardgame.ValidPosition(pos) && CanMoveTo(pos))
            {
                mat[pos.row, pos.column] = true;
            }

            //down-right
            pos.DefineValue(position.row + 1, position.column + 1);
            if (boardgame.ValidPosition(pos) && CanMoveTo(pos))
            {
                mat[pos.row, pos.column] = true;
            }

            //down-left
            pos.DefineValue(position.row + 1, position.column - 1);
            if (boardgame.ValidPosition(pos) && CanMoveTo(pos))
            {
                mat[pos.row, pos.column] = true;
            }

            return mat;
        }
    }
}
