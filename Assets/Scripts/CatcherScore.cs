using System;

namespace EggCatch
{
    public class CatcherScore
    {
        public int Score { get; private set; }
        public event Action<int> ScoreUpdate;

        public void PlusScore()
        {
            Score++;
            ScoreUpdate?.Invoke(Score);
        }
    }
}