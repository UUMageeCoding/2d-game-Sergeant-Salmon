using UnityEngine;
using UnityEngine.Rendering;

public class SoundEffectsManager : MonoBehaviour
{
    public static SoundEffectsManager instance;

    [SerializeField] private AudioSource soundEffectsObject;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void PlaySoundEffectsClip(AudioClip audioClip, Transform spawnTransform, float volume)
    {
        //spawn in gameobject
        AudioSource audioSource = Instantiate(soundEffectsObject, spawnTransform.position, Quaternion.identity);

        //assign audio clip
        audioSource.clip = audioClip;

        //assign volume
        audioSource.volume = volume;

        //play sound
        audioSource.Play();

        //get length of sound fx clip
        float clipLength = audioSource.clip.length;

        //destroy after finished
        Destroy(audioSource.gameObject, clipLength);

    }


    public void PlayRandomSoundEffectsClip(AudioClip[] audioClip, Transform spawnTransform, float volume)
    {
        //assign a random index
        int rand = Random.Range(0, audioClip.Length);
        
        //spawn in gameobject
        AudioSource audioSource = Instantiate(soundEffectsObject, spawnTransform.position, Quaternion.identity);

        //assign audio clip
        audioSource.clip = audioClip[rand];

        //assign volume
        audioSource.volume = volume;

        //play sound
        audioSource.Play();

        //get length of sound fx clip
        float clipLength = audioSource.clip.length;

        //destroy after finished
        Destroy(audioSource.gameObject, clipLength);

    }
}
