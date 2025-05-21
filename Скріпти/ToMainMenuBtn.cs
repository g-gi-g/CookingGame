using UnityEngine;
using UnityEngine.SceneManagement;


public class ToMainMenuBtn : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void OnButtonClick()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
