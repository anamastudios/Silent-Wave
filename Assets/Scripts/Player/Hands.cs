using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class Hands : MonoBehaviour
{
    //Public variables
    public Transform placeholder;
    public GameObject[] itemList;

    //Private variables
    Vector2 mousePos;
    Vector2 convertedTo2;
    Camera cam;
    GameObject item;
    int scrollNum = 0;
    int oldNum = 0;

    void Start()
    {
        cam = Camera.main.gameObject.GetComponent<Camera>();
        SetItem(0);
    }
    void Update()
    {
        ItemSwitcher();

        convertedTo2 = new Vector2(transform.position.x, transform.position.y);
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
    }
    private void ItemSwitcher()
    {
        if (Input.GetAxis("Mouse ScrollWheel") > 0f)
            scrollNum++;
        else if(Input.GetAxis("Mouse ScrollWheel") < 0f)
            scrollNum--;

        if (scrollNum < 0 || scrollNum > itemList.Length - 1)
            scrollNum = 0;

        if(scrollNum != oldNum)
            SetItem(scrollNum);
    }
    private void SetItem(int itemNum)
    {
        oldNum = itemNum;
        Destroy(item);
        item = Instantiate(itemList[itemNum], placeholder);

        Debug.Log("Deleted");
    }
    private void FixedUpdate()
    {
        Vector2 lookTo = mousePos - convertedTo2;
        float angle = Mathf.Atan2(lookTo.x, lookTo.y) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0,0, -angle);
    }
}
