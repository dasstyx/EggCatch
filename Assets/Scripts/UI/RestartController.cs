using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace EggCatch.UI
{
    [RequireComponent(typeof(Button))]
    public class RestartController : MonoBehaviour
    {
        private void Start()
        {
            GetComponent<Button>().onClick.AddListener(RestartScene);
        }

        private void RestartScene()
        {
            SceneManager.LoadScene(0);
        }
    }
}