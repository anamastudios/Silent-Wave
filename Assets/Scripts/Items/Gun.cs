using UnityEngine;

public class Gun : MonoBehaviour
{
    public Transform firepoint;
    public GameObject bulletPrefab;
    public AudioSource shootAudio;

    Rigidbody2D bulletRB;
    int magazineSize = 7;
    float fireRate;
    float nextFire;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
            Shoot();
    }
    private void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firepoint.position, firepoint.rotation);
        bulletRB = bullet.GetComponent<Rigidbody2D>();
        bulletRB.AddForce(firepoint.right * 25f, ForceMode2D.Impulse);

        shootAudio.Play();
    }
}
