using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Player _player;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            _player.Up();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            _player.Down();
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            _player.Right();
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            _player.Left();
        }
    }
}