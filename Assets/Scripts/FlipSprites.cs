using UnityEngine;

public class FlipSprites : MonoBehaviour
{
    public SpriteRenderer[] spriteRenderer;

    public void SpritesFlipX()
    {
        foreach(SpriteRenderer r in spriteRenderer)
            r.flipX = true;
    }
    public void SpritesUnflipX()
    {
        foreach (SpriteRenderer r in spriteRenderer)
            r.flipX = false;
    }
}
