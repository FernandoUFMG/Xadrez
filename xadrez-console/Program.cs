﻿using System;
using xadrez_console.board;
using xadrez_console.ChessGame;
using xadrez_console.board.Enums;
using xadrez_console.board.Exceptions;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            ChessMoves chessMoves = new ChessMoves();
            try
            {
                while (!chessMoves.Ended) 
                {
                    Console.Clear();
                    Screen.PrintBoard(chessMoves.Board);
                    Console.WriteLine();
                    Console.WriteLine("Vez do Player: " + chessMoves.CurrentPlayer);
                    Console.Write("Origem: ");
                    Position origin = Screen.readPosition().ReturnPosition();
                    Console.Write("Destino: ");
                    Position destiny = Screen.readPosition().ReturnPosition();
                    chessMoves.MakeMoviment(origin, destiny);
                }
            }
            catch (BoardException e)
            {
                Console.WriteLine(e.Message);
            }
            
            
            
        }
    }
}
