using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class GameOverController : MonoBehaviour
{
    [SerializeField] private CanvasGroup _window;
    [SerializeField] private Text _scoreText;

    public void Init(GameOverHandler handler)
    {
        handler.GameOverEvent += PopUp;
    }

    private void PopUp(GameOverData data)
    {
        _window.DOFade(1, 1);
        _scoreText.text = data.Score.ToString();
    }
}