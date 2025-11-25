using UnityEngine;

public class MutantSleepy : MonoBehaviour
{
    public GameObject body;
    public AudioSource spawnAudio;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("WaterWave"))
        {
            body.SetActive(true);
            gameObject.SetActive(false);
            if (!spawnAudio.isPlaying)
            {
                spawnAudio.Play();
                Debug.Log("Has been played");
            }
        }
    }
}
