using UnityEngine;

public class SoundWave : MonoBehaviour
{
    float scaleSpeed = 12f;

    void Update()
    {
        float scaler = scaleSpeed * Time.deltaTime;

        transform.localScale = new Vector2(transform.localScale.x + scaler, transform.localScale.y + scaler);

        Destroy(gameObject, 0.4f);
    }
}
