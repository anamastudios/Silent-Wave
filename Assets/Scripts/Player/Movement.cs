using UnityEngine;

public class Movement : MonoBehaviour
{
    // Public Variables
    public Rigidbody2D rigidPlayer;
    public bool lockMovement = false;
    public bool stopPlayer = false;
    public float speed;

    // Private Variables
    private float movX, movY;

    private void FixedUpdate()
    {
        if (!lockMovement)
        {
            movX = Input.GetAxis("Horizontal") * speed;
            movY = Input.GetAxis("Vertical") * speed;

            if(stopPlayer)
                rigidPlayer.linearVelocity = Vector2.zero;

            rigidPlayer.linearVelocity = new Vector2(movX, movY);
        }
    }
    public void InWater(bool _inWater)
    {

    }
    public void Running(bool _running)
    {

    }
    public void Crouching(bool _crouching)
    {

    }
}
