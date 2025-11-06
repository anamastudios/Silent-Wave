using UnityEngine;

public class Hands : MonoBehaviour
{
    //Public values
    public GameObject placeholder;
    
    //Private values
    Vector2 mousePos;
    Vector2 convertedTo2;
    Camera cam;

    void Start()
    {
        cam = Camera.main.gameObject.GetComponent<Camera>();
    }
    void Update()
    {
        convertedTo2 = new Vector2(transform.position.x, transform.position.y);
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
    }
    private void FixedUpdate()
    {
        Vector2 lookTo = mousePos - convertedTo2;
        float angle = Mathf.Atan2(lookTo.x, lookTo.y) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0,0, -angle);
    }
}
