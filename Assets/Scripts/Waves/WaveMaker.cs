using UnityEngine;

public class WaveMaker : MonoBehaviour
{
    public Player playerScript;
    public GameObject wavePrefab;
    public int maxWaveAmount = 5;
    public float waveRate;
    float nextWave;

    int waveIndex = 0;
    bool generateWaves = false;

    private void Update()
    {
        if(playerScript.GetSwimmingStatus())
            generateWaves = true;
        else generateWaves = false;

        if (generateWaves)
        {
            if (Time.time > nextWave)
            {
                GameObject wave = Instantiate(wavePrefab, transform.position, transform.rotation);
                waveIndex++;
                nextWave = Time.time + waveRate;
            }

            if(waveIndex >= maxWaveAmount)
            {
                waveIndex = 0;
                generateWaves = false;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Water"))
        {
            waveIndex = 0;
        }
    }
}
