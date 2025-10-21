using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundFXManager : MonoBehaviour
{
    public static SoundFXManager Instance;
    [SerializeField] private AudioSource soundFXObject;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;

        }
    }
   public void PlaySoundFXClip(AudioClip clip, Transform spawnTransform, float volume)
    {
        //spawn in gameobject
        AudioSource audioSource = Instantiate(soundFXObject, spawnTransform.position, Quaternion.identity);
        audioSource.clip = clip;
        audioSource.volume = volume;
        audioSource.Play();
        //destroy after clip length
        Destroy(audioSource.gameObject, clip.length);
        
    }
}
