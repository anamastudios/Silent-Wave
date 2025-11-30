using UnityEngine;

public class SoundCreakWave : MonoBehaviour
{
    float scaleSpeed = 50f;

    void Update()
    {
        float scaler = scaleSpeed * Time.deltaTime;

        transform.localScale = new Vector2(transform.localScale.x + scaler, transform.localScale.y + scaler);

        Destroy(gameObject, 0.9f);
    }
}
