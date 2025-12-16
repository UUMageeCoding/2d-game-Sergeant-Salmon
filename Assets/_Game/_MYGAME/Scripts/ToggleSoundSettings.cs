using UnityEngine;

public class ToggleSoundSettings : MonoBehaviour
{
        public CanvasGroup soundCanvas;
    private bool soundSettingsOpen = false;


    void Update()
    {
        if (Input.GetButtonDown("ToggleSoundSettings"))
        {
            if (soundSettingsOpen)               //close menu now
            {
                Time.timeScale = 1;
                soundCanvas.alpha = 0;
                soundCanvas.blocksRaycasts = false;
                soundSettingsOpen = false;
            }
            else
            {
                Time.timeScale = 0;
                soundCanvas.alpha = 1;
                soundCanvas.blocksRaycasts = true;
                soundSettingsOpen = true;
            }
        }
    }
}
