using UnityEngine;

public class Mutant : MonoBehaviour
{
    public Rigidbody2D rbMutant;
    public SpriteRenderer attackSpriteChange;
    public Sprite normalSprite;
    public Sprite attackSprite;
    public GameObject Model;
    public BoxCollider2D collision;
    public MutantAttackSphere attackRange;
    public AudioSource attackSound;
    public WaveMaker makerWave;
    public GameObject attackScreen;
    public float attackTime;
    public int attackDamage;
    public float speed;

    float nextAttack;
    bool allowMovement = false;
    Transform transPlayer;

    void Awake()
    {
        transPlayer = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }
    void FixedUpdate()
    {
        
        if (Model.activeSelf && !allowMovement && !attackRange.isInHitArea())
            allowMovement = true;

        if (allowMovement)
        {
            Vector3 playerPos = (transPlayer.position - rbMutant.transform.position).normalized;
            collision.enabled = true;
            rbMutant.MovePosition(rbMutant.transform.position + playerPos * speed * Time.fixedDeltaTime);

            makerWave.GenWaves(true);

            if (attackRange.isInHitArea())
                playerPos = Vector3.zero;
        }

        if (attackRange.isInHitArea())
        {
            makerWave.GenWaves(false);
            allowMovement = false;
            StartAttack();
        }
    }
    private void StartAttack()
    {
        if (Time.time > nextAttack)
        {
            Stats.Damage(attackDamage);
            nextAttack = Time.time + attackTime;
            attackSound.Play();
        }

        if (attackSound.isPlaying)
        {
            attackSpriteChange.sprite = attackSprite;
            attackScreen.SetActive(true);
        }
        else
        {
            attackSpriteChange.sprite = normalSprite;
            attackScreen.SetActive(false);
        }
    }
}
