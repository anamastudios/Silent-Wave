using UnityEngine;

public class FlipSprites : MonoBehaviour
{
    public SpriteRenderer[] spriteRenderer;

    public void SpritesFlipY()
    {
        foreach(SpriteRenderer r in spriteRenderer)
            r.flipY = true;
    }
    public void SpritesUnFlipY()
    {
        foreach (SpriteRenderer r in spriteRenderer)
            r.flipY = false;
    }
}
