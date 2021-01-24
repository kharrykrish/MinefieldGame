using MinefieldGame.GameLogic;
using System;

namespace MinefieldGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var desingDisplay = new DesingDisplay();
            var board = new Chessboard(desingDisplay);
            new GameEngine().Start(board, new Player(board, desingDisplay));



        }




    }
}
