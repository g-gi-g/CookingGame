using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {

    }

    public void toMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void restart()
    {
        SceneManager.LoadScene("MainScene");
    }
}
