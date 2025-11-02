using UnityEngine;

public class WaterWave : MonoBehaviour
{
    float scaleSpeed = 0.8f;

    void Update()
    {
        float scaler = scaleSpeed * Time.deltaTime;
        Debug.Log(scaler);

        transform.localScale = new Vector2(transform.localScale.x + scaler, transform.localScale.y + scaler);

        Destroy(gameObject, 2);
    }
}
