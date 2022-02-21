using System;
using UnityEngine;

public class GameOverHandler
{
    private CatcherScore _score;
    public event Action<GameOverData> GameOverEvent;

    public void Init(CatcherScore score)
    {
        _score = score;
    }

    public void TriggerGameOver()
    {
        var data = new GameOverData(_score.Score);
        GameOverEvent?.Invoke(data);
        Debug.Log($"Game over. The score is {data.Score}");
    }
}