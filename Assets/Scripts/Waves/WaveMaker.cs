using UnityEngine;

public class WaveMaker : MonoBehaviour
{
    public GameObject forSignal;
    public GameObject wavePrefab;
    public int maxWaveAmount = 5;
    public float waveRate;
    public bool signal;
    float nextWave;

    int waveIndex = 0;
    SignalWave waveGenerated;

    public void GenWaves(bool generateWaves)
    {
        if (generateWaves)
        {
            if (Time.time > nextWave)
            {
                GameObject wave = Instantiate(wavePrefab, transform.position, transform.rotation);
                
                if (signal)
                {
                    waveGenerated = wave.GetComponent<SignalWave>();
                    waveGenerated.SetSource(forSignal);
                }

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
