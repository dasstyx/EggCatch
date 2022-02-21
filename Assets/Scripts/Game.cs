using System;
using UnityEngine;

public class Game : MonoBehaviour
{
    public bool IsPlaying { get; private set; }
    [SerializeField] private int _maxPoses;
    [SerializeField] private EggAllSpawners _eggAllSpawners;
    [SerializeField] private UIBootstrapper _uiBootstrapper;
    [SerializeField] private GroundTrigger _groundTrigger;
    private GameOverHandler _gameOverHandler;
    private CatcherScore _score;

    private void Start()
    {
        IsPlaying = true;
        _score = new CatcherScore();
        _gameOverHandler = new GameOverHandler();
        _gameOverHandler.Init(_score);
        _uiBootstrapper.Init(_score, _gameOverHandler);
        
        _eggAllSpawners.Init(this);
        
        _groundTrigger.Init(_gameOverHandler);

        var player = FindObjectOfType<Player>();
        player.Init(_maxPoses, _score);

        _gameOverHandler.GameOverEvent += _ => StopGame();
    }

    private void StopGame()
    {
        IsPlaying = false;
    }
}