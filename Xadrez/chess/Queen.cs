using board;

namespace chess
{
    class Queen : Piece
    {
        public Queen(Board board, Color color) : base(board, color)
        {

        }
        public override bool[,] PossibleMovements()
        {
            bool[,] mat = new bool[boardgame.rows, boardgame.columns];
            Position pos = new Position(0, 0);

            //up-right
            pos.DefineValue(position.row - 1, position.column + 1);

            while (boardgame.ValidPosition(pos) && CanMoveTo(pos))
            {
                mat[pos.row, pos.column] = true;
                if (boardgame.GetPiece(pos) != null && boardgame.GetPiece(pos).color != color)
                {
                    break;
                }
                pos.row = pos.row - 1;
                pos.column = pos.column + 1;
            }

            //up-left
            pos.DefineValue(position.row - 1, position.column - 1);

            while (boardgame.ValidPosition(pos) && CanMoveTo(pos))
            {
                mat[pos.row, pos.column] = true;
                if (boardgame.GetPiece(pos) != null && boardgame.GetPiece(pos).color != color)
                {
                    break;
                }
                pos.row = pos.row - 1;
                pos.column = pos.column - 1;
            }

            //down-right
            pos.DefineValue(position.row + 1, position.column + 1);

            while (boardgame.ValidPosition(pos) && CanMoveTo(pos))
            {
                mat[pos.row, pos.column] = true;
                if (boardgame.GetPiece(pos) != null && boardgame.GetPiece(pos).color != color)
                {
                    break;
                }
                pos.row = pos.row + 1;
                pos.column = pos.column + 1;
            }

            //down-left
            pos.DefineValue(position.row + 1, position.column - 1);

            while (boardgame.ValidPosition(pos) && CanMoveTo(pos))
            {
                mat[pos.row, pos.column] = true;
                if (boardgame.GetPiece(pos) != null && boardgame.GetPiece(pos).color != color)
                {
                    break;
                }
                pos.row = pos.row + 1;
                pos.column = pos.column - 1;
            }
            //up
            pos.DefineValue(position.row - 1, position.column);

            while (boardgame.ValidPosition(pos) && CanMoveTo(pos))
            {
                mat[pos.row, pos.column] = true;
                if (boardgame.GetPiece(pos) != null && boardgame.GetPiece(pos).color != color)
                {
                    break;
                }
                pos.row = pos.row - 1;
            }

            //right
            pos.DefineValue(position.row, position.column + 1);

            while (boardgame.ValidPosition(pos) && CanMoveTo(pos))
            {
                mat[pos.row, pos.column] = true;
                if (boardgame.GetPiece(pos) != null && boardgame.GetPiece(pos).color != color)
                {
                    break;
                }
                pos.column = pos.column + 1;
            }

            //left
            pos.DefineValue(position.row, position.column - 1);

            while (boardgame.ValidPosition(pos) && CanMoveTo(pos))
            {
                mat[pos.row, pos.column] = true;
                if (boardgame.GetPiece(pos) != null && boardgame.GetPiece(pos).color != color)
                {
                    break;
                }
                pos.column = pos.column - 1;
            }

            //down 
            pos.DefineValue(position.row + 1, position.column);

            while (boardgame.ValidPosition(pos) && CanMoveTo(pos))
            {
                mat[pos.row, pos.column] = true;
                if (boardgame.GetPiece(pos) != null && boardgame.GetPiece(pos).color != color)
                {
                    break;
                }
                pos.row = pos.row + 1;
            }
            return mat;
        }
        public override string ToString()
        {
            return "Q";
        }
    }
}
