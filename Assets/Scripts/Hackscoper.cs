using JetBrains.Annotations;
using UnityEngine;

public class Hackscoper : MonoBehaviour
{
    public Transform goToTranform;
    public Rigidbody2D rbHack;
    public AnimSprite animSprite;
    float speed = 3f;
    bool allowMovement = true;
    bool attack = false;

    void FixedUpdate()
    {
        if (allowMovement)
        {
            Vector3 stopPos = (goToTranform.position - rbHack.transform.position).normalized;
            rbHack.MovePosition(rbHack.transform.position + stopPos * speed * Time.fixedDeltaTime);

            animSprite.StartAnim();
        }

        if (attack)
            AttackPlayer();
    }
    void AttackPlayer()
    {
        animSprite.StopAnim();
    }
    public void SetSpeedBoost(float boost)
    {
        speed += boost;
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
