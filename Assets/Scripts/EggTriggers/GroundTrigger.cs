using EggCatch.Eggs;
using EggCatch.GameOver;
using UnityEngine;

namespace EggCatch.EggTriggers
{
    [RequireComponent(typeof(Collider2D))]
    public class GroundTrigger : EggTriggerBase
    {
        private GameOverHandler _gameOverHandler;

        public void Init(GameOverHandler gameOverHandler)
        {
            _gameOverHandler = gameOverHandler;
        }

        protected override void HandleEgg(PhysicsEgg egg)
        {
            _gameOverHandler.TriggerGameOver();
        }
    }
}