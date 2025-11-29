using UnityEngine;

public class MutantAttackSphere : MonoBehaviour
{
    private bool isInArea = false;

    public bool isInHitArea()
    {
        return isInArea;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
            isInArea = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
            isInArea = false;
    }
}
