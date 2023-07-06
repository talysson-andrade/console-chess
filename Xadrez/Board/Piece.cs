namespace board
{
    class Piece
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

        
    }
}
