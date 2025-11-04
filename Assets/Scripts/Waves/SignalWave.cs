using UnityEngine;

public class SignalWave : MonoBehaviour
{
    //reminder: wave rate = 0.3f - perfect!

    float scaleSpeed = 6f;

    void Update()
    {
        float scaler = scaleSpeed * Time.deltaTime;

        transform.localScale = new Vector2(transform.localScale.x + scaler, transform.localScale.y + scaler);

        Destroy(gameObject, 0.5f);
    }
}
