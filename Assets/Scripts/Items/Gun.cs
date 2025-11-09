using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject firepoint;
    public GameObject bulletPrefab;
    public AudioSource shootAudio;

    int magazineSize = 7;
    float fireRate;
    float nextFire;

    void Update()
    {
        
    }
}
