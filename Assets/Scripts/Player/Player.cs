using UnityEngine;

public class Player : MonoBehaviour
{
    // Public Variables
    public Rigidbody2D rigidPlayer;
    public Transform raypoint;
    public WaveMaker WaterWaveMaker;
    public WaveMaker SoundWaveMaker;
    public bool lockMovement = false;
    public bool stopPlayer = false;
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
                isMoving = true;
            else if (movX <= -1 || movY <= -1)
            {
                isMoving = true;
            }
            else
                isMoving = false;

            SoundWaves();
            WaterWaves();
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
