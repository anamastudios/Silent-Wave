using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject followingObject;

    Vector3 followingObjectPos;

    void Update()
    {
        followingObjectPos = new Vector3(followingObject.transform.position.x, followingObject.transform.position.y, -10);

        transform.position = followingObjectPos;
    }
}
