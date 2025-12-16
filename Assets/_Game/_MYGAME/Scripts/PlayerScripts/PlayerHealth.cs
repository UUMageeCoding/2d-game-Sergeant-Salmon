using Markdig.Parsers;
using TMPro;
using UnityEngine;


public class PlayerHealth : MonoBehaviour
{

    public TMP_Text healthText;
    public Animator healthTextAnim;
    public GameOver gameOver;
    [SerializeField] private  AudioClip[] playerHurtSounds;
    [SerializeField] private  AudioClip playerDeathSound;

    private void Start()
    {
        healthText.text = "HP: " + StatsManager.Instance.currentHealth + " / " + StatsManager.Instance.maxHealth;
    }
    public void ChangeHealth(int amount)
    {
        StatsManager.Instance.currentHealth += amount;
        healthTextAnim.Play("TextUpdate");
        healthText.text = "HP: " + StatsManager.Instance.currentHealth + " / " + StatsManager.Instance.maxHealth;
        SoundEffectsManager.instance.PlayRandomSoundEffectsClip(playerHurtSounds, transform, 1f);

        if (StatsManager.Instance.currentHealth <= 0)
        {
            SoundEffectsManager.instance.PlaySoundEffectsClip(playerDeathSound, transform, 1f);
            gameObject.SetActive(false);
            Death();
        }
    }

    private void Death()
    {
       gameOver.Setup(); 
    }
}
