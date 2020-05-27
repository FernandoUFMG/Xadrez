﻿using xadrez_console.board;
using xadrez_console.board.Enums;

namespace xadrez_console.ChessGame
{
    class Horse : Piece
    {
        public Horse(Board board, Color color) : base(color, board)
        {

        }

        public override bool[,] PossibleMovements()
        {
            throw new System.NotImplementedException();
        }

        public override string ToString()
        {
            return "H";
        }
    }
}
