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
            for (int i = 0; i < boardgame.rows; i++)
            {
                for(int j = 0; j < boardgame.columns; j++)
                {
                    bool test = Math.Sqrt(Math.Pow(((position.row + 1) - (i + 1)), 2) + Math.Pow(((position.column + 1) - (j + 1)), 2)) == Math.Sqrt(5);
                    pos.DefineValue(i, j);
                    if (test && boardgame.ValidPosition(pos) && CanMoveTo(pos)) 
                    {
                        mat[i, j] = true;
                    }
                }
            }

          
            return mat;
        }
        public override string ToString()
        {
            return "H";
        }
    }
}
