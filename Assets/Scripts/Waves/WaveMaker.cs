using UnityEngine;

public class WaveMaker : MonoBehaviour
{
    public GameObject wavePrefab;
    public int maxWaveAmount = 5;
    public float waveRate;
    float nextWave;

    int waveIndex = 0;

    public void GenWaves(bool generateWaves)
    {
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
}
