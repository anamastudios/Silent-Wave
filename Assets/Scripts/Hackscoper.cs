using JetBrains.Annotations;
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
    float speed = 3f;
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

    }
    void AttackPlayer()
    {
        animSprite.StopAnim();
        rendererSprite.sprite = gunSpriteTorso;
        spriteFlip.SpritesFlipX();
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
