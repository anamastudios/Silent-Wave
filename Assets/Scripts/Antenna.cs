using UnityEngine;

public class Antenna : MonoBehaviour
{
    public WaveMaker waveMaker;
    void Update()
    {
        waveMaker.GenWaves(true);
    }
}
