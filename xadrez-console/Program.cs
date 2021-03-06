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
                    try
                    {
                        Screen.ShowBoard(chessMoves);
                        Console.Write("\nOrigem: ");
                        Position origin = Screen.readPosition().ReturnPosition();
                        chessMoves.VerifyInitialPosition(origin);
                        Console.Clear();
                        bool[,] possibleMovements = chessMoves.Board.ReturnPiece(origin).PossibleMovements();
                        Screen.ShowBoard(chessMoves,possibleMovements);
                        
                        Console.Write("\nDestino: ");
                        Position destiny = Screen.readPosition().ReturnPosition();
                        chessMoves.VerifyFinalPosition(origin, destiny);
                        chessMoves.MakeMoviment(origin, destiny, possibleMovements);
                    }
                    catch (BoardException e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadLine();
                    }
                }
            }
            catch (BoardException e)
            {
                Console.WriteLine(e.Message);
            }
            
            
            
        }
    }
}
