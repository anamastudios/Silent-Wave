using UnityEngine;

public class Antenna : MonoBehaviour
{
    public WaveMaker waveMaker;
    public GameObject DoorObject;

    Door door;

    void Update()
    {
        waveMaker.GenWaves(true);
    }
    public void openDoor()
    {
        door.openDoor();
        Debug.Log("OPEN IT!");
    }
}
