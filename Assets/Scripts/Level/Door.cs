using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite doorOpenSprite;
    public AudioSource openDoorSound;
    public string nextLevel;
    bool isdooropen = false;

    public void openDoor()
    {
        if (!isdooropen)
            openDoorSound.Play();

        isdooropen = true;
        spriteRenderer.sprite = doorOpenSprite;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && isdooropen)
            SceneManager.LoadScene(nextLevel);
    }
}
