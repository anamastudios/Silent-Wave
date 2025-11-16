using UnityEngine;

public class SignalWave : MonoBehaviour
{
    public GameObject doorToUnlock;
    float scaleSpeed = 6f;

    void Update()
    {
        float scaler = scaleSpeed * Time.deltaTime;

        transform.localScale = new Vector2(transform.localScale.x + scaler, transform.localScale.y + scaler);

        Destroy(gameObject, 0.7f);
    }
}
