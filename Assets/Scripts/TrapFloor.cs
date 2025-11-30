using UnityEngine;

public class TrapFloor : MonoBehaviour
{
    public WaveMaker makerWave;

    int creak = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("PlayerLegs"))
        {
            if (creak == 0)
            {
                makerWave.GenWaves(true);
                creak++;
            }
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        creak = 0;
    }
}
