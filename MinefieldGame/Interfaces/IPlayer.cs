using System;
using System.Collections.Generic;
using System.Text;

namespace MinefieldGame.Interfaces
{
    public  interface IPlayer
    {
        void MoveUp();
        void MoveDown();
        void MoveLeft();
        void MoveRight();
        void ReduceLives(int numOfLives);
        int GetMovesTaken();
        bool Alive();
        void Reset();
        bool Finished();

    }
}
