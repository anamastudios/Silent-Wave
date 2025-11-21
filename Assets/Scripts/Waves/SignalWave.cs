using UnityEngine;

public class SignalWave : MonoBehaviour
{
    [SerializeField] Antenna source;
    float scaleSpeed = 6f;

    void Update()
    {
        float scaler = scaleSpeed * Time.deltaTime;

        transform.localScale = new Vector2(transform.localScale.x + scaler, transform.localScale.y + scaler);

        Destroy(gameObject, 0.7f);
    }
    public void SetSource(GameObject obj)
    {
        source = obj.GetComponent<Antenna>();
    }
    public Antenna GetAntenna()
    {
        return source;
    }
}
