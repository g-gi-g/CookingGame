using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using TMPro;

public class MainMenuScript : MonoBehaviour
{
    public GameObject InfoText;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void StartGame()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void AboutGame()
    {
        StartCoroutine(showInfo());
    }

    IEnumerator showInfo()
    {
        InfoText.SetActive(true);
        yield return new WaitForSeconds(5f);
        InfoText.SetActive(false);
    }
}
