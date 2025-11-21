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
        door = DoorObject.GetComponent<Door>();
        door.openDoor();
        //Debug.Log("Sesame, open yourself!");
    }
}
