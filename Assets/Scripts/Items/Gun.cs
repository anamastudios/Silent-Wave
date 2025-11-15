using UnityEngine;
using UnityEngine.UI;

public class Gun : MonoBehaviour
{
    public Transform firepoint;
    public GameObject bulletPrefab;
    public AudioSource shootAudio;

    Rigidbody2D bulletRB;
    static float timePass;
    static int magazineMax = 7;
    static int magazine = 0;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
            Shoot();

        if (magazine == 0)
            Reload();
    }
    private void Shoot()
    {
        if(magazine != 0)
        {
            GameObject bullet = Instantiate(bulletPrefab, firepoint.position, firepoint.rotation);
            bulletRB = bullet.GetComponent<Rigidbody2D>();
            bulletRB.AddForce(firepoint.right * 50f, ForceMode2D.Impulse);
            magazine--;
            shootAudio.Play();
        }
    }
    private static void Reload()
    {
        timePass += Time.deltaTime;

        if (timePass >= 1.5f)
        {
            magazine = magazineMax;
            timePass = 0;
        }
    }
    public static int GetMagazine()
    {
        return magazine;
    }
    public static float GetTimePass()
    {
        return timePass;
    }
}
