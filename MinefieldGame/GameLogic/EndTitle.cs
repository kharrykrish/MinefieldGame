using MinefieldGame.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MinefieldGame.GameLogic
{
   public class EndTitle : Tile
    {
        public EndTitle(int x, int y, string xLabel = null, string yLabel = null) : base(x, y, xLabel, yLabel)
        {
        }


        public override void Activate(IPlayer player, IDisplay renderer)
        {
            renderer.ShowFinalScoreBoard(player.GetMovesTaken());
        }
    }
}
