using UnityEngine;

public class Device : MonoBehaviour
{
    Antenna interferedAntenna;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Signal"))
        {
            interferedAntenna = collision.GetComponent<Antenna>();
            interferedAntenna.openDoor();
        }
    }
}
