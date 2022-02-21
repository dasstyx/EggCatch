using UnityEngine;

public class UIBootstrapper : MonoBehaviour
{
    [SerializeField] private GameOverController gameOverController;
    [SerializeField] private CatcherScoreController catcherScoreController;

    public void Init(CatcherScore score, GameOverHandler gameOverHandler)
    {
        gameOverController.Init(gameOverHandler);
        catcherScoreController.Init(score);
    }
}