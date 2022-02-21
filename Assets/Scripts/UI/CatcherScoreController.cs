using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class CatcherScoreController : MonoBehaviour
{
    [SerializeField] private Text _text;

    public void Init(CatcherScore score)
    {
        score.ScoreUpdate += UpdateCounter;
    }

    private void UpdateCounter(int number)
    {
        _text.text = number.ToString();
    }
}