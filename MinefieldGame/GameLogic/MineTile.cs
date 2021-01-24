using MinefieldGame.Interfaces;

namespace MinefieldGame.GameLogic
{
    internal class MineTile : Tile
    {
      
        public MineTile(int x, int y, string _xLabel = null, string _yLabel = null) : base(x, y, _xLabel, _yLabel)
        {
        }

        public override void Activate(IPlayer player, IDisplay renderer)
        {
            player.ReduceLives(1);
            renderer.ShowHitByMine();
        }
    }
}