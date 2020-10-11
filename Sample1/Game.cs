using System;

namespace Sample1
{
    internal class Game
    {
        public Game()
        {
        }

        public int CurrentRound { get; internal set; }
        public int RotateGun { get; internal set; }

        internal object WinGame()
        {
            throw new NotImplementedException();
        }
    }
}