using UnityEngine;

public class Bullet : MonoBehaviour
{
    void Update()
    {
        Destroy(gameObject, 3);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Stats.Damage(30);
            Destroy(gameObject);
        }
    }
}
