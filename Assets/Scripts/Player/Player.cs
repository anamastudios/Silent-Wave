using Unity.Mathematics;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Public Variables
    public Rigidbody2D rigidPlayer;
    public Transform raypoint;
    public WaveMaker WaterWaveMaker;
    public WaveMaker SoundWaveMaker;
    public AnimSprite animsprite;
    public SpriteRenderer legs;
    public Sprite inWater;
    public Sprite normal;
    public FlipSprites flipSprites;
    public AudioSource footsteps;
    public AudioClip footstepSurface;
    public AudioClip footstepWater;
    public bool lockMovement = false;
    public bool stopPlayer = false;
    public bool deactivateWaterWaves = false;
    public bool deactivateSoundWaves = false;
    public float speed;

    // Private Variables
    private float movX, movY;
    private bool isSwimming = false;
    private bool isMoving = false;

    private void FixedUpdate()
    {
        if (!lockMovement)
        {
            movX = Input.GetAxis("Horizontal") * speed;
            movY = Input.GetAxis("Vertical") * speed;

            if(stopPlayer)
                rigidPlayer.linearVelocity = Vector2.zero;

            if (movX > 0 || movY > 0)
            {
                isMoving = true;
                animsprite.StartAnim();
            }
            else if (movX <= -1 || movY <= -1)
            {
                animsprite.StartAnim();
                isMoving = true;
            }
            else
            {
                animsprite.StopAnim();
                isMoving = false;
            }

            if (movX < 0)
                flipSprites.SpritesFlipX();
            else if (movX > 0)
                flipSprites.SpritesUnflipX();


            if (isSwimming)
            {
                footsteps.clip = footstepWater;
                animsprite.StopAnim();
                legs.sprite = inWater;
            }
            else
            {
                footsteps.clip = footstepSurface;
            }

            if (!deactivateSoundWaves)
                SoundWaves();
            
            if(!deactivateWaterWaves)
                WaterWaves();

            if (isMoving && !footsteps.isPlaying)
            {
                footsteps.pitch = UnityEngine.Random.Range(0.75f, 1f);
                footsteps.Play();
            }

            rigidPlayer.linearVelocity = new Vector2(movX, movY);
        }
    }

    private void SoundWaves()
    {
        if (isMoving && !isSwimming)
        {
            SoundWaveMaker.GenWaves(true);
        }
    }
    private void WaterWaves()
    {
        if (isSwimming && isMoving)
        {
            WaterWaveMaker.GenWaves(true);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Water"))
        {
            isSwimming = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Water"))
        {
            isSwimming = false;
        }
    }
}
