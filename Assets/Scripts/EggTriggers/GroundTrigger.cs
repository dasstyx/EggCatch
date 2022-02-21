using UnityEngine;

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