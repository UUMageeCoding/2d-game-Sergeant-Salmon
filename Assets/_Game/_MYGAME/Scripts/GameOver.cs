using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{

    
    public void Setup()
    {
        gameObject.SetActive(true);
       
    }

    public void RestartButton()
    {
        SceneManager.LoadScene("Game");
        Debug.Log("restart");
    }

    public void ExitButton()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
