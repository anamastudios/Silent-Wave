using UnityEngine;

public class Mutant : MonoBehaviour
{
    public Rigidbody2D rbMutant;
    public SpriteRenderer attackSpriteChange;
    public Sprite normalSprite;
    public Sprite attackSprite;
    public GameObject Model;
    public BoxCollider2D collision;
    public CircleCollider2D attackrange;
    public float attackTime;
    public float attackDamage;
    public float speed;

    bool allowMovement = false;
    Transform transPlayer;

    void Awake()
    {
        transPlayer = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }
    void FixedUpdate()
    {
        Vector3 playerPos = (transPlayer.position - rbMutant.transform.position).normalized;

        if (Model.activeSelf)
            allowMovement = true;

        if (allowMovement)
        {
            collision.enabled = true;
            attackrange.enabled = true;
            rbMutant.MovePosition(rbMutant.transform.position + playerPos * speed * Time.fixedDeltaTime);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            allowMovement = false;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            allowMovement = true;
        }
    }
}
