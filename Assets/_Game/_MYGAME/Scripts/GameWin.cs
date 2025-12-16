using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameWin : MonoBehaviour
{
public static int destroyedEnemies = 0; //Current number of destroyed enemys
 
public int numberOfEnemies = 0; //Fill this in the Inspector.

    void Update()
    {
        if(destroyedEnemies >= numberOfEnemies)
        {
            SceneManager.LoadScene("WinScreen");
            Debug.Log("You WIn");
        }
    }

}


