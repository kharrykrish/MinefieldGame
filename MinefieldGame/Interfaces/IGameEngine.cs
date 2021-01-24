using MinefieldGame.GameLogic;
using System;
using System.Collections.Generic;
using System.Text;

namespace MinefieldGame.Interfaces
{
    public interface IGameEngine
    {

        void Start(IBoard board, IPlayer player);

        void End();
    }
}
