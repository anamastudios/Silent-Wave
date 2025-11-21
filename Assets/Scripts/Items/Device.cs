using UnityEngine;

public class Device : MonoBehaviour
{
    [SerializeField] Antenna interferedAntenna;
    SignalWave signalWave;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Signal"))
        {
            signalWave = collision.GetComponent<SignalWave>();
            interferedAntenna = signalWave.GetAntenna();
            interferedAntenna.openDoor();
        }
    }
}
