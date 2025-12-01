using UnityEngine;

public class Hackscoper : MonoBehaviour
{
    public Transform goToTranform;
    public Rigidbody2D rbHack;
    public AnimSprite animSprite;
    public SpriteRenderer rendererSprite;
    public Sprite baseSpriteTorso;
    public Sprite gunSpriteTorso;
    public FlipSprites spriteFlip;
    public AudioSource footsteps;
    public Transform firePoint;
    public Transform playerModel;
    public GameObject bulletPrefab;
    public float fireRate;

    Vector2 convertedTo2;
    Vector2 target;
    Vector2 distance;
    float speed = 3f;
    float nextFire;
    bool allowMovement = true;
    bool attack = false;
    bool gainedBoost = false;

    void FixedUpdate()
    {
        if (allowMovement)
        {
            Vector3 stopPos = (goToTranform.position - rbHack.transform.position).normalized;
            rbHack.MovePosition(rbHack.transform.position + stopPos * speed * Time.fixedDeltaTime);

            if (!footsteps.isPlaying)
            {
                footsteps.Play();
            }

            animSprite.StartAnim();
        }

        if (attack)
            AttackPlayer();

        if (gainedBoost)
            Destroy(gameObject, 1);

        convertedTo2 = new Vector2(firePoint.position.x, firePoint.position.y);
        target = new Vector2(playerModel.position.x, playerModel.position.y);

        distance = target - convertedTo2;
        

        if (distance.magnitude > 15 && !gainedBoost)
            Stats.Damage(100);
    }
    void AttackPlayer()
    {
        animSprite.StopAnim();
        rendererSprite.sprite = gunSpriteTorso;
        spriteFlip.SpritesFlipX();

        Vector2 lookTo = target - convertedTo2;
        float angle = Mathf.Atan2(lookTo.x, lookTo.y) * Mathf.Rad2Deg;
        firePoint.rotation = Quaternion.Euler(0, 0, -angle);

        if (Time.time > nextFire)
        {
            Shoot();
            nextFire = Time.time + fireRate;
        }
    }
    public void Shoot()
    {
        GameObject fireball = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D fireballrb = fireball.GetComponent<Rigidbody2D>();
        fireballrb.AddForce(firePoint.up * 15f, ForceMode2D.Impulse);
    }
    public void SetSpeedBoost(float boost)
    {
        speed += boost;
        gainedBoost = true;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Sound"))
        {
            allowMovement = false;
            attack = true;
        }
    }
}
