using UnityEngine;

public class CrateCollect : MonoBehaviour
{
   [SerializeField] private AudioClip chestSFX;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            SoundFXManager.Instance.PlaySoundFXClip(chestSFX, transform, 1f);
            
            Debug.Log("Crate collected!");
            Destroy(gameObject);
        }
    }
}