using UnityEngine;

public class Player : MonoBehaviour
{
    // Public Variables
    public Rigidbody2D rigidPlayer;
    public Transform raypoint;
    public LayerMask mask;
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
            else
                isMoving = false;

            rigidPlayer.linearVelocity = new Vector2(movX, movY);
        }

        Debug.Log("Is he swimming?: " + isSwimming);
    }
    public bool GetMovingStatus()
    {
        return isMoving;
    }
    public bool GetSwimmingStatus()
    {
        return isSwimming;
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
