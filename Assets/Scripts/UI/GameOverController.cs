using DG.Tweening;
using EggCatch.GameOver;
using UnityEngine;
using UnityEngine.UI;

namespace EggCatch.UI
{
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
            _window.interactable = true;
            _window.DOFade(1, 1);
            _scoreText.text = data.Score.ToString();
        }
    }
}