﻿namespace board
{
    abstract class Piece
    {
        public Position position { get; set; }
        public Color color { get; set; }
        public bool moved { get; set; }
        public Board boardgame { get; protected set; }

        public Piece(Board boardgame,Color color)
        {
            this.position = null;
            this.color = color;
            this.moved = false;
            this.boardgame = boardgame;
        }
        public void MovedPiece()
        {
            moved = true;
        }

        protected bool CanMoveTo(Position position)
        {
            Piece piece = boardgame.GetPiece(position);
            return piece == null || piece.color != color;
        }

        public abstract bool[,] PossibleMovements();

        public bool ExistPossibleMoves()
        {
            bool[,] mat = PossibleMovements();
            for(int i = 0; i < boardgame.rows; i++)
            {
                for(int j = 0;j< boardgame.columns; j++)
                {
                    if (mat[i, j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        
    }
}
