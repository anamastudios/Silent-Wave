using UnityEngine;

public class Device : MonoBehaviour
{
    Antenna interferedAntenna;
    UI antennaUI;

    public static bool gotSignal = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Signal"))
        {
            interferedAntenna = collision.GetComponent<Antenna>();
            gotSignal = true;
        }
        else
        {
            gotSignal = false;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        gotSignal = false;
    }
}
