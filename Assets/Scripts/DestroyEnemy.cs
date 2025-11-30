using UnityEngine;

public class DestroyEnemy : MonoBehaviour
{
    GameObject toDestroy;
    Hackscoper hackscoper;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Hackscoper"))
        {
            toDestroy = collision.GetComponent<GameObject>();
            hackscoper = collision.GetComponent<Hackscoper>();
            hackscoper.SetSpeedBoost(20f);
        }
    }
}