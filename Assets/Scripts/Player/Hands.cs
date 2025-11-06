using UnityEngine;

public class Hands : MonoBehaviour
{
    //Public values
    public Transform placeholder;
    public GameObject[] itemsArray;

    //Private values
    int arrayItemLength;
    int currentNum = 0;
    int oldNum = 0;
    Vector2 mousePos;
    Vector2 convertedTo2;
    Camera cam;

    void Start()
    {
        cam = Camera.main.gameObject.GetComponent<Camera>();
    }
    void Update()
    {
        ItemSwitcher();

        convertedTo2 = new Vector2(transform.position.x, transform.position.y);
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
    }
    private void ItemSwitcher()
    {
        arrayItemLength = itemsArray.Length;

        if (Input.GetAxis("Mouse ScrollWheel") > 0)
            currentNum++;
        else if(Input.GetAxis("Mouse ScrollWheel") < 0)
            currentNum--;

        if (currentNum > arrayItemLength - 1 || currentNum < arrayItemLength - 1)
            currentNum = 0;

        if (currentNum > oldNum || currentNum < oldNum)
            SetItem(currentNum);

        Debug.Log(currentNum);

    }
    private void SetItem(int itemNum)
    {
        DestroyImmediate(itemsArray[oldNum]);
        oldNum = itemNum;

        GameObject item = Instantiate(itemsArray[itemNum], placeholder);
    }
    private void FixedUpdate()
    {
        Vector2 lookTo = mousePos - convertedTo2;
        float angle = Mathf.Atan2(lookTo.x, lookTo.y) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0,0, -angle);
    }
}
