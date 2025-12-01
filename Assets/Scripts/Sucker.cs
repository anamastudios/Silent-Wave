using UnityEngine;

public class Sucker : MonoBehaviour
{
    public GameObject victory;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bullet"))
        {
            victory.SetActive(true);
            DestroyImmediate(gameObject);
        }
    }
}
